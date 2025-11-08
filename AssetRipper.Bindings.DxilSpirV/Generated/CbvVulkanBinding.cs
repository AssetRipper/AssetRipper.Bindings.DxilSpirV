using System.Runtime.InteropServices;

namespace AssetRipper.Bindings.DxilSpirV;

public partial struct CbvVulkanBinding
{
    [NativeTypeName("__AnonymousRecord_dxil_spirv_c_L329_C2")]
    public _Vulkan_e__Union Vulkan;

    [NativeTypeName("dxil_spv_bool")]
    public byte PushConstant;

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Vulkan_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("dxil_spv_vulkan_binding")]
        public VulkanBinding UniformBinding;

        [FieldOffset(0)]
        [NativeTypeName("dxil_spv_push_constant_mapping")]
        public PushConstantMapping PushConstant;
    }
}
