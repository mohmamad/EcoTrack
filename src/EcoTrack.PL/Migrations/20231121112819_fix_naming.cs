using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EcoTrack.PL.Migrations
{
    /// <inheritdoc />
    public partial class fixnaming : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Deleteed",
                table: "Users",
                newName: "Deleted");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: -10L,
                column: "BirthDate",
                value: new DateTime(2023, 11, 21, 13, 28, 19, 135, DateTimeKind.Local).AddTicks(3414));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: -9L,
                column: "BirthDate",
                value: new DateTime(2023, 11, 21, 13, 28, 19, 135, DateTimeKind.Local).AddTicks(3463));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Deleted",
                table: "Users",
                newName: "Deleteed");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: -10L,
                column: "BirthDate",
                value: new DateTime(2023, 11, 20, 16, 28, 55, 174, DateTimeKind.Local).AddTicks(9656));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: -9L,
                column: "BirthDate",
                value: new DateTime(2023, 11, 20, 16, 28, 55, 174, DateTimeKind.Local).AddTicks(9695));
        }
    }
}
