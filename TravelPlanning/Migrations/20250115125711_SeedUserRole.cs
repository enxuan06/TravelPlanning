using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelPlanning.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Accommmodation",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2025, 1, 15, 20, 57, 10, 429, DateTimeKind.Local).AddTicks(7242), new DateTime(2025, 1, 15, 20, 57, 10, 429, DateTimeKind.Local).AddTicks(7227) });

            migrationBuilder.UpdateData(
                table: "Accommmodation",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2025, 1, 15, 20, 57, 10, 429, DateTimeKind.Local).AddTicks(7247), new DateTime(2025, 1, 15, 20, 57, 10, 429, DateTimeKind.Local).AddTicks(7247) });

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2025, 1, 15, 20, 57, 10, 429, DateTimeKind.Local).AddTicks(7549), new DateTime(2025, 1, 15, 20, 57, 10, 429, DateTimeKind.Local).AddTicks(7548) });

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2025, 1, 15, 20, 57, 10, 429, DateTimeKind.Local).AddTicks(7552), new DateTime(2025, 1, 15, 20, 57, 10, 429, DateTimeKind.Local).AddTicks(7551) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "004a2917-eda6-4f41-b5da-06ec899b6dac", "AQAAAAIAAYagAAAAEN2nGt1VZgIqZht9m3pGIWaO+faX3B9YE23gAcaq5Eb0znfmpLzLyKblvH3xydlAUw==", "9ce3224e-30f6-441c-982e-320e020c82fc" });

            migrationBuilder.UpdateData(
                table: "Transportation",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2025, 1, 15, 20, 57, 10, 429, DateTimeKind.Local).AddTicks(7665), new DateTime(2025, 1, 15, 20, 57, 10, 429, DateTimeKind.Local).AddTicks(7664) });

            migrationBuilder.UpdateData(
                table: "Transportation",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2025, 1, 15, 20, 57, 10, 429, DateTimeKind.Local).AddTicks(7669), new DateTime(2025, 1, 15, 20, 57, 10, 429, DateTimeKind.Local).AddTicks(7668) });

            migrationBuilder.CreateIndex(
                name: "IX_ItineraryPlan_DestinationId",
                table: "ItineraryPlan",
                column: "DestinationId");

            migrationBuilder.AddForeignKey(
                name: "FK_ItineraryPlan_Destination_DestinationId",
                table: "ItineraryPlan",
                column: "DestinationId",
                principalTable: "Destination",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItineraryPlan_Destination_DestinationId",
                table: "ItineraryPlan");

            migrationBuilder.DropIndex(
                name: "IX_ItineraryPlan_DestinationId",
                table: "ItineraryPlan");

            migrationBuilder.UpdateData(
                table: "Accommmodation",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2025, 1, 15, 20, 50, 57, 419, DateTimeKind.Local).AddTicks(2744), new DateTime(2025, 1, 15, 20, 50, 57, 419, DateTimeKind.Local).AddTicks(2730) });

            migrationBuilder.UpdateData(
                table: "Accommmodation",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2025, 1, 15, 20, 50, 57, 419, DateTimeKind.Local).AddTicks(2750), new DateTime(2025, 1, 15, 20, 50, 57, 419, DateTimeKind.Local).AddTicks(2749) });

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2025, 1, 15, 20, 50, 57, 419, DateTimeKind.Local).AddTicks(2990), new DateTime(2025, 1, 15, 20, 50, 57, 419, DateTimeKind.Local).AddTicks(2990) });

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2025, 1, 15, 20, 50, 57, 419, DateTimeKind.Local).AddTicks(2994), new DateTime(2025, 1, 15, 20, 50, 57, 419, DateTimeKind.Local).AddTicks(2993) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f09bd0fc-967e-4333-b416-ddc48594ac41", "AQAAAAIAAYagAAAAEEZtIaTeJjTfyiFWdxNJxMjM/liTy04VwC/f0ykXZTmjMzpkhZqot8ERY/aX29yWsg==", "0d287aac-6977-4f2d-8602-3fc7e89224f8" });

            migrationBuilder.UpdateData(
                table: "Transportation",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2025, 1, 15, 20, 50, 57, 419, DateTimeKind.Local).AddTicks(3188), new DateTime(2025, 1, 15, 20, 50, 57, 419, DateTimeKind.Local).AddTicks(3187) });

            migrationBuilder.UpdateData(
                table: "Transportation",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2025, 1, 15, 20, 50, 57, 419, DateTimeKind.Local).AddTicks(3192), new DateTime(2025, 1, 15, 20, 50, 57, 419, DateTimeKind.Local).AddTicks(3191) });
        }
    }
}
