using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Blackjack.Models;

namespace Blackjack.Forms
{
    public partial class FormGame : Form
    {
        private Player player;
        private Hand dealerHand;
        private Deck deck;
        private bool hitSoft17;
        private int currentRoundBet;

        private PictureBox[] picDealerCards;
        private PictureBox[] picPlayerCards;

        private string imagesFolder;
        private string historyFilePath;

        public FormGame(Player p, int decksCount, bool dealerHitSoft17, bool fastDeal = false)
        {
            InitializeComponent();

            player = p;
            dealerHand = new Hand();
            deck = new Deck(decksCount);
            hitSoft17 = dealerHitSoft17;
            tmrDealer.Interval = fastDeal ? 300 : 700;

            picDealerCards = new PictureBox[] { picDealer0, picDealer1, picDealer2, picDealer3, picDealer4, picDealer5 };
            picPlayerCards = new PictureBox[] { picPlayer0, picPlayer1, picPlayer2, picPlayer3, picPlayer4, picPlayer5 };

            imagesFolder = Path.Combine(Application.StartupPath, "Images");
            if (!Directory.Exists(imagesFolder))
            {
                imagesFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "Images");
            }

            historyFilePath = Path.Combine(Application.StartupPath, "history.dat");

            UpdateTopBar();
            LogEvent(string.Format("התחלת משחק | שחקן: {0} | יתרה: {1} ₪", player.Name, player.Balance));
        }

        private void UpdateTopBar()
        {
            lblPlayerName.Text = "שחקן: " + player.Name;
            lblBalance.Text = "יתרה: " + player.Balance.ToString("N0") + " ₪";
            lblCurrentBet.Text = "הימור נוכחי: " + player.CurrentBet.ToString("N0") + " ₪";
        }

        private void LogEvent(string msg)
        {
            string timeStr = DateTime.Now.ToString("HH:mm:ss");
            lstGameLog.Items.Add(string.Format("[{0}] {1}", timeStr, msg));
            lstGameLog.TopIndex = lstGameLog.Items.Count - 1;
        }

        private void ClearCardPictures()
        {
            for (int i = 0; i < picDealerCards.Length; i++)
            {
                if (picDealerCards[i].Image != null)
                {
                    picDealerCards[i].Image.Dispose();
                    picDealerCards[i].Image = null;
                }
            }

            for (int i = 0; i < picPlayerCards.Length; i++)
            {
                if (picPlayerCards[i].Image != null)
                {
                    picPlayerCards[i].Image.Dispose();
                    picPlayerCards[i].Image = null;
                }
            }
        }

        private Image LoadCardImage(string fileName)
        {
            try
            {
                string fullPath = Path.Combine(imagesFolder, fileName);
                if (File.Exists(fullPath))
                {
                    using (FileStream fs = new FileStream(fullPath, FileMode.Open, FileAccess.Read))
                    {
                        return Image.FromStream(fs);
                    }
                }
            }
            catch { }
            return null;
        }

        private void RenderHands(bool revealDealerHidden)
        {
            for (int i = 0; i < picDealerCards.Length; i++)
            {
                if (i < dealerHand.Cards.Count)
                {
                    if (i == 1 && !revealDealerHidden)
                    {
                        picDealerCards[i].Image = LoadCardImage("back.png");
                    }
                    else
                    {
                        picDealerCards[i].Image = LoadCardImage(dealerHand.Cards[i].ImageFileName);
                    }
                }
                else
                {
                    picDealerCards[i].Image = null;
                }
            }

            for (int i = 0; i < picPlayerCards.Length; i++)
            {
                if (i < player.Hand.Cards.Count)
                {
                    picPlayerCards[i].Image = LoadCardImage(player.Hand.Cards[i].ImageFileName);
                }
                else
                {
                    picPlayerCards[i].Image = null;
                }
            }

            int playerScore = player.Hand.CalculateScore();
            lblPlayerScore.Text = "ניקוד שחקן: " + playerScore;

            if (!revealDealerHidden && dealerHand.Cards.Count >= 2)
            {
                int visibleScore = dealerHand.Cards[0].Value;
                lblDealerScore.Text = string.Format("ניקוד דילר: {0} + ?", visibleScore);
            }
            else
            {
                int dealerScore = dealerHand.CalculateScore();
                lblDealerScore.Text = "ניקוד דילר: " + dealerScore;
            }
        }

        private int GetSelectedBetAmount()
        {
            if (!string.IsNullOrWhiteSpace(txtCustomBet.Text))
            {
                int custom;
                if (int.TryParse(txtCustomBet.Text.Trim(), out custom) && custom > 0)
                {
                    return custom;
                }
            }

            if (rdBet25.Checked) return 25;
            if (rdBet50.Checked) return 50;
            if (rdBet100.Checked) return 100;
            if (rdBet250.Checked) return 250;

            return 100;
        }

        private void ShowMessageBoxRtl(string message, string caption, MessageBoxIcon icon)
        {
            MessageBox.Show(
                message,
                caption,
                MessageBoxButtons.OK,
                icon,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
        }

        private void btnDeal_Click(object sender, EventArgs e)
        {
            int bet = GetSelectedBetAmount();

            if (bet <= 0)
            {
                ShowMessageBoxRtl("נא להזין סכום הימור תקין.", "שגיאת הימור", MessageBoxIcon.Warning);
                return;
            }

            if (bet > player.Balance)
            {
                ShowMessageBoxRtl(
                    string.Format("אין לך מספיק יתרה עבור הימור זה.\nיתרה נוכחית: {0} ₪.", player.Balance),
                    "יתרה לא מספקת",
                    MessageBoxIcon.Warning);
                return;
            }

            currentRoundBet = bet;
            player.PlaceBet(bet);
            UpdateTopBar();

            player.Hand.Clear();
            dealerHand.Clear();
            ClearCardPictures();

            LogEvent(string.Format("סיבוב חדש | הימור: {0} ₪", bet));

            Card p1 = deck.DrawCard();
            Card d1 = deck.DrawCard();
            Card p2 = deck.DrawCard();
            Card d2 = deck.DrawCard();

            player.Hand.AddCard(p1);
            dealerHand.AddCard(d1);
            player.Hand.AddCard(p2);
            dealerHand.AddCard(d2);

            LogEvent(string.Format("שחקן קיבל: {0}, {1} ({2})", p1.Rank, p2.Rank, player.Hand.CalculateScore()));
            LogEvent(string.Format("דילר מציג: {0}", d1.Rank));

            RenderHands(false);

            grpBetting.Enabled = false;
            btnHit.Enabled = true;
            btnStand.Enabled = true;
            btnDouble.Enabled = (player.Balance >= currentRoundBet);
            btnNewRound.Enabled = false;

            bool playerBJ = player.Hand.IsBlackjack();
            bool dealerBJ = dealerHand.IsBlackjack();

            if (playerBJ || dealerBJ)
            {
                RenderHands(true);

                if (playerBJ && dealerBJ)
                {
                    EndRound("תיקו", string.Format("לשני הצדדים יש בלאקג'ק.\nההימור בסך {0} ₪ הוחזר.", currentRoundBet), false);
                    player.PushBet();
                }
                else if (playerBJ)
                {
                    int winAmount = (int)(currentRoundBet * 1.5);
                    EndRound("בלאקג'ק!", string.Format("קיבלת בלאקג'ק!\nהרווחת {0} ₪.", winAmount), true);
                    player.WinBet(1.5);
                }
                else
                {
                    EndRound("הפסד", string.Format("לדילר יש בלאקג'ק.\nהפסדת {0} ₪.", currentRoundBet), false);
                    player.LoseBet();
                }
                FinishRoundState();
            }
        }

        private void btnHit_Click(object sender, EventArgs e)
        {
            btnDouble.Enabled = false;

            Card newCard = deck.DrawCard();
            player.Hand.AddCard(newCard);
            int score = player.Hand.CalculateScore();
            LogEvent(string.Format("קלף נוסף: {0} (סך הכל: {1})", newCard.Rank, score));

            RenderHands(false);

            if (player.Hand.IsBust())
            {
                RenderHands(true);
                LogEvent(string.Format("שריפה ב-{0} נקודות!", score));
                EndRound("שריפה", string.Format("עברת את 21 ({0} נקודות).\nהפסדת {1} ₪.", score, currentRoundBet), false);
                player.LoseBet();
                FinishRoundState();
            }
            else if (score == 21)
            {
                LogEvent("הגעת ל-21!");
                btnStand_Click(sender, e);
            }
            else if (player.Hand.Cards.Count == 6)
            {
                btnStand_Click(sender, e);
            }
        }

        private void btnStand_Click(object sender, EventArgs e)
        {
            btnHit.Enabled = false;
            btnStand.Enabled = false;
            btnDouble.Enabled = false;

            RenderHands(true);

            LogEvent(string.Format("עצירה ב-{0} נקודות", player.Hand.CalculateScore()));
            LogEvent(string.Format("קלף מוסתר של הדילר: {0}", dealerHand.Cards[1].Rank));

            tmrDealer.Start();
        }

        private void btnDouble_Click(object sender, EventArgs e)
        {
            if (player.Balance < currentRoundBet)
            {
                ShowMessageBoxRtl("אין לך מספיק יתרה להכפלת ההימור.", "לא ניתן להכפיל", MessageBoxIcon.Warning);
                return;
            }

            player.PlaceBet(currentRoundBet);
            currentRoundBet *= 2;
            UpdateTopBar();

            Card card = deck.DrawCard();
            player.Hand.AddCard(card);
            int score = player.Hand.CalculateScore();
            LogEvent(string.Format("הכפלת הימור ל-{0} ₪ | קלף: {1} (סך הכל: {2})", currentRoundBet, card.Rank, score));

            btnHit.Enabled = false;
            btnStand.Enabled = false;
            btnDouble.Enabled = false;

            if (player.Hand.IsBust())
            {
                RenderHands(true);
                LogEvent(string.Format("שריפה לאחר הכפלה ב-{0} נקודות!", score));
                EndRound("שריפה", string.Format("עברת את 21 ({0} נקודות).\nהפסדת {1} ₪.", score, currentRoundBet), false);
                player.LoseBet();
                FinishRoundState();
            }
            else
            {
                btnStand_Click(sender, e);
            }
        }

        private void tmrDealer_Tick(object sender, EventArgs e)
        {
            int dScore = dealerHand.CalculateScore();

            bool mustDraw = false;
            if (dScore < 17)
            {
                mustDraw = true;
            }
            else if (dScore == 17 && hitSoft17 && IsSoft17(dealerHand))
            {
                mustDraw = true;
            }

            if (mustDraw && dealerHand.Cards.Count < 6)
            {
                Card newCard = deck.DrawCard();
                dealerHand.AddCard(newCard);
                LogEvent(string.Format("דילר משך: {0} (סך הכל: {1})", newCard.Rank, dealerHand.CalculateScore()));
                RenderHands(true);
            }
            else
            {
                tmrDealer.Stop();
                ResolveFinalScores();
            }
        }

        private bool IsSoft17(Hand hand)
        {
            int sum = 0;
            bool hasAce = false;
            foreach (Card c in hand.Cards)
            {
                sum += c.Value;
                if (c.Rank == "אס" || c.Rank == "Ace") hasAce = true;
            }
            return (sum == 17 && hasAce);
        }

        private void ResolveFinalScores()
        {
            int pScore = player.Hand.CalculateScore();
            int dScore = dealerHand.CalculateScore();

            if (dealerHand.IsBust())
            {
                LogEvent(string.Format("הדילר נשרף ב-{0}! ניצחון (+{1} ₪)", dScore, currentRoundBet));
                EndRound("ניצחון", string.Format("הדילר נשרף עם {0} נקודות!\nהרווחת {1} ₪.", dScore, currentRoundBet), true);
                player.WinBet(1.0);
            }
            else if (pScore > dScore)
            {
                LogEvent(string.Format("ניצחון! ({0} מול {1}) (+{2} ₪)", pScore, dScore, currentRoundBet));
                EndRound("ניצחון", string.Format("ניצחת עם {0} נקודות מול {1} של הדילר!\nהרווחת {2} ₪.", pScore, dScore, currentRoundBet), true);
                player.WinBet(1.0);
            }
            else if (pScore < dScore)
            {
                LogEvent(string.Format("הפסד ({0} מול {1}) (-{2} ₪)", pScore, dScore, currentRoundBet));
                EndRound("הפסד", string.Format("הדילר ניצח עם {0} נקודות מול {1} שלך.\nהפסדת {2} ₪.", dScore, pScore, currentRoundBet), false);
                player.LoseBet();
            }
            else
            {
                LogEvent(string.Format("תיקו ב-{0} נקודות", pScore));
                EndRound("תיקו", string.Format("תיקו! לשניכם {0} נקודות.\nסכום ההימור בסך {1} ₪ הוחזר.", pScore, currentRoundBet), false);
                player.PushBet();
            }

            FinishRoundState();
        }

        private void EndRound(string resultTitle, string msg, bool isWin)
        {
            LogEvent("תוצאת סיבוב: " + resultTitle);

            SaveRecordToBinary(resultTitle);

            UpdateTopBar();

            ShowMessageBoxRtl(msg, resultTitle, isWin ? MessageBoxIcon.Information : MessageBoxIcon.Exclamation);
        }

        private void FinishRoundState()
        {
            UpdateTopBar();
            btnHit.Enabled = false;
            btnStand.Enabled = false;
            btnDouble.Enabled = false;
            btnNewRound.Enabled = true;
            grpBetting.Enabled = true;

            if (player.Balance <= 0)
            {
                ShowMessageBoxRtl(
                    "הקופה שלך התרוקנה.\nהוענק לך מענק של 500 ₪ להמשך משחק.",
                    "יתרה אזלה",
                    MessageBoxIcon.Information);
                player.Balance = 500;
                UpdateTopBar();
                LogEvent("הוענק מענק של 500 ₪.");
            }
        }

        private void SaveRecordToBinary(string result)
        {
            try
            {
                GameRecord record = new GameRecord(
                    player.Name,
                    DateTime.Now,
                    currentRoundBet,
                    result,
                    player.Hand.CalculateScore(),
                    dealerHand.CalculateScore(),
                    player.Balance);

                using (FileStream fs = new FileStream(historyFilePath, FileMode.Append, FileAccess.Write))
                using (BinaryWriter bw = new BinaryWriter(fs))
                {
                    record.WriteToBinary(bw);
                }
            }
            catch (Exception ex)
            {
                LogEvent("שגיאה ברישום לקובץ: " + ex.Message);
            }
        }

        private void btnNewRound_Click(object sender, EventArgs e)
        {
            player.Hand.Clear();
            dealerHand.Clear();
            ClearCardPictures();
            lblPlayerScore.Text = "ניקוד שחקן: 0";
            lblDealerScore.Text = "ניקוד דילר: ?";
            btnNewRound.Enabled = false;
            grpBetting.Enabled = true;
        }

        private void txtCustomBet_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtCustomBet.Text))
            {
                rdBet25.Checked = false;
                rdBet50.Checked = false;
                rdBet100.Checked = false;
                rdBet250.Checked = false;
            }
        }

        private void btnClearLog_Click(object sender, EventArgs e)
        {
            lstGameLog.Items.Clear();
        }

        private void btnViewHistory_Click(object sender, EventArgs e)
        {
            using (FormHistory hist = new FormHistory())
            {
                hist.ShowDialog();
            }
        }

        private void btnBackToMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormGame_FormClosing(object sender, FormClosingEventArgs e)
        {
            tmrDealer.Stop();
            ClearCardPictures();
        }
    }
}
