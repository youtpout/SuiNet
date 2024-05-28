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
            var response = await _transport.Send<RpcApiVersion>(new SuiRpcData("rpc.discover"));
            return response.Info.Version;
        }

        public virtual async Task<PaginatedCoins> GetCoins(GetCoinsParams input)
        {
            return await _transport.Send<PaginatedCoins>(new SuiRpcData("suix_getCoins",input));
        }

        public virtual async Task<PaginatedCoins> GetAllCoins(GetAllCoinsParams input)
        {
            return await _transport.Send<PaginatedCoins>(new SuiRpcData("suix_getAllCoins", input));
        }

    }
}
