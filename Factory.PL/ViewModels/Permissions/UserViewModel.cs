﻿namespace Factory.PL.ViewModels.Permissions
{
    public class UserViewModel
    {
        public string UserId { get; set; }
        public string UserName { get; set; }
        public List<string> Roles { get; set; } = new List<string>();
    }
}
