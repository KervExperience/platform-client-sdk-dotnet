using PureCloudPlatform.Client.V2.Client;
using System;

namespace PureCloudPlatform.Client.V2.Logging
{
    /// <summary>
    /// Contract for a logging sink that receives rendered <see cref="LogStatement"/> instances.
    /// </summary>
    public interface ILogSink : IAsyncDisposable, IDisposable
    {
        /// <summary>
        /// Emit a log entry to the sink.
        /// </summary>
        /// <param name="statement">The raw log statement object.</param>
        /// <param name="rendered">The pre-rendered textual representation (may already be formatted as JSON or text).</param>
        void Emit(LogStatement statement, string rendered);
    }
}
