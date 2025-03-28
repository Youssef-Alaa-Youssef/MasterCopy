using Microsoft.Extensions.Caching.Memory;
using System.Reflection;

public static class MemoryCacheExtensions
{
    private static readonly Func<MemoryCache, object> GetEntriesCollection;

    static MemoryCacheExtensions()
    {
        try
        {
            var propertyInfo = typeof(MemoryCache).GetProperty(
                "EntriesCollection",
                BindingFlags.NonPublic | BindingFlags.Instance
            );

            if (propertyInfo == null)
            {
                throw new InvalidOperationException("Could not find EntriesCollection property");
            }

            var getMethod = propertyInfo.GetGetMethod(true);

            if (getMethod == null)
            {
                throw new InvalidOperationException("Could not find getter method for EntriesCollection");
            }

            GetEntriesCollection = (Func<MemoryCache, object>)Delegate.CreateDelegate(
                typeof(Func<MemoryCache, object>),
                getMethod
            );
        }
        catch (Exception ex)
        {
            GetEntriesCollection = _ => null;
        }
    }

    public static IEnumerable<string> GetKeys(this IMemoryCache memoryCache)
    {
        if (memoryCache is not MemoryCache cache)
        {
            return Enumerable.Empty<string>();
        }

        var entriesCollection = GetEntriesCollection(cache);

        if (entriesCollection is not System.Collections.ICollection collection)
        {
            return Enumerable.Empty<string>();
        }

        var keys = new List<string>();

        foreach (var item in collection)
        {
            try
            {
                var keyProperty = item.GetType().GetProperty("Key");
                var val = keyProperty?.GetValue(item);

                if (val is string key)
                {
                    keys.Add(key);
                }
            }
            catch
            {
                continue;
            }
        }

        return keys;
    }
}