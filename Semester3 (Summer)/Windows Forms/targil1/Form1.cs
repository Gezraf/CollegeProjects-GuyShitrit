using System;
using System.Windows.Forms;

namespace targil1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            float val1 = float.Parse(txtVal1.Text);
            float val2 = float.Parse(txtVal2.Text);

            if (rdAdd.Checked == true)
                lblRes.Text = Convert.ToString(val1 + val2);
            else if (rdSub.Checked == true)
                lblRes.Text = Convert.ToString(val1 - val2);
            else if (rdMul.Checked == true)
                lblRes.Text = Convert.ToString(val1 * val2);
            else if (rdDiv.Checked == true)
                lblRes.Text = Convert.ToString(val1 / val2);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtVal1.Text = "";
            txtVal2.Text = "";
            lblRes.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}