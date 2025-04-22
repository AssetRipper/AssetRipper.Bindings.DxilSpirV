namespace AssetRipper.Bindings.DxilSpirV;

public unsafe partial struct dxil_spv_option_output_swizzle
{
    public dxil_spv_option_base @base;

    [NativeTypeName("const unsigned int *")]
    public uint* swizzles;

    [NativeTypeName("unsigned int")]
    public uint swizzle_count;
}
