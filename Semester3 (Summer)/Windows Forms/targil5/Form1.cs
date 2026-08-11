using System;
using System.Windows.Forms;

namespace targil5
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();

        int num1;
        int num2;
        char sign;
        double correctAnswer;

        string[] good = new string[100];
        string[] bad = new string[100];

        int goodCount = 0;
        int badCount = 0;

        public Form1()
        {
            InitializeComponent();

            NewQuestion();
        }

        private void NewQuestion()
        {
            num1 = rnd.Next(1, 101);
            num2 = rnd.Next(1, 101);

            int operation = rnd.Next(1, 5);

            if (operation == 1)
            {
                sign = '+';
                correctAnswer = num1 + num2;
            }
            else if (operation == 2)
            {
                sign = '-';
                correctAnswer = num1 - num2;
            }
            else if (operation == 3)
            {
                sign = '*';
                correctAnswer = num1 * num2;
            }
            else
            {
                sign = '/';
                correctAnswer = num1 / (double)num2;
            }

            lblNum1.Text = num1.ToString();
            lblNum2.Text = num2.ToString();
            lblSign.Text = sign.ToString();

            txtAnswer.Text = "";

            btnCheck.Enabled = true;
            btnNewTargil.Enabled = false;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            double userAnswer;

            if (double.TryParse(txtAnswer.Text, out userAnswer) == false)
            {
                MessageBox.Show("Please enter a numeric value.");
                return;
            }

            string equation =
                num1 + " " +
                sign + " " +
                num2 + " = " +
                userAnswer;

            if (Math.Abs(userAnswer - correctAnswer) < 0.001)
            {
                good[goodCount] = equation;
                goodCount++;
            }
            else
            {
                bad[badCount] = equation;
                badCount++;
            }

            btnCheck.Enabled = false;
            btnNewTargil.Enabled = true;
        }

        private void btnNewTargil_Click(object sender, EventArgs e)
        {
            NewQuestion();
        }

        private void btnGood_Click(object sender, EventArgs e)
        {
            lstResults.Items.Clear();

            for (int i = 0; i < goodCount; i++)
            {
                lstResults.Items.Add(good[i]);
            }
        }

        private void btnBad_Click(object sender, EventArgs e)
        {
            lstResults.Items.Clear();

            for (int i = 0; i < badCount; i++)
            {
                lstResults.Items.Add(bad[i]);
            }
        }
    }
}