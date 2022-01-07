using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TexasHoldEmRyberg.Models
{
    public class Table
    {
        public int TableId { get; set; }

        public int CardId { get; set; }

        public Card Card { get; set; }
    }
}
