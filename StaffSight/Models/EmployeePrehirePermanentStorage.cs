using System.ComponentModel.DataAnnotations;

namespace StaffSight.Models
{
    public class EmployeePrehirePermanentStorage
    {
        [Key]
        public string EmpID { get; set; }

        public string ReqID { get; set; }
    }
}
