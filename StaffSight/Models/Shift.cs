namespace StaffSight.Models
{
    public class Shift
    {
        public int ShiftID { get; set; }
        public string ShiftName { get; set; }
        public int ClassID { get; set; }
        public string DaysOfAvailability { get; set; }
        public DateTime HOAStart { get; set; }
        public DateTime HOAEnd { get; set; }
        public bool IsDeleted { get; set; }
    }
}
