using System.ComponentModel.DataAnnotations;

namespace StaffSight.Models
{
    public class ClassAttendance
    {
        [Key]
        public int AttendanceID { get; set; }
        public int ClassID { get; set; }
        public string EmpID { get; set; }
        public string ReportingEmpID { get; set; }
        public string AttendanceType { get; set; }
        public DateTime TimeNotified { get; set; }
    }
}
