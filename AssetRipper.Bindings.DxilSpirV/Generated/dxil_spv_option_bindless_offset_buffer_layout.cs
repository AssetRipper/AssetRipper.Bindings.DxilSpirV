namespace AssetRipper.Bindings.DxilSpirV;

public partial struct dxil_spv_option_bindless_offset_buffer_layout
{
    public dxil_spv_option_base @base;

    [NativeTypeName("unsigned int")]
    public uint untyped_offset;

    [NativeTypeName("unsigned int")]
    public uint typed_offset;

    [NativeTypeName("unsigned int")]
    public uint stride;
}
