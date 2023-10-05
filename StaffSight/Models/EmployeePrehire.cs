using System;
using System.ComponentModel.DataAnnotations;

namespace StaffSight.Models
{
    public class EmployeePrehire
    {
        [Key]
        [MaxLength(10)]
        public string EmpID { get; set; }

        [MaxLength(75)]
        public string FirstName { get; set; }

        [MaxLength(75)]
        public string LastName { get; set; }

        [MaxLength(75)]
        public string AddressFirst { get; set; }

        [MaxLength(75)]
        public string AddressSecond { get; set; }

        [MaxLength(75)]
        public string City { get; set; }

        [MaxLength(75)]
        public string State { get; set; }

        public int Zip { get; set; }

        public int PhoneNumber { get; set; }

        [MaxLength(150)]
        public string EmailAddress { get; set; }

        [MaxLength(75)]
        public string BilletNumber { get; set; }

        [MaxLength(75)]
        public string LocationName { get; set; }

        public int BranchID { get; set; }

        public DateTime ExpectedHireDate { get; set; }
        public bool IsContractor { get; set; }
        public bool IsConversion { get; set; }

        [MaxLength(10)]
        public string AssignedTA { get; set; }
    }
}
