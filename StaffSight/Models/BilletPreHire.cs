using System.ComponentModel.DataAnnotations;

namespace StaffSight.Models
{
    public class BilletPreHire
    {
        [Key]
        public int BilletID { get; set; }
        public string BilletNumber { get; set; }
        public string PositionNumber { get; set; }
        public bool IsDeleted { get; set; }
    }
}
