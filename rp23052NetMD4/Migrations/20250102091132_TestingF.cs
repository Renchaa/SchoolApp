using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace rp23052NetMD4.Migrations
{
    /// <inheritdoc />
    public partial class TestingF : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "05abd2cf-e9c5-4d12-aaa8-32c359f530c6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0e7e5f5c-5f1b-4b58-a9b0-0698eebba37f");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5a43619f-f57d-4d11-9541-f0bc1e7db74a", null, "admin", "ADMIN" },
                    { "96a36de8-7b71-4ce8-b39e-77039e5b9fc8", null, "client", "CLIENT" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Gender", "Name", "StudentIdNumber", "Surname" },
                values: new object[,]
                {
                    { 1, "Female", "Alice", "S12345", "Johnson" },
                    { 2, "Male", "Bob", "S67890", "Brown" }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "ContractDate", "Gender", "Name", "Surname" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 1, 2, 11, 11, 32, 137, DateTimeKind.Local).AddTicks(9975), "Male", "John", "Doe" },
                    { 2, new DateTime(2022, 1, 2, 11, 11, 32, 138, DateTimeKind.Local).AddTicks(37), "Female", "Jane", "Smith" }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Name", "TeacherId" },
                values: new object[,]
                {
                    { 1, "Mathematics", 1 },
                    { 2, "Physics", 2 }
                });

            migrationBuilder.InsertData(
                table: "Assignments",
                columns: new[] { "Id", "CourseId", "Deadline", "Description" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2025, 2, 2, 11, 11, 32, 138, DateTimeKind.Local).AddTicks(87), "Math Homework" },
                    { 2, 2, new DateTime(2025, 2, 2, 11, 11, 32, 138, DateTimeKind.Local).AddTicks(93), "Physics Lab Report" }
                });

            migrationBuilder.InsertData(
                table: "Submissions",
                columns: new[] { "Id", "AssignmentId", "Score", "StudentId", "SubmissionTime" },
                values: new object[,]
                {
                    { 1, 1, 85.0, 1, new DateTime(2025, 1, 2, 11, 11, 32, 138, DateTimeKind.Local).AddTicks(140) },
                    { 2, 2, 90.0, 2, new DateTime(2025, 1, 2, 11, 11, 32, 138, DateTimeKind.Local).AddTicks(143) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5a43619f-f57d-4d11-9541-f0bc1e7db74a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "96a36de8-7b71-4ce8-b39e-77039e5b9fc8");

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "05abd2cf-e9c5-4d12-aaa8-32c359f530c6", null, "client", "client" },
                    { "0e7e5f5c-5f1b-4b58-a9b0-0698eebba37f", null, "admin", "admin" }
                });
        }
    }
}
