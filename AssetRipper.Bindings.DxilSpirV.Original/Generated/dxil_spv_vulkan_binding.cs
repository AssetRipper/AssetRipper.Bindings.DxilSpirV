using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AssetRipper.Bindings.DxilSpirV;

public partial struct dxil_spv_vulkan_binding
{
    [NativeTypeName("unsigned int")]
    public uint set;

    [NativeTypeName("unsigned int")]
    public uint binding;

    [NativeTypeName("__AnonymousRecord_dxil_spirv_c_L294_C2")]
    public _Anonymous_e__Union Anonymous;

    [NativeTypeName("__AnonymousRecord_dxil_spirv_c_L306_C2")]
    public _bindless_e__Struct bindless;

    public dxil_spv_vulkan_descriptor_type descriptor_type;

    [UnscopedRef]
    public ref uint root_constant_index
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.root_constant_index;
        }
    }

    [UnscopedRef]
    public ref uint input_attachment_index
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.input_attachment_index;
        }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("unsigned int")]
        public uint root_constant_index;

        [FieldOffset(0)]
        [NativeTypeName("unsigned int")]
        public uint input_attachment_index;
    }

    public partial struct _bindless_e__Struct
    {
        [NativeTypeName("unsigned int")]
        public uint heap_root_offset;

        [NativeTypeName("dxil_spv_bool")]
        public byte use_heap;
    }
}
