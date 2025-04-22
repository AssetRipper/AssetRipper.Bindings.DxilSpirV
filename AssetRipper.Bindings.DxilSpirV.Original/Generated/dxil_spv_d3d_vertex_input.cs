namespace AssetRipper.Bindings.DxilSpirV;

public unsafe partial struct dxil_spv_d3d_vertex_input
{
    [NativeTypeName("const char *")]
    public sbyte* semantic;

    [NativeTypeName("unsigned int")]
    public uint semantic_index;

    [NativeTypeName("unsigned int")]
    public uint start_row;

    [NativeTypeName("unsigned int")]
    public uint rows;
}
