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
            migrationBuilder.UpdateData(
                table: "Accommmodation",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2024, 12, 2, 20, 27, 34, 314, DateTimeKind.Local).AddTicks(7410), new DateTime(2024, 12, 2, 20, 27, 34, 314, DateTimeKind.Local).AddTicks(7398) });

            migrationBuilder.UpdateData(
                table: "Accommmodation",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2024, 12, 2, 20, 27, 34, 314, DateTimeKind.Local).AddTicks(7416), new DateTime(2024, 12, 2, 20, 27, 34, 314, DateTimeKind.Local).AddTicks(7415) });

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2024, 12, 2, 20, 27, 34, 314, DateTimeKind.Local).AddTicks(7659), new DateTime(2024, 12, 2, 20, 27, 34, 314, DateTimeKind.Local).AddTicks(7658) });

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2024, 12, 2, 20, 27, 34, 314, DateTimeKind.Local).AddTicks(7662), new DateTime(2024, 12, 2, 20, 27, 34, 314, DateTimeKind.Local).AddTicks(7662) });

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
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "743d876b-f5ed-40a6-ac6e-90cddf86301a", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAENrdvK3+QXbn7RnzDCj+yCv6gtYRzvw9P2hFJ4CjuZw0fcYQeKhYEMiekCcWNY2isQ==", null, false, "2aab6241-400c-41e5-b6ab-e2c3717e9b5d", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Transportation",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2024, 12, 2, 20, 27, 34, 314, DateTimeKind.Local).AddTicks(7795), new DateTime(2024, 12, 2, 20, 27, 34, 314, DateTimeKind.Local).AddTicks(7795) });

            migrationBuilder.UpdateData(
                table: "Transportation",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2024, 12, 2, 20, 27, 34, 314, DateTimeKind.Local).AddTicks(7799), new DateTime(2024, 12, 2, 20, 27, 34, 314, DateTimeKind.Local).AddTicks(7799) });

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

            migrationBuilder.UpdateData(
                table: "Accommmodation",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2024, 12, 2, 20, 20, 42, 984, DateTimeKind.Local).AddTicks(3598), new DateTime(2024, 12, 2, 20, 20, 42, 984, DateTimeKind.Local).AddTicks(3577) });

            migrationBuilder.UpdateData(
                table: "Accommmodation",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2024, 12, 2, 20, 20, 42, 984, DateTimeKind.Local).AddTicks(3610), new DateTime(2024, 12, 2, 20, 20, 42, 984, DateTimeKind.Local).AddTicks(3608) });

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2024, 12, 2, 20, 20, 42, 984, DateTimeKind.Local).AddTicks(4106), new DateTime(2024, 12, 2, 20, 20, 42, 984, DateTimeKind.Local).AddTicks(4104) });

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2024, 12, 2, 20, 20, 42, 984, DateTimeKind.Local).AddTicks(4114), new DateTime(2024, 12, 2, 20, 20, 42, 984, DateTimeKind.Local).AddTicks(4112) });

            migrationBuilder.UpdateData(
                table: "Transportation",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2024, 12, 2, 20, 20, 42, 984, DateTimeKind.Local).AddTicks(4314), new DateTime(2024, 12, 2, 20, 20, 42, 984, DateTimeKind.Local).AddTicks(4313) });

            migrationBuilder.UpdateData(
                table: "Transportation",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataUpdated", "DateCreated" },
                values: new object[] { new DateTime(2024, 12, 2, 20, 20, 42, 984, DateTimeKind.Local).AddTicks(4322), new DateTime(2024, 12, 2, 20, 20, 42, 984, DateTimeKind.Local).AddTicks(4321) });
        }
    }
}
