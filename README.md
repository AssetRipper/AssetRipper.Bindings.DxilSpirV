# AssetRipper.Bindings.DxilSpirV

C# bindings for [dxil-spirv](https://github.com/HansKristian-Work/dxil-spirv)

Nightly builds are available on [NuGet](https://www.nuget.org/packages/AssetRipper.Bindings.DxilSpirV/).

## Building

> Note: This is just the highlights.

When pulling, make sure to use `git submodule update --recursive`.

Compiled native binaries should be placed in the `NativeLibaries` directory. This ensures that the native binaries are included in the NuGet package. However, due to limitations in .NET compilation, they will not be copied to other local projects, such as the example project. Those will need to be copied manually.

* `./AssetRipper.Bindings.DxilSpirV/NativeLibraries/win-arm64/native/`
* `./AssetRipper.Bindings.DxilSpirV/NativeLibraries/win-x64/native/`
* `./AssetRipper.Bindings.DxilSpirV/NativeLibraries/linux-arm64/native/`
* `./AssetRipper.Bindings.DxilSpirV/NativeLibraries/linux-x64/native/`
* `./AssetRipper.Bindings.DxilSpirV/NativeLibraries/osx-arm64/native/`
* `./AssetRipper.Bindings.DxilSpirV/NativeLibraries/osx-x64/native/`

## Pull Requests

I ([ds5678](https://github.com/ds5678)) have notifications disabled for this repository because to because I don't wish to receive notifications when automated pull requests are created and merged. For normal pull requests, you should include `@ds5678` in the pull request description. Otherwise, it could be many months before I notice it.
