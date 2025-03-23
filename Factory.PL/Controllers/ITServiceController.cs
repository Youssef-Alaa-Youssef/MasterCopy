using Factory.DAL.Enums;
using Factory.PL.Services.Monitor;
using Microsoft.AspNetCore.Mvc;

namespace Factory.PL.Controllers
{
    public class ITServiceController : Controller
    {
        private readonly SystemMonitoringService _monitoringService;

        public ITServiceController(SystemMonitoringService monitoringService)
        {
            _monitoringService = monitoringService;
        }

        [CheckPermission(Permissions.Read)]
        public IActionResult Monitoring()
        {
            var metrics = _monitoringService.GetSystemMetrics();
            return View(metrics);
        }
    }
}
