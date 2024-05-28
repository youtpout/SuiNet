using SuiNet.Client;
using SuiNet.Client.Types;
using Xunit.Abstractions;

namespace SuiNet.Test
{
    public class ClientTest
    {
        private readonly ITestOutputHelper _output;
        private readonly SuiClient _suiClient;
        string address = "0x02a212de6a9dfa3a69e22387acfbafbb1a9e591bd9d636e7895dcfc8de05f331";

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
    }
}