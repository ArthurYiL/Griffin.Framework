﻿
namespace Griffin.Net.Protocols.Http.WebSocket
{
    /// <summary>
    /// WebSocket request includes the initial handshake request
    /// </summary>
    public class WebSocketRequest : WebSocketMessage
    {

        private readonly IHttpRequest _handshake;
        private readonly WebSocketFrame _frame;

        internal WebSocketRequest(IHttpRequest handshake, WebSocketFrame frame)
            : base(frame.Opcode, frame.Payload)
        {
            _handshake = handshake;
            _frame = frame;
        }

        /// <summary>
        /// Cookies of the handshake request
        /// </summary>
        public IHttpRequest Handshake
        {
            get
            {
                return _handshake;
            }
        }

    }
}
