namespace AssetRipper.Bindings.DxilSpirV;

public partial struct dxil_spv_option_branch_control
{
    public dxil_spv_option_base @base;

    [NativeTypeName("dxil_spv_bool")]
    public byte use_shader_metadata;

    [NativeTypeName("dxil_spv_bool")]
    public byte force_unroll;

    [NativeTypeName("dxil_spv_bool")]
    public byte force_loop;

    [NativeTypeName("dxil_spv_bool")]
    public byte force_flatten;

    [NativeTypeName("dxil_spv_bool")]
    public byte force_branch;
}
