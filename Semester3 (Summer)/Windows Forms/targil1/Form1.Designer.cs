using System.Windows.Forms;
using System.Drawing;

namespace targil1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitle, lblFirstVal, lblSecondVal, lblRes;
        private TextBox txtVal1, txtVal2;
        private RadioButton rdAdd, rdSub, rdMul, rdDiv;
        private Button btnCalc, btnClear, btnExit;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new Label();
            this.lblFirstVal = new Label();
            this.lblSecondVal = new Label();
            this.txtVal1 = new TextBox();
            this.txtVal2 = new TextBox();
            this.lblRes = new Label();
            this.rdAdd = new RadioButton();
            this.rdSub = new RadioButton();
            this.rdMul = new RadioButton();
            this.rdDiv = new RadioButton();
            this.btnCalc = new Button();
            this.btnExit = new Button();
            this.btnClear = new Button();
            this.SuspendLayout();

            this.BackColor = Color.LightYellow;

            this.lblTitle.BackColor = Color.PaleGreen;
            this.lblTitle.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold);
            this.lblTitle.ForeColor = Color.Blue;
            this.lblTitle.Location = new Point(90, 25);
            this.lblTitle.Size = new Size(300, 32);
            this.lblTitle.Text = "Calculator";
            this.lblTitle.TextAlign = ContentAlignment.MiddleCenter;

            this.lblSecondVal.AutoSize = true;
            this.lblSecondVal.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold);
            this.lblSecondVal.ForeColor = Color.Blue;
            this.lblSecondVal.Location = new Point(170, 80);
            this.lblSecondVal.Text = "Value 2";

            this.lblFirstVal.AutoSize = true;
            this.lblFirstVal.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold);
            this.lblFirstVal.ForeColor = Color.Blue;
            this.lblFirstVal.Location = new Point(315, 80);
            this.lblFirstVal.Text = "Value 1";

            this.txtVal2.Location = new Point(145, 105);
            this.txtVal2.Size = new Size(95, 22);

            this.txtVal1.Location = new Point(285, 105);
            this.txtVal1.Size = new Size(100, 22);

            this.lblRes.BorderStyle = BorderStyle.Fixed3D;
            this.lblRes.Location = new Point(145, 145);
            this.lblRes.Size = new Size(240, 25);

            this.rdAdd.AutoSize = true;
            this.rdAdd.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold);
            this.rdAdd.ForeColor = Color.Blue;
            this.rdAdd.Location = new Point(25, 130);
            this.rdAdd.Text = "Add";

            this.rdSub.AutoSize = true;
            this.rdSub.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold);
            this.rdSub.ForeColor = Color.Blue;
            this.rdSub.Location = new Point(25, 155);
            this.rdSub.Text = "Sub";

            this.rdMul.AutoSize = true;
            this.rdMul.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold);
            this.rdMul.ForeColor = Color.Blue;
            this.rdMul.Location = new Point(25, 180);
            this.rdMul.Text = "Mul";

            this.rdDiv.AutoSize = true;
            this.rdDiv.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold);
            this.rdDiv.ForeColor = Color.Blue;
            this.rdDiv.Location = new Point(25, 205);
            this.rdDiv.Text = "Div";

            this.btnCalc.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold);
            this.btnCalc.ForeColor = Color.Blue;
            this.btnCalc.Location = new Point(145, 195);
            this.btnCalc.Size = new Size(235, 27);
            this.btnCalc.Text = "=";
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);

            this.btnClear.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold);
            this.btnClear.ForeColor = Color.Blue;
            this.btnClear.Location = new Point(145, 245);
            this.btnClear.Size = new Size(95, 27);
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            this.btnExit.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold);
            this.btnExit.ForeColor = Color.Blue;
            this.btnExit.Location = new Point(285, 245);
            this.btnExit.Size = new Size(95, 27);
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);

            this.AutoScaleDimensions = new SizeF(8F, 16F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(450, 320);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblFirstVal);
            this.Controls.Add(this.lblSecondVal);
            this.Controls.Add(this.txtVal1);
            this.Controls.Add(this.txtVal2);
            this.Controls.Add(this.lblRes);
            this.Controls.Add(this.rdAdd);
            this.Controls.Add(this.rdSub);
            this.Controls.Add(this.rdMul);
            this.Controls.Add(this.rdDiv);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}