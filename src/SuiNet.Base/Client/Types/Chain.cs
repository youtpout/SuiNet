//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace SuiNet.Base.Client.Types
//{
//    // Copyright (c) Mysten Labs, Inc.
//    // SPDX-License-Identifier: Apache-2.0

//    using System.Collections.Generic;

//    public class ResolvedNameServiceNames
//    {
//        public List<string> data { get; set; }
//        public bool hasNextPage { get; set; }
//        public string? nextCursor { get; set; }
//    }

//    public class SuiValidatorSummary
//    {
//        // Properties of SuiValidatorSummary
//    }

//    public class EpochInfo
//    {
//        public string epoch { get; set; }
//        public List<SuiValidatorSummary> validators { get; set; }
//        public string epochTotalTransactions { get; set; }
//        public string firstCheckpointId { get; set; }
//        public string epochStartTimestamp { get; set; }
//        public EndOfEpochInfo? endOfEpochInfo { get; set; }
//        public int? referenceGasPrice { get; set; }
//    }

//    public class EpochMetrics
//    {
//        public string epoch { get; set; }
//        public string epochTotalTransactions { get; set; }
//        public string firstCheckpointId { get; set; }
//        public string epochStartTimestamp { get; set; }
//        public EndOfEpochInfo? endOfEpochInfo { get; set; }
//    }

//    public class EpochPage
//    {
//        public List<EpochInfo> data { get; set; }
//        public string? nextCursor { get; set; }
//        public bool hasNextPage { get; set; }
//    }

//    public class EpochMetricsPage
//    {
//        public List<EpochMetrics> data { get; set; }
//        public string? nextCursor { get; set; }
//        public bool hasNextPage { get; set; }
//    }

//    public class EndOfEpochInfo
//    {
//        public string lastCheckpointId { get; set; }
//        public string epochEndTimestamp { get; set; }
//        public string protocolVersion { get; set; }
//        public string referenceGasPrice { get; set; }
//        public string totalStake { get; set; }
//        public string storageFundReinvestment { get; set; }
//        public string storageCharge { get; set; }
//        public string storageRebate { get; set; }
//        public string storageFundBalance { get; set; }
//        public string stakeSubsidyAmount { get; set; }
//        public string totalGasFees { get; set; }
//        public string totalStakeRewardsDistributed { get; set; }
//        public string leftoverStorageFundInflow { get; set; }
//    }

//    public class CheckpointPage
//    {
//        public List<Checkpoint> data { get; set; }
//        public string? nextCursor { get; set; }
//        public bool hasNextPage { get; set; }
//    }

//    public class Checkpoint
//    {
//        // Properties of Checkpoint
//    }

//    public class NetworkMetrics
//    {
//        public int currentTps { get; set; }
//        public int tps30Days { get; set; }
//        public string currentCheckpoint { get; set; }
//        public string currentEpoch { get; set; }
//        public string totalAddresses { get; set; }
//        public string totalObjects { get; set; }
//        public string totalPackages { get; set; }
//    }

//    public class AddressMetrics
//    {
//        public int checkpoint { get; set; }
//        public int epoch { get; set; }
//        public long timestampMs { get; set; }
//        public int cumulativeAddresses { get; set; }
//        public int cumulativeActiveAddresses { get; set; }
//        public int dailyActiveAddresses { get; set; }
//    }

//    public class AllEpochsAddressMetrics : List<AddressMetrics>
//    {
//    }

//    public class MoveCallMetric
//    {
//        public string module { get; set; }
//        public string package { get; set; }
//        public string function { get; set; }
//        public string rank { get; set; }
//    }

//    public class MoveCallMetrics
//    {
//        public List<MoveCallMetric> rank3Days { get; set; }
//        public List<MoveCallMetric> rank7Days { get; set; }
//        public List<MoveCallMetric> rank30Days { get; set; }
//    }

//    public class DynamicFieldPage
//    {
//        public List<DynamicFieldInfo> data { get; set; }
//        public string? nextCursor { get; set; }
//        public bool hasNextPage { get; set; }
//    }

//    public class DynamicFieldInfo
//    {
//        // Properties of DynamicFieldInfo
//    }

//    public class SuiMoveNormalizedModule
//    {
//        // Properties of SuiMoveNormalizedModule
//    }

//    public class SuiMoveObject
//    {
//        public string dataType { get; set; }
//        // Other properties of SuiMoveObject
//    }

//    public class SuiMovePackage
//    {
//        public string dataType { get; set; }
//        // Other properties of SuiMovePackage
//    }

//    public class SuiTransaction
//    {
//        // Properties of SuiTransaction
//    }

//    public class SuiCallArg
//    {
//        // Properties of SuiCallArg
//    }

//    public class ProgrammableTransaction
//    {
//        public List<SuiTransaction> transactions { get; set; }
//        public List<SuiCallArg> inputs { get; set; }
//    }


//}
