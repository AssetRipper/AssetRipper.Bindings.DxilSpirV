namespace AssetRipper.Bindings.DxilSpirV;

public partial struct dxil_spv_option_force_subgroup_size
{
    public dxil_spv_option_base @base;

    [NativeTypeName("unsigned int")]
    public uint forced_value;

    [NativeTypeName("dxil_spv_bool")]
    public byte wave_size_enable;
}
