using System;
using System.Collections.Generic;
using System.Text;

namespace SuiNet.Core.Interfaces
{
    /// <summary>
    /// Define serialisation method, so you can inject your own serialisation mechanism with newtonsoft or system json for example
    /// </summary>
    public interface IJsonSerializer
    {
        void Serialize<T>();
        T Deserialize<T>(string json);
    }
}
