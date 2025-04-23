using AssetRipper.Bindings.DxilSpirV.Extensions;
using System;
using System.Diagnostics;

namespace AssetRipper.Bindings.DxilSpirV;

public readonly unsafe struct DxilBlob : IDisposable
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public ParsedBlob* Pointer { get; }
	public bool IsNull => Pointer == null;
	public ShaderStage ShaderStage
	{
		get
		{
			ThrowIfNull();
			return NativeMethods.ParsedBlobGetShaderStage(Pointer);
		}
	}
	public uint NumRdatSubobjects
	{
		get
		{
			ThrowIfNull();
			return NativeMethods.ParsedBlobGetNumRdatSubobjects(Pointer);
		}
	}
	public uint NumEntryPoints
	{
		get
		{
			ThrowIfNull();
			uint result = default;
			NativeMethods.ParsedBlobGetNumEntryPoints(Pointer, &result).ThrowIfFailed();
			return result;
		}
	}
	public string? EntryPointName
	{
		get
		{
			return NumEntryPoints is 1 ? GetEntryPointName(0) : null;
		}
	}
	public string? EntryPointDemangledName
	{
		get
		{
			return NumEntryPoints is 1 ? GetEntryPointDemangledName(0) : null;
		}
	}

	public DxilBlob(ParsedBlob* pointer)
	{
		Pointer = pointer;
	}

	public string GetEntryPointName(uint index)
	{
		ThrowIfNull();
		if (index >= NumEntryPoints)
		{
			throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range.");
		}
		sbyte* name = null;
		NativeMethods.ParsedBlobGetEntryPointName(Pointer, index, &name).ThrowIfFailed();
		return NativeString.ToString(name);
	}

	public string GetEntryPointDemangledName(uint index)
	{
		ThrowIfNull();
		if (index >= NumEntryPoints)
		{
			throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range.");
		}
		sbyte* name = null;
		NativeMethods.ParsedBlobGetEntryPointName(Pointer, index, &name).ThrowIfFailed();
		return NativeString.ToString(name);
	}

	public DxilConverter CreateConverter()
	{
		ThrowIfNull();
		Converter* converter = null;
		NativeMethods.CreateConverter(Pointer, &converter).ThrowIfFailed();
		return new DxilConverter(converter);
	}

	private void ThrowIfNull()
	{
		if (IsNull)
		{
			throw new InvalidOperationException("ParsedBlob pointer is null.");
		}
	}

	public void Free()
	{
		if (!IsNull)
		{
			NativeMethods.ParsedBlobFree(Pointer);
		}
	}

	void IDisposable.Dispose() => Free();
}
