using System;
using System.Collections.Generic;
using System.Text;

namespace SuiNet.Base.Client.Types
{
    public class RpcResult<T> where T :new()
    {
        public string Jsonrpc { get; set; }
        public string Id { get; set; }
        public T Result { get; set; }
        public RpcError RpcError { get; set; }

        public RpcResult() { }
    }

    public class RpcError
    {
        public int Code { get; set; }
        public string Message { get; set; }
        public object Data { get; set; }
        public RpcError() { }
    }
}
