namespace AssetRipper.Bindings.DxilSpirV;

public unsafe partial struct D3dVertexInput
{
    [NativeTypeName("const char *")]
    public sbyte* Semantic;

    [NativeTypeName("unsigned int")]
    public uint SemanticIndex;

    [NativeTypeName("unsigned int")]
    public uint StartRow;

    [NativeTypeName("unsigned int")]
    public uint Rows;
}
