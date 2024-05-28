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
}
