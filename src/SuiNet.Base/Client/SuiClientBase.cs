
using SuiNet.Base.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SuiNet.Base.Client
{
    public class SuiClientBase
    {

        private readonly IHttpTransport _transport;

        public SuiClientBase(IHttpTransport transport)
        {
            this._transport = transport;
        }
        class Info
        {
            public string Version { get; set; }
        }

        public virtual async Task<string> GetRpcApiVersion()
        {

            var resp = await _transport.Send<Info>(new SuiRpcData("rpc.discover"));
            return resp.info.version;
        }
    }
}
