# Installation

## Installing .NET Core

The VB.NET track is built on top of the [.NET Core](https://www.microsoft.com/net/core/platform) platform, which runs on Windows, Linux and macOS. To build .NET Core projects, you can use the .NET Core Command Line Interface (CLI). This CLI is part of the .NET Core SDK, which you can install by following the [installation instructions](https://www.microsoft.com/net/download/core). Note: the VB.NET track requires SDK version 3.0 or greater.

After completing the installation, you can verify if the CLI was installed succesfully by running this command in a terminal:

```bash
dotnet --version
```

If the output is a version greater than or equal to `3.0.100`, the .NET Core SDK has been installed succesfully.

## Using an IDE

If you want a more full-featured editing experience, you probably want to to use an IDE. These are the most popular IDE's that support building .NET Core projects:

- [Visual Studio 2019](https://www.visualstudio.com/downloads/) (version 16.0.0 and higher)
- [Visual Studio Code](https://code.visualstudio.com/download) with a grammar and snippets [VB.NET extension](https://marketplace.visualstudio.com/items?itemName=gordonwalkedby.vbnet)
- [Visual Studio for Mac](https://www.visualstudio.com/vs/visual-studio-mac/) (still in beta)
- [Project Rider](https://www.jetbrains.com/rider/download/)

Note: as the .NET Core project format differs significantly from earlier versions, older IDE's (like Visual Studio 2015 and Xamarin Studio) are not supported.
