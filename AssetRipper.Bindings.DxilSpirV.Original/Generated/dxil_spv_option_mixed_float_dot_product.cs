using System.Runtime.CompilerServices;

namespace AssetRipper.Bindings.DxilSpirV;

public partial struct dxil_spv_option_mixed_float_dot_product
{
    public dxil_spv_option_base @base;

    [NativeTypeName("dxil_spv_bool")]
    public byte fp16_fp16_fp32;

    [NativeTypeName("dxil_spv_bool[4]")]
    public _reserved_e__FixedBuffer reserved;

    [InlineArray(4)]
    public partial struct _reserved_e__FixedBuffer
    {
        public byte e0;
    }
}
