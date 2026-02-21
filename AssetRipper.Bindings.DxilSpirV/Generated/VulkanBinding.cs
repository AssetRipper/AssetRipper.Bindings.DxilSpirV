using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AssetRipper.Bindings.DxilSpirV;

public partial struct VulkanBinding
{
    [NativeTypeName("unsigned int")]
    public uint Set;

    [NativeTypeName("unsigned int")]
    public uint Binding;

    [NativeTypeName("__AnonymousRecord_dxil_spirv_c_L294_C2")]
    public _Anonymous_e__Union Anonymous;

    [NativeTypeName("__AnonymousRecord_dxil_spirv_c_L306_C2")]
    public _Bindless_e__Struct Bindless;

    [NativeTypeName("dxil_spv_vulkan_descriptor_type")]
    public VulkanDescriptorType DescriptorType;

    [UnscopedRef]
    public ref uint RootConstantIndex
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.RootConstantIndex;
        }
    }

    [UnscopedRef]
    public ref uint InputAttachmentIndex
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.InputAttachmentIndex;
        }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("unsigned int")]
        public uint RootConstantIndex;

        [FieldOffset(0)]
        [NativeTypeName("unsigned int")]
        public uint InputAttachmentIndex;
    }

    public partial struct _Bindless_e__Struct
    {
        [NativeTypeName("unsigned int")]
        public uint HeapRootOffset;

        [NativeTypeName("dxil_spv_bool")]
        public byte UseHeap;
    }
}
