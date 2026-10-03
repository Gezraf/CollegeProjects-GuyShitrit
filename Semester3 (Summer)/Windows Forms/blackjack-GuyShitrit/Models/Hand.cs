using System;
using System.Collections.Generic;

namespace Blackjack.Models
{
    public class Hand
    {
        public List<Card> Cards { get; private set; }

        public Hand()
        {
            Cards = new List<Card>();
        }

        public void AddCard(Card card)
        {
            if (card != null)
            {
                Cards.Add(card);
            }
        }

        public int CalculateScore()
        {
            int total = 0;
            int aceCount = 0;

            foreach (Card card in Cards)
            {
                total += card.Value;
                if (card.Rank == "אס" || card.Rank == "Ace")
                {
                    aceCount++;
                }
            }

            // תחשיב אס כ-1 במקום 11 אם הסכום עולה על 21
            while (total > 21 && aceCount > 0)
            {
                total -= 10;
                aceCount--;
            }

            return total;
        }

        public bool IsBust()
        {
            return CalculateScore() > 21;
        }

        public bool IsBlackjack()
        {
            return Cards.Count == 2 && CalculateScore() == 21;
        }

        public void Clear()
        {
            Cards.Clear();
        }
    }
}
