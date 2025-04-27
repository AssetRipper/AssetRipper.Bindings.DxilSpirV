using AssetRipper.Bindings.DxilSpirV;
using System.Diagnostics;
using System.Text;

namespace AssetRipper.Bindings.DxilSpirv.Generator;

internal static class Program
{
	private const string RepositoryRoot = "../../../../";
	private const string OriginalOutputPath = "./AssetRipper.Bindings.DxilSpirV.Original/Generated";
	private const string OutputPath = "./AssetRipper.Bindings.DxilSpirV/Generated";

	static void Main()
	{
		ReflectionGenerator reflectionGenerator = new();
		reflectionGenerator.AnalyzeAssembly(typeof(NativeMethods).Assembly);

		string currentDirectory = Directory.GetCurrentDirectory();
		try
		{
			Directory.SetCurrentDirectory(Path.Combine(AppContext.BaseDirectory, RepositoryRoot));

			string beginningContent = File.ReadAllText("generate.rsp").Replace(OriginalOutputPath, OutputPath, StringComparison.Ordinal);

			StringBuilder sb = new();
			sb.AppendLine(beginningContent);
			sb.AppendLine("--exclude");
			sb.AppendLine("DXIL_SPV_TRUE");
			sb.AppendLine("DXIL_SPV_FALSE");
			sb.AppendLine("--remap");
			foreach ((string original, string cleaned) in reflectionGenerator.RemappedNames)
			{
				sb.AppendLine($"{original}={cleaned}");
			}

			if (Directory.Exists(OutputPath))
			{
				Directory.Delete(OutputPath, true);
			}

			const string ResponsePath = "generate_actual.rsp";
			File.WriteAllText(ResponsePath, sb.ToString());

			Process? process = Process.Start(new ProcessStartInfo("ClangSharpPInvokeGenerator", "@generate_actual.rsp"));

			process?.WaitForExit();

			File.Delete(ResponsePath);

		}
		finally
		{
			Directory.SetCurrentDirectory(currentDirectory);
		}
	}
}
