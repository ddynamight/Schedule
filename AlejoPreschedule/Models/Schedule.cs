using System;
using System.ComponentModel.DataAnnotations;

namespace Preschedule.Models
{
    public class Schedule
    {
        public int ScheduleId { get; set; }

        public string UserId { get; set; }

        public string Name { get; set; }

        public string AccessCode { get; set; }
        public string Email { get; set; }
  
        public string PhoneNumber { get; set; }
  
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
      
    }
}
