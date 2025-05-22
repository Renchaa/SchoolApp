using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace rp23052NetMD4.Migrations
{
    /// <inheritdoc />
    public partial class UsersUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6477acd8-176b-404c-a9df-ffedb4a8e68b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cdcf58fe-cd91-441a-a2a3-c430a115a9a1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "def30a42-5cd2-4535-b212-4036fc2887c2");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "70e500d7-ee8c-4b3d-a6a0-809e7352ad5d", null, "seller", "seller" },
                    { "72434935-9c87-49b8-9e05-8359cf31aa3f", null, "client", "client" },
                    { "f5e38b08-a1ec-4b08-8e6b-51621f8a39ee", null, "admin", "admin" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "70e500d7-ee8c-4b3d-a6a0-809e7352ad5d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "72434935-9c87-49b8-9e05-8359cf31aa3f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f5e38b08-a1ec-4b08-8e6b-51621f8a39ee");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6477acd8-176b-404c-a9df-ffedb4a8e68b", null, "admin", "admin" },
                    { "cdcf58fe-cd91-441a-a2a3-c430a115a9a1", null, "client", "client" },
                    { "def30a42-5cd2-4535-b212-4036fc2887c2", null, "seller", "seller" }
                });
        }
    }
}
