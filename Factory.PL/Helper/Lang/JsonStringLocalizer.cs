using Factory.PL.Helper.Lang;
using Microsoft.Extensions.Localization;
using System.Collections.Concurrent;
using System.Globalization;
using System.Text.Json;

public class JsonStringLocalizer : IStringLocalizer
{
    private readonly string _resourcesPath;
    private readonly string _baseName;
    private readonly ConcurrentDictionary<string, Lazy<Dictionary<string, string>>> _resourceCache =
        new ConcurrentDictionary<string, Lazy<Dictionary<string, string>>>();

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

    public IEnumerable<LocalizedString> GetAllStrings(bool includeParentCultures = false)
    {
        var culture = CultureInfo.CurrentUICulture;
        var resourceFile = GetResourceFile(culture);

        if (File.Exists(resourceFile))
        {
            var localizedStrings = GetLocalizedStrings(culture);
            return localizedStrings.Select(kvp =>
                new LocalizedString(kvp.Key, kvp.Value, resourceNotFound: false));
        }

        return Enumerable.Empty<LocalizedString>();
    }

    private string GetString(string name)
    {
        var culture = CultureInfo.CurrentUICulture;
        var localizedStrings = GetLocalizedStrings(culture);

        return localizedStrings.TryGetValue(name, out var value)
            ? value
            : null;
    }

    private Dictionary<string, string> GetLocalizedStrings(CultureInfo culture)
    {
        return _resourceCache.GetOrAdd(culture.Name, _ =>
            new Lazy<Dictionary<string, string>>(() =>
            {
                var resourceFile = GetResourceFile(culture);
                if (File.Exists(resourceFile))
                {
                    var json = File.ReadAllText(resourceFile);
                    try
                    {
                        return JsonSerializer.Deserialize<Dictionary<string, string>>(
                            json,
                            JsonSerializationOptions.DefaultOptions
                        ) ?? new Dictionary<string, string>();
                    }
                    catch (JsonException ex)
                    {
                        // Log the specific JSON parsing error
                        Console.WriteLine($"JSON Parsing Error in {resourceFile}: {ex.Message}");
                        return new Dictionary<string, string>();
                    }
                }
                return new Dictionary<string, string>();
            })).Value;
    }

    private string GetResourceFile(CultureInfo culture)
    {
        if (culture == null)
            throw new ArgumentNullException(nameof(culture));

        if (string.IsNullOrWhiteSpace(_baseName))
            throw new InvalidOperationException("Base name cannot be null or empty");

        if (string.IsNullOrWhiteSpace(_resourcesPath))
            throw new InvalidOperationException("Resources path cannot be null or empty");

        var parts = _baseName.Split(new[] { '.' }, StringSplitOptions.RemoveEmptyEntries);

        // Extract controller name
        var controllerName = ExtractControllerName(parts);
        var sanitizedControllerName = Path.GetFileName(controllerName);

        if (string.IsNullOrWhiteSpace(sanitizedControllerName))
            throw new InvalidOperationException("Invalid controller name");

        var resourceName = $"Controllers/{sanitizedControllerName}.{culture.Name}.json";
        var fullPath = Path.Combine(_resourcesPath, resourceName);

        // Security check to prevent directory traversal
        if (!Path.GetFullPath(fullPath).StartsWith(Path.GetFullPath(_resourcesPath)))
            throw new InvalidOperationException("Invalid resource path generated");

        return fullPath;
    }

    private string ExtractControllerName(string[] parts)
    {
        var controllerIndex = Array.FindIndex(parts, x =>
            string.Equals(x, "Views", StringComparison.OrdinalIgnoreCase)) + 1;

        return (controllerIndex > 0 && controllerIndex < parts.Length)
            ? parts[controllerIndex]
            : parts[parts.Length - 1];
    }
}