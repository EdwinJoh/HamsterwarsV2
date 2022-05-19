using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HamsterwarsV2.Migrations
{
    public partial class seedMatches : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "LoserId", "Timestamp", "WinnerId" },
                values: new object[] { 1, 2, new DateTime(2022, 5, 19, 14, 45, 53, 496, DateTimeKind.Local).AddTicks(1885), 1 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "LoserId", "Timestamp", "WinnerId" },
                values: new object[] { 2, 4, new DateTime(2022, 5, 19, 14, 45, 53, 496, DateTimeKind.Local).AddTicks(1932), 2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
