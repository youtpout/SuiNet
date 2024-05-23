using System;
using System.Collections.Generic;
using System.Text;

namespace SuiNet.Base.Client.Types
{
    public class Balance
    {
        public int Coinobjectcount { get; set; }
        public string Cointype { get; set; }
        public string Lockedbalance { get; set; }
    }

    public class BalanceChange
    {
        public string Amount { get; set; }
        public string Cointype { get; set; }
        public ObjectOwner Owner { get; set; }
    }

    public class Checkpoint
    {
        public List<CheckpointCommitment> Checkpointcommitments { get; set; }
        public string Digest { get; set; }
        public string Epoch { get; set; }
        public GasCostSummary Epochrollinggascostsummary { get; set; }
        public string Networktotaltransactions { get; set; }
        public string Sequencenumber { get; set; }
        public string Timestampms { get; set; }
        public string Transactions { get; set; }
        public string Validatorsignature { get; set; }
    }

    public class Claim
    {
        public int Indexmod4 { get; set; }
        public string Value { get; set; }
    }

    public class CoinStruct
    {
        public string Balance { get; set; }
        public string Coinobjectid { get; set; }
        public string Cointype { get; set; }
        public string Digest { get; set; }
        public string Previoustransaction { get; set; }
        public string Version { get; set; }
    }

    public class CommitteeInfo
    {
        public string Epoch { get; set; }
        public string Validators { get; set; }
    }

    public class DelegatedStake
    {
        public List<StakeObject> Stakes { get; set; }
        public string Stakingpool { get; set; }
        public string Validatoraddress { get; set; }
    }

    public class DevInspectResults
    {
        public TransactionEffects Effects { get; set; }
        public List<SuiEvent> Events { get; set; }
    }

    public class DisplayFieldsResponse
    {
    }

    public class DryRunTransactionBlockResponse
    {
        public List<BalanceChange> Balancechanges { get; set; }
        public TransactionEffects Effects { get; set; }
        public List<SuiEvent> Events { get; set; }
        public TransactionBlockData Input { get; set; }
        public List<SuiObjectChange> Objectchanges { get; set; }
    }

    public class DynamicFieldInfo
    {
        public string Bcsname { get; set; }
        public string Digest { get; set; }
        public DynamicFieldName Name { get; set; }
        public string Objectid { get; set; }
        public string Objecttype { get; set; }
        public DynamicFieldType Type { get; set; }
        public string Version { get; set; }
    }

    public class DynamicFieldName
    {
        public string Type { get; set; }
        public unknown Value { get; set; }
    }

    public class ECMHLiveObjectSetDigest
    {
        public int Digest { get; set; }
    }

    public class EndOfEpochData
    {
        public List<CheckpointCommitment> Epochcommitments { get; set; }
        public string Nextepochcommittee { get; set; }
        public string Nextepochprotocolversion { get; set; }
    }

    public class SuiEvent
    {
        public string Bcs { get; set; }
        public EventId Id { get; set; }
        public string Packageid { get; set; }
        public unknown Parsedjson { get; set; }
        public string Sender { get; set; }
        public string Transactionmodule { get; set; }
        public string Type { get; set; }
    }

    public class EventId
    {
        public string Eventseq { get; set; }
        public string Txdigest { get; set; }
    }

    public class GasCostSummary
    {
        public string Computationcost { get; set; }
        public string Nonrefundablestoragefee { get; set; }
        public string Storagecost { get; set; }
        public string Storagerebate { get; set; }
    }

    public class SuiGasData
    {
        public string Budget { get; set; }
        public string Owner { get; set; }
        public List<SuiObjectRef> Payment { get; set; }
        public string Price { get; set; }
    }

    public class GetPastObjectRequest
    {
        public string Objectid { get; set; }
        public string Version { get; set; }
    }

    public class LoadedChildObject
    {
        public string Objectid { get; set; }
        public string Sequencenumber { get; set; }
    }

    public class LoadedChildObjectsResponse
    {
        public List<LoadedChildObject> Loadedchildobjects { get; set; }
    }

    public class MoveCallParams
    {
        public List<unknown> Arguments { get; set; }
        public string Function { get; set; }
        public string Module { get; set; }
        public string Packageobjectid { get; set; }
    }

    public class MultiSig
    {
        public int Bitmap { get; set; }
        public MultiSigPublicKey Multisig_Pk { get; set; }
        public List<CompressedSignature> Sigs { get; set; }
    }

    public class MultiSigLegacy
    {
        public string Bitmap { get; set; }
        public MultiSigPublicKeyLegacy Multisig_Pk { get; set; }
        public List<CompressedSignature> Sigs { get; set; }
    }

    public class MultiSigPublicKey
    {
        public int Pk_Map { get; set; }
        public int Threshold { get; set; }
    }

    public class MultiSigPublicKeyLegacy
    {
        public int Pk_Map { get; set; }
        public int Threshold { get; set; }
    }

    public class SuiObjectData
    {
        public string Digest { get; set; }
        public string Objectid { get; set; }
        public string Version { get; set; }
    }

    public class SuiObjectDataOptions
    {
    }

    public class SuiObjectRef
    {
        public string Digest { get; set; }
        public string Objectid { get; set; }
        public string Version { get; set; }
    }

    public class SuiObjectResponseQuery
    {
    }

    public class OwnedObjectRef
    {
        public ObjectOwner Owner { get; set; }
        public SuiObjectRef Reference { get; set; }
    }

    public class PaginatedCheckpoints
    {
        public List<Checkpoint> Data { get; set; }
        public bool Hasnextpage { get; set; }
    }

    public class PaginatedCoins
    {
        public List<CoinStruct> Data { get; set; }
        public bool Hasnextpage { get; set; }
    }

    public class PaginatedDynamicFieldInfos
    {
        public List<DynamicFieldInfo> Data { get; set; }
        public bool Hasnextpage { get; set; }
    }

    public class PaginatedEvents
    {
        public List<SuiEvent> Data { get; set; }
        public bool Hasnextpage { get; set; }
    }

    public class PaginatedStrings
    {
        public string Data { get; set; }
        public bool Hasnextpage { get; set; }
    }

    public class PaginatedObjectsResponse
    {
        public List<SuiObjectResponse> Data { get; set; }
        public bool Hasnextpage { get; set; }
    }

    public class PaginatedTransactionResponse
    {
        public List<SuiTransactionBlockResponse> Data { get; set; }
        public bool Hasnextpage { get; set; }
    }

    public class ProtocolConfig
    {
        public string Attributes { get; set; }
    }

    public class SuiActiveJwk
    {
        public string Epoch { get; set; }
        public SuiJWK Jwk { get; set; }
        public SuiJwkId Jwk_Id { get; set; }
    }

    public class SuiAuthenticatorStateExpire
    {
        public string Min_Epoch { get; set; }
    }

    public class SuiChangeEpoch
    {
        public string Computation_Charge { get; set; }
        public string Epoch { get; set; }
        public string Epoch_Start_Timestamp_Ms { get; set; }
        public string Storage_Charge { get; set; }
        public string Storage_Rebate { get; set; }
    }

    public class CoinMetadata
    {
        public int Decimals { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public string Symbol { get; set; }
    }

    public class SuiExecutionResult
    {
    }

    public class SuiJWK
    {
        public string Alg { get; set; }
        public string E { get; set; }
        public string Kty { get; set; }
        public string N { get; set; }
    }

    public class SuiJwkId
    {
        public string Iss { get; set; }
        public string Kid { get; set; }
    }

    public class SuiMoveAbilitySet
    {
        public List<SuiMoveAbility> Abilities { get; set; }
    }

    public class SuiMoveModuleId
    {
        public string Address { get; set; }
        public string Name { get; set; }
    }

    public class SuiMoveNormalizedField
    {
        public string Name { get; set; }
        public SuiMoveNormalizedType Type { get; set; }
    }

    public class SuiMoveNormalizedFunction
    {
        public bool Isentry { get; set; }
        public List<SuiMoveNormalizedType> Parameters { get; set; }
        public List<SuiMoveNormalizedType> Return { get; set; }
        public List<SuiMoveAbilitySet> Typeparameters { get; set; }
        public SuiMoveVisibility Visibility { get; set; }
    }

    public class SuiMoveNormalizedModule
    {
        public string Address { get; set; }
        public string Exposedfunctions { get; set; }
    }

    public class SuiMoveNormalizedStruct
    {
        public SuiMoveAbilitySet Abilities { get; set; }
        public List<SuiMoveNormalizedField> Fields { get; set; }
        public List<SuiMoveStructTypeParameter> Typeparameters { get; set; }
    }

    public class SuiMoveStructTypeParameter
    {
        public SuiMoveAbilitySet Constraints { get; set; }
        public bool Isphantom { get; set; }
    }

    public class SuiObjectResponse
    {
    }

    public class MoveCallSuiTransaction
    {
        public string Function { get; set; }
        public string Module { get; set; }
        public string Package { get; set; }
    }

    public class SuiSystemStateSummary
    {
        public List<SuiValidatorSummary> Activevalidators { get; set; }
        public string Atriskvalidators { get; set; }
        public string Epoch { get; set; }
        public string Epochdurationms { get; set; }
        public string Epochstarttimestampms { get; set; }
        public string Inactivepoolsid { get; set; }
        public string Inactivepoolssize { get; set; }
        public string Maxvalidatorcount { get; set; }
        public string Minvalidatorjoiningstake { get; set; }
        public string Pendingactivevalidatorsid { get; set; }
        public string Pendingactivevalidatorssize { get; set; }
        public string Pendingremovals { get; set; }
        public string Protocolversion { get; set; }
        public string Referencegasprice { get; set; }
        public bool Safemode { get; set; }
        public string Safemodecomputationrewards { get; set; }
        public string Safemodenonrefundablestoragefee { get; set; }
        public string Safemodestoragerebates { get; set; }
        public string Safemodestoragerewards { get; set; }
        public string Stakesubsidybalance { get; set; }
        public string Stakesubsidycurrentdistributionamount { get; set; }
        public int Stakesubsidydecreaserate { get; set; }
        public string Stakesubsidydistributioncounter { get; set; }
        public string Stakesubsidyperiodlength { get; set; }
        public string Stakesubsidystartepoch { get; set; }
        public string Stakingpoolmappingsid { get; set; }
        public string Stakingpoolmappingssize { get; set; }
        public string Storagefundnonrefundablebalance { get; set; }
        public string Storagefundtotalobjectstoragerebates { get; set; }
        public string Systemstateversion { get; set; }
        public string Totalstake { get; set; }
        public string Validatorcandidatesid { get; set; }
        public string Validatorcandidatessize { get; set; }
        public string Validatorlowstakegraceperiod { get; set; }
        public string Validatorlowstakethreshold { get; set; }
        public string Validatorreportrecords { get; set; }
        public string Validatorverylowstakethreshold { get; set; }
    }

    public class SuiValidatorSummary
    {
        public string Commissionrate { get; set; }
        public string Description { get; set; }
        public string Exchangeratesid { get; set; }
        public string Exchangeratessize { get; set; }
        public string Gasprice { get; set; }
        public string Imageurl { get; set; }
        public string Name { get; set; }
        public string Netaddress { get; set; }
        public string Networkpubkeybytes { get; set; }
        public string Nextepochcommissionrate { get; set; }
        public string Nextepochgasprice { get; set; }
        public string Nextepochstake { get; set; }
        public string Operationcapid { get; set; }
        public string P2paddress { get; set; }
        public string Pendingpooltokenwithdraw { get; set; }
        public string Pendingstake { get; set; }
        public string Pendingtotalsuiwithdraw { get; set; }
        public string Pooltokenbalance { get; set; }
        public string Primaryaddress { get; set; }
        public string Projecturl { get; set; }
        public string Proofofpossessionbytes { get; set; }
        public string Protocolpubkeybytes { get; set; }
        public string Rewardspool { get; set; }
    }

    public class CoinSupply
    {
        public string Value { get; set; }
    }

    public class SuiTransactionBlock
    {
        public TransactionBlockData Data { get; set; }
        public string Txsignatures { get; set; }
    }

    public class TransactionBlockBytes
    {
        public List<SuiObjectRef> Gas { get; set; }
        public List<InputObjectKind> Inputobjects { get; set; }
        public string Txbytes { get; set; }
    }

    public class TransactionBlockEffectsModifiedAtVersions
    {
        public string Objectid { get; set; }
        public string Sequencenumber { get; set; }
    }

    public class SuiTransactionBlockResponse
    {
        public string Digest { get; set; }
    }

    public class SuiTransactionBlockResponseOptions
    {
    }

    public class SuiTransactionBlockResponseQuery
    {
    }

    public class TransferObjectParams
    {
        public string Objectid { get; set; }
        public string Recipient { get; set; }
    }

    public class TypeOrigin
    {
        public string Module_Name { get; set; }
        public string Package { get; set; }
        public string Struct_Name { get; set; }
    }

    public class UpgradeInfo
    {
        public string Upgraded_Id { get; set; }
        public string Upgraded_Version { get; set; }
    }

    public class ValidatorApy
    {
        public string Address { get; set; }
        public int Apy { get; set; }
    }

    public class ValidatorsApy
    {
        public List<ValidatorApy> Apys { get; set; }
        public string Epoch { get; set; }
    }

    public class ZkLoginAuthenticator
    {
        public ZkLoginInputs Inputs { get; set; }
        public string Maxepoch { get; set; }
        public Signature Usersignature { get; set; }
    }

    public class ZkLoginInputs
    {
        public string Addressseed { get; set; }
        public string Headerbase64 { get; set; }
        public Claim Issbase64details { get; set; }
        public ZkLoginProof Proofpoints { get; set; }
    }

    public class ZkLoginProof
    {
        public string A { get; set; }
        public string B { get; set; }
        public string C { get; set; }
    }


}
