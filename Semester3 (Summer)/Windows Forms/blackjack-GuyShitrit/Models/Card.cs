using System;

namespace Blackjack.Models
{
    public class Card
    {
        public string Rank { get; set; }
        public string Suit { get; set; }
        public int Value { get; set; }
        public string ImageFileName { get; set; }

        public Card(string rank, string suit, int value, string imageFileName)
        {
            Rank = rank;
            Suit = suit;
            Value = value;
            ImageFileName = imageFileName;
        }

        public override string ToString()
        {
            return string.Format("{0} ({1})", Rank, Value);
        }
    }
}
