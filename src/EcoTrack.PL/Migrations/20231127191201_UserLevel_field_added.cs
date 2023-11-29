using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EcoTrack.PL.Migrations
{
    /// <inheritdoc />
    public partial class UserLevelfieldadded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserLevel",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: -10L,
                columns: new[] { "BirthDate", "UserLevel" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 12, 0, 967, DateTimeKind.Local).AddTicks(5223), 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: -9L,
                columns: new[] { "BirthDate", "UserLevel" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 12, 0, 967, DateTimeKind.Local).AddTicks(5278), 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserLevel",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: -10L,
                column: "BirthDate",
                value: new DateTime(2023, 11, 26, 14, 47, 22, 528, DateTimeKind.Local).AddTicks(3776));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: -9L,
                column: "BirthDate",
                value: new DateTime(2023, 11, 26, 14, 47, 22, 528, DateTimeKind.Local).AddTicks(3818));
        }
    }
}
