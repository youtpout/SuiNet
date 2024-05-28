using SuiNet.Client;
using SuiNet.Client.Types;
using Xunit.Abstractions;

namespace SuiNet.Test
{
    public class ClientTest
    {
        private readonly ITestOutputHelper _output;
        private readonly SuiClient _suiClient;

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
            string address = "0x02a212de6a9dfa3a69e22387acfbafbb1a9e591bd9d636e7895dcfc8de05f331";
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
            string address = "0x02a212de6a9dfa3a69e22387acfbafbb1a9e591bd9d636e7895dcfc8de05f331";
            var coinParams = new GetAllCoinsParams
            {
                Owner = address,
                Limit = 10
            };
            var paginatedCoins = await _suiClient.GetAllCoins(coinParams);
            Assert.True(paginatedCoins.Data.Count > 0);
        }
    }
}