using Microsoft.Extensions.Localization;
using System.Collections.Concurrent;
using System.Globalization;
using System.Text.Json;

public class JsonStringLocalizer : IStringLocalizer
{
    private readonly string _resourcesPath;
    private readonly string _baseName;
    private readonly ConcurrentDictionary<string, string> _localizedStrings = new();

    public JsonStringLocalizer(string resourcesPath, string baseName)
    {
        _resourcesPath = resourcesPath;
        _baseName = baseName;
    }

    public LocalizedString this[string name]
    {
        get
        {
            var value = GetString(name);
            return new LocalizedString(name, value ?? name, resourceNotFound: value == null);
        }
    }

    public LocalizedString this[string name, params object[] arguments]
    {
        get
        {
            var format = GetString(name);
            var value = string.Format(format ?? name, arguments);
            return new LocalizedString(name, value, resourceNotFound: format == null);
        }
    }

    public IEnumerable<LocalizedString> GetAllStrings(bool includeParentCultures)
    {
        var culture = CultureInfo.CurrentUICulture;
        var resourceFile = GetResourceFile(culture);

        if (File.Exists(resourceFile))
        {
            var json = File.ReadAllText(resourceFile);
            var localizedStrings = JsonSerializer.Deserialize<Dictionary<string, string>>(json);

            foreach (var kvp in localizedStrings)
            {
                yield return new LocalizedString(kvp.Key, kvp.Value, resourceNotFound: false);
            }
        }
    }

    private string GetString(string name)
    {
        var culture = CultureInfo.CurrentUICulture;
        var resourceFile = GetResourceFile(culture);

        if (File.Exists(resourceFile))
        {
            var json = File.ReadAllText(resourceFile);
            var localizedStrings = JsonSerializer.Deserialize<Dictionary<string, string>>(json);

            if (localizedStrings.TryGetValue(name, out var value))
            {
                return value;
            }
        }

        return null;
    }

    private string GetResourceFile(CultureInfo culture)
    {
        var controllerName = _baseName.Split('.').Last(); 
        var resourceName = $"Controllers/{controllerName}.{culture.Name}.json";
        return Path.Combine(_resourcesPath, resourceName);
    }

}