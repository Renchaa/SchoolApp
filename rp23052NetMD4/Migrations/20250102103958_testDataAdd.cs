using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace rp23052NetMD4.Migrations
{
    /// <inheritdoc />
    public partial class testDataAdd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "0b50a96f-f634-4a24-a857-ad4c7ef8fde5", null, "admin", "ADMIN" },
                    { "3c175329-9a33-40b2-93e0-f6f67030db67", null, "client", "CLIENT" }
                });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 1,
                column: "Deadline",
                value: new DateTime(2025, 2, 2, 12, 39, 58, 439, DateTimeKind.Local).AddTicks(7624));

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 2,
                column: "Deadline",
                value: new DateTime(2025, 2, 2, 12, 39, 58, 439, DateTimeKind.Local).AddTicks(7633));

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "SubmissionTime",
                value: new DateTime(2025, 1, 2, 12, 39, 58, 439, DateTimeKind.Local).AddTicks(7651));

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "SubmissionTime",
                value: new DateTime(2025, 1, 2, 12, 39, 58, 439, DateTimeKind.Local).AddTicks(7655));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 1,
                column: "ContractDate",
                value: new DateTime(2020, 1, 2, 12, 39, 58, 439, DateTimeKind.Local).AddTicks(7413));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 2,
                column: "ContractDate",
                value: new DateTime(2022, 1, 2, 12, 39, 58, 439, DateTimeKind.Local).AddTicks(7510));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0b50a96f-f634-4a24-a857-ad4c7ef8fde5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3c175329-9a33-40b2-93e0-f6f67030db67");

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
    }
}
