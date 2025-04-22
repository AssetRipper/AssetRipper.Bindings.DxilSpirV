namespace AssetRipper.Bindings.DxilSpirV;

public unsafe partial struct D3dStreamOutput
{
    [NativeTypeName("const char *")]
    public sbyte* Semantic;

    [NativeTypeName("unsigned int")]
    public uint SemanticIndex;
}
