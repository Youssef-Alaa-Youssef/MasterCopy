using Microsoft.Extensions.Localization;
using System.Collections.Concurrent;
using System.Reflection;

public class JsonStringLocalizerFactory : IStringLocalizerFactory
{
    private readonly string _resourcesPath;
    private readonly ConcurrentDictionary<string, JsonStringLocalizer> _localizers = new();

    public JsonStringLocalizerFactory(string resourcesPath)
    {
        _resourcesPath = resourcesPath ?? throw new ArgumentNullException(nameof(resourcesPath));
    }

    public IStringLocalizer Create(Type resourceSource)
    {
        var typeInfo = resourceSource.GetTypeInfo();
        var assemblyName = typeInfo.Assembly.GetName().Name;
        var baseName = typeInfo.FullName;

        return CreateJsonStringLocalizer(assemblyName, baseName);
    }

    public IStringLocalizer Create(string baseName, string location)
    {
        return CreateJsonStringLocalizer(location, baseName);
    }

    private JsonStringLocalizer CreateJsonStringLocalizer(string assemblyName, string baseName)
    {
        var resourceKey = $"{assemblyName}.{baseName}";
        return _localizers.GetOrAdd(resourceKey, _ => new JsonStringLocalizer(_resourcesPath, baseName));
    }
}