using System.Drawing;
using System.Windows.Forms;

namespace targil2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitle;
        private Label lblYourPizza;
        private Label lblPizza;

        private GroupBox grpPizzaName;
        private RadioButton rdVegetarian;
        private RadioButton rdCapricciosa;
        private RadioButton rdSuprime;

        private GroupBox grpSize;
        private RadioButton rdSmall;
        private RadioButton rdMedium;
        private RadioButton rdLarge;

        private GroupBox grpTopping;
        private CheckBox chkMushrooms;
        private CheckBox chkOnions;
        private CheckBox chkTomatoes;
        private CheckBox chkGreenPeppers;

        private Button btnBuild;
        private Button btnExit;
        private Button btnChange;
        private Button btnBill;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new Label();
            this.lblYourPizza = new Label();
            this.lblPizza = new Label();

            this.grpPizzaName = new GroupBox();
            this.rdVegetarian = new RadioButton();
            this.rdCapricciosa = new RadioButton();
            this.rdSuprime = new RadioButton();

            this.grpSize = new GroupBox();
            this.rdSmall = new RadioButton();
            this.rdMedium = new RadioButton();
            this.rdLarge = new RadioButton();

            this.grpTopping = new GroupBox();
            this.chkMushrooms = new CheckBox();
            this.chkOnions = new CheckBox();
            this.chkTomatoes = new CheckBox();
            this.chkGreenPeppers = new CheckBox();

            this.btnBuild = new Button();
            this.btnExit = new Button();
            this.btnChange = new Button();
            this.btnBill = new Button();

            this.grpPizzaName.SuspendLayout();
            this.grpSize.SuspendLayout();
            this.grpTopping.SuspendLayout();
            this.SuspendLayout();

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font =
                new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            this.lblTitle.Location = new Point(190, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Text = "Build Pizza";

            // lblYourPizza
            this.lblYourPizza.AutoSize = true;
            this.lblYourPizza.Location = new Point(205, 70);
            this.lblYourPizza.Name = "lblYourPizza";
            this.lblYourPizza.Text = "Your Pizza Is:";

            // lblPizza
            this.lblPizza.Location = new Point(205, 95);
            this.lblPizza.Name = "lblPizza";
            this.lblPizza.Size = new Size(160, 100);

            // grpPizzaName
            this.grpPizzaName.Controls.Add(this.rdVegetarian);
            this.grpPizzaName.Controls.Add(this.rdCapricciosa);
            this.grpPizzaName.Controls.Add(this.rdSuprime);
            this.grpPizzaName.ForeColor = Color.Blue;
            this.grpPizzaName.Location = new Point(15, 55);
            this.grpPizzaName.Name = "grpPizzaName";
            this.grpPizzaName.Size = new Size(145, 155);
            this.grpPizzaName.Text = "Pizza Name";

            // rdVegetarian
            this.rdVegetarian.AutoSize = true;
            this.rdVegetarian.Checked = true;
            this.rdVegetarian.ForeColor = Color.Black;
            this.rdVegetarian.Location = new Point(15, 30);
            this.rdVegetarian.Name = "rdVegetarian";
            this.rdVegetarian.Text = "Vegetarian";

            // rdCapricciosa
            this.rdCapricciosa.AutoSize = true;
            this.rdCapricciosa.ForeColor = Color.Black;
            this.rdCapricciosa.Location = new Point(15, 70);
            this.rdCapricciosa.Name = "rdCapricciosa";
            this.rdCapricciosa.Text = "Capricciosa";

            // rdSuprime
            this.rdSuprime.AutoSize = true;
            this.rdSuprime.ForeColor = Color.Black;
            this.rdSuprime.Location = new Point(15, 110);
            this.rdSuprime.Name = "rdSuprime";
            this.rdSuprime.Text = "Suprime";

            // grpSize
            this.grpSize.Controls.Add(this.rdSmall);
            this.grpSize.Controls.Add(this.rdMedium);
            this.grpSize.Controls.Add(this.rdLarge);
            this.grpSize.ForeColor = Color.Blue;
            this.grpSize.Location = new Point(15, 225);
            this.grpSize.Name = "grpSize";
            this.grpSize.Size = new Size(145, 145);
            this.grpSize.Text = "Size";

            // rdSmall
            this.rdSmall.AutoSize = true;
            this.rdSmall.ForeColor = Color.Black;
            this.rdSmall.Location = new Point(15, 30);
            this.rdSmall.Name = "rdSmall";
            this.rdSmall.Text = "Small";

            // rdMedium
            this.rdMedium.AutoSize = true;
            this.rdMedium.Checked = true;
            this.rdMedium.ForeColor = Color.Black;
            this.rdMedium.Location = new Point(15, 70);
            this.rdMedium.Name = "rdMedium";
            this.rdMedium.Text = "Medium";

            // rdLarge
            this.rdLarge.AutoSize = true;
            this.rdLarge.ForeColor = Color.Black;
            this.rdLarge.Location = new Point(15, 110);
            this.rdLarge.Name = "rdLarge";
            this.rdLarge.Text = "Large";

            // grpTopping
            this.grpTopping.Controls.Add(this.chkMushrooms);
            this.grpTopping.Controls.Add(this.chkOnions);
            this.grpTopping.Controls.Add(this.chkTomatoes);
            this.grpTopping.Controls.Add(this.chkGreenPeppers);
            this.grpTopping.ForeColor = Color.Blue;
            this.grpTopping.Location = new Point(205, 225);
            this.grpTopping.Name = "grpTopping";
            this.grpTopping.Size = new Size(315, 120);
            this.grpTopping.Text = "Topping";

            // chkMushrooms
            this.chkMushrooms.AutoSize = true;
            this.chkMushrooms.Checked = true;
            this.chkMushrooms.ForeColor = Color.Black;
            this.chkMushrooms.Location = new Point(20, 35);
            this.chkMushrooms.Name = "chkMushrooms";
            this.chkMushrooms.Text = "Mushrooms";

            // chkOnions
            this.chkOnions.AutoSize = true;
            this.chkOnions.Checked = true;
            this.chkOnions.ForeColor = Color.Black;
            this.chkOnions.Location = new Point(180, 35);
            this.chkOnions.Name = "chkOnions";
            this.chkOnions.Text = "Onions";

            // chkTomatoes
            this.chkTomatoes.AutoSize = true;
            this.chkTomatoes.ForeColor = Color.Black;
            this.chkTomatoes.Location = new Point(20, 80);
            this.chkTomatoes.Name = "chkTomatoes";
            this.chkTomatoes.Text = "Tomatoes";

            // chkGreenPeppers
            this.chkGreenPeppers.AutoSize = true;
            this.chkGreenPeppers.ForeColor = Color.Black;
            this.chkGreenPeppers.Location = new Point(180, 80);
            this.chkGreenPeppers.Name = "chkGreenPeppers";
            this.chkGreenPeppers.Text = "Green Peppers";

            // btnBuild
            this.btnBuild.Location = new Point(55, 390);
            this.btnBuild.Name = "btnBuild";
            this.btnBuild.Size = new Size(80, 30);
            this.btnBuild.Text = "Build";
            this.btnBuild.Click +=
                new System.EventHandler(this.btnBuild_Click);

            // btnExit
            this.btnExit.Location = new Point(205, 390);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new Size(80, 30);
            this.btnExit.Text = "Exit";
            this.btnExit.Click +=
                new System.EventHandler(this.btnExit_Click);

            // btnChange
            this.btnChange.Location = new Point(355, 390);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new Size(80, 30);
            this.btnChange.Text = "Change";
            this.btnChange.Click +=
                new System.EventHandler(this.btnChange_Click);

            // btnBill
            this.btnBill.Location = new Point(485, 390);
            this.btnBill.Name = "btnBill";
            this.btnBill.Size = new Size(80, 30);
            this.btnBill.Text = "Bill";
            this.btnBill.Click +=
                new System.EventHandler(this.btnBill_Click);

            // Form1
            this.AutoScaleDimensions = new SizeF(8F, 16F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.LightYellow;
            this.ClientSize = new Size(590, 450);

            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblYourPizza);
            this.Controls.Add(this.lblPizza);
            this.Controls.Add(this.grpPizzaName);
            this.Controls.Add(this.grpSize);
            this.Controls.Add(this.grpTopping);
            this.Controls.Add(this.btnBuild);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnBill);

            this.Name = "Form1";
            this.Text = "Pizza Order";

            this.grpPizzaName.ResumeLayout(false);
            this.grpPizzaName.PerformLayout();
            this.grpSize.ResumeLayout(false);
            this.grpSize.PerformLayout();
            this.grpTopping.ResumeLayout(false);
            this.grpTopping.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}