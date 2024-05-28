using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuiNet.Client.Types
{
    public class CoinStruct
    {
        public string Balance { get; set; }
        public string CoinObjectId { get; set; }
        public string CoinType { get; set; }
        public string Digest { get; set; }
        public string PreviousTransaction { get; set; }
        public string Version { get; set; }
    }


    public class PaginatedCoins
    {
        public List<CoinStruct> Data { get; set; }
        public bool HasNextPage { get; set; }
        public string NextCursor { get; set; }
    }
}