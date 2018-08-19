using System.ComponentModel.DataAnnotations;

namespace Preschedule.Models
{
    public class Employees
    {
        [Key]
        public int EmpId { get; set; }

        public string FullName { get; set; }
        public string EmailAddress { get; set; }

    }
}
