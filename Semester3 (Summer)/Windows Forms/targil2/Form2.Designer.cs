using System.Drawing;
using System.Windows.Forms;

namespace targil2
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitle;
        private Label lblItems;
        private Label lblPrices;
        private Label lblTotal;
        private Button btnClose;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new Label();
            this.lblItems = new Label();
            this.lblPrices = new Label();
            this.lblTotal = new Label();
            this.btnClose = new Button();

            this.SuspendLayout();

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new Point(25, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Text = "Your pizza is:";

            // lblItems
            this.lblItems.Location = new Point(130, 55);
            this.lblItems.Name = "lblItems";
            this.lblItems.Size = new Size(130, 145);

            // lblPrices
            this.lblPrices.Location = new Point(270, 55);
            this.lblPrices.Name = "lblPrices";
            this.lblPrices.Size = new Size(80, 145);

            // lblTotal
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new Point(270, 200);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Text = "Sum total:";

            // btnClose
            this.btnClose.Location = new Point(165, 260);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new Size(90, 30);
            this.btnClose.Text = "Close";
            this.btnClose.Click +=
                new System.EventHandler(this.btnClose_Click);

            // Form2
            this.AutoScaleDimensions = new SizeF(8F, 16F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.LightYellow;
            this.ClientSize = new Size(400, 330);

            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblItems);
            this.Controls.Add(this.lblPrices);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnClose);

            this.Name = "Form2";
            this.Text = "Your bill is";

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}