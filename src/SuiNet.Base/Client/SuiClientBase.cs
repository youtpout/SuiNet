using SuiNet.Client.Types;
using SuiNet.Interfaces;
using System.Collections.Generic;
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

        /// <summary>
        /// Get all Coin<`coin_type`> objects owned by an address.
        /// </summary>
        public virtual async Task<PaginatedCoins> GetCoins(GetCoinsParams input)
        {
            return await _transport.Send<PaginatedCoins>(new SuiRpcData("suix_getCoins", input));
        }

        /// <summary>
        /// Get all Coin objects owned by an address..
        /// </summary>
        public virtual async Task<PaginatedCoins> GetAllCoins(GetAllCoinsParams input)
        {
            return await _transport.Send<PaginatedCoins>(new SuiRpcData("suix_getAllCoins", input));
        }

        /// <summary>
        /// Get the total coin balance for one coin type, owned by the address owner.
        /// </summary>
        public virtual async Task<CoinBalance> GetBalance(GetBalanceParams input)
        {
            return await _transport.Send<CoinBalance>(new SuiRpcData("suix_getBalance", input));
        }

        /// <summary>
        /// Get the total coin balance for all coin types, owned by the address owner.
        /// </summary>
        public virtual async Task<List<CoinBalance>> GetAllBalances(GetAllBalancesParams input)
        {
            return await _transport.Send<List<CoinBalance>>(new SuiRpcData("suix_getAllBalances", input));
        }

        /// <summary>
        /// Fetch CoinMetadata for a given coin type
        /// </summary>
        public virtual async Task<CoinMetadata> GetCoinMetadata(GetCoinMetadataParams input)
        {
            return await _transport.Send<CoinMetadata>(new SuiRpcData("suix_getCoinMetadata", input));
        }

        /// <summary>
        /// Fetch total supply for a coin
        /// </summary>
        public virtual async Task<CoinSupply> GetTotalSupply(GetTotalSupplyParams input)
        {
            return await _transport.Send<CoinSupply>(new SuiRpcData("suix_getTotalSupply", input));
        }

        /// <summary>
        /// Invoke any RPC method
        /// </summary>
        /// <param name="method">the method to be invoked</param>
        /// <param name="input">the arguments to be passed to the RPC request</param>
        public virtual async Task<T> Call<T>(string method, List<object> input) where T : new()
        {
            return await _transport.Send<T>(new SuiRpcData(method, input));
        }
    }
}
