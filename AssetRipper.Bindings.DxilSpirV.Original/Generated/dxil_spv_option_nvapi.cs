namespace AssetRipper.Bindings.DxilSpirV;

public partial struct dxil_spv_option_nvapi
{
    public dxil_spv_option_base @base;

    [NativeTypeName("dxil_spv_bool")]
    public byte enabled;

    [NativeTypeName("unsigned int")]
    public uint register_index;

    [NativeTypeName("unsigned int")]
    public uint register_space;
}
