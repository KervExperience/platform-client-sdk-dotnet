using System;
using System.Net.WebSockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PureCloudPlatform.Client.V2.Extensions.Notifications
{
    /// <summary>
    /// Wrapper around System.Net.WebSockets.ClientWebSocket to provide a simpler interface
    /// </summary>
    public class WebSocketWrapper : IDisposable
    {
        private readonly ClientWebSocket _webSocket;
        private CancellationTokenSource _receiveCts;
        private Task _receiveTask;

        /// <summary>
        /// Event raised when a message is received
        /// </summary>
        public event EventHandler<MessageReceivedEventArgs> MessageReceived;

        /// <summary>
        /// Event raised when the WebSocket is closed
        /// </summary>
        public event EventHandler<CloseEventArgs> Closed;

        /// <summary>
        /// Event raised when an error occurs
        /// </summary>
        public event EventHandler<ErrorEventArgs> Error;

        /// <summary>
        /// Gets whether the WebSocket is currently open
        /// </summary>
        public bool IsAlive => _webSocket?.State == WebSocketState.Open;

        public WebSocketWrapper()
        {
            _webSocket = new ClientWebSocket();
            _webSocket.Options.KeepAliveInterval = TimeSpan.FromSeconds(30);
        }

        /// <summary>
        /// Configures SSL/TLS protocols
        /// </summary>
        public void SetSslProtocol(System.Security.Authentication.SslProtocols protocols)
        {
            // ClientWebSocket uses system defaults for TLS, which is appropriate for modern .NET
            // TLS 1.2+ is enabled by default in .NET 8
        }

        /// <summary>
        /// Sets proxy configuration
        /// </summary>
        public void SetProxy(string url, string username = null, string password = null)
        {
            if (!string.IsNullOrEmpty(url))
            {
                var proxy = new System.Net.WebProxy(url);
                if (!string.IsNullOrEmpty(username))
                {
                    proxy.Credentials = new System.Net.NetworkCredential(username, password);
                }
                _webSocket.Options.Proxy = proxy;
            }
        }

        /// <summary>
        /// Connects to the WebSocket server
        /// </summary>
        public async Task ConnectAsync(string uri)
        {
            try
            {
                await _webSocket.ConnectAsync(new Uri(uri), CancellationToken.None);
                _receiveCts = new CancellationTokenSource();
                _receiveTask = ReceiveLoop(_receiveCts.Token);
            }
            catch (Exception ex)
            {
                Error?.Invoke(this, new ErrorEventArgs($"Connection error: {ex.Message}", ex));
                throw;
            }
        }

        /// <summary>
        /// Connects to the WebSocket server (synchronous wrapper)
        /// </summary>
        public void Connect(string uri)
        {
            ConnectAsync(uri).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Sends a text message
        /// </summary>
        public async Task SendAsync(string message)
        {
            if (_webSocket.State != WebSocketState.Open)
            {
                throw new InvalidOperationException("WebSocket is not open");
            }

            var bytes = Encoding.UTF8.GetBytes(message);
            await _webSocket.SendAsync(new ArraySegment<byte>(bytes), WebSocketMessageType.Text, true, CancellationToken.None);
        }

        /// <summary>
        /// Sends a text message (synchronous wrapper)
        /// </summary>
        public void Send(string message)
        {
            SendAsync(message).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Closes the WebSocket connection
        /// </summary>
        public async Task CloseAsync()
        {
            if (_webSocket.State == WebSocketState.Open)
            {
                _receiveCts?.Cancel();
                
                try
                {
                    await _webSocket.CloseAsync(WebSocketCloseStatus.NormalClosure, "Closing", CancellationToken.None);
                }
                catch (Exception ex)
                {
                    Error?.Invoke(this, new ErrorEventArgs($"Error closing WebSocket: {ex.Message}", ex));
                }
                
                if (_receiveTask != null)
                {
                    await _receiveTask;
                }
            }
        }

        /// <summary>
        /// Closes the WebSocket connection (synchronous wrapper)
        /// </summary>
        public void Close()
        {
            CloseAsync().GetAwaiter().GetResult();
        }

        private async Task ReceiveLoop(CancellationToken cancellationToken)
        {
            var buffer = new byte[8192];
            var messageBuffer = new StringBuilder();

            try
            {
                while (_webSocket.State == WebSocketState.Open && !cancellationToken.IsCancellationRequested)
                {
                    WebSocketReceiveResult result;
                    messageBuffer.Clear();

                    do
                    {
                        result = await _webSocket.ReceiveAsync(new ArraySegment<byte>(buffer), cancellationToken);

                        if (result.MessageType == WebSocketMessageType.Close)
                        {
                            Closed?.Invoke(this, new CloseEventArgs((ushort)(result.CloseStatus ?? WebSocketCloseStatus.NormalClosure), result.CloseStatusDescription));
                            return;
                        }

                        if (result.MessageType == WebSocketMessageType.Text)
                        {
                            messageBuffer.Append(Encoding.UTF8.GetString(buffer, 0, result.Count));
                        }
                    }
                    while (!result.EndOfMessage);

                    if (messageBuffer.Length > 0)
                    {
                        MessageReceived?.Invoke(this, new MessageReceivedEventArgs(messageBuffer.ToString()));
                    }
                }
            }
            catch (OperationCanceledException)
            {
                // Expected when cancellation is requested
            }
            catch (WebSocketException ex)
            {
                Error?.Invoke(this, new ErrorEventArgs($"WebSocket error: {ex.Message}", ex));
            }
            catch (Exception ex)
            {
                Error?.Invoke(this, new ErrorEventArgs($"Unexpected error: {ex.Message}", ex));
            }
        }

        public void Dispose()
        {
            _receiveCts?.Cancel();
            _receiveCts?.Dispose();
            _webSocket?.Dispose();
        }
    }

    /// <summary>
    /// Event args for message received events
    /// </summary>
    public class MessageReceivedEventArgs : EventArgs
    {
        public string Data { get; }

        public MessageReceivedEventArgs(string data)
        {
            Data = data;
        }
    }

    /// <summary>
    /// Event args for close events
    /// </summary>
    public class CloseEventArgs : EventArgs
    {
        public ushort Code { get; }
        public string Reason { get; }

        public CloseEventArgs(ushort code, string reason)
        {
            Code = code;
            Reason = reason ?? string.Empty;
        }
    }

    /// <summary>
    /// Event args for error events
    /// </summary>
    public class ErrorEventArgs : EventArgs
    {
        public string Message { get; }
        public Exception Exception { get; }

        public ErrorEventArgs(string message, Exception exception = null)
        {
            Message = message;
            Exception = exception;
        }
    }
}
