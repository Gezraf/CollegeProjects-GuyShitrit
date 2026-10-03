using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Blackjack.Models;

namespace Blackjack.Forms
{
    public partial class FormHistory : Form
    {
        private List<GameRecord> allRecords;
        private string historyFilePath;

        public FormHistory()
        {
            InitializeComponent();

            allRecords = new List<GameRecord>();
            historyFilePath = Path.Combine(Application.StartupPath, "history.dat");

            LoadHistoryFromBinaryFile();
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

        private void LoadHistoryFromBinaryFile()
        {
            allRecords.Clear();

            if (File.Exists(historyFilePath))
            {
                try
                {
                    using (FileStream fs = new FileStream(historyFilePath, FileMode.Open, FileAccess.Read))
                    using (BinaryReader br = new BinaryReader(fs))
                    {
                        while (fs.Position < fs.Length)
                        {
                            GameRecord record = GameRecord.ReadFromBinary(br);
                            allRecords.Add(record);
                        }
                    }
                }
                catch (Exception ex)
                {
                    ShowMessageBoxRtl(
                        "שגיאה בטעינת הנתונים: " + ex.Message,
                        "שגיאת קובץ",
                        MessageBoxIcon.Error);
                }
            }

            DisplayRecords(allRecords);
        }

        private void DisplayRecords(List<GameRecord> recordsToDisplay)
        {
            lstHistory.Items.Clear();

            for (int i = recordsToDisplay.Count - 1; i >= 0; i--)
            {
                GameRecord rec = recordsToDisplay[i];

                ListViewItem item = new ListViewItem(rec.PlayerName);
                item.SubItems.Add(rec.PlayedAt.ToString("dd/MM/yyyy HH:mm:ss"));
                item.SubItems.Add(rec.BetAmount.ToString("N0") + " ₪");
                item.SubItems.Add(rec.Result);
                item.SubItems.Add(rec.PlayerScore.ToString());
                item.SubItems.Add(rec.DealerScore.ToString());
                item.SubItems.Add(rec.FinalBalance.ToString("N0") + " ₪");

                if (rec.Result.Contains("ניצחון") || rec.Result.Contains("בלקג'ק"))
                {
                    item.ForeColor = Color.DarkGreen;
                }
                else if (rec.Result.Contains("הפסד") || rec.Result.Contains("שריפה"))
                {
                    item.ForeColor = Color.Firebrick;
                }
                else
                {
                    item.ForeColor = Color.DarkBlue;
                }

                lstHistory.Items.Add(item);
            }

            CalculateStatistics(recordsToDisplay);
        }

        private void CalculateStatistics(List<GameRecord> records)
        {
            int totalGames = records.Count;
            int wins = 0;
            int losses = 0;
            int pushes = 0;
            long totalBet = 0;

            foreach (GameRecord rec in records)
            {
                totalBet += rec.BetAmount;

                if (rec.Result.Contains("ניצחון") || rec.Result.Contains("בלקג'ק"))
                {
                    wins++;
                }
                else if (rec.Result.Contains("הפסד") || rec.Result.Contains("שריפה"))
                {
                    losses++;
                }
                else
                {
                    pushes++;
                }
            }

            double winRate = (totalGames > 0) ? (wins * 100.0 / totalGames) : 0.0;

            lblTotalGames.Text = "סך הכל סיבובים: " + totalGames;
            lblWins.Text = "ניצחונות ובלקג'ק: " + wins;
            lblLosses.Text = "הפסדים ושריפות: " + losses;
            lblPushes.Text = "תיקו: " + pushes;
            lblWinRate.Text = "אחוז הצלחה: " + winRate.ToString("0.0") + "%";
            lblTotalBet.Text = "סך כל ההימורים: " + totalBet.ToString("N0") + " ₪";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string query = txtSearch.Text.Trim();
            if (string.IsNullOrEmpty(query))
            {
                DisplayRecords(allRecords);
                return;
            }

            List<GameRecord> filtered = new List<GameRecord>();
            foreach (GameRecord rec in allRecords)
            {
                if (rec.PlayerName.IndexOf(query, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    filtered.Add(rec);
                }
            }

            DisplayRecords(filtered);
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            DisplayRecords(allRecords);
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadHistoryFromBinaryFile();
            ShowMessageBoxRtl("הנתונים נטענו בהצלחה.", "טעינה הושלמה", MessageBoxIcon.Information);
        }

        private void btnExportText_Click(object sender, EventArgs e)
        {
            if (allRecords.Count == 0)
            {
                ShowMessageBoxRtl("אין נתונים לייצוא.", "דוח ריק", MessageBoxIcon.Information);
                return;
            }

            try
            {
                string exportPath = Path.Combine(Application.StartupPath, "Blackjack_Report.txt");

                using (FileStream fs = new FileStream(exportPath, FileMode.Create, FileAccess.Write))
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteLine("===============================================================================");
                    sw.WriteLine("                    דוח מסכם - היסטוריית משחקי בלאקג'ק                          ");
                    sw.WriteLine("                    הופק על ידי: גיא שטרית                                    ");
                    sw.WriteLine("                    תאריך הפקה: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                    sw.WriteLine("===============================================================================");
                    sw.WriteLine();
                    sw.WriteLine(string.Format("{0,-15} {1,-20} {2,-10} {3,-15} {4,-10} {5,-10} {6,-12}",
                        "שם שחקן", "תאריך", "הימור", "תוצאה", "ניקוד", "דילר", "יתרה סופית"));
                    sw.WriteLine(new string('-', 95));

                    foreach (GameRecord r in allRecords)
                    {
                        sw.WriteLine(string.Format("{0,-15} {1,-20} {2,-10} {3,-15} {4,-10} {5,-10} {6,-12}",
                            r.PlayerName,
                            r.PlayedAt.ToString("dd/MM/yyyy HH:mm"),
                            r.BetAmount + " ₪",
                            r.Result,
                            r.PlayerScore,
                            r.DealerScore,
                            r.FinalBalance + " ₪"));
                    }

                    sw.WriteLine(new string('-', 95));
                    sw.WriteLine();
                    sw.WriteLine("סטטיסטיקה כללית:");
                    sw.WriteLine("  " + lblTotalGames.Text);
                    sw.WriteLine("  " + lblWins.Text);
                    sw.WriteLine("  " + lblLosses.Text);
                    sw.WriteLine("  " + lblPushes.Text);
                    sw.WriteLine("  " + lblWinRate.Text);
                    sw.WriteLine("  " + lblTotalBet.Text);
                    sw.WriteLine();
                    sw.WriteLine("=============================== סוף דוח =======================================");
                }

                ShowMessageBoxRtl(
                    "הדוח נשמר בהצלחה בקובץ:\n" + exportPath,
                    "ייצוא דוח הושלם",
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                ShowMessageBoxRtl("שגיאה בייצוא קובץ: " + ex.Message, "שגיאה", MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show(
                "האם אתה בטוח שברצונך לאפס את כל היסטוריית המשחקים?",
                "אישור מחיקה",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2,
                MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);

            if (res == DialogResult.Yes)
            {
                try
                {
                    if (File.Exists(historyFilePath))
                    {
                        File.Delete(historyFilePath);
                    }
                    allRecords.Clear();
                    DisplayRecords(allRecords);
                    ShowMessageBoxRtl("ההיסטוריה אופסה בהצלחה.", "נמחק", MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    ShowMessageBoxRtl("שגיאה במחיקת הקובץ: " + ex.Message, "שגיאה", MessageBoxIcon.Error);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
