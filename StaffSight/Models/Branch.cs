using System.ComponentModel.DataAnnotations;

namespace StaffSight.Models
{
    public class Branch
    {
        [Key]
        public int BranchID { get; set; }

        [MaxLength(75)]
        public string BranchName { get; set; }

        public bool IsDeleted { get; set; }
    }
}
