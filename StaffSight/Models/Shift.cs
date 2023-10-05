using System.ComponentModel.DataAnnotations;
using System;

namespace StaffSight.Models
{
    public class Shift
    {
        [Key]
        public int ShiftID { get; set; }

        [MaxLength(75)]
        public string ShiftName { get; set; }

        public int ClassID { get; set; }

        [MaxLength(75)]
        public string DaysOfAvailability { get; set; }

        public DateTime HOAStart { get; set; }

        public DateTime HOAEnd { get; set; }

        public bool IsDeleted { get; set; }
    }
}
