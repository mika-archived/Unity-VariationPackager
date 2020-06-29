/*-------------------------------------------------------------------------------------------
 * Copyright (c) Fuyuno Mikazuki / Natsuneko. All rights reserved.
 * Licensed under the MIT License. See LICENSE in the project root for license information.
 *------------------------------------------------------------------------------------------*/

namespace Mochizuki.VariationPackager.Models.Interface
{
    public interface IPackage
    {
        string Name { get; }

        string Version { get; }

        IPackageDescribe Describe { get; }
    }
}