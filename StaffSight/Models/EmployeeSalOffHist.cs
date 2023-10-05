using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace StaffSight.Models
{
    public class EmployeeSalOffHist
    {
        [Key]
        public string EmpID { get; set; }
        [Precision(18, 2)]
        public decimal Salary { get; set; }

        [MaxLength(10)]
        public string SalaryType { get; set; } = "Hourly";

        public DateTime EnteredDate { get; set; }

        [MaxLength(10)]
        public string EnteredBy { get; set; }

        public string? Note { get; set; }
    }
}
