﻿using System.ComponentModel.DataAnnotations;

namespace StaffSight.Models
{
    public class TrainerAssignment
    {
        [Key]
        public int TrainAssignID { get; set; }
        public string TrainerEmpID { get; set; }
        public int ClassID { get; set; }
        public bool IsDeleted { get; set; }
    }
}
