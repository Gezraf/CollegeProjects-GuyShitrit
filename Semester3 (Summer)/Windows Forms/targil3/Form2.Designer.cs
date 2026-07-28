using System.Drawing;
using System.Windows.Forms;

namespace targil3
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblStudents;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblStudents = new System.Windows.Forms.Label();
            this.SuspendLayout();
  


            this.lblStudents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStudents.Location = new System.Drawing.Point(19, 20);
            this.lblStudents.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStudents.Name = "lblStudents";
            this.lblStudents.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblStudents.Size = new System.Drawing.Size(638, 285);
            this.lblStudents.TabIndex = 0;
            this.lblStudents.TextAlign = System.Drawing.ContentAlignment.TopRight;




            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 325);
            this.Controls.Add(this.lblStudents);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form2";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "רשימת סטודנטים";
            this.ResumeLayout(false);

        }

        #endregion
    }
}