using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelPlanning.Migrations
{
    /// <inheritdoc />
    public partial class AddIdentity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItineraryPlan_Destination_DestinationId",
                table: "ItineraryPlan");

            migrationBuilder.DropIndex(
                name: "IX_ItineraryPlan_DestinationId",
                table: "ItineraryPlan");

            migrationBuilder.DropColumn(
                name: "ItineraryId",
                table: "Destination");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ItineraryId",
                table: "Destination",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.CreateIndex(
                name: "IX_ItineraryPlan_DestinationId",
                table: "ItineraryPlan",
                column: "DestinationId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ItineraryPlan_Destination_DestinationId",
                table: "ItineraryPlan",
                column: "DestinationId",
                principalTable: "Destination",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
