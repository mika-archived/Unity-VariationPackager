using System.Collections.Generic;
using System.IO;

using Mochizuki.VariationPackager.Models.Abstractions;

using UnityEngine;

namespace Mochizuki.VariationPackager.Processors
{
    public class CopyExternalLibrary : Processor
    {
        public override void Run()
        {
            var externals = Path.Combine(Application.dataPath, "..", "src", "VariationPackager", "bin", "Release");
            var destination = Path.Combine(Application.dataPath, "Mochizuki", "VariationPackager", "Plugins");
            var libraries = new List<string>
            {
                "Microsoft.Extensions.FileSystemGlobbing.dll",
                "Newtonsoft.Json.dll",
                "VariationPackager.dll"
            };

            foreach (var library in libraries)
                File.Copy(Path.Combine(externals, library), Path.Combine(destination, library), true);
        }
    }
}