namespace AssetRipper.Bindings.DxilSpirV;

public partial struct OptionRootConstantInlineUniformBlock
{
    [NativeTypeName("dxil_spv_option_base")]
    public OptionBase Base;

    [NativeTypeName("unsigned int")]
    public uint DescSet;

    [NativeTypeName("unsigned int")]
    public uint Binding;

    [NativeTypeName("dxil_spv_bool")]
    public byte Enable;
}
