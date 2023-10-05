using Microsoft.EntityFrameworkCore;
using StaffSight.Models;

namespace StaffSight.Data
{
    public class PosMgmtDBContext : DbContext
    {
        public PosMgmtDBContext(DbContextOptions<PosMgmtDBContext> options) : base(options)
        {
        }

        public DbSet<EmployeePrehire> EmployeePrehires { get; set; }
        public DbSet<EmployeeSalOffHist> EmployeeSalOffHists { get; set; }
        public DbSet<EmployeePrehirePermanentStorage> EmployeePrehirePermanentStorages { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<BilletsPrehire> BilletsPrehires { get; set; }
        public DbSet<RosterEmployee> RosterEmployees { get; set; }
        public DbSet<Shift> Shifts { get; set; }
        public DbSet<TrainingClass> TrainingClasses { get; set; }
        public DbSet<ClassLocation> ClassLocations { get; set; }
        public DbSet<AuditTrail> AuditTrails { get; set; }
        public DbSet<TrainerAssignment> TrainerAssignments { get; set; }
        public DbSet<ClassAttendance> ClassAttendances { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Define relationships and constraints here
        }
    }
}
