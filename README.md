# MergeTIFF
 A lightweight .NET Core console program to merge multiple TIFF files into one.
 * [Official page](https://www.ryadel.com/en/portfolio/mergetiff)
 * [Informative article](https://www.ryadel.com/en/mergetiff-asp-net-core-merge-tiff-tif-files-multi-page-open-source-free-download/)
 
# Introduction
MergeTIFF is a lightweight .NET Core console application that merges multiple TIFF files (including multi-page ones) into a single multi-page TIFF file. The full source code, as well as the Windows and Linux executables, is released under GNU v3 license and fully available on [GitHub](https://github.com/Darkseal/MergeTIFF/issues).

The tool has been developed by [Ryadel](https://www.ryadel.com/) as an educational project within one of our [ASP.NET Core and C# training courses](https://www.ryadel.com/en/training-courses/) and has been released to the public so that it could be used by anyone.

# Usage

The tool can be used from the windows command line or the Linux terminal by specifying two parameters:

    > MergeTIFF <sourceFolder> <targetFile>
* `<sourceFolder>` :  a folder containing the TIFF files to merge.
* `<targetFile>` : the container TIFF file path.

Example:

    > MergeTIFF C:\Temp\TIFF\ C:\Temp\MergeFile.tif

# Frameworks and Dependencies

MergeTIFF has been developed using the following dependencies:

* [.NET Core 2.2.108 SDK](https://dotnet.microsoft.com/download/visual-studio-sdks) (x32 and/or x64, depending on the platform you want to build the project for)
* [Windows Compatibility Pack v 2.1.1](https://www.nuget.org/packages/Microsoft.Windows.Compatibility) (required to use System.Drawing.Common & GDI+ interfaces)
* [WiX Toolset build tools 3.11.1](https://wixtoolset.org/releases/) and [WiX Toolset VS2019 Extension](https://marketplace.visualstudio.com/items?itemName=WixToolset.WixToolsetVisualStudio2019Extension) (for the installer package)

The *WiX Toolset* is only required if you plan to build the installer EXE for third-party release. If you don't know what *WiX Toolset* actually is, we strongly suggest reading this [WiX Toolset review and usage guide](https://www.ryadel.com/en/asp-net-create-msi-setup-exe-installer-project-wix-core-winforms-wpf-xaml/).

# Code References

The project strongly relies upon the [*MergeTiff* helper class](https://www.ryadel.com/en/asp-net-c-sharp-merge-tiff-files-into-single-multipage-tif/), which was released on [ryadel.com](https://www.ryadel.com/en/asp-net-c-sharp-merge-tiff-files-into-single-multipage-tif/) a while ago: if you like to know more about how it actually works, we strongly suggest take a look at [this post](https://www.ryadel.com/en/asp-net-c-sharp-merge-tiff-files-into-single-multipage-tif/). In case you want to know more about GDI+ - the Windows managed graphics interfaces which we used to build the class - we also suggest to read [this post](https://www.ryadel.com/en/multipage-tiff-files-asp-net-c-sharp-gdi-alternative/).

# Feedbacks

If you have questions, suggestions or any other feedback you would like to share with us, feel free to get in touch using our [contact form](https://www.ryadel.com/en/contacts/) or the GitHub project's issues [enter link description here](https://github.com/Darkseal/MergeTIFF/issues)page.
