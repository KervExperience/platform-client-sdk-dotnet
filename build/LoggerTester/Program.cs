using System.Data.Common;
using Microsoft.Data.SqlClient;
using Microsoft.Data.Sqlite;
using Microsoft.Extensions.Configuration;
using Npgsql;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Logging;
using LoggerTester;

internal class Program
{
    private static async Task Main(string[] _)
    {
        Console.WriteLine("=== Log Sinks Test (GenesysApiManager) ===");

        var builder = new ConfigurationBuilder().AddUserSecrets<Program>();
        var config = builder.Build();

        // Logger + Configuration (ensure we dispose so DB sinks flush)
        await using var logger = new Logger(
            logToConsole: true,
            logFormat: LogFormat.Text,
            logLevel: LogLevel.LTrace,
            logRequestBody: true,
            logResponseBody: true);

        var apiClient = new ApiClient();
        var cfg = new Configuration(apiClient: apiClient, useDefaultApiClient: false)
        {
            Logger = logger
        };

        // File sink
        var logFile = Path.Combine(Path.GetTempPath(), "sdk-log-sinks-demo.log");
        cfg.Logger.LogFilePath = logFile;

        // SQLite sink (diagnostics enabled, aggressive flush)
        var sqliteSetting = config["SQLITE_FILE"];
        DbConnection sqliteFactory() =>
            string.IsNullOrWhiteSpace(sqliteSetting)
                ? new SqliteConnection("Data Source=:memory:")
                : sqliteSetting.Contains('=') // Treat as full connection string if it already has key=value
                    ? new SqliteConnection(sqliteSetting)
                    : new SqliteConnection($"Data Source={sqliteSetting}");
        cfg.Logger.AddSink(new DbLogSink(sqliteFactory,
                                          ensureSchema: true,
                                          batchSize: 1,
                                          flushSeconds: 1,
                                          dialect: DbLogDialect.Sqlite,
                                          diagnostics: true));
        Console.WriteLine("Added SQLite sink (diagnostics on).");

        // SQL Server sink (optional)
        var sqlServerCs = config["SQLSERVER_CS"];
        if (!string.IsNullOrWhiteSpace(sqlServerCs))
        {
            try
            {
                cfg.Logger.AddSink(new DbLogSink(() => new SqlConnection(sqlServerCs),
                                                 ensureSchema: true,
                                                 batchSize: 1,
                                                 flushSeconds: 1,
                                                 dialect: DbLogDialect.SqlServer,
                                                 diagnostics: true));
                Console.WriteLine("Added SQL Server sink (diagnostics on).");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to add SQL Server sink: {ex.Message}");
            }
        }

        // PostgreSQL sink (optional)
        var pgCs = config["POSTGRES_CS"];
        if (!string.IsNullOrWhiteSpace(pgCs))
        {
            try
            {
                cfg.Logger.AddSink(new DbLogSink(() => new NpgsqlConnection(pgCs),
                                                 ensureSchema: true,
                                                 batchSize: 1,
                                                 flushSeconds: 1,
                                                 dialect: DbLogDialect.PostgreSql,
                                                 diagnostics: true));
                Console.WriteLine("Added PostgreSQL sink (diagnostics on).");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to add PostgreSQL sink: {ex.Message}");
            }
        }

        // Base path & token
        var basePath = config["GENESYS_BASE_PATH"];
        if (!string.IsNullOrWhiteSpace(basePath))
            cfg.ApiClient.setBasePath(basePath);

        var accessToken = config["ACCESS_TOKEN"];
        if (!string.IsNullOrWhiteSpace(accessToken))
            cfg.AccessToken = accessToken;

        var apiManager = new GenesysApiManager(cfg);

        Console.WriteLine("Exercising API calls to generate log traffic...");

        await ExerciseLoggingThroughManager(cfg, apiManager);

        Console.WriteLine("Log file written to: " + logFile);
        Console.WriteLine("Press ENTER after a couple seconds (allowing final flush) to exit.");
        Console.ReadLine();
    }

    private static async Task ExerciseLoggingThroughManager(Configuration cfg, GenesysApiManager manager)
    {
        try
        {
            var meSync = manager.GetCurrentUser();
            Console.WriteLine($"Sync user id: {meSync?.Id ?? "(null)"}");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Sync manager call threw (expected if unauthenticated): " + ex.Message);
        }

        try
        {
            var meAsync = await manager.GetCurrentUserAsync();
            Console.WriteLine($"Async user id: {meAsync?.Id ?? "(null)"}");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Async manager call threw (expected if unauthenticated): " + ex.Message);
        }
    }
}
