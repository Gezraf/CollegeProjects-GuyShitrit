namespace Blackjack.Forms
{
    partial class FormHistory
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
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lstHistory = new System.Windows.Forms.ListView();
            this.colPlayer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colBet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colResult = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPlayerScore = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDealerScore = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFinalBalance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grpStats = new System.Windows.Forms.GroupBox();
            this.lblTotalBet = new System.Windows.Forms.Label();
            this.lblWinRate = new System.Windows.Forms.Label();
            this.lblPushes = new System.Windows.Forms.Label();
            this.lblLosses = new System.Windows.Forms.Label();
            this.lblWins = new System.Windows.Forms.Label();
            this.lblTotalGames = new System.Windows.Forms.Label();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnExportText = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.grpSearch.SuspendLayout();
            this.grpStats.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblTitle.Location = new System.Drawing.Point(12, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(760, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "היסטוריית משחקים ושיאים";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpSearch
            // 
            this.grpSearch.Controls.Add(this.btnShowAll);
            this.grpSearch.Controls.Add(this.btnSearch);
            this.grpSearch.Controls.Add(this.txtSearch);
            this.grpSearch.Controls.Add(this.lblSearch);
            this.grpSearch.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.grpSearch.Location = new System.Drawing.Point(12, 55);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grpSearch.Size = new System.Drawing.Size(760, 60);
            this.grpSearch.TabIndex = 1;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "חיפוש וסינון";
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(15, 22);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(110, 28);
            this.btnShowAll.TabIndex = 3;
            this.btnShowAll.Text = "הצג הכל";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(135, 22);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 28);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "חפש";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(250, 25);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(360, 23);
            this.txtSearch.TabIndex = 1;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(620, 28);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(118, 16);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "חיפוש לפי שם שחקן:";
            // 
            // lstHistory
            // 
            this.lstHistory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colPlayer,
            this.colDate,
            this.colBet,
            this.colResult,
            this.colPlayerScore,
            this.colDealerScore,
            this.colFinalBalance});
            this.lstHistory.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lstHistory.FullRowSelect = true;
            this.lstHistory.GridLines = true;
            this.lstHistory.HideSelection = false;
            this.lstHistory.Location = new System.Drawing.Point(12, 125);
            this.lstHistory.Name = "lstHistory";
            this.lstHistory.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lstHistory.RightToLeftLayout = true;
            this.lstHistory.Size = new System.Drawing.Size(760, 255);
            this.lstHistory.TabIndex = 2;
            this.lstHistory.UseCompatibleStateImageBehavior = false;
            this.lstHistory.View = System.Windows.Forms.View.Details;
            // 
            // colPlayer
            // 
            this.colPlayer.Text = "שם שחקן";
            this.colPlayer.Width = 120;
            // 
            // colDate
            // 
            this.colDate.Text = "תאריך ושעה";
            this.colDate.Width = 140;
            // 
            // colBet
            // 
            this.colBet.Text = "הימור";
            this.colBet.Width = 80;
            // 
            // colResult
            // 
            this.colResult.Text = "תוצאה";
            this.colResult.Width = 110;
            // 
            // colPlayerScore
            // 
            this.colPlayerScore.Text = "ניקוד שחקן";
            this.colPlayerScore.Width = 90;
            // 
            // colDealerScore
            // 
            this.colDealerScore.Text = "ניקוד דילר";
            this.colDealerScore.Width = 90;
            // 
            // colFinalBalance
            // 
            this.colFinalBalance.Text = "יתרה סופית";
            this.colFinalBalance.Width = 105;
            // 
            // grpStats
            // 
            this.grpStats.Controls.Add(this.lblTotalBet);
            this.grpStats.Controls.Add(this.lblWinRate);
            this.grpStats.Controls.Add(this.lblPushes);
            this.grpStats.Controls.Add(this.lblLosses);
            this.grpStats.Controls.Add(this.lblWins);
            this.grpStats.Controls.Add(this.lblTotalGames);
            this.grpStats.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.grpStats.Location = new System.Drawing.Point(12, 390);
            this.grpStats.Name = "grpStats";
            this.grpStats.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grpStats.Size = new System.Drawing.Size(760, 95);
            this.grpStats.TabIndex = 3;
            this.grpStats.TabStop = false;
            this.grpStats.Text = "סטטיסטיקה";
            // 
            // lblTotalBet
            // 
            this.lblTotalBet.AutoSize = true;
            this.lblTotalBet.Location = new System.Drawing.Point(40, 60);
            this.lblTotalBet.Name = "lblTotalBet";
            this.lblTotalBet.Size = new System.Drawing.Size(126, 16);
            this.lblTotalBet.TabIndex = 5;
            this.lblTotalBet.Text = "סך כל ההימורים: 0 ₪";
            // 
            // lblWinRate
            // 
            this.lblWinRate.AutoSize = true;
            this.lblWinRate.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblWinRate.Location = new System.Drawing.Point(300, 60);
            this.lblWinRate.Name = "lblWinRate";
            this.lblWinRate.Size = new System.Drawing.Size(124, 16);
            this.lblWinRate.TabIndex = 4;
            this.lblWinRate.Text = "אחוז הצלחה: 0.0%";
            // 
            // lblPushes
            // 
            this.lblPushes.AutoSize = true;
            this.lblPushes.Location = new System.Drawing.Point(580, 60);
            this.lblPushes.Name = "lblPushes";
            this.lblPushes.Size = new System.Drawing.Size(63, 16);
            this.lblPushes.TabIndex = 3;
            this.lblPushes.Text = "תיקו: 0";
            // 
            // lblLosses
            // 
            this.lblLosses.AutoSize = true;
            this.lblLosses.Location = new System.Drawing.Point(40, 30);
            this.lblLosses.Name = "lblLosses";
            this.lblLosses.Size = new System.Drawing.Size(125, 16);
            this.lblLosses.TabIndex = 2;
            this.lblLosses.Text = "הפסדים ושריפות: 0";
            // 
            // lblWins
            // 
            this.lblWins.AutoSize = true;
            this.lblWins.Location = new System.Drawing.Point(300, 30);
            this.lblWins.Name = "lblWins";
            this.lblWins.Size = new System.Drawing.Size(128, 16);
            this.lblWins.TabIndex = 1;
            this.lblWins.Text = "ניצחונות ובלקג'ק: 0";
            // 
            // lblTotalGames
            // 
            this.lblTotalGames.AutoSize = true;
            this.lblTotalGames.Location = new System.Drawing.Point(580, 30);
            this.lblTotalGames.Name = "lblTotalGames";
            this.lblTotalGames.Size = new System.Drawing.Size(129, 16);
            this.lblTotalGames.TabIndex = 0;
            this.lblTotalGames.Text = "סך הכל סיבובים: 0";
            // 
            // btnReload
            // 
            this.btnReload.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnReload.Location = new System.Drawing.Point(622, 498);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(150, 35);
            this.btnReload.TabIndex = 4;
            this.btnReload.Text = "טען מחדש";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnExportText
            // 
            this.btnExportText.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnExportText.Location = new System.Drawing.Point(446, 498);
            this.btnExportText.Name = "btnExportText";
            this.btnExportText.Size = new System.Drawing.Size(160, 35);
            this.btnExportText.TabIndex = 5;
            this.btnExportText.Text = "ייצא דוח לקובץ";
            this.btnExportText.UseVisualStyleBackColor = true;
            this.btnExportText.Click += new System.EventHandler(this.btnExportText_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnClear.Location = new System.Drawing.Point(270, 498);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(160, 35);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "איפוס היסטוריה";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnClose.Location = new System.Drawing.Point(12, 498);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 35);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "סגור";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FormHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 545);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExportText);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.grpStats);
            this.Controls.Add(this.lstHistory);
            this.Controls.Add(this.grpSearch);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "היסטוריית משחקים";
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            this.grpStats.ResumeLayout(false);
            this.grpStats.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.ListView lstHistory;
        private System.Windows.Forms.ColumnHeader colPlayer;
        private System.Windows.Forms.ColumnHeader colDate;
        private System.Windows.Forms.ColumnHeader colBet;
        private System.Windows.Forms.ColumnHeader colResult;
        private System.Windows.Forms.ColumnHeader colPlayerScore;
        private System.Windows.Forms.ColumnHeader colDealerScore;
        private System.Windows.Forms.ColumnHeader colFinalBalance;
        private System.Windows.Forms.GroupBox grpStats;
        private System.Windows.Forms.Label lblTotalBet;
        private System.Windows.Forms.Label lblWinRate;
        private System.Windows.Forms.Label lblPushes;
        private System.Windows.Forms.Label lblLosses;
        private System.Windows.Forms.Label lblWins;
        private System.Windows.Forms.Label lblTotalGames;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnExportText;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
    }
}
