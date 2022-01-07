using Microsoft.EntityFrameworkCore.Migrations;

namespace TexasHoldEmRyberg.Migrations
{
    public partial class cardInitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cards",
                columns: table => new
                {
                    CardId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Suit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CardImg = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cards", x => x.CardId);
                });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "CardId", "CardImg", "Suit", "Value" },
                values: new object[,]
                {
                    { 1, "2_of_clubs.png", "Clubs", "Two" },
                    { 29, "4_of_diamonds.png", "Diamonds", "Four" },
                    { 30, "5_of_diamonds.png", "Diamonds", "Five" },
                    { 31, "6_of_diamonds.png", "Diamonds", "Six" },
                    { 32, "7_of_diamonds.png", "Diamonds", "Seven" },
                    { 33, "8_of_diamonds.png", "Diamonds", "Eight" },
                    { 34, "9_of_diamonds.png", "Diamonds", "Nine" },
                    { 35, "10_of_diamonds.png", "Diamonds", "Ten" },
                    { 36, "jack_of_diamonds.png", "Diamonds", "Jack" },
                    { 37, "queen_of_diamonds.png", "Diamonds", "Queen" },
                    { 38, "king_of_diamonds.png", "Diamonds", "King" },
                    { 28, "3_of_diamonds.png", "Diamonds", "Three" },
                    { 39, "ace_of_diamonds.png", "Diamonds", "Ace" },
                    { 41, "3_of_spades.png", "Spades", "Three" },
                    { 42, "4_of_spades.png", "Spades", "Four" },
                    { 43, "5_of_spades.png", "Spades", "Five" },
                    { 44, "6_of_spades.png", "Spades", "Six" },
                    { 45, "7_of_spades.png", "Spades", "Seven" },
                    { 46, "8_of_spades.png", "Spades", "Eight" },
                    { 47, "9_of_spades.png", "Spades", "Nine" },
                    { 48, "10_of_spades.png", "Spades", "Ten" },
                    { 49, "jack_of_spades.png", "Spades", "Jack" },
                    { 50, "queen_of_spades.png", "Spades", "Queen" },
                    { 40, "2_of_spades.png", "Spades", "Two" },
                    { 27, "2_of_diamonds.png", "Diamonds", "Two" },
                    { 26, "ace_of_hearts.png", "Hearts", "Ace" },
                    { 25, "king_of_hearts.png", "Hearts", "King" },
                    { 2, "3_of_clubs.png", "Clubs", "Three" },
                    { 3, "4_of_clubs.png", "Clubs", "Four" },
                    { 4, "5_of_clubs.png", "Clubs", "Five" },
                    { 5, "6_of_clubs.png", "Clubs", "Six" },
                    { 6, "7_of_clubs.png", "Clubs", "Seven" },
                    { 7, "8_of_clubs.png", "Clubs", "Eight" },
                    { 8, "9_of_clubs.png", "Clubs", "Nine" },
                    { 9, "10_of_clubs.png", "Clubs", "Ten" },
                    { 10, "jack_of_clubs.png", "Clubs", "Jack" },
                    { 11, "queen_of_clubs.png", "Clubs", "Queen" },
                    { 12, "king_of_clubs.png", "Clubs", "King" },
                    { 13, "ace_of_clubs.png", "Clubs", "Ace" },
                    { 14, "2_of_hearts.png", "Hearts", "Two" },
                    { 15, "3_of_hearts.png", "Hearts", "Three" },
                    { 16, "4_of_hearts.png", "Hearts", "Four" }
                });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "CardId", "CardImg", "Suit", "Value" },
                values: new object[,]
                {
                    { 17, "5_of_hearts.png", "Hearts", "Five" },
                    { 18, "6_of_hearts.png", "Hearts", "Six" },
                    { 19, "7_of_hearts.png", "Hearts", "Seven" },
                    { 20, "8_of_hearts.png", "Hearts", "Eight" },
                    { 21, "9_of_hearts.png", "Hearts", "Nine" },
                    { 22, "10_of_hearts.png", "Hearts", "Ten" },
                    { 23, "jack_of_hearts.png", "Hearts", "Jack" },
                    { 24, "queen_of_hearts.png", "Hearts", "Queen" },
                    { 51, "king_of_spades.png", "Spades", "King" },
                    { 52, "ace_of_spades.png", "Spades", "Ace" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cards");
        }
    }
}
