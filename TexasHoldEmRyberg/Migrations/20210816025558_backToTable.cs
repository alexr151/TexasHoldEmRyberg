using Microsoft.EntityFrameworkCore.Migrations;

namespace TexasHoldEmRyberg.Migrations
{
    public partial class backToTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Tables",
                columns: new[] { "TableId", "CardId" },
                values: new object[] { 8, 53 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 8);
        }
    }
}
