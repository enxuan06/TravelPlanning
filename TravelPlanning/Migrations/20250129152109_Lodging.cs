using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelPlanning.Migrations
{
    /// <inheritdoc />
    public partial class Lodging : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1c75f888-d1e6-4bdd-9f20-04297888aa5c", "AQAAAAIAAYagAAAAEJuxH5tacpzXPFsfpqB76GwmzKCHbV96n+wQYzxGRCU3AdxHOzgB/kzSyLmeYRfKXA==", "39817c49-1aaf-4e24-9799-91b585e7b024" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a436e3dd-2d5b-4731-b7cc-8c24b5502fba", "AQAAAAIAAYagAAAAEAnCumfajiva1NEwT1FcFrW7dC6nrr1Y9A4LfQ5TyCQ7aMV1bED5DkFR6LJHU/gk0g==", "fb89e354-9e5e-47b6-890a-a828069af0d3" });
        }
    }
}
