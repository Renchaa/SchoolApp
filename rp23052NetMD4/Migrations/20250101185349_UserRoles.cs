using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable


namespace rp23052NetMD4.Migrations
{
    /// <inheritdoc />
    public partial class UserRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6477acd8-176b-404c-a9df-ffedb4a8e68b", null, "admin", "admin" },
                    { "cdcf58fe-cd91-441a-a2a3-c430a115a9a1", null, "client", "client" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6477acd8-176b-404c-a9df-ffedb4a8e68b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cdcf58fe-cd91-441a-a2a3-c430a115a9a1");
        }
    }
}
