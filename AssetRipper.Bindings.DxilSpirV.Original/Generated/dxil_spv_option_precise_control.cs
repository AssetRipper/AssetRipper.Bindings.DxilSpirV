namespace AssetRipper.Bindings.DxilSpirV;

public partial struct dxil_spv_option_precise_control
{
    public dxil_spv_option_base @base;

    [NativeTypeName("dxil_spv_bool")]
    public byte force_precise;

    [NativeTypeName("dxil_spv_bool")]
    public byte propagate_precise;
}
