/*-------------------------------------------------------------------------------------------
 * Copyright (c) Fuyuno Mikazuki / Natsuneko. All rights reserved.
 * Licensed under the MIT License. See LICENSE in the project root for license information.
 *------------------------------------------------------------------------------------------*/

using System.Collections.Generic;

namespace Mochizuki.VariationPackager.Models.Interface
{
    public interface IPackageDescribe
    {
        string Output { get; }

        List<IPackageVariation> Variations { get; }
    }
}