using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelPlanning.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Accommmodation",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2024, 12, 2, 16, 5, 1, 178, DateTimeKind.Local).AddTicks(3948), new DateTime(2024, 12, 2, 16, 5, 1, 178, DateTimeKind.Local).AddTicks(3935) });

            migrationBuilder.UpdateData(
                table: "Accommmodation",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2024, 12, 2, 16, 5, 1, 178, DateTimeKind.Local).AddTicks(3952), new DateTime(2024, 12, 2, 16, 5, 1, 178, DateTimeKind.Local).AddTicks(3951) });

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2024, 12, 2, 16, 5, 1, 178, DateTimeKind.Local).AddTicks(4275), new DateTime(2024, 12, 2, 16, 5, 1, 178, DateTimeKind.Local).AddTicks(4275) });

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2024, 12, 2, 16, 5, 1, 178, DateTimeKind.Local).AddTicks(4279), new DateTime(2024, 12, 2, 16, 5, 1, 178, DateTimeKind.Local).AddTicks(4278) });

            migrationBuilder.UpdateData(
                table: "Transportation",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2024, 12, 2, 16, 5, 1, 178, DateTimeKind.Local).AddTicks(4358), new DateTime(2024, 12, 2, 16, 5, 1, 178, DateTimeKind.Local).AddTicks(4357) });

            migrationBuilder.UpdateData(
                table: "Transportation",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2024, 12, 2, 16, 5, 1, 178, DateTimeKind.Local).AddTicks(4361), new DateTime(2024, 12, 2, 16, 5, 1, 178, DateTimeKind.Local).AddTicks(4360) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Accommmodation",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2024, 12, 2, 16, 4, 9, 915, DateTimeKind.Local).AddTicks(7886), new DateTime(2024, 12, 2, 16, 4, 9, 915, DateTimeKind.Local).AddTicks(7874) });

            migrationBuilder.UpdateData(
                table: "Accommmodation",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2024, 12, 2, 16, 4, 9, 915, DateTimeKind.Local).AddTicks(7890), new DateTime(2024, 12, 2, 16, 4, 9, 915, DateTimeKind.Local).AddTicks(7890) });

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2024, 12, 2, 16, 4, 9, 915, DateTimeKind.Local).AddTicks(8055), new DateTime(2024, 12, 2, 16, 4, 9, 915, DateTimeKind.Local).AddTicks(8054) });

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2024, 12, 2, 16, 4, 9, 915, DateTimeKind.Local).AddTicks(8057), new DateTime(2024, 12, 2, 16, 4, 9, 915, DateTimeKind.Local).AddTicks(8057) });

            migrationBuilder.UpdateData(
                table: "Transportation",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2024, 12, 2, 16, 4, 9, 915, DateTimeKind.Local).AddTicks(8121), new DateTime(2024, 12, 2, 16, 4, 9, 915, DateTimeKind.Local).AddTicks(8120) });

            migrationBuilder.UpdateData(
                table: "Transportation",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2024, 12, 2, 16, 4, 9, 915, DateTimeKind.Local).AddTicks(8124), new DateTime(2024, 12, 2, 16, 4, 9, 915, DateTimeKind.Local).AddTicks(8123) });
        }
    }
}
