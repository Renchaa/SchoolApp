using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace rp23052NetMD4.Migrations
{
    /// <inheritdoc />
    public partial class someRevert : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5a43619f-f57d-4d11-9541-f0bc1e7db74a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "96a36de8-7b71-4ce8-b39e-77039e5b9fc8");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ec5defec-f88c-4b9a-8993-06b73ec8729e", null, "admin", "ADMIN" },
                    { "f0f21ee2-f001-4d71-a9fc-0f5f0f3247b4", null, "client", "CLIENT" }
                });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 1,
                column: "Deadline",
                value: new DateTime(2025, 2, 2, 11, 31, 10, 775, DateTimeKind.Local).AddTicks(7531));

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 2,
                column: "Deadline",
                value: new DateTime(2025, 2, 2, 11, 31, 10, 775, DateTimeKind.Local).AddTicks(7540));

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "SubmissionTime",
                value: new DateTime(2025, 1, 2, 11, 31, 10, 775, DateTimeKind.Local).AddTicks(7560));

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "SubmissionTime",
                value: new DateTime(2025, 1, 2, 11, 31, 10, 775, DateTimeKind.Local).AddTicks(7564));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 1,
                column: "ContractDate",
                value: new DateTime(2020, 1, 2, 11, 31, 10, 775, DateTimeKind.Local).AddTicks(7376));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 2,
                column: "ContractDate",
                value: new DateTime(2022, 1, 2, 11, 31, 10, 775, DateTimeKind.Local).AddTicks(7465));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ec5defec-f88c-4b9a-8993-06b73ec8729e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f0f21ee2-f001-4d71-a9fc-0f5f0f3247b4");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5a43619f-f57d-4d11-9541-f0bc1e7db74a", null, "admin", "ADMIN" },
                    { "96a36de8-7b71-4ce8-b39e-77039e5b9fc8", null, "client", "CLIENT" }
                });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 1,
                column: "Deadline",
                value: new DateTime(2025, 2, 2, 11, 11, 32, 138, DateTimeKind.Local).AddTicks(87));

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 2,
                column: "Deadline",
                value: new DateTime(2025, 2, 2, 11, 11, 32, 138, DateTimeKind.Local).AddTicks(93));

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "SubmissionTime",
                value: new DateTime(2025, 1, 2, 11, 11, 32, 138, DateTimeKind.Local).AddTicks(140));

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "SubmissionTime",
                value: new DateTime(2025, 1, 2, 11, 11, 32, 138, DateTimeKind.Local).AddTicks(143));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 1,
                column: "ContractDate",
                value: new DateTime(2020, 1, 2, 11, 11, 32, 137, DateTimeKind.Local).AddTicks(9975));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 2,
                column: "ContractDate",
                value: new DateTime(2022, 1, 2, 11, 11, 32, 138, DateTimeKind.Local).AddTicks(37));
        }
    }
}
