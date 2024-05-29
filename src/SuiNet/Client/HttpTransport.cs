using SuiNet.Client.Types;
using SuiNet.Interfaces;
using System;
using System.Diagnostics;
using System.Net.Http;
using System.Net.Http.Json;
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

        public HttpTransport(string baseUrl)
        {
            this._httpClient = new HttpClient();
            this._httpClient.BaseAddress = new Uri(baseUrl);
        }

        public async Task<T> Send<T>(SuiRpcData data) where T : new()
        {
            _requestId++;
            data.Id = _requestId.ToString();
            var response = await _httpClient.PostAsJsonAsync<SuiRpcData>("", data);
            response.EnsureSuccessStatusCode();
            var jsonResponse = await response.Content.ReadAsStringAsync();
            Debug.WriteLine(jsonResponse);
            RpcResult<T> result = Deserialize<RpcResult<T>>(jsonResponse);

            return result.Result;
        }

        public async Task Send(SuiRpcData data)
        {
            var response = await _httpClient.PostAsJsonAsync<SuiRpcData>("", data);
            response.EnsureSuccessStatusCode();
        }

        public T Deserialize<T>(string json)
        {
            return JsonSerializer.Deserialize<T>(json, new JsonSerializerOptions(JsonSerializerDefaults.Web));
        }

        public T Parse<T>(object data)
        {
            JsonElement result = (JsonElement)data;
            return result.Deserialize<T>();
        }
    }
}
