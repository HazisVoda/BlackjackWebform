using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackGame
{
    public class Player
    {
        public List<Card> Hand { get; set; } = new List<Card>();
        public int Score { get; set; }

        public void CalculateScore()
        {
            Score = Hand.Sum(card => card.Value);
            foreach (var card in Hand)
            {
                if (card.Rank == "Ace" && Score > 21)
                {
                    Score -= 10; // Asi me vleren 1 ne kete rast
                }
            }
        }
    }
}
