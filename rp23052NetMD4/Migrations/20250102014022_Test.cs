using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace rp23052NetMD4.Migrations
{
    /// <inheritdoc />
    public partial class Test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "043215fe-d6a7-4c9c-bdb9-0903f80e049b", null, "admin", "admin" },
                    { "f7e40e48-91ee-4f60-a45d-7351e6fc436e", null, "client", "client" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "043215fe-d6a7-4c9c-bdb9-0903f80e049b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f7e40e48-91ee-4f60-a45d-7351e6fc436e");

            

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "9a898295-3351-4be4-85e8-10fcc992a78f", null, "admin", "admin" },
                    { "efbfc70e-a001-4d39-8f39-a273217de2c4", null, "client", "client" }
                });
        }
    }
}
