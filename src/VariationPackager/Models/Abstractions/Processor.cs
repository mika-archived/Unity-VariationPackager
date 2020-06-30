/*-------------------------------------------------------------------------------------------
 * Copyright (c) Fuyuno Mikazuki / Natsuneko. All rights reserved.
 * Licensed under the MIT License. See LICENSE in the project root for license information.
 *------------------------------------------------------------------------------------------*/

using System;

using Mochizuki.VariationPackager.Models.Interface;

using UnityEngine;

namespace Mochizuki.VariationPackager.Models.Abstractions
{
    [Serializable]
    public class Processor : MonoBehaviour, IProcessor
    {
        public virtual void Run() { }
    }
}