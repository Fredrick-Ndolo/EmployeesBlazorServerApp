using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeManagement.Api.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    DepartmentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.DepartmentID);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    DepartmentID = table.Column<int>(type: "int", nullable: false),
                    PhotoPath = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeID);
                    table.ForeignKey(
                        name: "FK_Employees_Departments_DepartmentID",
                        column: x => x.DepartmentID,
                        principalTable: "Departments",
                        principalColumn: "DepartmentID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "DepartmentID", "DepartmentName" },
                values: new object[] { 1, "IT" });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "DepartmentID", "DepartmentName" },
                values: new object[] { 2, "HR" });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "DepartmentID", "DepartmentName" },
                values: new object[] { 3, "ADMIN" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeID", "DateOfBirth", "DepartmentID", "Email", "FirstName", "Gender", "LastName", "PhotoPath" },
                values: new object[] { 1, new DateTime(1993, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "fredrickndolo2@gmail.com", "Fredrick", 0, "Ndolo", "images/003.png" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeID", "DateOfBirth", "DepartmentID", "Email", "FirstName", "Gender", "LastName", "PhotoPath" },
                values: new object[] { 2, new DateTime(1996, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "lizasharon95@gmail.com", "Liza", 1, "Onyango", "images/012.png" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeID", "DateOfBirth", "DepartmentID", "Email", "FirstName", "Gender", "LastName", "PhotoPath" },
                values: new object[] { 3, new DateTime(2020, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "phabyfavor@gmail.com", "Phabian", 0, "Favor", "images/013.png" });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DepartmentID",
                table: "Employees",
                column: "DepartmentID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Departments");
        }
    }
}
