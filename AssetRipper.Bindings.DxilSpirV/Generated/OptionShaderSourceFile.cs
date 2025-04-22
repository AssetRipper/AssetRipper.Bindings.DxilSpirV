namespace AssetRipper.Bindings.DxilSpirV;

public unsafe partial struct OptionShaderSourceFile
{
    [NativeTypeName("dxil_spv_option_base")]
    public OptionBase Base;

    [NativeTypeName("const char *")]
    public sbyte* Name;
}
