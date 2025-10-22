namespace AssetRipper.Bindings.DxilSpirV;

public enum MetaDescriptorKind
{
    Invalid = 0,
    PushConstant,
    PushBda,
    UboContainingConstant,
    UboContainingBda,
    ReadonlySsbo,
    IntMax = 0x7fffffff,
}
