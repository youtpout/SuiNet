using System;
using System.Collections.Generic;
using System.Text;

namespace SuiNet.Base.Client
{
    public class SuiRpcData
    {
        public string Method { get; set; }
        public List<object> Params { get; set; }

        public SuiRpcData() { }

        public SuiRpcData(string method, List<object> @params)
        {
            Method = method;
            Params = @params;
        }


        public SuiRpcData(string method)
        {
            Method = method;
            Params = new List<object>();
        }
    }
}
