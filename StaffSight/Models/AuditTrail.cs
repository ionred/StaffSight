using System;
using System.ComponentModel.DataAnnotations;

namespace StaffSight.Models
{
    public class AuditTrail
    {
        [Key]
        public int AuditID { get; set; }

        [MaxLength(75)]
        public string ModuleUsed { get; set; }

        [MaxLength(75)]
        public string TableName { get; set; }

        public int TableRowID { get; set; }

        [MaxLength(75)]
        public string OldValue { get; set; }

        [MaxLength(75)]
        public string NewValue { get; set; }

        public bool RecordDeleted { get; set; }

        [MaxLength(10)]
        public string ChangeByEmpID { get; set; }

        [MaxLength(75)]
        public string ChangeByEmpName { get; set; }

        public bool IsConfidential { get; set; }
    }
}
