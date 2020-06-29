using Mochizuki.VariationPackager.Models.Interface;

using Newtonsoft.Json;

namespace Mochizuki.VariationPackager.Models.Json
{
    internal class Package : IPackage
    {
        [JsonConstructor]
        public Package([JsonProperty("moe.mochizuki.unity.packaging")]
                       PackageDescribe describe)
        {
            Describe = describe;
        }

        public IPackageDescribe Describe { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }
    }
}