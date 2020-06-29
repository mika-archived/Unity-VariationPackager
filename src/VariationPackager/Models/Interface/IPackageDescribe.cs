using System.Collections.Generic;

namespace Mochizuki.VariationPackager.Models.Interface
{
    public interface IPackageDescribe
    {
        string Output { get; }

        List<IPackageVariation> Variations { get; }
    }
}