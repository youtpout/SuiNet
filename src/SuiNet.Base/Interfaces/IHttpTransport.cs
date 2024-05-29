using SuiNet.Client;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SuiNet.Interfaces
{
    /// <summary>
    /// Define transport method, so you can inject your own transport mechanism, usefull to use custom transport on unity or other special engine
    public interface IHttpTransport: IJsonDeserializer
    {
        Task<T> Send<T>(SuiRpcData data) where T : new();
        Task Send(SuiRpcData data);
    }
}
