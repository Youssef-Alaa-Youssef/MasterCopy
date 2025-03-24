using Factory.DAL.Enums;
using Factory.PL.Services.Monitor;
using Microsoft.AspNetCore.Mvc;
using Factory.DAL.Models;

namespace Factory.PL.Controllers
{
    public class ITServiceController : Controller
    {
        private readonly SystemMonitoringService _monitoringService;

        public ITServiceController(SystemMonitoringService monitoringService)
        {
            _monitoringService = monitoringService ?? throw new ArgumentNullException(nameof(monitoringService));
        }

        [CheckPermission(Permissions.Read)]
        public async Task<IActionResult> Monitoring()
        {
            var metrics =  _monitoringService.GetSystemMetrics();
            if (metrics == null)
            {
                return NotFound("System metrics could not be retrieved.");
            }

            return View(metrics);
        }
    }
}