using SuiNet.Base.Interfaces;

namespace SuiNet.Base.Client
{
    public class SuiClientOptions
    {
        public string Url { get; set; }
        public IHttpTransport Transport { get; set; }
    }
}
