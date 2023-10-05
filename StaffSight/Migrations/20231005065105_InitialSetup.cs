using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StaffSight.Migrations
{
    /// <inheritdoc />
    public partial class InitialSetup : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AuditTrails",
                columns: table => new
                {
                    AuditID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModuleUsed = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    TableName = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    TableRowID = table.Column<int>(type: "int", nullable: false),
                    OldValue = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    NewValue = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    RecordDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ChangeByEmpID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    ChangeByEmpName = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    IsConfidential = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuditTrails", x => x.AuditID);
                });

            migrationBuilder.CreateTable(
                name: "BilletsPrehires",
                columns: table => new
                {
                    BilletID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BilletNumber = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    PositionNumber = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BilletsPrehires", x => x.BilletID);
                });

            migrationBuilder.CreateTable(
                name: "Branches",
                columns: table => new
                {
                    BranchID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchName = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branches", x => x.BranchID);
                });

            migrationBuilder.CreateTable(
                name: "ClassAttendances",
                columns: table => new
                {
                    AttendanceID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClassID = table.Column<int>(type: "int", nullable: false),
                    EmpID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    ReportingEmpID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    AttendanceType = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    IncidentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsPreApproved = table.Column<bool>(type: "bit", nullable: false),
                    TimeNotified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassAttendances", x => x.AttendanceID);
                });

            migrationBuilder.CreateTable(
                name: "ClassLocations",
                columns: table => new
                {
                    ClassLocationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClassLocationName = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassLocations", x => x.ClassLocationID);
                });

            migrationBuilder.CreateTable(
                name: "EmployeePrehirePermanentStorages",
                columns: table => new
                {
                    EmpID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ReqID = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeePrehirePermanentStorages", x => x.EmpID);
                });

            migrationBuilder.CreateTable(
                name: "EmployeePrehires",
                columns: table => new
                {
                    EmpID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    AddressFirst = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    AddressSecond = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    City = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    State = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    Zip = table.Column<int>(type: "int", nullable: false),
                    PhoneNumber = table.Column<int>(type: "int", nullable: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    BilletNumber = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    LocationName = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    BranchID = table.Column<int>(type: "int", nullable: false),
                    ExpectedHireDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsContractor = table.Column<bool>(type: "bit", nullable: false),
                    IsConversion = table.Column<bool>(type: "bit", nullable: false),
                    AssignedTA = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeePrehires", x => x.EmpID);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeSalOffHists",
                columns: table => new
                {
                    EmpID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Salary = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    SalaryType = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    EnteredDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EnteredBy = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeSalOffHists", x => x.EmpID);
                });

            migrationBuilder.CreateTable(
                name: "RosterEmployees",
                columns: table => new
                {
                    RosterID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClassID = table.Column<int>(type: "int", nullable: false),
                    EmpID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RosterEmployees", x => x.RosterID);
                });

            migrationBuilder.CreateTable(
                name: "Shifts",
                columns: table => new
                {
                    ShiftID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShiftName = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    ClassID = table.Column<int>(type: "int", nullable: false),
                    DaysOfAvailability = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    HOAStart = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HOAEnd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shifts", x => x.ShiftID);
                });

            migrationBuilder.CreateTable(
                name: "TrainerAssignments",
                columns: table => new
                {
                    TrainAssignID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TrainerEmpID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    ClassID = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainerAssignments", x => x.TrainAssignID);
                });

            migrationBuilder.CreateTable(
                name: "TrainingClasses",
                columns: table => new
                {
                    ClassID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClassName = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    ClassLocationID = table.Column<int>(type: "int", nullable: false),
                    BranchID = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ClassStartTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    ClassEndTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingClasses", x => x.ClassID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuditTrails");

            migrationBuilder.DropTable(
                name: "BilletsPrehires");

            migrationBuilder.DropTable(
                name: "Branches");

            migrationBuilder.DropTable(
                name: "ClassAttendances");

            migrationBuilder.DropTable(
                name: "ClassLocations");

            migrationBuilder.DropTable(
                name: "EmployeePrehirePermanentStorages");

            migrationBuilder.DropTable(
                name: "EmployeePrehires");

            migrationBuilder.DropTable(
                name: "EmployeeSalOffHists");

            migrationBuilder.DropTable(
                name: "RosterEmployees");

            migrationBuilder.DropTable(
                name: "Shifts");

            migrationBuilder.DropTable(
                name: "TrainerAssignments");

            migrationBuilder.DropTable(
                name: "TrainingClasses");
        }
    }
}
