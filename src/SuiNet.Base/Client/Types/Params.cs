using System;
using System.Collections.Generic;
using System.Text;

namespace SuiNet.Client.Types
{
    public class GetCoinsParams
    {
        public string Owner { get; set; }
        public string CoinType { get; set; }
        public string Cursor { get; set; }
        public int Limit { get; set; }
    }

    public class GetAllCoinsParams
    {
        public string Owner { get; set; }
        public string Cursor { get; set; }
        public int Limit { get; set; }
    }

    public class GetBalanceParams
    {
        public string Owner { get; set; }
        public string CoinType { get; set; }
    }

    public class GetAllBalancesParams
    {
        public string Owner { get; set; }
    }

    public class GetCoinMetadataParams
    {
        public string CoinType { get; set; }
    }

    public class GetTotalSupplyParams
    {
        public string CoinType { get; set; }
    }
}
