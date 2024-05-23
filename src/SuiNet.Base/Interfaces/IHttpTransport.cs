using SuiNet.Base.Client;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SuiNet.Base.Interfaces
{
    /// <summary>
    /// Define transport method, so you can inject your own transport mechanism, usefull to use custom trasnport on unity or other special engine
    public interface IHttpTransport
    {
        Task<T> Send<T, SuiRpcData>(SuiRpcData data);
        Task Send<SuiRpcData>(SuiRpcData data);
    }
}
