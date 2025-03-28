using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using Factory.DAL.Models.Notifications;
using Factory.PL.Services.Notify;
using Factory.BLL.InterFaces;
using Factory.DAL.Models.Auth;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.SignalR;
using Factory.PL.Hubs;
using System.Security.Claims;
using Factory.PL.ViewModels.Notification;
using Microsoft.AspNetCore.Authorization;
using Factory.DAL.Enums;

namespace Factory.PL.Controllers
{
    public class NotificationController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IHubContext<NotificationHub> _hubContext;
        private readonly IStringLocalizer<NotificationController> _localizer;

        public NotificationController(
            IHubContext<NotificationHub> hubContext,
            INotificationService notificationService,
            IUnitOfWork unitOfWork,
            IStringLocalizer<NotificationController> localizer)
        {
            _unitOfWork = unitOfWork;
            _hubContext = hubContext;
            _localizer = localizer;
        }

        public async Task<IActionResult> Index()
        {
            var users = await _unitOfWork.GetRepository<ApplicationUser>().GetAllAsync();
            var notifications = (await _unitOfWork.GetRepository<Notification>()
                .GetAllAsync())
                .OrderByDescending(n => n.CreatedAt)
                .Select(n => new Notification
                {
                    Id = n.Id,
                    Message = n.Message,
                    CreatedAt = n.CreatedAt,
                    UserId = users.FirstOrDefault(u => u.Id == n.UserId)?.FullName,
                    IsRead = n.IsRead,
                    Description = n.Description,
                    Type = n.Type,
                    IconClass = n.IconClass
                })
                .ToList();

            return View(notifications);
        }

        [HttpGet]
        [CheckPermission(Permissions.Create)]
        public async Task<IActionResult> Add()
        {
            var users = await _unitOfWork.GetRepository<ApplicationUser>().GetAllAsync();
            ViewBag.Users = users.Select(u => new { u.Id, FullName = $"{u.FullName} - {u.UserName}" });

            return View(new AddNotificationViewModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [CheckPermission(Permissions.Create)]
        public async Task<IActionResult> Add(AddNotificationViewModel model)
        {
            if (ModelState.IsValid && model.SelectedUserIds != null && model.SelectedUserIds.Any())
            {
                try
                {
                    foreach (var userId in model.SelectedUserIds)
                    {
                        var userNotification = new Notification
                        {
                            Message = model.Message,
                            Description = model.Description,
                            Type = model.Type,
                            IconClass = model.IconClass,
                            CreatedAt = DateTime.UtcNow,
                            UserId = userId,
                            IsRead = false
                        };

                        await _unitOfWork.GetRepository<Notification>().AddAsync(userNotification);

                        // Send real-time notification to the user
                        await _hubContext.Clients.User(userId)
                            .SendAsync("ReceiveNotification", new
                            {
                                userNotification.Message,
                                userNotification.Type,
                                userNotification.IconClass,
                                userNotification.CreatedAt,
                                userNotification.Description,
                            });
                    }

                    await _unitOfWork.SaveChangesAsync();

                    TempData["Success"] = _localizer["NotificationsAddedSuccessfully"].ToString();
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception ex)
                {
                    TempData["Error"] = _localizer["ErrorAddingNotifications", ex.Message].ToString();
                }
            }
            else
            {
                TempData["Error"] = _localizer["SubmissionError"].ToString();
            }

            // Reload users for the form
            var users = await _unitOfWork.GetRepository<ApplicationUser>().GetAllAsync();
            ViewBag.Users = users.Select(u => new { u.Id, FullName = $"{u.FullName} - {u.UserName}" });

            return View(model);
        }

        [HttpGet("api/notification/unread")]
        [Authorize]
        public async Task<IActionResult> GetUnreadNotifications()
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            if (string.IsNullOrEmpty(userId))
            {
                return Unauthorized();
            }

            var notifications = await _unitOfWork.GetRepository<Notification>()
                .Query()
                .Where(n => !n.IsRead && n.UserId == userId)
                .OrderBy(n => n.CreatedAt)
                .Select(n => new
                {
                    n.Id,
                    n.Message,
                    n.Type,
                    n.IconClass,
                    n.CreatedAt
                })
                .ToListAsync();

            return Json(notifications);
        }

        [HttpPost("api/notification/MarkAsRead/{id}")]
        [Authorize]
        public async Task<IActionResult> MarkAsRead(int id)
        {
            var notification = await _unitOfWork.GetRepository<Notification>().GetByIdAsync(id);
            if (notification == null)
            {
                return NotFound();
            }

            notification.IsRead = true;
            await _unitOfWork.SaveChangesAsync();

            return Ok();
        }

        [Authorize]
        public async Task<IActionResult> Details(int id)
        {
            var notification = await _unitOfWork.GetRepository<Notification>()
                .Query()
                .FirstOrDefaultAsync(n => n.Id == id);

            if (notification == null)
            {
                return NotFound();
            }

            return View(notification);
        }

        [Authorize]
        public async Task<IActionResult> AllNotifications()
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            if (string.IsNullOrEmpty(userId))
            {
                return Unauthorized();
            }

            var notifications = await _unitOfWork.GetRepository<Notification>()
                .Query()
                .Where(n => n.UserId == userId)
                .OrderBy(n => n.IsRead)
                .ThenByDescending(n => n.CreatedAt)
                .ToListAsync();

            return View(notifications);
        }
    }
}