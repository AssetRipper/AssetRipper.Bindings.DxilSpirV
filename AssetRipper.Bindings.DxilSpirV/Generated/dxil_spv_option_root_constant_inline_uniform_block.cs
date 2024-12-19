namespace AssetRipper.Bindings.DxilSpirV;

public partial struct dxil_spv_option_root_constant_inline_uniform_block
{
    public dxil_spv_option_base @base;

    [NativeTypeName("unsigned int")]
    public uint desc_set;

    [NativeTypeName("unsigned int")]
    public uint binding;

    [NativeTypeName("dxil_spv_bool")]
    public byte enable;
}
