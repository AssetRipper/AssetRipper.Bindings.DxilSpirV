using System.Runtime.InteropServices;

namespace AssetRipper.Bindings.DxilSpirV;

public partial struct dxil_spv_cbv_vulkan_binding
{
    [NativeTypeName("__AnonymousRecord_dxil_spirv_c_L327_C2")]
    public _vulkan_e__Union vulkan;

    [NativeTypeName("dxil_spv_bool")]
    public byte push_constant;

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _vulkan_e__Union
    {
        [FieldOffset(0)]
        public dxil_spv_vulkan_binding uniform_binding;

        [FieldOffset(0)]
        public dxil_spv_push_constant_mapping push_constant;
    }
}
