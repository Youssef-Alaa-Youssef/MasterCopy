using Factory.DAL.Enums;
using Factory.PL.Services.Permssions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Caching.Memory;

public class CheckPermissionAttribute : AuthorizeAttribute, IAsyncAuthorizationFilter
{
    private readonly Permissions _permission;

    public CheckPermissionAttribute(Permissions permission)
    {
        _permission = permission;
    }

    public async Task OnAuthorizationAsync(AuthorizationFilterContext context)
    {
        var cache = context.HttpContext.RequestServices.GetRequiredService<IMemoryCache>();
        var user = context.HttpContext.User;

        if (!user.Identity.IsAuthenticated)
        {
            context.Result = new RedirectToActionResult("Login", "Auth", null);
            return;
        }

        var controllerName = context.RouteData.Values["controller"].ToString().Trim();
        var actionName = context.RouteData.Values["action"].ToString().Trim();

        var rolePermissionService = context.HttpContext.RequestServices.GetService<IRolePermissionService>();

        var pageIdCacheKey = $"{controllerName}_{actionName}_PageId";
        var permissionCacheKey = $"{controllerName}_{actionName}_Permission_{user.Identity.Name}_{_permission}";

        if (!cache.TryGetValue(pageIdCacheKey, out int? pageId))
        {
            pageId = await rolePermissionService.GetPageIdByControllerAction(controllerName, actionName);

            cache.Set(pageIdCacheKey, pageId, TimeSpan.FromMinutes(10));
        }

        if (pageId == null)
        {
            context.Result = new RedirectToActionResult("AccessDenied", "Auth", null);
            return;
        }

        if (!cache.TryGetValue(permissionCacheKey, out bool hasPermission))
        {
            hasPermission = await rolePermissionService.CheckUserPermission(user, pageId.Value, (int)_permission);

            cache.Set(permissionCacheKey, hasPermission, TimeSpan.FromMinutes(10));
        }

        if (!hasPermission)
        {
            context.Result = new RedirectToActionResult("AccessDenied", "Auth", null);
        }
    }
}