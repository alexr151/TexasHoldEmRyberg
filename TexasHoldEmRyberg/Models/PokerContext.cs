using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TexasHoldEmRyberg.Models
{
    public class PokerContext : DbContext
    {

        public PokerContext(DbContextOptions<PokerContext> options) : base(options) { }

        public DbSet<Card> Cards { get; set; }

        public DbSet<Table> Tables { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Card>().HasData(

                new Card { CardId = 1, Value = "Two", Suit = "Clubs", CardImg = "2_of_clubs.png" },
                new Card { CardId = 2, Value = "Three", Suit = "Clubs", CardImg = "3_of_clubs.png" },
                new Card { CardId = 3, Value = "Four", Suit = "Clubs", CardImg = "4_of_clubs.png" },
                new Card { CardId = 4, Value = "Five", Suit = "Clubs", CardImg = "5_of_clubs.png" },
                new Card { CardId = 5, Value = "Six", Suit = "Clubs", CardImg = "6_of_clubs.png" },
                new Card { CardId = 6, Value = "Seven", Suit = "Clubs", CardImg = "7_of_clubs.png" },
                new Card { CardId = 7, Value = "Eight", Suit = "Clubs", CardImg = "8_of_clubs.png" },
                new Card { CardId = 8, Value = "Nine", Suit = "Clubs", CardImg = "9_of_clubs.png" },
                new Card { CardId = 9, Value = "Ten", Suit = "Clubs", CardImg = "10_of_clubs.png" },
                new Card { CardId = 10, Value = "Jack", Suit = "Clubs", CardImg = "jack_of_clubs.png" },
                new Card { CardId = 11, Value = "Queen", Suit = "Clubs", CardImg = "queen_of_clubs.png" },
                new Card { CardId = 12, Value = "King", Suit = "Clubs", CardImg = "king_of_clubs.png" },
                new Card { CardId = 13, Value = "Ace", Suit = "Clubs", CardImg = "ace_of_clubs.png" },


                new Card { CardId = 14, Value = "Two", Suit = "Hearts", CardImg = "2_of_hearts.png" },
                new Card { CardId = 15, Value = "Three", Suit = "Hearts", CardImg = "3_of_hearts.png" },
                new Card { CardId = 16, Value = "Four", Suit = "Hearts", CardImg = "4_of_hearts.png" },
                new Card { CardId = 17, Value = "Five", Suit = "Hearts", CardImg = "5_of_hearts.png" },
                new Card { CardId = 18, Value = "Six", Suit = "Hearts", CardImg = "6_of_hearts.png" },
                new Card { CardId = 19, Value = "Seven", Suit = "Hearts", CardImg = "7_of_hearts.png" },
                new Card { CardId = 20, Value = "Eight", Suit = "Hearts", CardImg = "8_of_hearts.png" },
                new Card { CardId = 21, Value = "Nine", Suit = "Hearts", CardImg = "9_of_hearts.png" },
                new Card { CardId = 22, Value = "Ten", Suit = "Hearts", CardImg = "10_of_hearts.png" },
                new Card { CardId = 23, Value = "Jack", Suit = "Hearts", CardImg = "jack_of_hearts.png" },
                new Card { CardId = 24, Value = "Queen", Suit = "Hearts", CardImg = "queen_of_hearts.png" },
                new Card { CardId = 25, Value = "King", Suit = "Hearts", CardImg = "king_of_hearts.png" },
                new Card { CardId = 26, Value = "Ace", Suit = "Hearts", CardImg = "ace_of_hearts.png" },
                 
                new Card { CardId = 27, Value = "Two", Suit = "Diamonds", CardImg = "2_of_diamonds.png" },
                new Card { CardId = 28, Value = "Three", Suit = "Diamonds", CardImg = "3_of_diamonds.png" },
                new Card { CardId = 29, Value = "Four", Suit = "Diamonds", CardImg = "4_of_diamonds.png" },
                new Card { CardId = 30, Value = "Five", Suit = "Diamonds", CardImg = "5_of_diamonds.png" },
                new Card { CardId = 31, Value = "Six", Suit = "Diamonds", CardImg = "6_of_diamonds.png" },
                new Card { CardId = 32, Value = "Seven", Suit = "Diamonds", CardImg = "7_of_diamonds.png" },
                new Card { CardId = 33, Value = "Eight", Suit = "Diamonds", CardImg = "8_of_diamonds.png" },
                new Card { CardId = 34, Value = "Nine", Suit = "Diamonds", CardImg = "9_of_diamonds.png" },
                new Card { CardId = 35, Value = "Ten", Suit = "Diamonds", CardImg = "10_of_diamonds.png" },
                new Card { CardId = 36, Value = "Jack", Suit = "Diamonds", CardImg = "jack_of_diamonds.png" },
                new Card { CardId = 37, Value = "Queen", Suit = "Diamonds", CardImg = "queen_of_diamonds.png" },
                new Card { CardId = 38, Value = "King", Suit = "Diamonds", CardImg = "king_of_diamonds.png" },
                new Card { CardId = 39, Value = "Ace", Suit = "Diamonds", CardImg = "ace_of_diamonds.png" },


                new Card { CardId = 40, Value = "Two", Suit = "Spades", CardImg = "2_of_spades.png" },
                new Card { CardId = 41, Value = "Three", Suit = "Spades", CardImg = "3_of_spades.png" },
                new Card { CardId = 42, Value = "Four", Suit = "Spades", CardImg = "4_of_spades.png" },
                new Card { CardId = 43, Value = "Five", Suit = "Spades", CardImg = "5_of_spades.png" },
                new Card { CardId = 44, Value = "Six", Suit = "Spades", CardImg = "6_of_spades.png" },
                new Card { CardId = 45, Value = "Seven", Suit = "Spades", CardImg = "7_of_spades.png" },
                new Card { CardId = 46, Value = "Eight", Suit = "Spades", CardImg = "8_of_spades.png" },
                new Card { CardId = 47, Value = "Nine", Suit = "Spades", CardImg = "9_of_spades.png" },
                new Card { CardId = 48, Value = "Ten", Suit = "Spades", CardImg = "10_of_spades.png" },
                new Card { CardId = 49, Value = "Jack", Suit = "Spades", CardImg = "jack_of_spades.png" },
                new Card { CardId = 50, Value = "Queen", Suit = "Spades", CardImg = "queen_of_spades.png" },
                new Card { CardId = 51, Value = "King", Suit = "Spades", CardImg = "king_of_spades.png" },
                new Card { CardId = 52, Value = "Ace", Suit = "Spades", CardImg = "ace_of_spades.png" },

                new Card { CardId = 53, Value = "Back", Suit = "Back", CardImg = "cardback.jpg"}
                );

          
        }
    }
}
