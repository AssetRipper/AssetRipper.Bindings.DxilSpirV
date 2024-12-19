namespace AssetRipper.Bindings.DxilSpirV;

public partial struct dxil_spv_option_subgroup_properties
{
    public dxil_spv_option_base @base;

    [NativeTypeName("unsigned int")]
    public uint minimum_size;

    [NativeTypeName("unsigned int")]
    public uint maximum_size;
}
