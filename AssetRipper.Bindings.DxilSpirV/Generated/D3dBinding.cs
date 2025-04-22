namespace AssetRipper.Bindings.DxilSpirV;

public partial struct D3dBinding
{
    [NativeTypeName("dxil_spv_shader_stage")]
    public ShaderStage Stage;

    [NativeTypeName("dxil_spv_resource_kind")]
    public ResourceKind Kind;

    [NativeTypeName("unsigned int")]
    public uint ResourceIndex;

    [NativeTypeName("unsigned int")]
    public uint RegisterSpace;

    [NativeTypeName("unsigned int")]
    public uint RegisterIndex;

    [NativeTypeName("unsigned int")]
    public uint RangeSize;

    [NativeTypeName("unsigned int")]
    public uint Alignment;
}
