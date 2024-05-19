using SuiNet.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuiNet.Core.Client
{
    public class SuiClientOptions
    {
        public string Url { get; set; }
        public IHttpTransport Transport { get; set; }
    }
}
