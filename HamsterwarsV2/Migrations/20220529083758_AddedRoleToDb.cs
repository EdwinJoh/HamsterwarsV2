using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HamsterwarsV2.Migrations
{
    public partial class AddedRoleToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "b20cdd4c-7d27-4bdb-92e5-204d45299854", "cf1ef864-b0fe-4ad1-83ed-5eb7c1c8f82b", "User", "USER" },
                    { "db6ef37d-9e6c-44f0-8df1-128da301f3c6", "34f28162-0c4a-460c-b352-e27187d7abf6", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 1,
                column: "Timestamp",
                value: new DateTime(2022, 5, 29, 10, 37, 58, 286, DateTimeKind.Local).AddTicks(4825));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 2,
                column: "Timestamp",
                value: new DateTime(2022, 5, 29, 10, 37, 58, 286, DateTimeKind.Local).AddTicks(4828));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b20cdd4c-7d27-4bdb-92e5-204d45299854");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "db6ef37d-9e6c-44f0-8df1-128da301f3c6");

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 1,
                column: "Timestamp",
                value: new DateTime(2022, 5, 29, 10, 34, 29, 123, DateTimeKind.Local).AddTicks(7519));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 2,
                column: "Timestamp",
                value: new DateTime(2022, 5, 29, 10, 34, 29, 123, DateTimeKind.Local).AddTicks(7530));
        }
    }
}
