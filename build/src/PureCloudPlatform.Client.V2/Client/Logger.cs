using System;
using System.Text;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Threading.Tasks;
using PureCloudPlatform.Client.V2.Logging;

namespace PureCloudPlatform.Client.V2.Client
{
    /// <summary>
    /// SDK Logger with pluggable sink architecture
    /// </summary>
    public class Logger : IAsyncDisposable, IDisposable
    {
        private readonly List<ILogSink> _sinks = new();
        private string logFilePath; // retained for backwards compat property semantics

        /// <summary>
        /// Initializes a new instance of the Logger class (backwards compatible)
        /// </summary>
        public Logger(string logFilePath = null,
                      bool logToConsole = true,
                      LogFormat logFormat = LogFormat.Text,
                      LogLevel logLevel = LogLevel.LNone,
                      bool logResponseBody = false,
                      bool logRequestBody = false,
                      IEnumerable<ILogSink> sinks = null)
        {
            this.logFilePath = logFilePath;
            LogToConsole = logToConsole;
            Format = logFormat;
            Level = logLevel;
            LogResponseBody = logResponseBody;
            LogRequestBody = logRequestBody;

            // Register implicit sinks to preserve original behavior
            if (LogToConsole)
                _sinks.Add(new ConsoleLogSink());
            if (!string.IsNullOrEmpty(logFilePath))
            {
                try { _sinks.Add(new FileLogSink(logFilePath)); }
                catch { /* ignore */ }
            }
            if (sinks != null)
                _sinks.AddRange(sinks);
        }

        /// <summary>
        /// Add a sink at runtime
        /// </summary>
        public Logger AddSink(ILogSink sink)
        {
            if (sink != null) _sinks.Add(sink);
            return this;
        }

        /// <summary>
        /// Gets or sets the LogFilePath (setting after construction will add a FileLogSink)
        /// </summary>
        public string LogFilePath
        {
            get => logFilePath;
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    logFilePath = value;
                    try { _sinks.Add(new FileLogSink(value)); } catch { /* no-op */ }
                }
            }
        }

        /// <summary>
        /// Gets or sets the LogToConsole value (setting to true after construction will add a Console sink)
        /// </summary>
        public bool LogToConsole { get; set; }

        /// <summary>
        /// Gets or sets the Log Format.
        /// </summary>
        public LogFormat? Format { get; set; }

        /// <summary>
        /// Gets or sets the Log Level.
        /// </summary>
        public LogLevel? Level { get; set; }

        /// <summary>
        /// Gets or sets the LogResponseBody value.
        /// </summary>
        public bool LogResponseBody { get; set; }

        /// <summary>
        /// Gets or sets the LogRequestBody value.
        /// </summary>
        public bool LogRequestBody { get; set; }

        /// <summary>
        /// Parses a LogLevel value from a string
        /// </summary>
        internal static LogLevel? LogLevelFromString(string logLevel)
        {
            logLevel = "l" + logLevel;
            try
            {
                LogLevel logLevelValue = (LogLevel)Enum.Parse(typeof(LogLevel), logLevel, true);
                if (Enum.IsDefined(typeof(LogLevel), logLevelValue) | logLevelValue.ToString().Contains(","))
                    return logLevelValue;
                else
                    return null;
            }
            catch (ArgumentException)
            {
                return null;
            }
        }

        /// <summary>
        /// Parses a LogFormat value from a string
        /// </summary>
        internal static LogFormat? LogFormatFromString(string logFormat)
        {
            try
            {
                LogFormat logFormatValue = (LogFormat)Enum.Parse(typeof(LogFormat), logFormat, true);
                if (Enum.IsDefined(typeof(LogFormat), logFormatValue) | logFormatValue.ToString().Contains(","))
                    return logFormatValue;
                else
                    return null;
            }
            catch (ArgumentException)
            {
                return null;
            }
        }

        internal void Trace(string method,
                          string url,
                          object requestBody,
                          int statusCode,
                          Dictionary<String, String> requestHeaders,
                          Dictionary<String, String> responseHeaders)
        {
            LogStatement logStatement = new LogStatement(
                DateTime.UtcNow,
                "trace",
                method,
                url,
                requestHeaders,
                responseHeaders,
                statusCode,
                requestBodyToString(requestBody)
            );

            Log(LogLevel.LTrace, logStatement);
        }

        internal void Debug(string method,
                          string url,
                          object requestBody,
                          int statusCode,
                          Dictionary<String, String> requestHeaders)
        {
            LogStatement logStatement = new LogStatement(
                DateTime.UtcNow,
                "debug",
                method,
                url,
                requestHeaders,
                statusCode: statusCode,
                requestBody: requestBodyToString(requestBody)
            );

            Log(LogLevel.LDebug, logStatement);
        }

        internal void Error(string method,
                          string url,
                          object requestBody,
                          string responseBody,
                          int statusCode,
                          Dictionary<String, String> requestHeaders,
                          Dictionary<String, String> responseHeaders)
        {
            LogStatement logStatement = new LogStatement(
                DateTime.UtcNow,
                "error",
                method,
                url,
                requestHeaders,
                responseHeaders,
                statusCode,
                requestBodyToString(requestBody),
                responseBody
            );

            Log(LogLevel.LError, logStatement);
        }

        /// <summary>
        /// Write log statement to registered sinks
        /// </summary>
        protected virtual void Log(LogLevel logLevel, LogStatement logStatement)
        {
            if (Level == null) return;
            if (logLevel < Level) return;

            string rendered = logStatement.AsString(Format, LogRequestBody, LogResponseBody);

            // Ensure console sink present if LogToConsole toggled after construction
            if (LogToConsole && _sinks.Find(s => s is ConsoleLogSink) == null)
                _sinks.Add(new ConsoleLogSink());

            foreach (var sink in _sinks)
            {
                try { sink.Emit(logStatement, rendered); }
                catch { /* swallow sink errors */ }
            }
        }

        private static string requestBodyToString(object requestBody)
        {
            if (requestBody != null)
            {
                if (requestBody.GetType() == typeof(String))
                    return requestBody.ToString();
                else if (requestBody.GetType() == typeof(byte[]))
                    return System.Text.Encoding.UTF8.GetString((byte[])requestBody);
            }
            return null;
        }

        /// <summary>
        /// Dispose sinks synchronously
        /// </summary>
        public void Dispose()
        {
            foreach (var sink in _sinks)
            {
                try { sink.Dispose(); } catch { }
            }
        }

        /// <summary>
        /// Dispose sinks asynchronously if supported
        /// </summary>
        public async ValueTask DisposeAsync()
        {
            foreach (var sink in _sinks)
            {
                try { await sink.DisposeAsync(); } catch { }
            }
        }
    }

    public enum LogFormat
    {
        JSON,
        Text
    }

    public enum LogLevel
    {
        LTrace,
        LDebug,
        LError,
        LNone
    }

    /// <summary>
    /// LogStatement represents a single log entry
    /// </summary>
    public class LogStatement
    {
        public LogStatement(DateTime date,
                            string level = null,
                            string method = null,
                            string url = null,
                            Dictionary<String, String> requestHeaders = null,
                            Dictionary<String, String> responseHeaders = null,
                            int statusCode = 0,
                            string requestBody = null,
                            string responseBody = null)
        {
            this.date = date;
            this.level = level;
            this.method = method;
            this.url = url;
            this.requestHeaders = requestHeaders ?? new Dictionary<string, string>();
            this.responseHeaders = responseHeaders;
            this.correlationId = getCorrelationId(responseHeaders);
            this.statusCode = statusCode;
            this.requestBody = requestBody;
            this.responseBody = responseBody;
        }

        [JsonProperty]
        private DateTime date;
        [JsonProperty]
        private string level;
        [JsonProperty]
        private string method;
        [JsonProperty]
        private string url;
        [JsonProperty]
        private Dictionary<String, String> requestHeaders;
        [JsonProperty]
        private Dictionary<String, String> responseHeaders;
        [JsonProperty]
        private string correlationId;
        [JsonProperty]
        private int statusCode;
        [JsonProperty]
        private string requestBody;
        [JsonProperty]
        private string responseBody;

        // Public read-only accessors for sinks (avoid reflection)
        public DateTime Date => date;
        public string Level => level;
        public string Method => method;
        public string Url => url;
        public IReadOnlyDictionary<string, string> RequestHeaders => requestHeaders;
        public IReadOnlyDictionary<string, string> ResponseHeaders => responseHeaders;
        public string CorrelationId => correlationId;
        public int StatusCode => statusCode;
        public string RequestBody => requestBody;
        public string ResponseBody => responseBody;

        public string AsString(LogFormat? logFormat, bool logRequestBody, bool logResponseBody)
        {
            if (requestHeaders != null && requestHeaders.ContainsKey("Authorization"))
                requestHeaders["Authorization"] = "[REDACTED]";

            if (!logRequestBody)
                requestBody = null;
            if (!logResponseBody)
                responseBody = null;

            if (logFormat == LogFormat.JSON)
            {
                JsonSerializerSettings settings = new JsonSerializerSettings()
                {
                    NullValueHandling = NullValueHandling.Ignore,
                    ContractResolver = new DefaultContractResolver
                    {
                        NamingStrategy = new CamelCaseNamingStrategy()
                    }
                };

                return JsonConvert.SerializeObject(this, settings);
            }

            return String.Format(@"{0}: {1}
=== REQUEST ==={2}{3}{4}{5}
=== RESPONSE ==={6}{7}{8}{9}", level?.ToUpper(),
                            date,
                            formatValue("URL", url),
                            formatValue("Method", method),
                            formatValue("Headers", formatHeaders(requestHeaders)),
                            formatValue("Body", requestBody),

                            formatValue("Status", String.Format("{0}", statusCode)),
                            formatValue("Headers", formatHeaders(responseHeaders)),
                            formatValue("CorrelationId", correlationId),
                            formatValue("Body", responseBody));
        }

        private string formatValue(string name, string value)
        {
            return String.IsNullOrEmpty(value) ? "" : String.Format("\n{0}: {1}", name, value);
        }

        private string formatHeaders(Dictionary<String, String> headers)
        {
            if (headers == null)
                return "";

            var sb = new StringBuilder();
            foreach (var item in headers)
                sb.AppendFormat("\n\t{0}: {1}", item.Key, item.Value);
            return sb.ToString();
        }

        private string getCorrelationId(Dictionary<String, String> headers)
        {
            if (headers == null)
                return "";
            headers.TryGetValue("ININ-Correlation-Id", out var cid);
            return cid ?? "";
        }
    }
}