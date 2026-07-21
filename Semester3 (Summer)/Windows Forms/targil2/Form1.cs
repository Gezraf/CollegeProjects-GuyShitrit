using System;
using System.Windows.Forms;
using targil2;

namespace targil2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string GetPizzaName()
        {
            if (rdVegetarian.Checked)
                return "Vegetarian";

            if (rdCapricciosa.Checked)
                return "Capricciosa";

            if (rdSuprime.Checked)
                return "Suprime";

            return "";
        }

        private string GetSizeName()
        {
            if (rdSmall.Checked)
                return "Small";

            if (rdMedium.Checked)
                return "Medium";

            if (rdLarge.Checked)
                return "Large";

            return "";
        }

        private double GetBasePrice()
        {
            if (rdVegetarian.Checked)
                return 2;

            if (rdCapricciosa.Checked)
                return 2.5;

            if (rdSuprime.Checked)
                return 3;

            return 0;
        }

        private double GetSizePrice()
        {
            double basePrice = GetBasePrice();

            if (rdMedium.Checked)
                return basePrice * 0.5;

            if (rdLarge.Checked)
                return basePrice * 0.7;

            return 0;
        }

        private double GetTotalPrice()
        {
            double total = GetBasePrice() + GetSizePrice();

            if (chkMushrooms.Checked)
                total += 0.5;

            if (chkOnions.Checked)
                total += 0.4;

            if (chkTomatoes.Checked)
                total += 0.3;

            if (chkGreenPeppers.Checked)
                total += 0.2;

            return total;
        }

        private string GetPizzaDescription()
        {
            string description = GetPizzaName();

            if (GetSizeName() != "")
                description += Environment.NewLine + GetSizeName();

            if (chkMushrooms.Checked)
                description += Environment.NewLine + "Mushrooms";

            if (chkOnions.Checked)
                description += Environment.NewLine + "Onions";

            if (chkTomatoes.Checked)
                description += Environment.NewLine + "Tomatoes";

            if (chkGreenPeppers.Checked)
                description += Environment.NewLine + "Green Peppers";

            return description;
        }

        private void btnBuild_Click(object sender, EventArgs e)
        {
            lblPizza.Text = GetPizzaDescription();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            rdVegetarian.Checked = false;
            rdCapricciosa.Checked = false;
            rdSuprime.Checked = false;

            rdSmall.Checked = false;
            rdMedium.Checked = false;
            rdLarge.Checked = false;

            chkMushrooms.Checked = false;
            chkOnions.Checked = false;
            chkTomatoes.Checked = false;
            chkGreenPeppers.Checked = false;

            lblPizza.Text = "";
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            string items = "";
            string prices = "";

            if (GetPizzaName() != "")
            {
                items += GetPizzaName() + Environment.NewLine;
                prices += GetBasePrice().ToString("0.##") + " $" +
                          Environment.NewLine;
            }

            if (GetSizeName() != "")
            {
                items += GetSizeName() + Environment.NewLine;
                prices += GetSizePrice().ToString("0.##") + " $" +
                          Environment.NewLine;
            }

            if (chkMushrooms.Checked)
            {
                items += "Mushrooms" + Environment.NewLine;
                prices += "0.5 $" + Environment.NewLine;
            }

            if (chkOnions.Checked)
            {
                items += "Onions" + Environment.NewLine;
                prices += "0.4 $" + Environment.NewLine;
            }

            if (chkTomatoes.Checked)
            {
                items += "Tomatoes" + Environment.NewLine;
                prices += "0.3 $" + Environment.NewLine;
            }

            if (chkGreenPeppers.Checked)
            {
                items += "Green Peppers" + Environment.NewLine;
                prices += "0.2 $" + Environment.NewLine;
            }

            Form2 bill = new Form2(items, prices, GetTotalPrice());
            bill.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}