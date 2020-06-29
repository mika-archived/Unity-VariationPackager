/*-------------------------------------------------------------------------------------------
 * Copyright (c) Fuyuno Mikazuki / Natsuneko. All rights reserved.
 * Licensed under the MIT License. See LICENSE in the project root for license information.
 *------------------------------------------------------------------------------------------*/

using System.Collections.Generic;

namespace Mochizuki.VariationPackager.Models.Interface
{
    public interface IPackageConfiguration
    {
        string Name { get; }

        string BaseDir { get; }

        List<string> Includes { get; }

        List<string> Excludes { get; }
    }
}