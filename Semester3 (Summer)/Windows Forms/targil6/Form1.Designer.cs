using System.Drawing;
using System.Windows.Forms;

namespace targil6
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblNameTitle;
        private Label lblPhoneTitle;

        private ListBox lstName;
        private ListBox lstPhone;

        private Button btnShow;
        private Button btnFind;
        private Button btnDelete;
        private Button btnUpdate;

        private TextBox txtInsert;
        private TextBox txtNameInput;
        private TextBox txtPhoneInput;

        private Label lblNameInput;
        private Label lblPhoneInput;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblNameTitle = new Label();
            this.lblPhoneTitle = new Label();

            this.lstName = new ListBox();
            this.lstPhone = new ListBox();

            this.btnShow = new Button();
            this.btnFind = new Button();
            this.btnDelete = new Button();
            this.btnUpdate = new Button();

            this.txtInsert = new TextBox();
            this.txtNameInput = new TextBox();
            this.txtPhoneInput = new TextBox();

            this.lblNameInput = new Label();
            this.lblPhoneInput = new Label();

            this.SuspendLayout();

            //
            // lblNameTitle
            //
            this.lblNameTitle.AutoSize = true;
            this.lblNameTitle.Font =
                new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            this.lblNameTitle.Location = new Point(95, 30);
            this.lblNameTitle.Name = "lblNameTitle";
            this.lblNameTitle.Text = "Name";

            //
            // lblPhoneTitle
            //
            this.lblPhoneTitle.AutoSize = true;
            this.lblPhoneTitle.Font =
                new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            this.lblPhoneTitle.Location = new Point(310, 30);
            this.lblPhoneTitle.Name = "lblPhoneTitle";
            this.lblPhoneTitle.Text = "Phone";

            //
            // lstName
            //
            this.lstName.FormattingEnabled = true;
            this.lstName.Location = new Point(45, 65);
            this.lstName.Name = "lstName";
            this.lstName.Size = new Size(160, 220);

            //
            // lstPhone
            //
            this.lstPhone.FormattingEnabled = true;
            this.lstPhone.Location = new Point(260, 65);
            this.lstPhone.Name = "lstPhone";
            this.lstPhone.Size = new Size(160, 220);

            //
            // btnShow
            //
            this.btnShow.Location = new Point(35, 335);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new Size(90, 40);
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click +=
                new System.EventHandler(this.btnShow_Click);

            //
            // btnFind
            //
            this.btnFind.Location = new Point(145, 335);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new Size(90, 40);
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click +=
                new System.EventHandler(this.btnFind_Click);

            //
            // btnDelete
            //
            this.btnDelete.Location = new Point(255, 335);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new Size(90, 40);
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click +=
                new System.EventHandler(this.btnDelete_Click);

            //
            // txtInsert
            //
            this.txtInsert.Location = new Point(365, 345);
            this.txtInsert.Name = "txtInsert";
            this.txtInsert.Size = new Size(130, 22);
            this.txtInsert.Text = "Insert";

            //
            // lblNameInput
            //
            this.lblNameInput.AutoSize = true;
            this.lblNameInput.Location = new Point(520, 315);
            this.lblNameInput.Name = "lblNameInput";
            this.lblNameInput.Text = "Name";

            //
            // txtNameInput
            //
            this.txtNameInput.Location = new Point(575, 312);
            this.txtNameInput.Name = "txtNameInput";
            this.txtNameInput.Size = new Size(140, 22);

            //
            // lblPhoneInput
            //
            this.lblPhoneInput.AutoSize = true;
            this.lblPhoneInput.Location = new Point(520, 355);
            this.lblPhoneInput.Name = "lblPhoneInput";
            this.lblPhoneInput.Text = "Phone";

            //
            // txtPhoneInput
            //
            this.txtPhoneInput.Location = new Point(575, 352);
            this.txtPhoneInput.Name = "txtPhoneInput";
            this.txtPhoneInput.Size = new Size(140, 22);

            //
            // btnUpdate
            //
            this.btnUpdate.Location = new Point(575, 395);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new Size(140, 40);
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click +=
                new System.EventHandler(this.btnUpdate_Click);

            //
            // Form1
            //
            this.AutoScaleDimensions = new SizeF(8F, 16F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(760, 475);

            this.Controls.Add(this.lblNameTitle);
            this.Controls.Add(this.lblPhoneTitle);

            this.Controls.Add(this.lstName);
            this.Controls.Add(this.lstPhone);

            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnDelete);

            this.Controls.Add(this.txtInsert);

            this.Controls.Add(this.lblNameInput);
            this.Controls.Add(this.txtNameInput);

            this.Controls.Add(this.lblPhoneInput);
            this.Controls.Add(this.txtPhoneInput);

            this.Controls.Add(this.btnUpdate);

            this.Name = "Form1";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "SQL Data";

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}