using SuiNet.Client.Types;
using SuiNet.Interfaces;
using System.Threading.Tasks;

namespace SuiNet.Client
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
