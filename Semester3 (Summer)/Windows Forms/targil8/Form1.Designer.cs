using System.Drawing;
using System.Windows.Forms;

namespace targil8
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private Button btnFlip;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnFlip = new Button();

            this.SuspendLayout();

            //
            // btnFlip
            //
            this.btnFlip.Location = new Point(325, 500);
            this.btnFlip.Name = "btnFlip";
            this.btnFlip.Size = new Size(150, 50);
            this.btnFlip.Text = "Flip";
            this.btnFlip.UseVisualStyleBackColor = true;

            this.btnFlip.Click +=
                new System.EventHandler(this.btnFlip_Click);

            //
            // Form1
            //
            this.AutoScaleDimensions = new SizeF(8F, 16F);
            this.AutoScaleMode = AutoScaleMode.Font;

            this.ClientSize = new Size(800, 600);

            this.Controls.Add(this.btnFlip);

            this.Name = "Form1";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Image Flip";

            this.ResumeLayout(false);
        }
    }
}