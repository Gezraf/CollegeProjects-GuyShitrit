using System;

namespace Blackjack.Models
{
    public class Player
    {
        public string Name { get; set; }
        public int Balance { get; set; }
        public int CurrentBet { get; set; }
        public Hand Hand { get; private set; }

        public Player(string name, int startingBalance)
        {
            Name = string.IsNullOrWhiteSpace(name) ? "שחקן" : name.Trim();
            Balance = startingBalance > 0 ? startingBalance : 1000;
            CurrentBet = 0;
            Hand = new Hand();
        }

        public bool PlaceBet(int amount)
        {
            if (amount <= 0 || amount > Balance)
            {
                return false;
            }

            Balance -= amount;
            CurrentBet += amount;
            return true;
        }

        public void WinBet(double multiplier = 1.0)
        {
            int winnings = (int)Math.Round(CurrentBet * multiplier);
            Balance += CurrentBet + winnings;
            CurrentBet = 0;
        }

        public void LoseBet()
        {
            CurrentBet = 0;
        }

        public void PushBet()
        {
            Balance += CurrentBet;
            CurrentBet = 0;
        }
    }
}
