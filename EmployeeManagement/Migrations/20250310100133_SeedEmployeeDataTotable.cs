using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EmployeeManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedEmployeeDataTotable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "DateOfJoining", "Department", "Designation", "Name" },
                values: new object[,]
                {
                    { 1, new DateOnly(2020, 6, 15), "IT", "Software Developer", "John Smith" },
                    { 2, new DateOnly(2018, 3, 22), "IT", "Project Manager", "Sarah Johnson" },
                    { 3, new DateOnly(2019, 9, 10), "HR", "HR Manager", "James Brown" },
                    { 4, new DateOnly(2021, 12, 5), "Marketing", "Marketing Specialist", "Emily Davis" },
                    { 5, new DateOnly(2022, 1, 30), "Analytics", "Data Analyst", "Michael Wilson" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
