namespace AssetRipper.Bindings.DxilSpirV;

public unsafe partial struct dxil_spv_d3d_stream_output
{
    [NativeTypeName("const char *")]
    public sbyte* semantic;

    [NativeTypeName("unsigned int")]
    public uint semantic_index;
}
