using System;
using System.Windows.Forms;
using Blackjack.Models;

namespace Blackjack.Forms
{
    public partial class FormWelcome : Form
    {
        public FormWelcome()
        {
            InitializeComponent();

            cmbBudget.SelectedIndex = 1; // 1000
            cmbDecks.SelectedIndex = 0;  // חפיסה אחת
            cmbRules.SelectedIndex = 0;  // Standard
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            string playerName = txtPlayerName.Text.Trim();
            if (string.IsNullOrEmpty(playerName))
            {
                MessageBox.Show(
                    "נא להזין שם שחקן.",
                    "שגיאת קלט",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
                txtPlayerName.Focus();
                return;
            }

            int startingBalance = 1000;
            switch (cmbBudget.SelectedIndex)
            {
                case 0: startingBalance = 500; break;
                case 1: startingBalance = 1000; break;
                case 2: startingBalance = 2500; break;
                case 3: startingBalance = 5000; break;
            }

            int decksCount = 1;
            switch (cmbDecks.SelectedIndex)
            {
                case 0: decksCount = 1; break;
                case 1: decksCount = 2; break;
                case 2: decksCount = 4; break;
            }

            bool hitSoft17 = (cmbRules.SelectedIndex == 1);
            bool fastDeal = chkFastDeal.Checked;

            Player player = new Player(playerName, startingBalance);

            this.Hide();
            using (FormGame gameForm = new FormGame(player, decksCount, hitSoft17, fastDeal))
            {
                gameForm.ShowDialog();
            }
            this.Show();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            using (FormHistory historyForm = new FormHistory())
            {
                historyForm.ShowDialog();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show(
                "האם אתה בטוח שברצונך לצאת מהמשחק?",
                "אישור יציאה",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2,
                MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);

            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
