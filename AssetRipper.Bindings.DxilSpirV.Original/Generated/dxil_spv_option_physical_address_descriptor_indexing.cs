namespace AssetRipper.Bindings.DxilSpirV;

public partial struct dxil_spv_option_physical_address_descriptor_indexing
{
    public dxil_spv_option_base @base;

    [NativeTypeName("unsigned int")]
    public uint element_stride;

    [NativeTypeName("unsigned int")]
    public uint element_offset;
}
