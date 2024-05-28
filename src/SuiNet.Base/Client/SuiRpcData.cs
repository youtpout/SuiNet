using System;
using System.Collections.Generic;
using System.Text;

namespace SuiNet.Client
{
    public class SuiRpcData
    {
        public string Method { get; set; }
        public List<object> Params { get; set; }
        public string Jsonrpc { get{
                return "2.0";
            } }
        public string Id { get; set; }

        public SuiRpcData() { }

        public SuiRpcData(string method, List<object> listParams)
        {
            Method = method;
            Params = listParams;
        }

        public SuiRpcData(string method, object objectParams)
        {
            Method = method;
            var list=new List<object>();
            foreach(var prop in objectParams.GetType().GetProperties()) {
                list.Add(prop.GetValue(objectParams, null));
            }
            Params = list;
        }


        public SuiRpcData(string method)
        {
            Method = method;
            Params = new List<object>();
        }
    }
}
