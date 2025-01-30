using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelPlanning.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c03a20bc-cbd0-4222-8822-2d328aba0e2f", "AQAAAAIAAYagAAAAEOFqqitHvUubjTjs0T/88Eh/TZz0F3I1/2pxKqc2DxoydEh2PkvSuNZM5AtsEav6eg==", "570c0f1b-2c68-4d2d-962b-a12a11e52ef5" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1c75f888-d1e6-4bdd-9f20-04297888aa5c", "AQAAAAIAAYagAAAAEJuxH5tacpzXPFsfpqB76GwmzKCHbV96n+wQYzxGRCU3AdxHOzgB/kzSyLmeYRfKXA==", "39817c49-1aaf-4e24-9799-91b585e7b024" });
        }
    }
}
