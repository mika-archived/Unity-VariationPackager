namespace Mochizuki.VariationPackager.Models.Interface
{
    public interface IPackageVariation
    {
        string Name { get; }

        IPackageConfiguration Archive { get; }

        IPackageConfiguration UnityPackage { get; }
    }
}