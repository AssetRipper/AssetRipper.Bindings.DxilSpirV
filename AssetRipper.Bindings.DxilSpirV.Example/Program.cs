namespace AssetRipper.Bindings.DxilSpirV.Example;

internal class Program
{
	private static void Main(string[] args)
	{
		Logger.AddConsoleLogger();
		byte[] data = File.ReadAllBytes(args[0]);
		File.WriteAllBytes(args[1], ConvertDxil(data));
	}

	private static byte[] ConvertDxil(ReadOnlySpan<byte> data)
	{
		using DxilBlob blob = NativeMethods.ParseDxilBlob(data);
		using DxilConverter converter = blob.CreateConverter();
		converter.Run();
		ReadOnlySpan<byte> spirv = converter.GetCompiledSpirV();
		return spirv.ToArray();
	}
}
