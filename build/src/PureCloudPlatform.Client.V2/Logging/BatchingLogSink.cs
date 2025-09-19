using PureCloudPlatform.Client.V2.Client;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace PureCloudPlatform.Client.V2.Logging
{

    /// <summary>
    /// Base class for log sinks that batch <see cref="LogStatement"/> entries and flush them
    /// either when a batch size threshold is reached or a flush interval elapses.
    /// </summary>
    /// <remarks>
    /// Implementations should override <see cref="FlushAsync"/> to persist a batch. The base class
    /// handles a bounded channel with a single reader and multiple writers. When the channel
    /// is full the oldest entry is dropped (DropOldest) to avoid back-pressure on the caller.
    /// </remarks>
    public abstract class BatchingLogSink : ILogSink
    {
        private readonly Channel<(LogStatement stmt, string rendered)> _channel;
        private readonly CancellationTokenSource _cts = new();
        private readonly Task _worker;
        private readonly int _batchSize;
        private readonly TimeSpan _flushInterval;

        /// <summary>
        /// Create a new batching sink.
        /// </summary>
        /// <param name="batchSize">Maximum number of log entries to accumulate before forcing a flush.</param>
        /// <param name="capacity">Maximum number of queued entries awaiting processing (older entries are dropped when full).</param>
        /// <param name="flushInterval">Maximum time to wait before flushing a non-empty batch.</param>
        protected BatchingLogSink(int batchSize, int capacity, TimeSpan flushInterval)
        {
            _batchSize = batchSize;
            _flushInterval = flushInterval;
            var options = new BoundedChannelOptions(capacity)
            {
                SingleReader = true,
                SingleWriter = false,
                FullMode = BoundedChannelFullMode.DropOldest
            };
            _channel = Channel.CreateBounded<(LogStatement stmt, string rendered)>(options);
            _worker = Task.Run(WorkerLoop);
        }

        /// <summary>
        /// Enqueue a log statement for batched processing. If the channel is full the
        /// oldest pending entry is discarded (see <see cref="BoundedChannelFullMode.DropOldest"/>).
        /// </summary>
        /// <param name="statement">The raw <see cref="LogStatement"/>.</param>
        /// <param name="rendered">The pre-rendered textual representation.</param>
        public void Emit(LogStatement statement, string rendered)
        {
            if (!_channel.Writer.TryWrite((statement, rendered))) { }
        }

        // Worker coroutine: collects items until batch size or flush interval is hit
        private async Task WorkerLoop()
        {
            var buffer = new List<(LogStatement stmt, string rendered)>(_batchSize);
            var nextFlush = DateTime.UtcNow + _flushInterval;
            try
            {
                while (await _channel.Reader.WaitToReadAsync(_cts.Token))
                {
                    while (_channel.Reader.TryRead(out var item))
                    {
                        buffer.Add(item);
                        if (buffer.Count >= _batchSize)
                        {
                            nextFlush = await FlushAndGetNext(buffer);
                        }
                    }
                    if (buffer.Count > 0 && DateTime.UtcNow >= nextFlush)
                        nextFlush = await FlushAndGetNext(buffer);
                }
            }
            catch (OperationCanceledException) { }
            catch { }
            finally
            {
                // Final flush with a non-cancelled token so we persist remaining buffered entries
                if (buffer.Count > 0)
                {
                    try { await FlushAsync(buffer, CancellationToken.None); } catch { }
                }
            }
        }

        private async Task<DateTime> FlushAndGetNext(List<(LogStatement stmt, string rendered)> buffer)
        {
            try { await FlushAsync(buffer, _cts.Token); } catch { }
            buffer.Clear();
            return DateTime.UtcNow + _flushInterval;
        }

        /// <summary>
        /// Flush a batch of log entries to the underlying store.
        /// </summary>
        /// <param name="batch">The immutable snapshot of the current batch.</param>
        /// <param name="ct">Cancellation token (cancelled when sink is disposed).</param>
        protected abstract Task FlushAsync(IReadOnlyList<(LogStatement stmt, string rendered)> batch, CancellationToken ct);

        /// <inheritdoc />
        public void Dispose()
        {
            // Complete writer so worker drains existing items then performs final flush
            _channel.Writer.TryComplete();
            try { _worker.Wait(5000); } catch { }
            // Now signal cancellation for any operations blocked on the token (should be none after completion)
            _cts.Cancel();
            _cts.Dispose();
        }

        /// <inheritdoc />
        public async ValueTask DisposeAsync()
        {
            _channel.Writer.TryComplete();
            try { await _worker; } catch { }
            _cts.Cancel();
            _cts.Dispose();
        }
    }
}
