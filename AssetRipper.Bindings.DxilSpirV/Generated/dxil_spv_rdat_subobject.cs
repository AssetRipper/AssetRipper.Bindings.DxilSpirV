using System.Runtime.CompilerServices;

namespace AssetRipper.Bindings.DxilSpirV;

public unsafe partial struct dxil_spv_rdat_subobject
{
    public dxil_spv_rdat_subobject_kind kind;

    [NativeTypeName("const char *")]
    public sbyte* subobject_name;

    public dxil_spv_hit_group_type hit_group_type;

    [NativeTypeName("const char *const *")]
    public sbyte** exports;

    [NativeTypeName("unsigned int")]
    public uint num_exports;

    [NativeTypeName("unsigned int[2]")]
    public _args_e__FixedBuffer args;

    [NativeTypeName("const void *")]
    public void* payload;

    [NativeTypeName("size_t")]
    public nuint payload_size;

    [InlineArray(2)]
    public partial struct _args_e__FixedBuffer
    {
        public uint e0;
    }
}
