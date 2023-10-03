using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StaffSight.Models
{
    [Table("EmployeePreHire")]
    public class EmployeePreHire
    {
        [Key]

        [StringLength(10)]
        public string EmpID { get; set; }
        [StringLength(75)]
        public string FirstName { get; set; }
        [StringLength(75)]
        public string LastName { get; set; }
        public int? BilletID { get; set; }
        [StringLength(75)]
        public string? LocationName { get; set; }
        public int? BranchID { get; set; }
        public DateTime? ExpectedHireDate { get; set; }
        [Precision(18, 2)]

        public decimal? Salary { get; set; }
        [StringLength(10)]
        public string? SalaryType { get; set; } = "Hourly";
    }

}
