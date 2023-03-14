using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UniversityRegistrar.Migrations
{
    public partial class filesNeededForDepartmentObject : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DepartmentID",
                table: "Departments",
                newName: "DepartmentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DepartmentId",
                table: "Departments",
                newName: "DepartmentID");
        }
    }
}
