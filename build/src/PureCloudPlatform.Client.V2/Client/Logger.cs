using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace PureCloudPlatform.Client.V2.Client
{
    /// <summary>
    /// SDK Logger with pluggable sink architecture
    /// </summary>
    /// <remarks>
    /// Initializes a new instance of the Logger class
    /// </remarks>
    public class Logger(
                  bool logToConsole = true,
                  LogFormat logFormat = LogFormat.Text,
                  LogLevel logLevel = LogLevel.LNone,
                  bool logResponseBody = false,
                  bool logRequestBody = false)
    {
        private ILogger ExternaLogger;

        /// <summary>
        /// Sets the external logger to be used for logging operations.
        /// </summary>
        /// <param name="logger">The logger instance that will handle log messages. Cannot be null.</param>
        public void SetExternalLogger(ILogger logger) => ExternaLogger = logger;

        /// <summary>
        /// Gets or sets the LogToConsole value (setting to true after construction will add a Console sink)
        /// </summary>
        public bool LogToConsole { get; set; } = logToConsole;

        /// <summary>
        /// Gets or sets the Log Format.
        /// </summary>
        public LogFormat? Format { get; set; } = logFormat;

        /// <summary>
        /// Gets or sets the Log Level.
        /// </summary>
        public LogLevel? Level { get; set; } = logLevel;

        /// <summary>
        /// Gets or sets the LogResponseBody value.
        /// </summary>
        public bool LogResponseBody { get; set; } = logResponseBody;

        /// <summary>
        /// Gets or sets the LogRequestBody value.
        /// </summary>
        public bool LogRequestBody { get; set; } = logRequestBody;


        internal void Trace(string method,
                          string url,
                          object requestBody,
                          int statusCode,
                          Dictionary<string, string> requestHeaders,
                          Dictionary<string, string> responseHeaders)
        {
            LogStatement logStatement = new(
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
                          Dictionary<string, string> requestHeaders)
        {
            LogStatement logStatement = new(
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
                          Dictionary<string, string> requestHeaders,
                          Dictionary<string, string> responseHeaders)
        {
            LogStatement logStatement = new(
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

            // if we have an external logger, we always log as info
            ExternaLogger?.Log(Microsoft.Extensions.Logging.LogLevel.Information, "GenesysAPI Call:\n{apiCall}", rendered);
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
    }

    /// <summary>
    /// Specifies the available formats for log output.
    /// </summary>
    /// <remarks>Use this enumeration to select the format in which log entries are written. The format
    /// affects how log data is structured and consumed by downstream systems or tools.</remarks>
    public enum LogFormat
    {
        /// <summary>
        /// Represents a type or member related to JSON functionality.
        /// </summary>
        JSON,
        /// <summary>
        /// Gets or sets the text content associated with this instance.
        /// </summary>
        Text
    }

    /// <summary>
    /// Specifies the severity level for logging messages.
    /// </summary>
    /// <remarks>Use the LogLevel enumeration to control which messages are recorded by a logging system.
    /// Lower levels, such as LTrace and LDebug, are typically used for detailed diagnostic information, while LError
    /// indicates error conditions. LNone disables logging output. The effective log level determines which messages are
    /// included in logs; messages below the configured level are ignored.</remarks>
    public enum LogLevel
    {
        /// <summary>
        /// Provides tracing and logging functionality for diagnostic purposes within the application.
        /// </summary>
        /// <remarks>Use this class to record informational messages, warnings, and errors to assist with
        /// debugging and monitoring application behavior. Tracing output may be directed to various listeners depending
        /// on configuration. This class is typically used during development and troubleshooting to gain insight into
        /// application execution.</remarks>
        LTrace,
        /// <summary>
        /// Provides logging and debugging utilities for application development.
        /// </summary>
        /// <remarks>Use this class to output diagnostic information during development or
        /// troubleshooting. The available methods and properties facilitate logging messages, tracking execution flow,
        /// and inspecting application state. This class is intended for use in development and may be disabled or
        /// omitted in production environments.</remarks>
        LDebug,
        /// <summary>
        /// Represents an error encountered during Lua script execution.
        /// </summary>
        /// <remarks>Use this type to capture and inspect details about errors that occur when running Lua
        /// code. The contents typically include the error message and any relevant context provided by the Lua
        /// runtime.</remarks>
        LError,
        /// <summary>
        /// Represents the absence of a specific value or option in the enumeration.
        /// </summary>
        LNone
    }

    /// <summary>
    /// LogStatement represents a single log entry
    /// </summary>
    public class LogStatement(DateTime date,
                        string level = null,
                        string method = null,
                        string url = null,
                        Dictionary<string, string> requestHeaders = null,
                        Dictionary<string, string> responseHeaders = null,
                        int statusCode = 0,
                        string requestBody = null,
                        string responseBody = null)
    {
        [JsonProperty]
        private readonly DateTime date = date;
        [JsonProperty]
        private readonly string level = level;
        [JsonProperty]
        private readonly string method = method;
        [JsonProperty]
        private readonly string url = url;
        [JsonProperty]
        private readonly Dictionary<string, string> requestHeaders = requestHeaders ?? [];
        [JsonProperty]
        private readonly Dictionary<string, string> responseHeaders = responseHeaders;
        [JsonProperty]
        private readonly string correlationId = GetCorrelationId(responseHeaders);
        [JsonProperty]
        private readonly int statusCode = statusCode;
        [JsonProperty]
        private string requestBody = requestBody;
        [JsonProperty]
        private string responseBody = responseBody;

        /// <summary>
        /// Returns a string representation of the log entry in the specified format, optionally including the request
        /// and response bodies.
        /// </summary>
        /// <remarks>When logging, authorization headers are automatically redacted to protect sensitive
        /// information. Use the <paramref name="logRequestBody"/> and <paramref name="logResponseBody"/> parameters to
        /// control whether potentially sensitive request and response bodies are included in the output.</remarks>
        /// <param name="logFormat">The format to use for the log output. Specify <see cref="LogFormat.JSON"/> to serialize the log entry as
        /// JSON; otherwise, a plain text format is used.</param>
        /// <param name="logRequestBody">Indicates whether the request body should be included in the log output. If <see langword="false"/>, the
        /// request body is omitted.</param>
        /// <param name="logResponseBody">Indicates whether the response body should be included in the log output. If <see langword="false"/>, the
        /// response body is omitted.</param>
        /// <returns>A string containing the formatted log entry. The output will be in JSON or plain text format, depending on
        /// <paramref name="logFormat"/>. Sensitive information such as authorization headers is redacted.</returns>
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
                JsonSerializerSettings settings = new()
                {
                    NullValueHandling = NullValueHandling.Ignore,
                    ContractResolver = new DefaultContractResolver
                    {
                        NamingStrategy = new CamelCaseNamingStrategy()
                    }
                };

                return JsonConvert.SerializeObject(this, settings);
            }

            return string.Format(@"{0}: {1}
=== REQUEST ==={2}{3}{4}{5}
=== RESPONSE ==={6}{7}{8}{9}", level?.ToUpper(),
                            date,
                            FormatValue("URL", url),
                            FormatValue("Method", method),
                            FormatValue("Headers", FormatHeaders(requestHeaders)),
                            FormatValue("Body", requestBody),

                            FormatValue("Status", string.Format("{0}", statusCode)),
                            FormatValue("Headers", FormatHeaders(responseHeaders)),
                            FormatValue("CorrelationId", correlationId),
                            FormatValue("Body", responseBody));
        }

        private static string FormatValue(string name, string value)
        {
            return string.IsNullOrEmpty(value) ? "" : string.Format("\n{0}: {1}", name, value);
        }

        private static string FormatHeaders(Dictionary<string, string> headers)
        {
            if (headers == null)
                return "";

            var sb = new StringBuilder();
            foreach (var item in headers)
                sb.AppendFormat("\n\t{0}: {1}", item.Key, item.Value);
            return sb.ToString();
        }

        private static string GetCorrelationId(Dictionary<string, string> headers)
        {
            if (headers == null)
                return "";
            headers.TryGetValue("ININ-Correlation-Id", out var cid);
            return cid ?? "";
        }
    }
}