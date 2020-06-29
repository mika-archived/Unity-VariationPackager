using System.Collections.Generic;

using Mochizuki.VariationPackager.Models.Interface;

using Newtonsoft.Json;

namespace Mochizuki.VariationPackager.Models.Json
{
    internal class PackageDescribe : IPackageDescribe
    {
        [JsonProperty("output")]
        public string Output { get; set; }

        // ReSharper disable once CollectionNeverQueried.Global
        public List<IPackageVariation> Variations { get; }

        [JsonConstructor]
        public PackageDescribe([JsonProperty("variations")] List<PackageVariation> variations)
        {
            Variations = new List<IPackageVariation>();
            Variations.AddRange(variations);
        }
    }
}