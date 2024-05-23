using SuiNet.Base.Client;
using SuiNet.Base.Interfaces;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SuiNet.Client
{
    public class HttpTransport : IHttpTransport
    {
        HttpClient _httpClient;
        private static int _requestId;

        public HttpTransport()
        {
            this._httpClient = new HttpClient();
            this._httpClient.BaseAddress = new Uri("https://fullnode.mainnet.sui.io:443");
        }

        public async Task<T> Send<T>(SuiRpcData data)
        {
            _requestId++;
            data.Id = _requestId.ToString();
            var response = await _httpClient.PostAsJsonAsync<SuiRpcData>("", data);
            response.EnsureSuccessStatusCode();
            var jsonResponse = await response.Content.ReadAsStringAsync();
            T result = JsonSerializer.Deserialize<T>(jsonResponse, new JsonSerializerOptions(JsonSerializerDefaults.Web));
            return result;
        }

        public async Task Send(SuiRpcData data)
        {
            var response = await _httpClient.PostAsJsonAsync<SuiRpcData>("", data);
            response.EnsureSuccessStatusCode();
        }
    }
}
