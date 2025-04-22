namespace AssetRipper.Bindings.DxilSpirV;

public unsafe partial struct dxil_spv_compiled_spirv
{
    [NativeTypeName("const void *")]
    public void* data;

    [NativeTypeName("size_t")]
    public nuint size;
}
