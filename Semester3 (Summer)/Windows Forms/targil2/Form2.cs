using System;
using System.Windows.Forms;

namespace targil2
{
    public partial class Form2 : Form
    {
        public Form2(string items, string prices, double total)
        {
            InitializeComponent();

            lblItems.Text = items;
            lblPrices.Text = prices;
            lblTotal.Text = "Sum total: " +
                            total.ToString("0.##") + " $";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}