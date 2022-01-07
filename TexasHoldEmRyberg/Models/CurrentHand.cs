using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TexasHoldEmRyberg.Models
{
    public class CurrentHand
    {

        
        private List<int> tableIds = createTableIds();

        public static List<int> createTableIds()
        {
            Random rand = new Random();
            List<int> possible = Enumerable.Range(1, 53).ToList();
            List<int> listNumbers = new List<int>();
            for (int i = 0; i < 7; i++)
            {
                int index = rand.Next(0, possible.Count);
                listNumbers.Add(possible[index]);
                possible.RemoveAt(index);
            }

            return listNumbers;
        }

        public int Hand1 { get; set; }

        public int Hand2 { get; set; }

        public int Flop1 { get; set; }
        public int Flop2 { get; set; }
        public int Flop3 { get; set; }
        public int Turn { get; set; }
        public int River { get; set; }

        public CurrentHand()
        {
            Hand1 = tableIds[0];
            Hand2 = tableIds[1];
            Flop1 = tableIds[2];
            Flop2 = tableIds[3];
            Flop3 = tableIds[4];
            Turn = tableIds[5];
            River = tableIds[6];
        }
    }
}
