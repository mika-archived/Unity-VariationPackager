namespace Mochizuki.VariationPackager.Packaging
{
    // ReSharper disable once UnusedType.Global
    public static class AutomatedRelease
    {
        public static void Build()
        {
            CLI.BuildWithScene("Release", true);
        }
    }
}