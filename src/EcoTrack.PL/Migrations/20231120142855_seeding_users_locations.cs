using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EcoTrack.PL.Migrations
{
    /// <inheritdoc />
    public partial class seedinguserslocations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "LocationId", "CityName", "CountryName" },
                values: new object[,]
                {
                    { -10L, "Nablus", "Palestine" },
                    { -9L, "Jenin", "Palestine" },
                    { -8L, "Tokyo", "Japan" },
                    { -7L, "Seoul", "North Korea" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "BirthDate", "Deleteed", "Email", "FirstName", "LastName", "LocationId", "Password", "Username" },
                values: new object[,]
                {
                    { -10L, new DateTime(2023, 11, 20, 16, 28, 55, 174, DateTimeKind.Local).AddTicks(9656), false, "morsee@egy.pt", "Mer'e", "Pharaoh", -10L, "5e884898da28047151d0e56f8dc6292773603d0d6aabbdd62a11ef721d1542d8", "morse" },
                    { -9L, new DateTime(2023, 11, 20, 16, 28, 55, 174, DateTimeKind.Local).AddTicks(9695), false, "moghrabi@egy.pt", "Sal", "Tan", -8L, "5e884898da28047151d0e56f8dc6292773603d0d6aabbdd62a11ef721d1542d8", "mohammad" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: -9L);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: -7L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: -10L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: -9L);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: -10L);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: -8L);
        }
    }
}
