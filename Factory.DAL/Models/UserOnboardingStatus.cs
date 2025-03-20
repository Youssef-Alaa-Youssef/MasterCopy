using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.DAL.Models
{
    public class UserOnboardingStatus
    {
        public bool IsFirstLogin { get; set; }
        public bool HasCompletedTour { get; set; }
        public int LastViewedStep { get; set; }
        public DateTime AccountCreatedDate { get; set; }
    }
}
