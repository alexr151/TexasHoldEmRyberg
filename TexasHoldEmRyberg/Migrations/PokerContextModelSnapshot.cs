﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TexasHoldEmRyberg.Models;

namespace TexasHoldEmRyberg.Migrations
{
    [DbContext(typeof(PokerContext))]
    partial class PokerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TexasHoldEmRyberg.Models.Card", b =>
                {
                    b.Property<int>("CardId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CardImg")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Suit")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CardId");

                    b.ToTable("Cards");

                    b.HasData(
                        new
                        {
                            CardId = 1,
                            CardImg = "2_of_clubs.png",
                            Suit = "Clubs",
                            Value = "Two"
                        },
                        new
                        {
                            CardId = 2,
                            CardImg = "3_of_clubs.png",
                            Suit = "Clubs",
                            Value = "Three"
                        },
                        new
                        {
                            CardId = 3,
                            CardImg = "4_of_clubs.png",
                            Suit = "Clubs",
                            Value = "Four"
                        },
                        new
                        {
                            CardId = 4,
                            CardImg = "5_of_clubs.png",
                            Suit = "Clubs",
                            Value = "Five"
                        },
                        new
                        {
                            CardId = 5,
                            CardImg = "6_of_clubs.png",
                            Suit = "Clubs",
                            Value = "Six"
                        },
                        new
                        {
                            CardId = 6,
                            CardImg = "7_of_clubs.png",
                            Suit = "Clubs",
                            Value = "Seven"
                        },
                        new
                        {
                            CardId = 7,
                            CardImg = "8_of_clubs.png",
                            Suit = "Clubs",
                            Value = "Eight"
                        },
                        new
                        {
                            CardId = 8,
                            CardImg = "9_of_clubs.png",
                            Suit = "Clubs",
                            Value = "Nine"
                        },
                        new
                        {
                            CardId = 9,
                            CardImg = "10_of_clubs.png",
                            Suit = "Clubs",
                            Value = "Ten"
                        },
                        new
                        {
                            CardId = 10,
                            CardImg = "jack_of_clubs.png",
                            Suit = "Clubs",
                            Value = "Jack"
                        },
                        new
                        {
                            CardId = 11,
                            CardImg = "queen_of_clubs.png",
                            Suit = "Clubs",
                            Value = "Queen"
                        },
                        new
                        {
                            CardId = 12,
                            CardImg = "king_of_clubs.png",
                            Suit = "Clubs",
                            Value = "King"
                        },
                        new
                        {
                            CardId = 13,
                            CardImg = "ace_of_clubs.png",
                            Suit = "Clubs",
                            Value = "Ace"
                        },
                        new
                        {
                            CardId = 14,
                            CardImg = "2_of_hearts.png",
                            Suit = "Hearts",
                            Value = "Two"
                        },
                        new
                        {
                            CardId = 15,
                            CardImg = "3_of_hearts.png",
                            Suit = "Hearts",
                            Value = "Three"
                        },
                        new
                        {
                            CardId = 16,
                            CardImg = "4_of_hearts.png",
                            Suit = "Hearts",
                            Value = "Four"
                        },
                        new
                        {
                            CardId = 17,
                            CardImg = "5_of_hearts.png",
                            Suit = "Hearts",
                            Value = "Five"
                        },
                        new
                        {
                            CardId = 18,
                            CardImg = "6_of_hearts.png",
                            Suit = "Hearts",
                            Value = "Six"
                        },
                        new
                        {
                            CardId = 19,
                            CardImg = "7_of_hearts.png",
                            Suit = "Hearts",
                            Value = "Seven"
                        },
                        new
                        {
                            CardId = 20,
                            CardImg = "8_of_hearts.png",
                            Suit = "Hearts",
                            Value = "Eight"
                        },
                        new
                        {
                            CardId = 21,
                            CardImg = "9_of_hearts.png",
                            Suit = "Hearts",
                            Value = "Nine"
                        },
                        new
                        {
                            CardId = 22,
                            CardImg = "10_of_hearts.png",
                            Suit = "Hearts",
                            Value = "Ten"
                        },
                        new
                        {
                            CardId = 23,
                            CardImg = "jack_of_hearts.png",
                            Suit = "Hearts",
                            Value = "Jack"
                        },
                        new
                        {
                            CardId = 24,
                            CardImg = "queen_of_hearts.png",
                            Suit = "Hearts",
                            Value = "Queen"
                        },
                        new
                        {
                            CardId = 25,
                            CardImg = "king_of_hearts.png",
                            Suit = "Hearts",
                            Value = "King"
                        },
                        new
                        {
                            CardId = 26,
                            CardImg = "ace_of_hearts.png",
                            Suit = "Hearts",
                            Value = "Ace"
                        },
                        new
                        {
                            CardId = 27,
                            CardImg = "2_of_diamonds.png",
                            Suit = "Diamonds",
                            Value = "Two"
                        },
                        new
                        {
                            CardId = 28,
                            CardImg = "3_of_diamonds.png",
                            Suit = "Diamonds",
                            Value = "Three"
                        },
                        new
                        {
                            CardId = 29,
                            CardImg = "4_of_diamonds.png",
                            Suit = "Diamonds",
                            Value = "Four"
                        },
                        new
                        {
                            CardId = 30,
                            CardImg = "5_of_diamonds.png",
                            Suit = "Diamonds",
                            Value = "Five"
                        },
                        new
                        {
                            CardId = 31,
                            CardImg = "6_of_diamonds.png",
                            Suit = "Diamonds",
                            Value = "Six"
                        },
                        new
                        {
                            CardId = 32,
                            CardImg = "7_of_diamonds.png",
                            Suit = "Diamonds",
                            Value = "Seven"
                        },
                        new
                        {
                            CardId = 33,
                            CardImg = "8_of_diamonds.png",
                            Suit = "Diamonds",
                            Value = "Eight"
                        },
                        new
                        {
                            CardId = 34,
                            CardImg = "9_of_diamonds.png",
                            Suit = "Diamonds",
                            Value = "Nine"
                        },
                        new
                        {
                            CardId = 35,
                            CardImg = "10_of_diamonds.png",
                            Suit = "Diamonds",
                            Value = "Ten"
                        },
                        new
                        {
                            CardId = 36,
                            CardImg = "jack_of_diamonds.png",
                            Suit = "Diamonds",
                            Value = "Jack"
                        },
                        new
                        {
                            CardId = 37,
                            CardImg = "queen_of_diamonds.png",
                            Suit = "Diamonds",
                            Value = "Queen"
                        },
                        new
                        {
                            CardId = 38,
                            CardImg = "king_of_diamonds.png",
                            Suit = "Diamonds",
                            Value = "King"
                        },
                        new
                        {
                            CardId = 39,
                            CardImg = "ace_of_diamonds.png",
                            Suit = "Diamonds",
                            Value = "Ace"
                        },
                        new
                        {
                            CardId = 40,
                            CardImg = "2_of_spades.png",
                            Suit = "Spades",
                            Value = "Two"
                        },
                        new
                        {
                            CardId = 41,
                            CardImg = "3_of_spades.png",
                            Suit = "Spades",
                            Value = "Three"
                        },
                        new
                        {
                            CardId = 42,
                            CardImg = "4_of_spades.png",
                            Suit = "Spades",
                            Value = "Four"
                        },
                        new
                        {
                            CardId = 43,
                            CardImg = "5_of_spades.png",
                            Suit = "Spades",
                            Value = "Five"
                        },
                        new
                        {
                            CardId = 44,
                            CardImg = "6_of_spades.png",
                            Suit = "Spades",
                            Value = "Six"
                        },
                        new
                        {
                            CardId = 45,
                            CardImg = "7_of_spades.png",
                            Suit = "Spades",
                            Value = "Seven"
                        },
                        new
                        {
                            CardId = 46,
                            CardImg = "8_of_spades.png",
                            Suit = "Spades",
                            Value = "Eight"
                        },
                        new
                        {
                            CardId = 47,
                            CardImg = "9_of_spades.png",
                            Suit = "Spades",
                            Value = "Nine"
                        },
                        new
                        {
                            CardId = 48,
                            CardImg = "10_of_spades.png",
                            Suit = "Spades",
                            Value = "Ten"
                        },
                        new
                        {
                            CardId = 49,
                            CardImg = "jack_of_spades.png",
                            Suit = "Spades",
                            Value = "Jack"
                        },
                        new
                        {
                            CardId = 50,
                            CardImg = "queen_of_spades.png",
                            Suit = "Spades",
                            Value = "Queen"
                        },
                        new
                        {
                            CardId = 51,
                            CardImg = "king_of_spades.png",
                            Suit = "Spades",
                            Value = "King"
                        },
                        new
                        {
                            CardId = 52,
                            CardImg = "ace_of_spades.png",
                            Suit = "Spades",
                            Value = "Ace"
                        },
                        new
                        {
                            CardId = 53,
                            CardImg = "cardback.jpg",
                            Suit = "Back",
                            Value = "Back"
                        });
                });

            modelBuilder.Entity("TexasHoldEmRyberg.Models.Table", b =>
                {
                    b.Property<int>("TableId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CardId")
                        .HasColumnType("int");

                    b.HasKey("TableId");

                    b.HasIndex("CardId");

                    b.ToTable("Tables");

                    b.HasData(
                        new
                        {
                            TableId = 8,
                            CardId = 53
                        });
                });

            modelBuilder.Entity("TexasHoldEmRyberg.Models.Table", b =>
                {
                    b.HasOne("TexasHoldEmRyberg.Models.Card", "Card")
                        .WithMany()
                        .HasForeignKey("CardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Card");
                });
#pragma warning restore 612, 618
        }
    }
}
