using Microsoft.Extensions.Caching.Memory;
using Factory.DAL.Models.Permission;
using Factory.BLL.InterFaces;
using System.Globalization;
using Factory.PL.Services.Permssions;

namespace Factory.PL.Services.Permissions
{
    public class ModuleService : IModuleService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMemoryCache _memoryCache;
        private const string CacheKeyPrefix = "UserModules_";

        public ModuleService(IUnitOfWork unitOfWork, IMemoryCache memoryCache)
        {
            _unitOfWork = unitOfWork;
            _memoryCache = memoryCache;
        }

        public async Task<List<Module>> GetModulesForUserAsync(string userId)
        {
            var currentCulture = CultureInfo.CurrentCulture.Name;
            var isArabic = currentCulture == "ar-SA";
            var cacheKey = $"{CacheKeyPrefix}{userId}_{currentCulture}"; // Include culture in cache key

            if (_memoryCache.TryGetValue(cacheKey, out List<Module> cachedModules))
            {
                return cachedModules;
            }

            var modules = await _unitOfWork.GetRepository<Module>().GetModulesForUserAsync(userId);

            // Clone the modules to avoid modifying cached entities
            var localizedModules = modules.Select(m => new Module
            {
                Id = m.Id,
                Name = isArabic ? m.Name : m.NameEn,
                IconClass = m.IconClass,
                IsActive = m.IsActive,
                SubModules = m.SubModules.Select(sm => new SubModule
                {
                    Id = sm.Id,
                    Name = isArabic ? sm.Name : sm.NameEn,
                    IconClass = sm.IconClass,
                    ModuleId = sm.ModuleId,
                    Pages = sm.Pages.Select(p => new Page
                    {
                        Id = p.Id,
                        Name = isArabic ? p.Name : p.NameEn,
                        Action = p.Action,
                        Controller = p.Controller,
                        IsActive = p.IsActive,
                        SecureUrlKey = p.SecureUrlKey
                    }).ToList()
                }).ToList()
            }).ToList();

            var cacheOptions = new MemoryCacheEntryOptions()
                .SetSlidingExpiration(TimeSpan.FromMinutes(10));

            _memoryCache.Set(cacheKey, localizedModules, cacheOptions);

            return localizedModules;
        }

        public void InvalidateCacheForUser(string userId)
        {
            var cultures = new[] { "ar-SA", "en-US" }; 
            foreach (var culture in cultures)
            {
                var cacheKey = $"{CacheKeyPrefix}{userId}_{culture}";
                _memoryCache.Remove(cacheKey);
            }
        }
    }
}