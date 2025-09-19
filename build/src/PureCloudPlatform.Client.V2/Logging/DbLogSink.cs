using PureCloudPlatform.Client.V2.Client;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PureCloudPlatform.Client.V2.Logging
{
    /// <summary>
    /// Batching sink that persists log statements into a relational database table using raw INSERTs.
    /// Supports SQLite style (original), SQL Server and PostgreSQL dialects with optional automatic schema creation.
    /// </summary>
    /// <remarks>
    /// The sink accepts a connection factory function. If <paramref name="ensureSchema"/> is true it will attempt
    /// to create the destination table if it does not already exist (best effort, errors ignored). The dialect can be
    /// specified explicitly or auto-detected from the concrete <see cref="DbConnection"/> type name.
    /// Parameters are used for every value to avoid SQL injection. No migrations beyond initial CREATE TABLE are performed.
    /// </remarks>
    /// <param name="connectionFactory">Factory that returns an unopened <see cref="DbConnection"/>.</param>
    /// <param name="tableName">Target table name (default: ApiLogs).</param>
    /// <param name="ensureSchema">If true, attempt to create the table on first use.</param>
    /// <param name="batchSize">Maximum batch size before flushing (each row uses 10 parameters).</param>
    /// <param name="capacity">Maximum buffered items in the channel.</param>
    /// <param name="flushSeconds">Maximum seconds between automatic flushes.</param>
    /// <param name="dialect">Database dialect (Auto = inspect connection type).</param>
    /// <param name="diagnostics">If true, write internal flush exceptions to stderr to aid debugging.</param>
    public sealed class DbLogSink(Func<DbConnection> connectionFactory,
                     string tableName = "genesys_api_logs",
                     bool ensureSchema = false,
                     int batchSize = 100,
                     int capacity = 10_000,
                     int flushSeconds = 2,
                     DbLogDialect dialect = DbLogDialect.Auto,
                     bool diagnostics = false) : BatchingLogSink(batchSize, capacity, TimeSpan.FromSeconds(flushSeconds))
    {
        private readonly Func<DbConnection> _connectionFactory = connectionFactory ?? throw new ArgumentNullException(nameof(connectionFactory));
        private bool _schemaEnsured;
        private readonly bool _diagnostics = diagnostics;

        /// <summary>
        /// Insert the batch of statements into the configured table using a single multi-statement command.
        /// </summary>
        protected override async Task FlushAsync(IReadOnlyList<(LogStatement stmt, string rendered)> batch, CancellationToken ct)
        {
            if (batch.Count == 0) return;
            try
            {
                using var conn = _connectionFactory();
                await conn.OpenAsync(ct).ConfigureAwait(false);

                // Decide effective dialect each flush (in case Auto and different provider types used)
                var effectiveDialect = dialect == DbLogDialect.Auto ? DetectDialect(conn) : dialect;

                if (ensureSchema && !_schemaEnsured)
                {
                    try
                    {
                        using var ensureCmd = conn.CreateCommand();
                        ensureCmd.CommandText = BuildEnsureSchemaSql(effectiveDialect, tableName);
                        if (!string.IsNullOrWhiteSpace(ensureCmd.CommandText))
                        {
                            try { await ensureCmd.ExecuteNonQueryAsync(ct).ConfigureAwait(false); } catch (Exception ex) { if (_diagnostics) Console.Error.WriteLine($"[DbLogSink] ensure schema error: {ex.Message}"); }
                        }
                    }
                    catch (Exception ex) { if (_diagnostics) Console.Error.WriteLine($"[DbLogSink] schema block error: {ex.Message}"); }
                    finally { _schemaEnsured = true; }
                }

                using var cmd = conn.CreateCommand();
                var sb = new StringBuilder();
                for (int i = 0; i < batch.Count; i++)
                {
                    var s = batch[i].stmt;

                    string rhParam = $"@rh{i}";
                    string resphParam = $"@resph{i}";
                    // For PostgreSQL we must cast text parameters to jsonb explicitly
                    bool pg = effectiveDialect == DbLogDialect.PostgreSql;
                    string rhExpr = pg ? rhParam + "::jsonb" : rhParam;
                    string resphExpr = pg ? resphParam + "::jsonb" : resphParam;

                    sb.Append($"INSERT INTO {tableName} (UtcDate, Level, Method, Url, StatusCode, CorrelationId, RequestHeadersJson, ResponseHeadersJson, RequestBody, ResponseBody) VALUES (@d{i}, @l{i}, @m{i}, @u{i}, @sc{i}, @cid{i}, {rhExpr}, {resphExpr}, @req{i}, @resp{i});");

                    // Use actual DateTime for providers with temporal column (Postgres/SqlServer). For text-based schemas store ISO string.
                    object dateValue = effectiveDialect is DbLogDialect.PostgreSql or DbLogDialect.SqlServer
                        ? s.Date
                        : s.Date.ToString("o");

                    AddParam(cmd, $"@d{i}", dateValue);
                    AddParam(cmd, $"@l{i}", s.Level);
                    AddParam(cmd, $"@m{i}", s.Method);
                    AddParam(cmd, $"@u{i}", s.Url);
                    AddParam(cmd, $"@sc{i}", s.StatusCode);
                    AddParam(cmd, $"@cid{i}", s.CorrelationId);
                    AddParam(cmd, rhParam, SerializeHeaders(s.RequestHeaders));
                    AddParam(cmd, resphParam, SerializeHeaders(s.ResponseHeaders));
                    AddParam(cmd, $"@req{i}", s.RequestBody);
                    AddParam(cmd, $"@resp{i}", s.ResponseBody);
                }
                cmd.CommandText = sb.ToString();
                await cmd.ExecuteNonQueryAsync(ct).ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                if (_diagnostics)
                {
                    Console.Error.WriteLine($"[DbLogSink] Flush failed: {ex.GetType().Name}: {ex.Message}");
                }
                // swallow to keep logger resilient
            }
        }

        private static void AddParam(DbCommand cmd, string name, object value)
        {
            var p = cmd.CreateParameter();
            p.ParameterName = name;
            p.Value = value ?? DBNull.Value;
            cmd.Parameters.Add(p);
        }

        private static string SerializeHeaders(IReadOnlyDictionary<string, string> headers)
        {
            if (headers == null) return null;
            try { return System.Text.Json.JsonSerializer.Serialize(headers); } catch { return null; }
        }

        private static DbLogDialect DetectDialect(DbConnection conn)
        {
            var n = conn.GetType().Name.ToLowerInvariant();
            if (n.Contains("sqlconnection")) return DbLogDialect.SqlServer;
            if (n.Contains("npgsql")) return DbLogDialect.PostgreSql;
            if (n.Contains("sqlite")) return DbLogDialect.Sqlite;
            return DbLogDialect.Generic;
        }

        private static string BuildEnsureSchemaSql(DbLogDialect dialect, string table)
        {
            return dialect switch
            {
                DbLogDialect.SqlServer =>
$@"IF NOT EXISTS (SELECT 1 FROM sys.tables WHERE name = '{table}')
BEGIN
    CREATE TABLE {table} (
        Id INT IDENTITY(1,1) PRIMARY KEY,
        UtcDate DATETIME2 NOT NULL,
        Level NVARCHAR(16) NULL,
        Method NVARCHAR(16) NULL,
        Url NVARCHAR(2048) NULL,
        StatusCode INT NULL,
        CorrelationId NVARCHAR(128) NULL,
        RequestHeadersJson NVARCHAR(MAX) NULL,
        ResponseHeadersJson NVARCHAR(MAX) NULL,
        RequestBody NVARCHAR(MAX) NULL,
        ResponseBody NVARCHAR(MAX) NULL
    );
END",                DbLogDialect.PostgreSql =>
$@"CREATE TABLE IF NOT EXISTS {table} (
    Id BIGSERIAL PRIMARY KEY,
    UtcDate TIMESTAMPTZ NOT NULL,
    Level TEXT,
    Method TEXT,
    Url TEXT,
    StatusCode INT,
    CorrelationId TEXT,
    RequestHeadersJson JSONB,
    ResponseHeadersJson JSONB,
    RequestBody TEXT,
    ResponseBody TEXT
);",                DbLogDialect.Sqlite =>
$@"CREATE TABLE IF NOT EXISTS {table} (
    Id INTEGER PRIMARY KEY AUTOINCREMENT,
    UtcDate TEXT NOT NULL,
    Level TEXT,
    Method TEXT,
    Url TEXT,
    StatusCode INT,
    CorrelationId TEXT,
    RequestHeadersJson TEXT,
    ResponseHeadersJson TEXT,
    RequestBody TEXT,
    ResponseBody TEXT
);",                _ =>
$@"CREATE TABLE IF NOT EXISTS {table} (
    Id INTEGER PRIMARY KEY,
    UtcDate TEXT NOT NULL,
    Level TEXT,
    Method TEXT,
    Url TEXT,
    StatusCode INT,
    CorrelationId TEXT,
    RequestHeadersJson TEXT,
    ResponseHeadersJson TEXT,
    RequestBody TEXT,
    ResponseBody TEXT
);"
            };
        }
    }

    /// <summary>
    /// Dialects supported by <see cref="DbLogSink"/>.
    /// </summary>
    public enum DbLogDialect
    {
        /// <summary>Detect from connection type name.</summary>
        Auto,
        /// <summary>Microsoft SQL Server (System.Data.SqlClient / Microsoft.Data.SqlClient).</summary>
        SqlServer,
        /// <summary>PostgreSQL (Npgsql).</summary>
        PostgreSql,
        /// <summary>SQLite provider.</summary>
        Sqlite,
        /// <summary>Generic ANSI-style fallback.</summary>
        Generic
    }
}
