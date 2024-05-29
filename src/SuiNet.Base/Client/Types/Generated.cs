using SuiNet.Client.Types;
using System.Collections.Generic;

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

    public enum ObjectValueKind
    {
        Pure,
        ByImmutableReference,
        ByMutableReference,
        ByValue
    }

    public class SuiMoveFunctionArgTypeJson
    {
        /// <summary>
        /// Possible value ByImmutableReference, ByMutableReference, ByValue
        /// </summary>
        public string Object { get; set; }
    }

    public class SuiMoveFunctionArgType
    {
        public ObjectValueKind Object { get; set; }
    }

    #region SuiMoveNormalizedModules

    public class SuiMoveNormalizedModules:Dictionary<string, SuiMoveNormalizedModule>
    {

    }

    public class SuiMoveNormalizedModule
    {
        public int FileFormatVersion { get; set; }
        public string Address { get; set; }
        public string Name { get; set; }
        public List<object> Friends { get; set; }
        public Dictionary<string, object> Structs { get; set; }
        public Dictionary<string,object> ExposedFunctions { get; set; }
    }

    public class SuiMoveNormalizedFunction
    {
        public bool IsEntry { get; set; }
        public List<SuiMoveNormalizedType> Parameters { get; set; }
        public List<SuiMoveNormalizedType> Return { get; set; }
        public List<SuiMoveAbilitySet> TypeParameters { get; set; }
        public string Visibility { get; set; }
    }

    public class SuiMoveAbilitySet
    {
        public List<string> Abilities { get; set; }
    }

    public class SuiReference
    {
        public SuiStruct Struct { get; set; }
    }


    public class SuiMoveNormalizedType
    {
        public SuiReference Reference { get; set; }
    }

    public class SuiStruct
    {
        public string Address { get; set; }
        public string Module { get; set; }
        public string Name { get; set; }
        public List<SuiMoveNormalizedType> TypeArguments { get; set; }
    }

    #endregion
}