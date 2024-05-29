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

    public class CoinBalance
    {
        public string CoinType { get; set; }
        public int CoinObjectCount { get; set; }
        public string TotalBalance { get; set; }
        public Dictionary<string, string> LockedBalance { get; set; }
    }

    public class CoinMetadata
    {
        public int Decimals { get; set; }
        public string Description { get; set; }
        public string IconUrl { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public string Symbol { get; set; }
    }

    public class CoinSupply
    {
        public string Value { get; set; }
    }
}