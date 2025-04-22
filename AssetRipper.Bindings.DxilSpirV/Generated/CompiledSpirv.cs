namespace AssetRipper.Bindings.DxilSpirV;

public unsafe partial struct CompiledSpirv
{
    [NativeTypeName("const void *")]
    public void* Data;

    [NativeTypeName("size_t")]
    public nuint Size;
}
