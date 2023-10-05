using System.ComponentModel.DataAnnotations;

namespace StaffSight.Models
{
    public class ClassLocation
    {
        [Key]
        public int ClassLocationID { get; set; }

        [MaxLength(75)]
        public string ClassLocationName { get; set; }

        public bool IsDeleted { get; set; }
    }
}
