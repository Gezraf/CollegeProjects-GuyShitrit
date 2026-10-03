using System;
using System.Collections.Generic;

namespace Blackjack.Models
{
    public class Deck
    {
        private List<Card> cards;
        private Random random;

        public Deck(int numberOfDecks = 1)
        {
            random = new Random();
            cards = new List<Card>();
            Reset(numberOfDecks);
        }

        public void Reset(int numberOfDecks = 1)
        {
            if (numberOfDecks < 1) numberOfDecks = 1;
            cards.Clear();

            string[] suits = { "לב", "יהלום", "תלתן", "עלה" };
            string[] ranks = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "נסיך", "מלכה", "מלך", "אס" };
            int[] values = { 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 11 };
            string[] imageFiles = { "2.png", "3.png", "4.png", "5.png", "6.png", "7.png", "8.png", "9.png", "10.png", "jack.png", "queen.png", "king.png", "ace.png" };

            for (int d = 0; d < numberOfDecks; d++)
            {
                foreach (string suit in suits)
                {
                    for (int i = 0; i < ranks.Length; i++)
                    {
                        cards.Add(new Card(ranks[i], suit, values[i], imageFiles[i]));
                    }
                }
            }

            Shuffle();
        }

        public void Shuffle()
        {
            for (int i = cards.Count - 1; i > 0; i--)
            {
                int j = random.Next(i + 1);
                Card temp = cards[i];
                cards[i] = cards[j];
                cards[j] = temp;
            }
        }

        public Card DrawCard()
        {
            if (cards.Count == 0)
            {
                Reset(1);
            }

            Card drawn = cards[0];
            cards.RemoveAt(0);
            return drawn;
        }

        public int CardsRemaining
        {
            get { return cards.Count; }
        }
    }
}
