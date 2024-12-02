using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TravelPlanning.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Accommmodation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PricePerNight = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accommmodation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Activity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Duration = table.Column<int>(type: "int", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Activity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Destination",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ActivityId = table.Column<int>(type: "int", nullable: false),
                    TransportId = table.Column<int>(type: "int", nullable: false),
                    AccomId = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Destination", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Transportation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartLocation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EndLocation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cost = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transportation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ItineraryPlan",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Activities = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Budget = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    DestinationId = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItineraryPlan", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItineraryPlan_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Accommmodation",
                columns: new[] { "Id", "Address", "CreatedBy", "DataUpdated", "DateCreated", "EndDate", "Name", "PricePerNight", "StartDate", "Type", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, null, "System", new DateTime(2024, 12, 2, 16, 4, 9, 915, DateTimeKind.Local).AddTicks(7886), new DateTime(2024, 12, 2, 16, 4, 9, 915, DateTimeKind.Local).AddTicks(7874), new DateTime(2024, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Park View Hotel", 80.50m, new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hotel", "System" },
                    { 2, null, "System", new DateTime(2024, 12, 2, 16, 4, 9, 915, DateTimeKind.Local).AddTicks(7890), new DateTime(2024, 12, 2, 16, 4, 9, 915, DateTimeKind.Local).AddTicks(7890), new DateTime(2024, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "KSL Hotel & Resort", 80.50m, new DateTime(2024, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Motel", "System" }
                });

            migrationBuilder.InsertData(
                table: "Activity",
                columns: new[] { "Id", "CreatedBy", "DataUpdated", "DateCreated", "Duration", "Location", "Name", "Type", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 12, 2, 16, 4, 9, 915, DateTimeKind.Local).AddTicks(8055), new DateTime(2024, 12, 2, 16, 4, 9, 915, DateTimeKind.Local).AddTicks(8054), 1, "Bugis", "Visit Sultan Mosque", "Religious and Cultural Landmark", "System" },
                    { 2, "System", new DateTime(2024, 12, 2, 16, 4, 9, 915, DateTimeKind.Local).AddTicks(8057), new DateTime(2024, 12, 2, 16, 4, 9, 915, DateTimeKind.Local).AddTicks(8057), 2, "Juhor", "LEGOLAND Malaysia", "Theme Park", "System" }
                });

            migrationBuilder.InsertData(
                table: "Transportation",
                columns: new[] { "Id", "Cost", "CreatedBy", "DataUpdated", "DateCreated", "EndLocation", "StartLocation", "Type", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, 150.50m, "System", new DateTime(2024, 12, 2, 16, 4, 9, 915, DateTimeKind.Local).AddTicks(8121), new DateTime(2024, 12, 2, 16, 4, 9, 915, DateTimeKind.Local).AddTicks(8120), "Bugis", "Tampines", "Boat", "System" },
                    { 2, 60.50m, "System", new DateTime(2024, 12, 2, 16, 4, 9, 915, DateTimeKind.Local).AddTicks(8124), new DateTime(2024, 12, 2, 16, 4, 9, 915, DateTimeKind.Local).AddTicks(8123), "Juhor", "Kuala Lumpur", "AirPlane", "System" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ItineraryPlan_UserId",
                table: "ItineraryPlan",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Accommmodation");

            migrationBuilder.DropTable(
                name: "Activity");

            migrationBuilder.DropTable(
                name: "Destination");

            migrationBuilder.DropTable(
                name: "ItineraryPlan");

            migrationBuilder.DropTable(
                name: "Transportation");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
