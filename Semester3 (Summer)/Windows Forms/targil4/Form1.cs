using System;
using System.IO;
using System.Windows.Forms;

namespace targil4
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            int amount = int.Parse(txtNumber.Text);

            FileStream f = new FileStream("numbers.txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(f);

            for (int i = 0; i < amount; i++)
            {
                sw.WriteLine(rnd.Next(1, 101));
            }

            sw.Close();
            f.Close();

            StreamReader sr = new StreamReader("numbers.txt");

            string line;

            int sum = 0;
            int count = 0;

            int[] freq = new int[101];

            string low = "";
            string high = "";

            while ((line = sr.ReadLine()) != null)
            {
                int num = int.Parse(line);

                sum += num;
                count++;

                freq[num]++;

                if (num <= 50)
                    low += num + " ";

                else
                    high += num + " ";
            }

            sr.Close();

            lblAverage.Text = (sum / (double)count).ToString("0.00");

            int common = 1;

            for (int i = 2; i <= 100; i++)
            {
                if (freq[i] > freq[common])
                    common = i;
            }

            lblCommon.Text = common.ToString();

            lblLow.Text = low;

            lblHigh.Text = high;
        }

        private void txtNumber_TextChanged(object sender, EventArgs e)
        {

        }
    }
}