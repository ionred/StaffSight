using System.ComponentModel.DataAnnotations;

namespace StaffSight.Models
{
    public class RosterEmployee
    {
        [Key]
        public int RosterID { get; set; }
        public int ClassID { get; set; }
        public string EmpID { get; set; }
        public bool IsDeleted { get; set; }
    }
}
