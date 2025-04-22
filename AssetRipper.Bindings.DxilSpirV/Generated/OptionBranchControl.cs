namespace AssetRipper.Bindings.DxilSpirV;

public partial struct OptionBranchControl
{
    [NativeTypeName("dxil_spv_option_base")]
    public OptionBase Base;

    [NativeTypeName("dxil_spv_bool")]
    public byte UseShaderMetadata;

    [NativeTypeName("dxil_spv_bool")]
    public byte ForceUnroll;

    [NativeTypeName("dxil_spv_bool")]
    public byte ForceLoop;

    [NativeTypeName("dxil_spv_bool")]
    public byte ForceFlatten;

    [NativeTypeName("dxil_spv_bool")]
    public byte ForceBranch;
}
