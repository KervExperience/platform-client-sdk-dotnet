using PureCloudPlatform.Client.V2.Client;
using System;
using System.Threading.Tasks;

namespace PureCloudPlatform.Client.V2.Logging
{
    /// <summary>
    /// Simple sink that writes rendered log statements directly to <see cref="Console"/>.
    /// </summary>
    internal sealed class ConsoleLogSink : ILogSink
    {
        /// <summary>
        /// Write the rendered log entry to the console.
        /// </summary>
        /// <param name="statement">The raw log statement.</param>
        /// <param name="rendered">The rendered textual representation.</param>
        public void Emit(LogStatement statement, string rendered) => Console.WriteLine(rendered);
        /// <inheritdoc />
        public void Dispose() { }
        /// <inheritdoc />
        public ValueTask DisposeAsync() => ValueTask.CompletedTask;
    }
}
