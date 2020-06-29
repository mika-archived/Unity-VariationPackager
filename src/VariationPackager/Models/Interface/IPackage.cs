namespace Mochizuki.VariationPackager.Models.Interface
{
    public interface IPackage
    {
        string Name { get; }

        string Version { get; }

        IPackageDescribe Describe { get; }
    }
}