using System;
using System.ComponentModel.DataAnnotations;

namespace StaffSight.Models
{
    public class ClassAttendance
    {
        [Key]
        public int AttendanceID { get; set; }

        public int ClassID { get; set; }

        [MaxLength(10)]
        public string EmpID { get; set; }

        [MaxLength(10)]
        public string ReportingEmpID { get; set; }

        [MaxLength(75)]
        public string AttendanceType { get; set; }

        public DateTime IncidentDate { get; set; }

        public bool IsPreApproved { get; set; }

        public DateTime TimeNotified { get; set; }
    }
}
