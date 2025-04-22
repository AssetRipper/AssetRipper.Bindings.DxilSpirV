namespace AssetRipper.Bindings.DxilSpirV;

public partial struct OptionShaderQuirk
{
    [NativeTypeName("dxil_spv_option_base")]
    public OptionBase Base;

    [NativeTypeName("dxil_spv_shader_quirk")]
    public ShaderQuirk Quirk;
}
