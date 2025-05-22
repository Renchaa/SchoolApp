using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace rp23052NetMD4.Migrations
{
    /// <inheritdoc />
    public partial class RemoveUserTypes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "9a898295-3351-4be4-85e8-10fcc992a78f", null, "admin", "admin" },
                    { "efbfc70e-a001-4d39-8f39-a273217de2c4", null, "client", "client" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9a898295-3351-4be4-85e8-10fcc992a78f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "efbfc70e-a001-4d39-8f39-a273217de2c4");

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
    }
}
