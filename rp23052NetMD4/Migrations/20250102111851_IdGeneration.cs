using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace rp23052NetMD4.Migrations
{
    /// <inheritdoc />
    public partial class IdGeneration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "85656b6c-8c5d-47ce-900f-d0970b9f2b60", null, "admin", "ADMIN" },
                    { "d54f60b3-2e50-412b-8a1c-79ad48cc8ea7", null, "client", "CLIENT" }
                });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 1,
                column: "Deadline",
                value: new DateTime(2025, 2, 2, 13, 18, 50, 912, DateTimeKind.Local).AddTicks(2038));

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 2,
                column: "Deadline",
                value: new DateTime(2025, 2, 2, 13, 18, 50, 912, DateTimeKind.Local).AddTicks(2044));

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "SubmissionTime",
                value: new DateTime(2025, 1, 2, 13, 18, 50, 912, DateTimeKind.Local).AddTicks(2083));

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "SubmissionTime",
                value: new DateTime(2025, 1, 2, 13, 18, 50, 912, DateTimeKind.Local).AddTicks(2085));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 1,
                column: "ContractDate",
                value: new DateTime(2020, 1, 2, 13, 18, 50, 912, DateTimeKind.Local).AddTicks(1934));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 2,
                column: "ContractDate",
                value: new DateTime(2022, 1, 2, 13, 18, 50, 912, DateTimeKind.Local).AddTicks(1989));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "85656b6c-8c5d-47ce-900f-d0970b9f2b60");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d54f60b3-2e50-412b-8a1c-79ad48cc8ea7");

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
    }
}
