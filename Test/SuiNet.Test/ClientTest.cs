using SuiNet.Client;
using SuiNet.Client.Types;
using System.Text.Json;
using Xunit.Abstractions;

namespace SuiNet.Test
{
    public class ClientTest
    {
        private readonly ITestOutputHelper _output;
        private readonly SuiClient _suiClient;
        string address = "0x02a212de6a9dfa3a69e22387acfbafbb1a9e591bd9d636e7895dcfc8de05f331";
        const string DEFAULT_PACKAGE = "0x2";
        const string DEFAULT_MODULE = "coin";
        const string DEFAULT_FUNCTION = "balance";
        const string DEFAULT_STRUCT = "Coin";
        public ClientTest(ITestOutputHelper output)
        {
            this._output = output;
            _suiClient = new SuiClient();
        }

        [Fact]
        public async void TestApiVersion()
        {
            var version = await _suiClient.GetRpcApiVersion();
            _output.WriteLine(version);
            Assert.NotEmpty(version);
        }

        [Fact]
        public async void TestGetCoins()
        {
            var coinParams = new GetCoinsParams
            {
                Owner = address,
                CoinType = "0x2::sui::SUI",
                Limit = 10
            };
            var paginatedCoins = await _suiClient.GetCoins(coinParams);
            Assert.True(paginatedCoins.Data.Count > 0);
        }

        [Fact]
        public async void TestGetAllCoins()
        {
            var coinParams = new GetAllCoinsParams
            {
                Owner = address,
                Limit = 10
            };
            var paginatedCoins = await _suiClient.GetAllCoins(coinParams);
            Assert.True(paginatedCoins.Data.Count > 0);
        }

        [Fact]
        public async void TestGetBalance()
        {
            var coinParams = new GetBalanceParams
            {
                Owner = address,
                CoinType = "0x2::sui::SUI"
            };
            var paginatedCoins = await _suiClient.GetBalance(coinParams);
            Assert.NotEmpty(paginatedCoins.TotalBalance);
        }

        [Fact]
        public async void TestGetAllBalances()
        {
            var coinParams = new GetAllBalancesParams
            {
                Owner = address
            };
            var paginatedCoins = await _suiClient.GetAllBalances(coinParams);
            Assert.True(paginatedCoins.Count > 0);
        }


        [Fact]
        public async void TestGetCoinMetadata()
        {
            var coinParams = new GetCoinMetadataParams
            {
                CoinType = "0xc060006111016b8a020ad5b33834984a437aaa7d3c74c18e09a95d48aceab08c::coin::COIN"
            };
            var paginatedCoins = await _suiClient.GetCoinMetadata(coinParams);
            Assert.Equal("USDT", paginatedCoins.Symbol);
        }


        [Fact]
        public async void TestGetTotalSupply()
        {
            var coinParams = new GetTotalSupplyParams
            {
                CoinType = "0xda1644f58a955833a15abae24f8cc65b5bd8152ce013fde8be0a6a3dcf51fe36::token::TOKEN"
            };
            var paginatedCoins = await _suiClient.GetTotalSupply(coinParams);
            Assert.NotEmpty(paginatedCoins.Value);
        }

        [Fact]
        public async void TestCall()
        {
            var coinParams = new GetTotalSupplyParams
            {
                CoinType = "0xda1644f58a955833a15abae24f8cc65b5bd8152ce013fde8be0a6a3dcf51fe36::token::TOKEN"
            };
            var paginatedCoins = await _suiClient.Call<CoinSupply>("suix_getTotalSupply", new List<object>() { coinParams.CoinType });
            Assert.NotEmpty(paginatedCoins.Value);
        }

        [Fact]
        public async void TestGetMoveFunctionArgTypes()
        {
            var input = new GetMoveFunctionArgTypesParams
            {
                Function = DEFAULT_FUNCTION,
                Package = DEFAULT_PACKAGE,
                Module = DEFAULT_MODULE
            };
            var result = await _suiClient.GetMoveFunctionArgTypes(input);
            var moveResult = result[0];
            Assert.Equal(ObjectValueKind.ByImmutableReference, result[0].Object);
        }
    }
}