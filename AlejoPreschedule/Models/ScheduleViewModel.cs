using System;
using System.ComponentModel.DataAnnotations;

namespace Preschedule.Models
{
    public class ScheduleViewModel
    {
        public int ScheduleId { get; set; }
        [Display(Name = "Full Name")]
        [Required(ErrorMessage ="Name is required")]
        public string Name { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required(ErrorMessage ="Phone number is required")]
        public string PhoneNumber { get; set; }
        public string AccessCode { get; set; }
        public string Address { get; set; }
        public string Purpose { get; set; }
        public string FromWhere { get; set; }
        public string ToWhom { get; set; }
        public string Name_of_company { get; set; }
        public string Name_of_event { get; set; }
        public string From_Where { get; set; }
        public string To_Whom { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        public Schedule schedule { get; set; }
    }
}
//var userId = await _userManager.GetUserIdAsync(HttpContext.User);
//return View(await _context.Goal.Where(g => g.UserID == userId).ToListAsync());