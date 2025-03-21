namespace Factory.DAL.Models
{
    public class SystemMetrics
    {
        public float CpuUsage { get; set; } 
        public float MemoryUsage { get; set; } 
        public float DiskUsage { get; set; } 
        public DateTime Timestamp { get; set; } 
    }
}
