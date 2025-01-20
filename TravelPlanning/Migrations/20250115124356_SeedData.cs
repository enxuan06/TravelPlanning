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
                values: new object[] { new DateTime(2025, 1, 15, 20, 43, 55, 730, DateTimeKind.Local).AddTicks(6821), new DateTime(2025, 1, 15, 20, 43, 55, 730, DateTimeKind.Local).AddTicks(6806) });

            migrationBuilder.UpdateData(
                table: "Accommmodation",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2025, 1, 15, 20, 43, 55, 730, DateTimeKind.Local).AddTicks(6827), new DateTime(2025, 1, 15, 20, 43, 55, 730, DateTimeKind.Local).AddTicks(6826) });

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2025, 1, 15, 20, 43, 55, 730, DateTimeKind.Local).AddTicks(7193), new DateTime(2025, 1, 15, 20, 43, 55, 730, DateTimeKind.Local).AddTicks(7192) });

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2025, 1, 15, 20, 43, 55, 730, DateTimeKind.Local).AddTicks(7196), new DateTime(2025, 1, 15, 20, 43, 55, 730, DateTimeKind.Local).AddTicks(7196) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d3ca848c-fb78-4a09-8bdb-6085ef79d5a5", "AQAAAAIAAYagAAAAEGzosEPai9l6OXJC3SaDYw81wIjXRwdfewc0FapyIMDOsG+DbJiNinbA3tPEiCG7vQ==", "705cff21-8740-4172-9585-ee7383e8a9c7" });

            migrationBuilder.UpdateData(
                table: "Transportation",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2025, 1, 15, 20, 43, 55, 730, DateTimeKind.Local).AddTicks(7306), new DateTime(2025, 1, 15, 20, 43, 55, 730, DateTimeKind.Local).AddTicks(7305) });

            migrationBuilder.UpdateData(
                table: "Transportation",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2025, 1, 15, 20, 43, 55, 730, DateTimeKind.Local).AddTicks(7310), new DateTime(2025, 1, 15, 20, 43, 55, 730, DateTimeKind.Local).AddTicks(7309) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Accommmodation",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2025, 1, 15, 20, 43, 4, 325, DateTimeKind.Local).AddTicks(6943), new DateTime(2025, 1, 15, 20, 43, 4, 325, DateTimeKind.Local).AddTicks(6928) });

            migrationBuilder.UpdateData(
                table: "Accommmodation",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2025, 1, 15, 20, 43, 4, 325, DateTimeKind.Local).AddTicks(6948), new DateTime(2025, 1, 15, 20, 43, 4, 325, DateTimeKind.Local).AddTicks(6947) });

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2025, 1, 15, 20, 43, 4, 325, DateTimeKind.Local).AddTicks(7293), new DateTime(2025, 1, 15, 20, 43, 4, 325, DateTimeKind.Local).AddTicks(7292) });

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2025, 1, 15, 20, 43, 4, 325, DateTimeKind.Local).AddTicks(7296), new DateTime(2025, 1, 15, 20, 43, 4, 325, DateTimeKind.Local).AddTicks(7296) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e802c6ec-5d6c-4bd9-ab46-967fae68acbf", "AQAAAAIAAYagAAAAELpNiXoA+w7xLZJV8j3OXrzdvbrWROI7mGisEqfUOagslkTcaRwen0jQWagE9yisrw==", "0843a16e-3be0-4eaf-b3d4-45a7dc764376" });

            migrationBuilder.UpdateData(
                table: "Transportation",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2025, 1, 15, 20, 43, 4, 325, DateTimeKind.Local).AddTicks(7400), new DateTime(2025, 1, 15, 20, 43, 4, 325, DateTimeKind.Local).AddTicks(7400) });

            migrationBuilder.UpdateData(
                table: "Transportation",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2025, 1, 15, 20, 43, 4, 325, DateTimeKind.Local).AddTicks(7404), new DateTime(2025, 1, 15, 20, 43, 4, 325, DateTimeKind.Local).AddTicks(7403) });
        }
    }
}
