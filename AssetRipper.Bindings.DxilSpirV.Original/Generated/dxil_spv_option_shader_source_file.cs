namespace AssetRipper.Bindings.DxilSpirV;

public unsafe partial struct dxil_spv_option_shader_source_file
{
    public dxil_spv_option_base @base;

    [NativeTypeName("const char *")]
    public sbyte* name;
}
