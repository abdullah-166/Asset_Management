using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Asset_Management.Migrations
{
    public partial class CreateDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Components_Employees_AssignedToEmployeeId",
                table: "Components");

            migrationBuilder.DropIndex(
                name: "IX_Components_AssignedToEmployeeId",
                table: "Components");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Components_AssignedToEmployeeId",
                table: "Components",
                column: "AssignedToEmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Components_Employees_AssignedToEmployeeId",
                table: "Components",
                column: "AssignedToEmployeeId",
                principalTable: "Employees",
                principalColumn: "EmployeeId");
        }
    }
}
