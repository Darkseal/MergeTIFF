using System;
using System.Collections.Generic;
using System.IO;

namespace MergeTiff.NET
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                if (args.Length != 2)
                {
                    Console.WriteLine("");
                    Console.WriteLine("--------------------------------------------------");
                    Console.WriteLine("MergeTiff - A tiny .NET Core console program ");
                    Console.WriteLine("            to merge multiple TIFF files into one.");
                    Console.WriteLine("--------------------------------------------------");
                    Console.WriteLine("");
                    Console.WriteLine("Usage:");
                    Console.WriteLine("");
                    Console.WriteLine("MergeTiff <sourceFolder> <targetFile>");
                    Console.WriteLine("");
                    Console.WriteLine(" - <sourceFolder> : a folder containing the TIFF files to merge.");
                    Console.WriteLine(" - <targetFile>   : the container TIFF file path.");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    return;
                }

                var sourceFolder = args[0];
                if (!Directory.Exists(sourceFolder))
                    throw new NotSupportedException(String.Format("Input folder {0} not found.", sourceFolder));

                var targetFilePath = args[1];

                var files = new List<byte[]>();
                foreach (var file in Directory.GetFiles(sourceFolder, "*.tif?"))
                    files.Add(File.ReadAllBytes(file));

                var targetFileData = TiffHelper.MergeTiff(files.ToArray());

                File.WriteAllBytes(targetFilePath, targetFileData);
            }
            catch (Exception e)
            {
                Console.WriteLine("");
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("ERROR: " + e.Message);
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("");
            }
        }
    }
}
