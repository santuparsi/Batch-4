using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HandsonEFUsingCodeFirst.Migrations
{
    public partial class Employee_Dept_Added : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Depts",
                columns: table => new
                {
                    Did = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    Dname = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Depts", x => x.Did);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Eid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ename = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    JoinDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Designation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Salary = table.Column<double>(type: "float", nullable: true),
                    Did = table.Column<string>(type: "nvarchar(5)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Eid);
                    table.ForeignKey(
                        name: "FK_Employees_Depts_Did",
                        column: x => x.Did,
                        principalTable: "Depts",
                        principalColumn: "Did",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_Did",
                table: "Employees",
                column: "Did");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Depts");
        }
    }
}
