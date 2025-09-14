dotnet new tool-manifest --force
dotnet tool install ClangSharpPInvokeGenerator
cd AssetRipper.Bindings.DxilSpirV.Original.Generator
dotnet run
cd ../AssetRipper.Bindings.DxilSpirV.Generator
dotnet run
cd ..
