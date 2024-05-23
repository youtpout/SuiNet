
using SuiNet.Base.Client.Types;
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

        public virtual async Task<string> GetRpcApiVersion()
        {

            var resp = await _transport.Send<RpcApiVersion>(new SuiRpcData("rpc.discover"));
            return resp.Info.Version;
        }
    }
}
