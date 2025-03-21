using Factory.DAL.Models;
using System.Diagnostics;
namespace Factory.PL.Services.Monitor
{
    public class SystemMonitoringService
    {
        public SystemMetrics GetSystemMetrics()
        {
            var cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            var memoryCounter = new PerformanceCounter("Memory", "Available MBytes");
            var diskCounter = new PerformanceCounter("LogicalDisk", "% Disk Time", "_Total");

            cpuCounter.NextValue(); 
            System.Threading.Thread.Sleep(1000); 

            return new SystemMetrics
            {
                CpuUsage = cpuCounter.NextValue(),
                MemoryUsage = 100 - (memoryCounter.NextValue() / (1024 * 1024) * 100), 
                DiskUsage = diskCounter.NextValue(),
                Timestamp = DateTime.Now
            };
        }
    }
}
