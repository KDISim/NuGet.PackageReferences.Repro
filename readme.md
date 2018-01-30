Reproces a NuGet scenario using old style csproj's with PackageReference NuGet references which leads to inconsistent versions of transient dependencies being restored. We chose the NuGet package System.Reactive for this because it has a few transient dependencies.

The dependencies are setup like this:
![dependencies]

When we build project 1 we see the following in the bin folder:
![project1_bin]
As you can see version 3.1.0 of the System.Reactive.Core package was used here.

When we build project 3 we see the following in the bin folder:
![project3_bin]
As you can see version 3.1.1 of the System.Reactive.Core package was used here.

When we build project 4 we see the following in the bin folder:
![project4_bin]
As you can see version 3.1.1 of the System.Reactive.Core package was used here.

[dependencies]: images/dependencies.png
[project1_bin]: images/project1.bin.png
[project3_bin]: images/project3.bin.png
[project4_bin]: images/project4.bin.png