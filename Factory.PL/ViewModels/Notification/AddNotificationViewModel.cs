namespace Factory.PL.ViewModels.Notification
{
    public class AddNotificationViewModel
    {
        public string Message { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public string IconClass { get; set; }
        public List<string> SelectedUserIds { get; set; } 
    }
}
