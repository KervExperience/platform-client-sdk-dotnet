using PureCloudPlatform.Client.V2.Client;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PureCloudPlatform.Client.V2.Logging
{
    /// <summary>
    /// Batching sink that appends rendered log entries to a file.
    /// </summary>
    internal sealed class FileLogSink : BatchingLogSink
    {
        private readonly string _path;
        /// <summary>
        /// Create a new file log sink.
        /// </summary>
        /// <param name="path">Destination file path (directories are created if necessary).</param>
        /// <param name="batchSize">Maximum batch size before forcing a flush.</param>
        /// <param name="capacity">Maximum number of buffered entries.</param>
        /// <param name="flushSeconds">Maximum seconds between automatic flushes.</param>
        public FileLogSink(string path, int batchSize = 50, int capacity = 5_000, int flushSeconds = 2)
            : base(batchSize, capacity, TimeSpan.FromSeconds(flushSeconds))
        {
            _path = path;
            Directory.CreateDirectory(Path.GetDirectoryName(Path.GetFullPath(path)) ?? ".");
        }

        /// <summary>
        /// Append the batch to the target file (best-effort, errors ignored).
        /// </summary>
        protected override async Task FlushAsync(IReadOnlyList<(LogStatement stmt, string rendered)> batch, CancellationToken ct)
        {
            var sb = new StringBuilder();
            foreach (var (_, rendered) in batch)
                sb.Append(rendered).Append('\n');
            try { await File.AppendAllTextAsync(_path, sb.ToString(), Encoding.UTF8, ct); } catch { }
        }
    }
}
