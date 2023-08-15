using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackjackGame
{
    public class Game
    {
        public Deck deck = new Deck();
        public Player player = new Player();
        public Player dealer = new Player();

        public void Start()
        {
            PlayRound();
        }

        public void PlayRound()
        {
            DealInitialCards();
        }

        public void DrawBtn()
        {

            if (player.Score < 17)
            {
                Card newCard = deck.CardDraw();
                player.Hand.Add(newCard);
                player.CalculateScore();
            }
            else
                MessageBox.Show("You have over 17 points. You can not draw any more cards. Please click Next.");

        }

        public void DealInitialCards()
        {
            player.Hand.Add(deck.CardDraw());
            player.Hand.Add(deck.CardDraw());
            player.CalculateScore();

            dealer.Hand.Add(deck.CardDraw());
            dealer.Hand.Add(deck.CardDraw());
            dealer.CalculateScore();
        }

        public void NextBtn()
        {
            if (player.Score > 17)
            {

                DealerTurn();
                DetermineWinner();

            }
            else
                MessageBox.Show("You haven't drawn enough cards yet. Please click draw until you have more than 17 points.");
        }

        private void DealerTurn()
        {
            while (dealer.Score < 17)
            {
                Card newCard = deck.CardDraw();
                dealer.Hand.Add(newCard);
                dealer.CalculateScore();
            }
        }

        private void DetermineWinner()
        {

            if (player.Score > 21)
            {
                MessageBox.Show("You busted! Dealer wins!");


            }
            else if (dealer.Score > 21)
            {
                MessageBox.Show("Dealer busted! You win.");

            }
            else if (player.Score == dealer.Score)
            {
                MessageBox.Show("It's a tie!");
            }
            else if (player.Score > dealer.Score)
            {
                MessageBox.Show("You win!");
            }
            else
            {
                MessageBox.Show("Dealer wins.");
            }
        }
    }
}