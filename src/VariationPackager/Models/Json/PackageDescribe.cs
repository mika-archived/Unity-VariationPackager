/*-------------------------------------------------------------------------------------------
 * Copyright (c) Fuyuno Mikazuki / Natsuneko. All rights reserved.
 * Licensed under the MIT License. See LICENSE in the project root for license information.
 *------------------------------------------------------------------------------------------*/

using System.Collections.Generic;

using Mochizuki.VariationPackager.Models.Interface;

using Newtonsoft.Json;

namespace Mochizuki.VariationPackager.Models.Json
{
    internal class PackageDescribe : IPackageDescribe
    {
        [JsonConstructor]
        public PackageDescribe([JsonProperty("variations")] List<PackageVariation> variations)
        {
            Variations = new List<IPackageVariation>();
            Variations.AddRange(variations);
        }

        [JsonProperty("output")]
        public string Output { get; set; }

        // ReSharper disable once CollectionNeverQueried.Global
        public List<IPackageVariation> Variations { get; }
    }
}