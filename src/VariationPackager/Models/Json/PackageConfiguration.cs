using System.Collections.Generic;

using Mochizuki.VariationPackager.Models.Interface;

using Newtonsoft.Json;

namespace Mochizuki.VariationPackager.Models.Json
{
    public class PackageConfiguration : IPackageConfiguration
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("basedir")]
        public string BaseDir { get; set; }

        [JsonProperty("includes")]
        public List<string> Includes { get; set; }

        [JsonProperty("excludes")]
        public List<string> Excludes { get; set; }
    }
}