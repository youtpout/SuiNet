using System;
using System.Collections.Generic;
using System.Text;

namespace SuiNet.Client.Types
{
    public class RpcApiVersion
    {
        public Info Info { get; set; }
    }

    public class Info
    {
        public string Version { get; set; }
    }
}
