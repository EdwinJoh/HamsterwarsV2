using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HamsterwarsV2.Migrations
{
    public partial class initalData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Hamsters",
                columns: new[] { "HamsterId", "Age", "Defeats", "FavFood", "Games", "ImgName", "Loves", "Name", "Wins" },
                values: new object[] { 2, 2, 1, "Kottleter", 2, "hamster-1.jpg", "Inte mycket", "Edwin", 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "HamsterId",
                keyValue: 2);
        }
    }
}
