using System;
using System.Collections.Generic;
using System.Text;

namespace SuiNet.Interfaces
{
    /// <summary>
    /// Define a deserializer method for json, the library can support multiple json libraries
    /// </summary>
    public interface IJsonDeserializer
    {
        T Deserialize<T>(string json);

        /// <summary>
        /// Parse a JsonElement 
        /// </summary>
        T Parse<T>(object data);
    }
}
