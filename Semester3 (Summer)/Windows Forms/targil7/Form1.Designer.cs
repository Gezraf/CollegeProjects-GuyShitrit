using System.Drawing;
using System.Windows.Forms;

namespace targil7
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitle;
        private FlowLayoutPanel pnlGallery;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new Label();
            this.pnlGallery = new FlowLayoutPanel();

            this.SuspendLayout();

            //
            // lblTitle
            //
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font =
                new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);

            this.lblTitle.Location = new Point(30, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Text = "Students Gallery";

            //
            // pnlGallery
            //
            this.pnlGallery.AutoScroll = true;
            this.pnlGallery.BorderStyle = BorderStyle.FixedSingle;
            this.pnlGallery.Location = new Point(30, 70);
            this.pnlGallery.Name = "pnlGallery";
            this.pnlGallery.Size = new Size(1000, 600);
            this.pnlGallery.TabIndex = 0;
            this.pnlGallery.WrapContents = true;

            //
            // Form1
            //
            this.AutoScaleDimensions = new SizeF(8F, 16F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(1060, 700);

            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pnlGallery);

            this.Name = "Form1";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Students Gallery";

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}