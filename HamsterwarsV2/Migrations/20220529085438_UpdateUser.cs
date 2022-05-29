using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HamsterwarsV2.Migrations
{
    public partial class UpdateUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b20cdd4c-7d27-4bdb-92e5-204d45299854");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "db6ef37d-9e6c-44f0-8df1-128da301f3c6");

            migrationBuilder.RenameColumn(
                name: "FirsName",
                table: "AspNetUsers",
                newName: "FirstName");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a6e772e2-345c-4ddd-b82d-98a45c59ab1c", "9ca53e00-310b-4992-995c-e9a0b3734e8d", "User", "USER" },
                    { "c21e7f5c-fe44-4a51-817b-aa60135ae3c6", "ea04c2f3-df9a-43d5-87a9-bb89d760aaec", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 1,
                column: "Timestamp",
                value: new DateTime(2022, 5, 29, 10, 54, 37, 765, DateTimeKind.Local).AddTicks(7500));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 2,
                column: "Timestamp",
                value: new DateTime(2022, 5, 29, 10, 54, 37, 765, DateTimeKind.Local).AddTicks(7504));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a6e772e2-345c-4ddd-b82d-98a45c59ab1c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c21e7f5c-fe44-4a51-817b-aa60135ae3c6");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "AspNetUsers",
                newName: "FirsName");

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
    }
}
