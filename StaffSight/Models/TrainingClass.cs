using System.ComponentModel.DataAnnotations;

namespace StaffSight.Models
{
    public class TrainingClass
    {
        [Key]
        public int ClassID { get; set; }
        public string ClassName { get; set; }
        public int ClassLocationID { get; set; }
        public int BranchID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public TimeSpan ClassStartTime { get; set; }
        public TimeSpan ClassEndTime { get; set; }
        public bool IsDeleted { get; set; }
    }
}
