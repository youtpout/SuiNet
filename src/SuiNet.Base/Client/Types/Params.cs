﻿using System;
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

    public class GetMoveFunctionArgTypesParams
    {
        public string Package { get; set; }
        public string Module { get; set; }
        public string Function { get; set; }
    }

    public class GetNormalizedMoveModulesByPackageParams
    {
        public string Package { get; set; }
    }

    public class GetNormalizedMoveFunctionParams
    {
        public string Package { get; set; }
        public string Module { get; set; }
        public string Function { get; set; }
    }

    public class GetNormalizedMoveStructParams
    {
        public string Package { get; set; }
        public string Module { get; set; }
        public string Struct { get; set; }
    }

    public class GetOwnedObjectsParams
    {
        public string Owner { get; set; }
        public SuiObjectResponseQuery SuiObjectResponseQuery { get; set; }
        public string Cursor { get; set; }
        public int Limit { get; set; } = 50;
    }


}
