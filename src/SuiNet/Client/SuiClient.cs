using System;
using System.Collections.Generic;
using System.Text;

namespace SuiNet.Client
{
    public class SuiClient : SuiClientBase
    {
        public SuiClient():base(new HttpTransport())
        {
        }
    }
}
