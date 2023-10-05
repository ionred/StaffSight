using System.ComponentModel.DataAnnotations;

namespace StaffSight.Models
{
    public class BilletsPrehire
    {
        [Key]
        public int BilletID { get; set; }

        [MaxLength(75)]
        public string BilletNumber { get; set; }

        [MaxLength(75)]
        public string PositionNumber { get; set; }

        public bool IsDeleted { get; set; }
    }
}
