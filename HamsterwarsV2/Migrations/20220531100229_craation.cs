using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HamsterwarsV2.Migrations
{
    public partial class craation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hamsters",
                columns: table => new
                {
                    HamsterId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    FavFood = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Loves = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ImgName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Wins = table.Column<int>(type: "int", nullable: false),
                    Defeats = table.Column<int>(type: "int", nullable: false),
                    Games = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hamsters", x => x.HamsterId);
                });

            migrationBuilder.CreateTable(
                name: "Matches",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WinnerId = table.Column<int>(type: "int", nullable: false),
                    LoserId = table.Column<int>(type: "int", nullable: false),
                    Timestamp = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Matches", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Hamsters",
                columns: new[] { "HamsterId", "Age", "Defeats", "FavFood", "Games", "ImgName", "Loves", "Name", "Wins" },
                values: new object[,]
                {
                    { 1, 2, 0, "Kottleter", 0, "hamster-1.jpg", "Inte mycket", "Arvy", 0 },
                    { 2, 2, 0, "Kottleter", 0, "hamster-2.jpg", "Inte mycket", "Unexpected", 0 },
                    { 3, 2, 0, "Kottleter", 0, "hamster-3.jpg", "Inte mycket", "Sonny", 0 },
                    { 4, 2, 0, "Kottleter", 0, "hamster-4.jpg", "Inte mycket", "Atlanta", 0 },
                    { 5, 2, 0, "Kottleter", 0, "hamster-5.jpg", "Inte mycket", "Galaxy", 0 },
                    { 6, 2, 0, "Kottleter", 0, "hamster-6.jpg", "Inte mycket", "Piper", 0 },
                    { 7, 2, 0, "Kottleter", 0, "hamster-7.jpg", "Inte mycket", "Bliss", 0 },
                    { 8, 2, 0, "Kottleter", 0, "hamster-8.jpg", "Inte mycket", "Tyson", 0 },
                    { 9, 2, 0, "Kottleter", 0, "hamster-9.jpg", "Inte mycket", "Hugh Heifer", 0 },
                    { 10, 2, 0, "Kottleter", 0, "hamster-10.jpg", "Inte mycket", "Fury", 0 },
                    { 11, 2, 0, "Kottleter", 0, "hamster-11.jpg", "Inte mycket", "Duke", 0 },
                    { 12, 2, 0, "Kottleter", 0, "hamster-12.jpg", "Inte mycket", "Marvin", 0 },
                    { 13, 2, 0, "Kottleter", 0, "hamster-13.jpg", "Inte mycket", "Nexus", 0 },
                    { 14, 2, 0, "Kottleter", 0, "hamster-14.jpg", "Inte mycket", "Cherry", 0 },
                    { 15, 2, 0, "Kottleter", 0, "hamster-15.jpg", "Inte mycket", "Lollipop", 0 },
                    { 16, 2, 0, "Kottleter", 0, "hamster-16.jpg", "Inte mycket", "Olive", 0 },
                    { 17, 2, 0, "Kottleter", 0, "hamster-17.jpg", "Inte mycket", "Spiral", 0 },
                    { 18, 2, 0, "Kottleter", 0, "hamster-18.jpg", "Inte mycket", "Pulsar", 0 },
                    { 19, 2, 0, "Kottleter", 0, "hamster-19.jpg", "Inte mycket", "Cartman", 0 },
                    { 20, 2, 0, "Kottleter", 0, "hamster-20.jpg", "Inte mycket", "Keroppi", 0 },
                    { 21, 2, 0, "Kottleter", 0, "hamster-21.jpg", "Inte mycket", "Froggo", 0 },
                    { 22, 2, 0, "Kottleter", 0, "hamster-22.jpg", "Inte mycket", "Big Daddy", 0 },
                    { 23, 2, 0, "Kottleter", 0, "hamster-23.jpg", "Inte mycket", "Bubbles", 0 },
                    { 24, 2, 0, "Kottleter", 0, "hamster-24.jpg", "Inte mycket", "Captain Hook", 0 },
                    { 25, 2, 0, "Kottleter", 0, "hamster-25.jpg", "Inte mycket", "Harry", 0 },
                    { 26, 2, 0, "Kottleter", 0, "hamster-26.jpg", "Inte mycket", "Shelldon", 0 },
                    { 27, 2, 0, "Kottleter", 0, "hamster-27.jpg", "Inte mycket", "Bob", 0 },
                    { 28, 2, 0, "Kottleter", 0, "hamster-28.jpg", "Inte mycket", "Molly", 0 },
                    { 29, 2, 0, "Kottleter", 0, "hamster-29.jpg", "Inte mycket", "Shelly", 0 },
                    { 30, 2, 0, "Kottleter", 0, "hamster-30.jpg", "Inte mycket", "Claude", 0 },
                    { 31, 2, 0, "Kottleter", 0, "hamster-31.jpg", "Inte mycket", "Backspace", 0 },
                    { 32, 2, 0, "Kottleter", 0, "hamster-32.jpg", "Inte mycket", "Big Mac", 0 },
                    { 33, 2, 0, "Kottleter", 0, "hamster-33.jpg", "Inte mycket", "Goody", 0 },
                    { 34, 2, 0, "Kottleter", 0, "hamster-34.jpg", "Inte mycket", "Alie", 0 },
                    { 35, 2, 0, "Kottleter", 0, "hamster-35.jpg", "Inte mycket", "Ninja", 0 },
                    { 36, 2, 0, "Kottleter", 0, "hamster-36.jpg", "Inte mycket", "Lucifer", 0 },
                    { 37, 2, 0, "Kottleter", 0, "hamster-37.jpg", "Inte mycket", "God", 0 },
                    { 38, 2, 0, "Kottleter", 0, "hamster-38.jpg", "Inte mycket", "Casper", 0 },
                    { 39, 2, 0, "Kottleter", 0, "hamster-39.jpg", "Inte mycket", "Kevin", 0 },
                    { 40, 2, 0, "Kottleter", 0, "hamster-40.jpg", "Inte mycket", "Lucifer", 0 }
                });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "LoserId", "Timestamp", "WinnerId" },
                values: new object[,]
                {
                    { 1, 2, new DateTime(2022, 5, 31, 12, 2, 28, 858, DateTimeKind.Local).AddTicks(5652), 1 },
                    { 2, 4, new DateTime(2022, 5, 31, 12, 2, 28, 858, DateTimeKind.Local).AddTicks(5656), 2 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hamsters");

            migrationBuilder.DropTable(
                name: "Matches");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
