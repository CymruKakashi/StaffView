using Microsoft.EntityFrameworkCore.Migrations;

namespace StaffView.Migrations
{
    public partial class NormalizeNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Outofoffice",
                table: "Employee",
                newName: "OutOfOffice");

            migrationBuilder.RenameColumn(
                name: "Employeetitle",
                table: "Employee",
                newName: "EmployeeTitle");

            migrationBuilder.RenameColumn(
                name: "Desknumber",
                table: "Employee",
                newName: "DeskNumber");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "OutOfOffice",
                table: "Employee",
                newName: "Outofoffice");

            migrationBuilder.RenameColumn(
                name: "EmployeeTitle",
                table: "Employee",
                newName: "Employeetitle");

            migrationBuilder.RenameColumn(
                name: "DeskNumber",
                table: "Employee",
                newName: "Desknumber");
        }
    }
}
