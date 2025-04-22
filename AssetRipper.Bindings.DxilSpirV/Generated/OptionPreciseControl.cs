namespace AssetRipper.Bindings.DxilSpirV;

public partial struct OptionPreciseControl
{
    [NativeTypeName("dxil_spv_option_base")]
    public OptionBase Base;

    [NativeTypeName("dxil_spv_bool")]
    public byte ForcePrecise;

    [NativeTypeName("dxil_spv_bool")]
    public byte PropagatePrecise;
}
