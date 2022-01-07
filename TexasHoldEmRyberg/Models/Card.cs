using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TexasHoldEmRyberg.Models
{
    public class Card
    {
        public int CardId { get; set; }

        public string Value { get; set; }
        public string Suit { get; set; }

        public string CardImg { get; set; }
    }
}
