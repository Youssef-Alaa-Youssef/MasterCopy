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
        if (culture == null)
        {
            throw new ArgumentNullException(nameof(culture));
        }

        if (string.IsNullOrWhiteSpace(_baseName))
        {
            throw new InvalidOperationException("Base name cannot be null or empty");
        }

        if (string.IsNullOrWhiteSpace(_resourcesPath))
        {
            throw new InvalidOperationException("Resources path cannot be null or empty");
        }

        var parts = _baseName.Split(new[] { '.' }, StringSplitOptions.RemoveEmptyEntries);

        if (parts.Length < 2)
        {
            throw new InvalidOperationException($"Invalid base name format: {_baseName}");
        }

        var controllerIndex = Array.FindIndex(parts, x =>
            string.Equals(x, "Views", StringComparison.OrdinalIgnoreCase)) + 1;

        if (controllerIndex <= 0 || controllerIndex >= parts.Length)
        {
            throw new InvalidOperationException($"Could not determine controller from base name: {_baseName}");
        }

        var controllerName = parts[controllerIndex];
        var sanitizedControllerName = Path.GetFileName(controllerName); 

        if (string.IsNullOrWhiteSpace(sanitizedControllerName))
        {
            throw new InvalidOperationException("Invalid controller name");
        }

        var resourceName = $"Controllers/{sanitizedControllerName}.{culture.Name}.json";
        var fullPath = Path.Combine(_resourcesPath, resourceName);

        if (!Path.GetFullPath(fullPath).StartsWith(Path.GetFullPath(_resourcesPath)))
        {
            throw new InvalidOperationException("Invalid resource path generated");
        }

        return fullPath;
    }

}