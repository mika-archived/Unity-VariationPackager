/*-------------------------------------------------------------------------------------------
 * Copyright (c) Fuyuno Mikazuki / Natsuneko. All rights reserved.
 * Licensed under the MIT License. See LICENSE in the project root for license information.
 *------------------------------------------------------------------------------------------*/

namespace Mochizuki.VariationPackager.Models.Interface
{
    public interface IPackageVariation
    {
        string Name { get; }

        IPackageConfiguration Archive { get; }

        IPackageConfiguration UnityPackage { get; }
    }
}