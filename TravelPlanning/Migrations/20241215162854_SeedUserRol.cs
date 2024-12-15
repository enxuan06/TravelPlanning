using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TravelPlanning.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Accommmodation",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2024, 12, 16, 0, 28, 53, 133, DateTimeKind.Local).AddTicks(9752), new DateTime(2024, 12, 16, 0, 28, 53, 133, DateTimeKind.Local).AddTicks(9730) });

            migrationBuilder.UpdateData(
                table: "Accommmodation",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2024, 12, 16, 0, 28, 53, 133, DateTimeKind.Local).AddTicks(9757), new DateTime(2024, 12, 16, 0, 28, 53, 133, DateTimeKind.Local).AddTicks(9756) });

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2024, 12, 16, 0, 28, 53, 134, DateTimeKind.Local).AddTicks(55), new DateTime(2024, 12, 16, 0, 28, 53, 134, DateTimeKind.Local).AddTicks(54) });

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2024, 12, 16, 0, 28, 53, 134, DateTimeKind.Local).AddTicks(59), new DateTime(2024, 12, 16, 0, 28, 53, 134, DateTimeKind.Local).AddTicks(58) });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "c6dc11a8-f0ca-4ef1-92c2-8a5328d30cf4", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEBkLS62F5skmalnbUXbg4yRMhIjxluntic42rYoYX8/P9RZ7oyz6nrZEdpNGbUlnRQ==", null, false, "a10f26c5-2e48-4e46-bf6f-c08cb255161c", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Transportation",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2024, 12, 16, 0, 28, 53, 134, DateTimeKind.Local).AddTicks(196), new DateTime(2024, 12, 16, 0, 28, 53, 134, DateTimeKind.Local).AddTicks(195) });

            migrationBuilder.UpdateData(
                table: "Transportation",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2024, 12, 16, 0, 28, 53, 134, DateTimeKind.Local).AddTicks(200), new DateTime(2024, 12, 16, 0, 28, 53, 134, DateTimeKind.Local).AddTicks(200) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Accommmodation",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2024, 12, 2, 16, 35, 22, 502, DateTimeKind.Local).AddTicks(9847), new DateTime(2024, 12, 2, 16, 35, 22, 502, DateTimeKind.Local).AddTicks(9830) });

            migrationBuilder.UpdateData(
                table: "Accommmodation",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2024, 12, 2, 16, 35, 22, 502, DateTimeKind.Local).AddTicks(9856), new DateTime(2024, 12, 2, 16, 35, 22, 502, DateTimeKind.Local).AddTicks(9855) });

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2024, 12, 2, 16, 35, 22, 503, DateTimeKind.Local).AddTicks(290), new DateTime(2024, 12, 2, 16, 35, 22, 503, DateTimeKind.Local).AddTicks(289) });

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2024, 12, 2, 16, 35, 22, 503, DateTimeKind.Local).AddTicks(294), new DateTime(2024, 12, 2, 16, 35, 22, 503, DateTimeKind.Local).AddTicks(293) });

            migrationBuilder.UpdateData(
                table: "Transportation",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2024, 12, 2, 16, 35, 22, 503, DateTimeKind.Local).AddTicks(468), new DateTime(2024, 12, 2, 16, 35, 22, 503, DateTimeKind.Local).AddTicks(468) });

            migrationBuilder.UpdateData(
                table: "Transportation",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2024, 12, 2, 16, 35, 22, 503, DateTimeKind.Local).AddTicks(473), new DateTime(2024, 12, 2, 16, 35, 22, 503, DateTimeKind.Local).AddTicks(472) });
        }
    }
}
