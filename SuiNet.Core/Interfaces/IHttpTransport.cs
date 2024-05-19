using System;
using System.Collections.Generic;
using System.Text;

namespace SuiNet.Core.Interfaces
{
    /// <summary>
    /// Define transport method, so you can inject your own transport mechanism, usefull to use custom trasnport on unity or other special engine
    public interface IHttpTransport
    {
        T Send<T,U>(U data);
        T Receive<T,U>(U data);
    }
}
