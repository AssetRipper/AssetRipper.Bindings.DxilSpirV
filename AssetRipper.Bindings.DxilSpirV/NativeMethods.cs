using AssetRipper.Bindings.DxilSpirV.Extensions;
using System;

namespace AssetRipper.Bindings.DxilSpirV;

public static unsafe partial class NativeMethods
{
	static NativeMethods()
	{
		SetThreadLogCallback((delegate* unmanaged[Cdecl]<void*, LogLevel, sbyte*, void>)&Logger.LogMessage, null);
	}

	public static void GetVersion(out int major, out int minor, out int patch)
	{
		uint major_ = default;
		uint minor_ = default;
		uint patch_ = default;
		GetVersion(&major_, &minor_, &patch_);
		major = unchecked((int)major_);
		minor = unchecked((int)minor_);
		patch = unchecked((int)patch_);
	}

	public static DxilBlob ParseDxilBlob(ReadOnlySpan<byte> data)
	{
		if (data.IsEmpty)
		{
			throw new ArgumentException("Data cannot be empty.", nameof(data));
		}

		ParsedBlob* parsedBlob = default;
		fixed (byte* dataPtr = data)
		{
			ParseDxilBlob(dataPtr, (nuint)data.Length, &parsedBlob).ThrowIfFailed();
		}
		return new DxilBlob(parsedBlob);
	}

	public static DxilBlob ParseReflectionDxilBlob(ReadOnlySpan<byte> data)
	{
		if (data.IsEmpty)
		{
			throw new ArgumentException("Data cannot be empty.", nameof(data));
		}

		ParsedBlob* parsedBlob = default;
		fixed (byte* dataPtr = data)
		{
			ParseReflectionDxilBlob(dataPtr, (nuint)data.Length, &parsedBlob).ThrowIfFailed();
		}
		return new DxilBlob(parsedBlob);
	}

	public static DxilBlob ParseDxil(ReadOnlySpan<byte> data)
	{
		if (data.IsEmpty)
		{
			throw new ArgumentException("Data cannot be empty.", nameof(data));
		}

		ParsedBlob* parsedBlob = default;
		fixed (byte* dataPtr = data)
		{
			ParseDxil(dataPtr, (nuint)data.Length, &parsedBlob).ThrowIfFailed();
		}
		return new DxilBlob(parsedBlob);
	}
}
