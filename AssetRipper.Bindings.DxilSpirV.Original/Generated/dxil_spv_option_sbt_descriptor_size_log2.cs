namespace AssetRipper.Bindings.DxilSpirV;

public partial struct dxil_spv_option_sbt_descriptor_size_log2
{
    public dxil_spv_option_base @base;

    [NativeTypeName("unsigned int")]
    public uint size_log2_srv_uav_cbv;

    [NativeTypeName("unsigned int")]
    public uint size_log2_sampler;
}
