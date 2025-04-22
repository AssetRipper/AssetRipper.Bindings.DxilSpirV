using System.Runtime.CompilerServices;

namespace AssetRipper.Bindings.DxilSpirV;

public unsafe partial struct RdatSubobject
{
    [NativeTypeName("dxil_spv_rdat_subobject_kind")]
    public RdatSubobjectKind Kind;

    [NativeTypeName("const char *")]
    public sbyte* SubobjectName;

    [NativeTypeName("dxil_spv_hit_group_type")]
    public HitGroupType HitGroupType;

    [NativeTypeName("const char *const *")]
    public sbyte** Exports;

    [NativeTypeName("unsigned int")]
    public uint NumExports;

    [NativeTypeName("unsigned int[2]")]
    public _Args_e__FixedBuffer Args;

    [NativeTypeName("const void *")]
    public void* Payload;

    [NativeTypeName("size_t")]
    public nuint PayloadSize;

    [InlineArray(2)]
    public partial struct _Args_e__FixedBuffer
    {
        public uint e0;
    }
}
