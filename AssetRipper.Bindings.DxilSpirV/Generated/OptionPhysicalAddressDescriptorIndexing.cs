namespace AssetRipper.Bindings.DxilSpirV;

public partial struct OptionPhysicalAddressDescriptorIndexing
{
    [NativeTypeName("dxil_spv_option_base")]
    public OptionBase Base;

    [NativeTypeName("unsigned int")]
    public uint ElementStride;

    [NativeTypeName("unsigned int")]
    public uint ElementOffset;
}
