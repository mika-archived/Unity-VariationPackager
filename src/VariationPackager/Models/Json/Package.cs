/*-------------------------------------------------------------------------------------------
 * Copyright (c) Fuyuno Mikazuki / Natsuneko. All rights reserved.
 * Licensed under the MIT License. See LICENSE in the project root for license information.
 *------------------------------------------------------------------------------------------*/

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

        public IPackageDescribe Describe { get; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }
    }
}