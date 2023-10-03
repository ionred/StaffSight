using System.ComponentModel.DataAnnotations;

namespace StaffSight.Models
{
    public class AuditTrail
    {
        [Key]
        public int AuditID { get; set; }
        public string ModuleUsed { get; set; }
        public string TableName { get; set; }
        public int TableRowID { get; set; }
        public string OldValue { get; set; }
        public string NewValue { get; set; }
        public bool RecordDeleted { get; set; }
        public string ChangeByEmpID { get; set; }
        public string ChangeByEmpName { get; set; }
    }
}
