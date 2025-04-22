namespace AssetRipper.Bindings.DxilSpirV;

public partial struct OptionSubgroupProperties
{
    [NativeTypeName("dxil_spv_option_base")]
    public OptionBase Base;

    [NativeTypeName("unsigned int")]
    public uint MinimumSize;

    [NativeTypeName("unsigned int")]
    public uint MaximumSize;
}
