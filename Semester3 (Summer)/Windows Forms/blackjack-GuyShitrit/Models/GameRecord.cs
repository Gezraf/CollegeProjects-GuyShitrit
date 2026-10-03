using System;
using System.IO;

namespace Blackjack.Models
{
    public class GameRecord
    {
        public string PlayerName { get; set; }
        public DateTime PlayedAt { get; set; }
        public int BetAmount { get; set; }
        public string Result { get; set; }
        public int PlayerScore { get; set; }
        public int DealerScore { get; set; }
        public int FinalBalance { get; set; }

        public GameRecord()
        {
            PlayerName = string.Empty;
            PlayedAt = DateTime.Now;
            Result = string.Empty;
        }

        public GameRecord(string playerName, DateTime playedAt, int betAmount, string result, int playerScore, int dealerScore, int finalBalance)
        {
            PlayerName = playerName;
            PlayedAt = playedAt;
            BetAmount = betAmount;
            Result = result;
            PlayerScore = playerScore;
            DealerScore = dealerScore;
            FinalBalance = finalBalance;
        }

        public void WriteToBinary(BinaryWriter bw)
        {
            bw.Write(PlayerName);
            bw.Write(PlayedAt.ToBinary());
            bw.Write(BetAmount);
            bw.Write(Result);
            bw.Write(PlayerScore);
            bw.Write(DealerScore);
            bw.Write(FinalBalance);
        }

        public static GameRecord ReadFromBinary(BinaryReader br)
        {
            GameRecord record = new GameRecord();
            record.PlayerName = br.ReadString();
            record.PlayedAt = DateTime.FromBinary(br.ReadInt64());
            record.BetAmount = br.ReadInt32();
            record.Result = br.ReadString();
            record.PlayerScore = br.ReadInt32();
            record.DealerScore = br.ReadInt32();
            record.FinalBalance = br.ReadInt32();
            return record;
        }
    }
}
