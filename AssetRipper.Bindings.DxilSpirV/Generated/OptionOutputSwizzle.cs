namespace AssetRipper.Bindings.DxilSpirV;

public unsafe partial struct OptionOutputSwizzle
{
    [NativeTypeName("dxil_spv_option_base")]
    public OptionBase Base;

    [NativeTypeName("const unsigned int *")]
    public uint* Swizzles;

    [NativeTypeName("unsigned int")]
    public uint SwizzleCount;
}
