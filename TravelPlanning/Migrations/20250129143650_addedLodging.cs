using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelPlanning.Migrations
{
    /// <inheritdoc />
    public partial class addedLodging : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b83d6b17-e865-408e-9b38-b92660de28fc", "AQAAAAIAAYagAAAAEHjDu0XRck9ewwK8xl4NBclBXvwQgU7lRiLggOQZrck7Fchd7JbFGwQF3YPaNeVNwQ==", "253d686f-bb14-4556-8537-93305fc7100a" });
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
