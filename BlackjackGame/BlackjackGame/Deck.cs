using BlackjackGame;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace BlackjackGame
{
    public class Deck : Card
    {
        public List<Card> deck = new List<Card>();
        public Random random = new Random();
        const int TotalCards = 52;

        public Deck()
        {

            DeckCreate();
            Shuffle();

        }

        public void DeckCreate()
        {
            string[] ranks = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };
            for (int i = 0; i < 4; i++)
            {
                foreach (var rank in ranks)
                {
                    int value = rank == "Ace" ? 11 : int.TryParse(rank, out int val) ? val : 10;

                    deck.Add(new Card { Rank = rank, Value = value });
                }
            }
        }

        public void Shuffle()
        {
            int n = deck.Count;
            while (n > 1)
            {
                n--;
                Random random = new Random();
                int k = random.Next(0, n + 1);
                Card temp = deck[k];
                deck[k] = deck[n];
                deck[n] = temp;
            }
        }

        public Card CardDraw()
        {
            if (deck.Count == 0)
            {
                MessageBox.Show("No more cards in the deck!");
                return null;
            }

            Card card = deck[0];
            deck.RemoveAt(0);
            return card;
        }
    }
}

