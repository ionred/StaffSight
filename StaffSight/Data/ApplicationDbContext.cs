using Microsoft.EntityFrameworkCore;
using StaffSight.Models;

namespace StaffSight.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<EmployeePreHire> EmployeePreHires { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<BilletPreHire> BilletPreHires { get; set; }
        public DbSet<RosterEmployee> RosterEmployees { get; set; }
        public DbSet<Shift> Shifts { get; set; }
        public DbSet<TrainingClass> TrainingClasses { get; set; }
        public DbSet<ClassLocation> ClassLocations { get; set; }
        public DbSet<AuditTrail> AuditTrails { get; set; }
        public DbSet<TrainerAssignment> TrainerAssignments { get; set; }
        public DbSet<ClassAttendance> ClassAttendances { get; set; }

    }
}
