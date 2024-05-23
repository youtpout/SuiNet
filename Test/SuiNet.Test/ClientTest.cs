using SuiNet.Client;
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
    }
}