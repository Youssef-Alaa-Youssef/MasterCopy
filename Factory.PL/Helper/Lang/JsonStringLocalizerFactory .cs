using Microsoft.Extensions.Localization;

public class JsonStringLocalizerFactory : IStringLocalizerFactory
{
    private readonly string _resourcesPath;

    public JsonStringLocalizerFactory(string resourcesPath)
    {
        _resourcesPath = resourcesPath;
    }

    public IStringLocalizer Create(Type resourceSource)
    {
        var baseName = resourceSource.FullName;
        return new JsonStringLocalizer(_resourcesPath, baseName);
    }

    public IStringLocalizer Create(string baseName, string location)
    {
        return new JsonStringLocalizer(_resourcesPath, baseName);
    }
}