using Microsoft.EntityFrameworkCore.Migrations;

namespace TexasHoldEmRyberg.Migrations
{
    public partial class cardBack : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "CardId", "CardImg", "Suit", "Value" },
                values: new object[] { 53, "cardback.jpg", "Back", "Back" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 53);
        }
    }
}
