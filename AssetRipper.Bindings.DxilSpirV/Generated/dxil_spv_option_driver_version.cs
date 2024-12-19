namespace AssetRipper.Bindings.DxilSpirV;

public partial struct dxil_spv_option_driver_version
{
    public dxil_spv_option_base @base;

    [NativeTypeName("unsigned int")]
    public uint driver_id;

    [NativeTypeName("unsigned int")]
    public uint driver_version;
}
