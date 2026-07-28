using System.Drawing;
using System.Windows.Forms;

namespace targil3
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private GroupBox grpStudentDetails;
        private Label lblStudentName;
        private Label lblStudentAge;
        private TextBox txtStudentName;
        private TextBox txtStudentAge;
        private Button btnCheckDetails;

        private GroupBox grpPaymentDetails;
        private Label lblPayments;
        private RadioButton rdCash;
        private RadioButton rdCredit;
        private ListBox lstPayments;
        private Button btnCheckPayment;
        private Button btnSave;

        private Button btnShowStudents;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.grpStudentDetails = new System.Windows.Forms.GroupBox();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.lblStudentAge = new System.Windows.Forms.Label();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.txtStudentAge = new System.Windows.Forms.TextBox();
            this.btnCheckDetails = new System.Windows.Forms.Button();
            this.grpPaymentDetails = new System.Windows.Forms.GroupBox();
            this.lblPayments = new System.Windows.Forms.Label();
            this.rdCash = new System.Windows.Forms.RadioButton();
            this.rdCredit = new System.Windows.Forms.RadioButton();
            this.lstPayments = new System.Windows.Forms.ListBox();
            this.btnCheckPayment = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnShowStudents = new System.Windows.Forms.Button();
            this.cmbFirstLanguage = new System.Windows.Forms.ComboBox();
            this.cmbSecondLanguage = new System.Windows.Forms.ComboBox();
            this.grpStudentDetails.SuspendLayout();
            this.grpPaymentDetails.SuspendLayout();
            this.SuspendLayout();
  

            this.grpStudentDetails.Controls.Add(this.cmbSecondLanguage);
            this.grpStudentDetails.Controls.Add(this.cmbFirstLanguage);
            this.grpStudentDetails.Controls.Add(this.lblStudentName);
            this.grpStudentDetails.Controls.Add(this.lblStudentAge);
            this.grpStudentDetails.Controls.Add(this.txtStudentName);
            this.grpStudentDetails.Controls.Add(this.txtStudentAge);
            this.grpStudentDetails.Controls.Add(this.btnCheckDetails);
            this.grpStudentDetails.Location = new System.Drawing.Point(19, 16);
            this.grpStudentDetails.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpStudentDetails.Name = "grpStudentDetails";
            this.grpStudentDetails.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpStudentDetails.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grpStudentDetails.Size = new System.Drawing.Size(525, 179);
            this.grpStudentDetails.TabIndex = 0;
            this.grpStudentDetails.TabStop = false;
            this.grpStudentDetails.Text = "פרטי הסטודנט";


            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Location = new System.Drawing.Point(433, 42);
            this.lblStudentName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(71, 13);
            this.lblStudentName.TabIndex = 0;
            this.lblStudentName.Text = "שם הסטודנט";
            this.lblStudentName.Click += new System.EventHandler(this.lblStudentName_Click);


            this.lblStudentAge.AutoSize = true;
            this.lblStudentAge.Location = new System.Drawing.Point(431, 96);
            this.lblStudentAge.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStudentAge.Name = "lblStudentAge";
            this.lblStudentAge.Size = new System.Drawing.Size(73, 13);
            this.lblStudentAge.TabIndex = 2;
            this.lblStudentAge.Text = "גיל הסטודנט";
            this.lblStudentAge.Click += new System.EventHandler(this.lblStudentAge_Click);


            this.txtStudentName.Location = new System.Drawing.Point(405, 57);
            this.txtStudentName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(98, 20);
            this.txtStudentName.TabIndex = 1;


            this.txtStudentAge.Location = new System.Drawing.Point(405, 111);
            this.txtStudentAge.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtStudentAge.Name = "txtStudentAge";
            this.txtStudentAge.Size = new System.Drawing.Size(98, 20);
            this.txtStudentAge.TabIndex = 3;


            this.btnCheckDetails.Location = new System.Drawing.Point(82, 125);
            this.btnCheckDetails.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCheckDetails.Name = "btnCheckDetails";
            this.btnCheckDetails.Size = new System.Drawing.Size(135, 28);
            this.btnCheckDetails.TabIndex = 8;
            this.btnCheckDetails.Text = "בדיקת פרטים";
            this.btnCheckDetails.UseVisualStyleBackColor = true;
            this.btnCheckDetails.Click += new System.EventHandler(this.btnCheckDetails_Click);


            this.grpPaymentDetails.Controls.Add(this.lblPayments);
            this.grpPaymentDetails.Controls.Add(this.rdCash);
            this.grpPaymentDetails.Controls.Add(this.rdCredit);
            this.grpPaymentDetails.Controls.Add(this.lstPayments);
            this.grpPaymentDetails.Controls.Add(this.btnCheckPayment);
            this.grpPaymentDetails.Controls.Add(this.btnSave);
            this.grpPaymentDetails.Location = new System.Drawing.Point(19, 207);
            this.grpPaymentDetails.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpPaymentDetails.Name = "grpPaymentDetails";
            this.grpPaymentDetails.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpPaymentDetails.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grpPaymentDetails.Size = new System.Drawing.Size(525, 171);
            this.grpPaymentDetails.TabIndex = 1;
            this.grpPaymentDetails.TabStop = false;
            this.grpPaymentDetails.Text = "פרטי תשלום";


            this.lblPayments.AutoSize = true;
            this.lblPayments.Location = new System.Drawing.Point(360, 58);
            this.lblPayments.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPayments.Name = "lblPayments";
            this.lblPayments.Size = new System.Drawing.Size(84, 13);
            this.lblPayments.TabIndex = 3;
            this.lblPayments.Text = "מספר תשלומים";


            this.rdCash.AutoSize = true;
            this.rdCash.Checked = true;
            this.rdCash.Location = new System.Drawing.Point(447, 24);
            this.rdCash.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdCash.Name = "rdCash";
            this.rdCash.Size = new System.Drawing.Size(54, 17);
            this.rdCash.TabIndex = 1;
            this.rdCash.TabStop = true;
            this.rdCash.Text = "מזומן";
            this.rdCash.UseVisualStyleBackColor = true;
            this.rdCash.CheckedChanged += new System.EventHandler(this.rdCash_CheckedChanged);


            this.rdCredit.AutoSize = true;
            this.rdCredit.Location = new System.Drawing.Point(380, 24);
            this.rdCredit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdCredit.Name = "rdCredit";
            this.rdCredit.Size = new System.Drawing.Size(61, 17);
            this.rdCredit.TabIndex = 2;
            this.rdCredit.Text = "אשראי";
            this.rdCredit.UseVisualStyleBackColor = true;
            this.rdCredit.CheckedChanged += new System.EventHandler(this.rdCredit_CheckedChanged);


            this.lstPayments.FormattingEnabled = true;
            this.lstPayments.Location = new System.Drawing.Point(364, 83);
            this.lstPayments.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstPayments.Name = "lstPayments";
            this.lstPayments.Size = new System.Drawing.Size(61, 56);
            this.lstPayments.TabIndex = 4;
            this.lstPayments.SelectedIndexChanged += new System.EventHandler(this.lstPayments_SelectedIndexChanged);


            this.btnCheckPayment.Location = new System.Drawing.Point(188, 118);
            this.btnCheckPayment.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCheckPayment.Name = "btnCheckPayment";
            this.btnCheckPayment.Size = new System.Drawing.Size(116, 28);
            this.btnCheckPayment.TabIndex = 5;
            this.btnCheckPayment.Text = "בדיקת תשלום";
            this.btnCheckPayment.UseVisualStyleBackColor = true;
            this.btnCheckPayment.Click += new System.EventHandler(this.btnCheckPayment_Click);


            this.btnSave.Location = new System.Drawing.Point(52, 118);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(98, 28);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "שמירה";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);


            this.btnShowStudents.Location = new System.Drawing.Point(371, 401);
            this.btnShowStudents.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnShowStudents.Name = "btnShowStudents";
            this.btnShowStudents.Size = new System.Drawing.Size(158, 31);
            this.btnShowStudents.TabIndex = 2;
            this.btnShowStudents.Text = "הצג רשימת סטודנטים";
            this.btnShowStudents.UseVisualStyleBackColor = true;
            this.btnShowStudents.Click += new System.EventHandler(this.btnShowStudents_Click);


            this.cmbFirstLanguage.FormattingEnabled = true;
            this.cmbFirstLanguage.Items.AddRange(new object[] {
            "אנגלית",
            "גרמנית",
            "ספרדית",
            "צרפתית",
            "סינית"});
            this.cmbFirstLanguage.Location = new System.Drawing.Point(237, 56);
            this.cmbFirstLanguage.Name = "cmbFirstLanguage";
            this.cmbFirstLanguage.Size = new System.Drawing.Size(95, 21);
            this.cmbFirstLanguage.TabIndex = 9;
            this.cmbFirstLanguage.Text = "שפה ראשונה";
            this.cmbFirstLanguage.SelectedIndexChanged += new System.EventHandler(this.cmbFirstLanguage_SelectedIndexChanged_1);


            this.cmbSecondLanguage.DropDownWidth = 95;
            this.cmbSecondLanguage.FormattingEnabled = true;
            this.cmbSecondLanguage.Items.AddRange(new object[] {
            "אנגלית",
            "גרמנית",
            "ספרדית",
            "צרפתית",
            "סינית"});
            this.cmbSecondLanguage.Location = new System.Drawing.Point(119, 55);
            this.cmbSecondLanguage.Name = "cmbSecondLanguage";
            this.cmbSecondLanguage.Size = new System.Drawing.Size(89, 21);
            this.cmbSecondLanguage.TabIndex = 10;
            this.cmbSecondLanguage.Text = "שפה שנייה";
            this.cmbSecondLanguage.SelectedIndexChanged += new System.EventHandler(this.cmbSecondLanguage_SelectedIndexChanged_1);




            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 443);
            this.Controls.Add(this.btnShowStudents);
            this.Controls.Add(this.grpPaymentDetails);
            this.Controls.Add(this.grpStudentDetails);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "מכללה";
            this.grpStudentDetails.ResumeLayout(false);
            this.grpStudentDetails.PerformLayout();
            this.grpPaymentDetails.ResumeLayout(false);
            this.grpPaymentDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComboBox cmbSecondLanguage;
        private ComboBox cmbFirstLanguage;
    }
}