namespace Blackjack.Forms
{
    partial class FormWelcome
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblCredit = new System.Windows.Forms.Label();
            this.grpSetup = new System.Windows.Forms.GroupBox();
            this.chkFastDeal = new System.Windows.Forms.CheckBox();
            this.cmbRules = new System.Windows.Forms.ComboBox();
            this.lblRules = new System.Windows.Forms.Label();
            this.cmbDecks = new System.Windows.Forms.ComboBox();
            this.lblDecks = new System.Windows.Forms.Label();
            this.cmbBudget = new System.Windows.Forms.ComboBox();
            this.lblBudget = new System.Windows.Forms.Label();
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpSetup.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblTitle.Location = new System.Drawing.Point(12, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(460, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "משחק בלאקג'ק";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCredit
            // 
            this.lblCredit.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblCredit.Location = new System.Drawing.Point(12, 45);
            this.lblCredit.Name = "lblCredit";
            this.lblCredit.Size = new System.Drawing.Size(460, 20);
            this.lblCredit.TabIndex = 5;
            this.lblCredit.Text = "הוגש על ידי: גיא שטרית";
            this.lblCredit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpSetup
            // 
            this.grpSetup.Controls.Add(this.chkFastDeal);
            this.grpSetup.Controls.Add(this.cmbRules);
            this.grpSetup.Controls.Add(this.lblRules);
            this.grpSetup.Controls.Add(this.cmbDecks);
            this.grpSetup.Controls.Add(this.lblDecks);
            this.grpSetup.Controls.Add(this.cmbBudget);
            this.grpSetup.Controls.Add(this.lblBudget);
            this.grpSetup.Controls.Add(this.txtPlayerName);
            this.grpSetup.Controls.Add(this.lblPlayerName);
            this.grpSetup.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.grpSetup.Location = new System.Drawing.Point(26, 78);
            this.grpSetup.Name = "grpSetup";
            this.grpSetup.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grpSetup.Size = new System.Drawing.Size(430, 230);
            this.grpSetup.TabIndex = 1;
            this.grpSetup.TabStop = false;
            this.grpSetup.Text = "הגדרות שחקן ומשחק";
            // 
            // chkFastDeal
            // 
            this.chkFastDeal.AutoSize = true;
            this.chkFastDeal.Location = new System.Drawing.Point(135, 192);
            this.chkFastDeal.Name = "chkFastDeal";
            this.chkFastDeal.Size = new System.Drawing.Size(140, 20);
            this.chkFastDeal.TabIndex = 8;
            this.chkFastDeal.Text = "חלוקת קלפים מהירה";
            this.chkFastDeal.UseVisualStyleBackColor = true;
            // 
            // cmbRules
            // 
            this.cmbRules.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRules.FormattingEnabled = true;
            this.cmbRules.Items.AddRange(new object[] {
            "עצירה ב-17 ומעלה",
            "משיכה ב-17 רך"});
            this.cmbRules.Location = new System.Drawing.Point(34, 155);
            this.cmbRules.Name = "cmbRules";
            this.cmbRules.Size = new System.Drawing.Size(240, 24);
            this.cmbRules.TabIndex = 7;
            // 
            // lblRules
            // 
            this.lblRules.AutoSize = true;
            this.lblRules.Location = new System.Drawing.Point(315, 158);
            this.lblRules.Name = "lblRules";
            this.lblRules.Size = new System.Drawing.Size(76, 16);
            this.lblRules.TabIndex = 6;
            this.lblRules.Text = "חוקי הדילר:";
            // 
            // cmbDecks
            // 
            this.cmbDecks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDecks.FormattingEnabled = true;
            this.cmbDecks.Items.AddRange(new object[] {
            "חפיסה אחת",
            "2 חפיסות",
            "4 חפיסות"});
            this.cmbDecks.Location = new System.Drawing.Point(34, 115);
            this.cmbDecks.Name = "cmbDecks";
            this.cmbDecks.Size = new System.Drawing.Size(240, 24);
            this.cmbDecks.TabIndex = 5;
            // 
            // lblDecks
            // 
            this.lblDecks.AutoSize = true;
            this.lblDecks.Location = new System.Drawing.Point(301, 118);
            this.lblDecks.Name = "lblDecks";
            this.lblDecks.Size = new System.Drawing.Size(90, 16);
            this.lblDecks.TabIndex = 4;
            this.lblDecks.Text = "כמות חפיסות:";
            // 
            // cmbBudget
            // 
            this.cmbBudget.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBudget.FormattingEnabled = true;
            this.cmbBudget.Items.AddRange(new object[] {
            "500 ₪",
            "1,000 ₪",
            "2,500 ₪",
            "5,000 ₪"});
            this.cmbBudget.Location = new System.Drawing.Point(34, 75);
            this.cmbBudget.Name = "cmbBudget";
            this.cmbBudget.Size = new System.Drawing.Size(240, 24);
            this.cmbBudget.TabIndex = 3;
            // 
            // lblBudget
            // 
            this.lblBudget.AutoSize = true;
            this.lblBudget.Location = new System.Drawing.Point(298, 78);
            this.lblBudget.Name = "lblBudget";
            this.lblBudget.Size = new System.Drawing.Size(93, 16);
            this.lblBudget.TabIndex = 2;
            this.lblBudget.Text = "תקציב התחלתי:";
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.Location = new System.Drawing.Point(34, 35);
            this.txtPlayerName.MaxLength = 20;
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.Size = new System.Drawing.Size(240, 23);
            this.txtPlayerName.TabIndex = 1;
            this.txtPlayerName.Text = "";
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Location = new System.Drawing.Point(317, 38);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(74, 16);
            this.lblPlayerName.TabIndex = 0;
            this.lblPlayerName.Text = "שם השחקן:";
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnStart.Location = new System.Drawing.Point(26, 325);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(430, 42);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "התחל משחק";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnHistory.Location = new System.Drawing.Point(26, 380);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(210, 35);
            this.btnHistory.TabIndex = 3;
            this.btnHistory.Text = "היסטוריית משחקים";
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnExit.Location = new System.Drawing.Point(246, 380);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(210, 35);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "יציאה";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FormWelcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 435);
            this.Controls.Add(this.lblCredit);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.grpSetup);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormWelcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "בלאקג'ק - מסך ראשי";
            this.grpSetup.ResumeLayout(false);
            this.grpSetup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblCredit;
        private System.Windows.Forms.GroupBox grpSetup;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.TextBox txtPlayerName;
        private System.Windows.Forms.Label lblBudget;
        private System.Windows.Forms.ComboBox cmbBudget;
        private System.Windows.Forms.Label lblDecks;
        private System.Windows.Forms.ComboBox cmbDecks;
        private System.Windows.Forms.Label lblRules;
        private System.Windows.Forms.ComboBox cmbRules;
        private System.Windows.Forms.CheckBox chkFastDeal;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Button btnExit;
    }
}
