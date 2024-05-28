using SuiNet.Interfaces;

namespace SuiNet.Client
{
    public class SuiClientOptions
    {
        public string Url { get; set; }
        public IHttpTransport Transport { get; set; }
    }
}
