using Microsoft.AspNetCore.Identity;
using Preschedule.Models;
using System.Collections.Generic;

namespace AlejoPreschedule.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public virtual ICollection<Schedule> Schedules { get; set; }
    }
}
