namespace AssetRipper.Bindings.DxilSpirV;

public partial struct OptionBindlessOffsetBufferLayout
{
    [NativeTypeName("dxil_spv_option_base")]
    public OptionBase Base;

    [NativeTypeName("unsigned int")]
    public uint UntypedOffset;

    [NativeTypeName("unsigned int")]
    public uint TypedOffset;

    [NativeTypeName("unsigned int")]
    public uint Stride;
}
