using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackGame
{
    public class Card
    {
        public string Rank { get; set; }
        public int Value { get; set; }
        public static Card operator +(Card c1, Card c2)
        {
            Card pointSum = new Card();
            pointSum.Value = c1.Value + c2.Value;
            return pointSum;
        }
    }
}
