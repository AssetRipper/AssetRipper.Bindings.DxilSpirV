using System.Runtime.CompilerServices;

namespace AssetRipper.Bindings.DxilSpirV;

public partial struct OptionMixedFloatDotProduct
{
    [NativeTypeName("dxil_spv_option_base")]
    public OptionBase Base;

    [NativeTypeName("dxil_spv_bool")]
    public byte Fp16Fp16Fp32;

    [NativeTypeName("dxil_spv_bool[4]")]
    public _Reserved_e__FixedBuffer Reserved;

    [InlineArray(4)]
    public partial struct _Reserved_e__FixedBuffer
    {
        public byte e0;
    }
}
