using SuiNet.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuiNet.Core.Client
{
    public class SuiClient
    {

        private readonly IHttpTransport _transport;

        public SuiClient(IHttpTransport transport)
        {
            this._transport = transport;
        }


    }
}
