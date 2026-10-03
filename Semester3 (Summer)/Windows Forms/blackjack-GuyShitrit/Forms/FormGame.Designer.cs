namespace Blackjack.Forms
{
    partial class FormGame
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
            this.components = new System.ComponentModel.Container();
            this.grpDealer = new System.Windows.Forms.GroupBox();
            this.lblDealerScore = new System.Windows.Forms.Label();
            this.picDealer5 = new System.Windows.Forms.PictureBox();
            this.picDealer4 = new System.Windows.Forms.PictureBox();
            this.picDealer3 = new System.Windows.Forms.PictureBox();
            this.picDealer2 = new System.Windows.Forms.PictureBox();
            this.picDealer1 = new System.Windows.Forms.PictureBox();
            this.picDealer0 = new System.Windows.Forms.PictureBox();
            this.grpPlayer = new System.Windows.Forms.GroupBox();
            this.lblPlayerScore = new System.Windows.Forms.Label();
            this.picPlayer5 = new System.Windows.Forms.PictureBox();
            this.picPlayer4 = new System.Windows.Forms.PictureBox();
            this.picPlayer3 = new System.Windows.Forms.PictureBox();
            this.picPlayer2 = new System.Windows.Forms.PictureBox();
            this.picPlayer1 = new System.Windows.Forms.PictureBox();
            this.picPlayer0 = new System.Windows.Forms.PictureBox();
            this.grpBetting = new System.Windows.Forms.GroupBox();
            this.btnDeal = new System.Windows.Forms.Button();
            this.lblCustomBet = new System.Windows.Forms.Label();
            this.txtCustomBet = new System.Windows.Forms.TextBox();
            this.rdBet250 = new System.Windows.Forms.RadioButton();
            this.rdBet100 = new System.Windows.Forms.RadioButton();
            this.rdBet50 = new System.Windows.Forms.RadioButton();
            this.rdBet25 = new System.Windows.Forms.RadioButton();
            this.grpActions = new System.Windows.Forms.GroupBox();
            this.btnNewRound = new System.Windows.Forms.Button();
            this.btnDouble = new System.Windows.Forms.Button();
            this.btnStand = new System.Windows.Forms.Button();
            this.btnHit = new System.Windows.Forms.Button();
            this.grpLog = new System.Windows.Forms.GroupBox();
            this.btnClearLog = new System.Windows.Forms.Button();
            this.lstGameLog = new System.Windows.Forms.ListBox();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnBackToMenu = new System.Windows.Forms.Button();
            this.btnViewHistory = new System.Windows.Forms.Button();
            this.lblCurrentBet = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.tmrDealer = new System.Windows.Forms.Timer(this.components);
            this.grpDealer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDealer5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDealer4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDealer3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDealer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDealer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDealer0)).BeginInit();
            this.grpPlayer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer0)).BeginInit();
            this.grpBetting.SuspendLayout();
            this.grpActions.SuspendLayout();
            this.grpLog.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDealer
            // 
            this.grpDealer.Controls.Add(this.lblDealerScore);
            this.grpDealer.Controls.Add(this.picDealer5);
            this.grpDealer.Controls.Add(this.picDealer4);
            this.grpDealer.Controls.Add(this.picDealer3);
            this.grpDealer.Controls.Add(this.picDealer2);
            this.grpDealer.Controls.Add(this.picDealer1);
            this.grpDealer.Controls.Add(this.picDealer0);
            this.grpDealer.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.grpDealer.Location = new System.Drawing.Point(12, 60);
            this.grpDealer.Name = "grpDealer";
            this.grpDealer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grpDealer.Size = new System.Drawing.Size(650, 195);
            this.grpDealer.TabIndex = 0;
            this.grpDealer.TabStop = false;
            this.grpDealer.Text = "קלפי הדילר";
            // 
            // lblDealerScore
            // 
            this.lblDealerScore.AutoSize = true;
            this.lblDealerScore.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblDealerScore.Location = new System.Drawing.Point(18, 20);
            this.lblDealerScore.Name = "lblDealerScore";
            this.lblDealerScore.Size = new System.Drawing.Size(91, 16);
            this.lblDealerScore.TabIndex = 6;
            this.lblDealerScore.Text = "ניקוד דילר: ?";
            // 
            // picDealer5
            // 
            this.picDealer5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picDealer5.Location = new System.Drawing.Point(544, 45);
            this.picDealer5.Name = "picDealer5";
            this.picDealer5.Size = new System.Drawing.Size(95, 135);
            this.picDealer5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDealer5.TabIndex = 5;
            this.picDealer5.TabStop = false;
            // 
            // picDealer4
            // 
            this.picDealer4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picDealer4.Location = new System.Drawing.Point(439, 45);
            this.picDealer4.Name = "picDealer4";
            this.picDealer4.Size = new System.Drawing.Size(95, 135);
            this.picDealer4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDealer4.TabIndex = 4;
            this.picDealer4.TabStop = false;
            // 
            // picDealer3
            // 
            this.picDealer3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picDealer3.Location = new System.Drawing.Point(334, 45);
            this.picDealer3.Name = "picDealer3";
            this.picDealer3.Size = new System.Drawing.Size(95, 135);
            this.picDealer3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDealer3.TabIndex = 3;
            this.picDealer3.TabStop = false;
            // 
            // picDealer2
            // 
            this.picDealer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picDealer2.Location = new System.Drawing.Point(229, 45);
            this.picDealer2.Name = "picDealer2";
            this.picDealer2.Size = new System.Drawing.Size(95, 135);
            this.picDealer2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDealer2.TabIndex = 2;
            this.picDealer2.TabStop = false;
            // 
            // picDealer1
            // 
            this.picDealer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picDealer1.Location = new System.Drawing.Point(124, 45);
            this.picDealer1.Name = "picDealer1";
            this.picDealer1.Size = new System.Drawing.Size(95, 135);
            this.picDealer1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDealer1.TabIndex = 1;
            this.picDealer1.TabStop = false;
            // 
            // picDealer0
            // 
            this.picDealer0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picDealer0.Location = new System.Drawing.Point(19, 45);
            this.picDealer0.Name = "picDealer0";
            this.picDealer0.Size = new System.Drawing.Size(95, 135);
            this.picDealer0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDealer0.TabIndex = 0;
            this.picDealer0.TabStop = false;
            // 
            // grpPlayer
            // 
            this.grpPlayer.Controls.Add(this.lblPlayerScore);
            this.grpPlayer.Controls.Add(this.picPlayer5);
            this.grpPlayer.Controls.Add(this.picPlayer4);
            this.grpPlayer.Controls.Add(this.picPlayer3);
            this.grpPlayer.Controls.Add(this.picPlayer2);
            this.grpPlayer.Controls.Add(this.picPlayer1);
            this.grpPlayer.Controls.Add(this.picPlayer0);
            this.grpPlayer.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.grpPlayer.Location = new System.Drawing.Point(12, 265);
            this.grpPlayer.Name = "grpPlayer";
            this.grpPlayer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grpPlayer.Size = new System.Drawing.Size(650, 195);
            this.grpPlayer.TabIndex = 1;
            this.grpPlayer.TabStop = false;
            this.grpPlayer.Text = "קלפי השחקן";
            // 
            // lblPlayerScore
            // 
            this.lblPlayerScore.AutoSize = true;
            this.lblPlayerScore.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblPlayerScore.Location = new System.Drawing.Point(18, 20);
            this.lblPlayerScore.Name = "lblPlayerScore";
            this.lblPlayerScore.Size = new System.Drawing.Size(95, 16);
            this.lblPlayerScore.TabIndex = 6;
            this.lblPlayerScore.Text = "ניקוד שחקן: 0";
            // 
            // picPlayer5
            // 
            this.picPlayer5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPlayer5.Location = new System.Drawing.Point(544, 45);
            this.picPlayer5.Name = "picPlayer5";
            this.picPlayer5.Size = new System.Drawing.Size(95, 135);
            this.picPlayer5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPlayer5.TabIndex = 5;
            this.picPlayer5.TabStop = false;
            // 
            // picPlayer4
            // 
            this.picPlayer4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPlayer4.Location = new System.Drawing.Point(439, 45);
            this.picPlayer4.Name = "picPlayer4";
            this.picPlayer4.Size = new System.Drawing.Size(95, 135);
            this.picPlayer4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPlayer4.TabIndex = 4;
            this.picPlayer4.TabStop = false;
            // 
            // picPlayer3
            // 
            this.picPlayer3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPlayer3.Location = new System.Drawing.Point(334, 45);
            this.picPlayer3.Name = "picPlayer3";
            this.picPlayer3.Size = new System.Drawing.Size(95, 135);
            this.picPlayer3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPlayer3.TabIndex = 3;
            this.picPlayer3.TabStop = false;
            // 
            // picPlayer2
            // 
            this.picPlayer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPlayer2.Location = new System.Drawing.Point(229, 45);
            this.picPlayer2.Name = "picPlayer2";
            this.picPlayer2.Size = new System.Drawing.Size(95, 135);
            this.picPlayer2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPlayer2.TabIndex = 2;
            this.picPlayer2.TabStop = false;
            // 
            // picPlayer1
            // 
            this.picPlayer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPlayer1.Location = new System.Drawing.Point(124, 45);
            this.picPlayer1.Name = "picPlayer1";
            this.picPlayer1.Size = new System.Drawing.Size(95, 135);
            this.picPlayer1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPlayer1.TabIndex = 1;
            this.picPlayer1.TabStop = false;
            // 
            // picPlayer0
            // 
            this.picPlayer0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPlayer0.Location = new System.Drawing.Point(19, 45);
            this.picPlayer0.Name = "picPlayer0";
            this.picPlayer0.Size = new System.Drawing.Size(95, 135);
            this.picPlayer0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPlayer0.TabIndex = 0;
            this.picPlayer0.TabStop = false;
            // 
            // grpBetting
            // 
            this.grpBetting.Controls.Add(this.btnDeal);
            this.grpBetting.Controls.Add(this.lblCustomBet);
            this.grpBetting.Controls.Add(this.txtCustomBet);
            this.grpBetting.Controls.Add(this.rdBet250);
            this.grpBetting.Controls.Add(this.rdBet100);
            this.grpBetting.Controls.Add(this.rdBet50);
            this.grpBetting.Controls.Add(this.rdBet25);
            this.grpBetting.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.grpBetting.Location = new System.Drawing.Point(12, 470);
            this.grpBetting.Name = "grpBetting";
            this.grpBetting.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grpBetting.Size = new System.Drawing.Size(650, 80);
            this.grpBetting.TabIndex = 2;
            this.grpBetting.TabStop = false;
            this.grpBetting.Text = "הימור לסיבוב";
            // 
            // btnDeal
            // 
            this.btnDeal.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnDeal.Location = new System.Drawing.Point(19, 25);
            this.btnDeal.Name = "btnDeal";
            this.btnDeal.Size = new System.Drawing.Size(140, 38);
            this.btnDeal.TabIndex = 6;
            this.btnDeal.Text = "חלק קלפים";
            this.btnDeal.UseVisualStyleBackColor = true;
            this.btnDeal.Click += new System.EventHandler(this.btnDeal_Click);
            // 
            // lblCustomBet
            // 
            this.lblCustomBet.AutoSize = true;
            this.lblCustomBet.Location = new System.Drawing.Point(260, 37);
            this.lblCustomBet.Name = "lblCustomBet";
            this.lblCustomBet.Size = new System.Drawing.Size(73, 16);
            this.lblCustomBet.TabIndex = 5;
            this.lblCustomBet.Text = "הימור מותאם:";
            // 
            // txtCustomBet
            // 
            this.txtCustomBet.Location = new System.Drawing.Point(180, 34);
            this.txtCustomBet.MaxLength = 7;
            this.txtCustomBet.Name = "txtCustomBet";
            this.txtCustomBet.Size = new System.Drawing.Size(75, 23);
            this.txtCustomBet.TabIndex = 4;
            this.txtCustomBet.TextChanged += new System.EventHandler(this.txtCustomBet_TextChanged);
            // 
            // rdBet250
            // 
            this.rdBet250.AutoSize = true;
            this.rdBet250.Location = new System.Drawing.Point(345, 35);
            this.rdBet250.Name = "rdBet250";
            this.rdBet250.Size = new System.Drawing.Size(65, 20);
            this.rdBet250.TabIndex = 3;
            this.rdBet250.Text = "250 ₪";
            this.rdBet250.UseVisualStyleBackColor = true;
            // 
            // rdBet100
            // 
            this.rdBet100.AutoSize = true;
            this.rdBet100.Checked = true;
            this.rdBet100.Location = new System.Drawing.Point(425, 35);
            this.rdBet100.Name = "rdBet100";
            this.rdBet100.Size = new System.Drawing.Size(65, 20);
            this.rdBet100.TabIndex = 2;
            this.rdBet100.TabStop = true;
            this.rdBet100.Text = "100 ₪";
            this.rdBet100.UseVisualStyleBackColor = true;
            // 
            // rdBet50
            // 
            this.rdBet50.AutoSize = true;
            this.rdBet50.Location = new System.Drawing.Point(505, 35);
            this.rdBet50.Name = "rdBet50";
            this.rdBet50.Size = new System.Drawing.Size(57, 20);
            this.rdBet50.TabIndex = 1;
            this.rdBet50.Text = "50 ₪";
            this.rdBet50.UseVisualStyleBackColor = true;
            // 
            // rdBet25
            // 
            this.rdBet25.AutoSize = true;
            this.rdBet25.Location = new System.Drawing.Point(575, 35);
            this.rdBet25.Name = "rdBet25";
            this.rdBet25.Size = new System.Drawing.Size(57, 20);
            this.rdBet25.TabIndex = 0;
            this.rdBet25.Text = "25 ₪";
            this.rdBet25.UseVisualStyleBackColor = true;
            // 
            // grpActions
            // 
            this.grpActions.Controls.Add(this.btnNewRound);
            this.grpActions.Controls.Add(this.btnDouble);
            this.grpActions.Controls.Add(this.btnStand);
            this.grpActions.Controls.Add(this.btnHit);
            this.grpActions.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.grpActions.Location = new System.Drawing.Point(12, 560);
            this.grpActions.Name = "grpActions";
            this.grpActions.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grpActions.Size = new System.Drawing.Size(650, 75);
            this.grpActions.TabIndex = 3;
            this.grpActions.TabStop = false;
            this.grpActions.Text = "פעולות שחקן";
            // 
            // btnNewRound
            // 
            this.btnNewRound.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnNewRound.Enabled = false;
            this.btnNewRound.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnNewRound.Location = new System.Drawing.Point(19, 25);
            this.btnNewRound.Name = "btnNewRound";
            this.btnNewRound.Size = new System.Drawing.Size(140, 38);
            this.btnNewRound.TabIndex = 3;
            this.btnNewRound.Text = "סיבוב חדש";
            this.btnNewRound.UseVisualStyleBackColor = true;
            this.btnNewRound.Click += new System.EventHandler(this.btnNewRound_Click);
            // 
            // btnDouble
            // 
            this.btnDouble.Enabled = false;
            this.btnDouble.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnDouble.Location = new System.Drawing.Point(180, 25);
            this.btnDouble.Name = "btnDouble";
            this.btnDouble.Size = new System.Drawing.Size(140, 38);
            this.btnDouble.TabIndex = 2;
            this.btnDouble.Text = "הכפל הימור";
            this.btnDouble.UseVisualStyleBackColor = true;
            this.btnDouble.Click += new System.EventHandler(this.btnDouble_Click);
            // 
            // btnStand
            // 
            this.btnStand.Enabled = false;
            this.btnStand.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnStand.Location = new System.Drawing.Point(340, 25);
            this.btnStand.Name = "btnStand";
            this.btnStand.Size = new System.Drawing.Size(140, 38);
            this.btnStand.TabIndex = 1;
            this.btnStand.Text = "עצור";
            this.btnStand.UseVisualStyleBackColor = true;
            this.btnStand.Click += new System.EventHandler(this.btnStand_Click);
            // 
            // btnHit
            // 
            this.btnHit.Enabled = false;
            this.btnHit.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnHit.Location = new System.Drawing.Point(495, 25);
            this.btnHit.Name = "btnHit";
            this.btnHit.Size = new System.Drawing.Size(140, 38);
            this.btnHit.TabIndex = 0;
            this.btnHit.Text = "קלף נוסף";
            this.btnHit.UseVisualStyleBackColor = true;
            this.btnHit.Click += new System.EventHandler(this.btnHit_Click);
            // 
            // grpLog
            // 
            this.grpLog.Controls.Add(this.btnClearLog);
            this.grpLog.Controls.Add(this.lstGameLog);
            this.grpLog.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.grpLog.Location = new System.Drawing.Point(675, 60);
            this.grpLog.Name = "grpLog";
            this.grpLog.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grpLog.Size = new System.Drawing.Size(275, 575);
            this.grpLog.TabIndex = 4;
            this.grpLog.TabStop = false;
            this.grpLog.Text = "יומן מהלכים";
            // 
            // btnClearLog
            // 
            this.btnClearLog.Location = new System.Drawing.Point(12, 532);
            this.btnClearLog.Name = "btnClearLog";
            this.btnClearLog.Size = new System.Drawing.Size(250, 30);
            this.btnClearLog.TabIndex = 1;
            this.btnClearLog.Text = "נקה יומן מהלכים";
            this.btnClearLog.UseVisualStyleBackColor = true;
            this.btnClearLog.Click += new System.EventHandler(this.btnClearLog_Click);
            // 
            // lstGameLog
            // 
            this.lstGameLog.FormattingEnabled = true;
            this.lstGameLog.ItemHeight = 16;
            this.lstGameLog.Location = new System.Drawing.Point(12, 28);
            this.lstGameLog.Name = "lstGameLog";
            this.lstGameLog.Size = new System.Drawing.Size(250, 484);
            this.lstGameLog.TabIndex = 0;
            // 
            // pnlTop
            // 
            this.pnlTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTop.Controls.Add(this.btnBackToMenu);
            this.pnlTop.Controls.Add(this.btnViewHistory);
            this.pnlTop.Controls.Add(this.lblCurrentBet);
            this.pnlTop.Controls.Add(this.lblBalance);
            this.pnlTop.Controls.Add(this.lblPlayerName);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlTop.Size = new System.Drawing.Size(962, 45);
            this.pnlTop.TabIndex = 5;
            // 
            // btnBackToMenu
            // 
            this.btnBackToMenu.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnBackToMenu.Location = new System.Drawing.Point(12, 7);
            this.btnBackToMenu.Name = "btnBackToMenu";
            this.btnBackToMenu.Size = new System.Drawing.Size(100, 28);
            this.btnBackToMenu.TabIndex = 4;
            this.btnBackToMenu.Text = "חזרה לתפריט";
            this.btnBackToMenu.UseVisualStyleBackColor = true;
            this.btnBackToMenu.Click += new System.EventHandler(this.btnBackToMenu_Click);
            // 
            // btnViewHistory
            // 
            this.btnViewHistory.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnViewHistory.Location = new System.Drawing.Point(118, 7);
            this.btnViewHistory.Name = "btnViewHistory";
            this.btnViewHistory.Size = new System.Drawing.Size(110, 28);
            this.btnViewHistory.TabIndex = 3;
            this.btnViewHistory.Text = "היסטוריית שיאים";
            this.btnViewHistory.UseVisualStyleBackColor = true;
            this.btnViewHistory.Click += new System.EventHandler(this.btnViewHistory_Click);
            // 
            // lblCurrentBet
            // 
            this.lblCurrentBet.AutoSize = true;
            this.lblCurrentBet.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblCurrentBet.Location = new System.Drawing.Point(340, 13);
            this.lblCurrentBet.Name = "lblCurrentBet";
            this.lblCurrentBet.Size = new System.Drawing.Size(106, 16);
            this.lblCurrentBet.TabIndex = 2;
            this.lblCurrentBet.Text = "הימור נוכחי: 0 ₪";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblBalance.Location = new System.Drawing.Point(540, 13);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(107, 16);
            this.lblBalance.TabIndex = 1;
            this.lblBalance.Text = "יתרה: 1,000 ₪";
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblPlayerName.Location = new System.Drawing.Point(760, 13);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(43, 16);
            this.lblPlayerName.TabIndex = 0;
            this.lblPlayerName.Text = "שחקן:";
            // 
            // tmrDealer
            // 
            this.tmrDealer.Interval = 700;
            this.tmrDealer.Tick += new System.EventHandler(this.tmrDealer_Tick);
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 650);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.grpLog);
            this.Controls.Add(this.grpActions);
            this.Controls.Add(this.grpBetting);
            this.Controls.Add(this.grpPlayer);
            this.Controls.Add(this.grpDealer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "שולחן בלאקג'ק";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormGame_FormClosing);
            this.grpDealer.ResumeLayout(false);
            this.grpDealer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDealer5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDealer4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDealer3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDealer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDealer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDealer0)).EndInit();
            this.grpPlayer.ResumeLayout(false);
            this.grpPlayer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer0)).EndInit();
            this.grpBetting.ResumeLayout(false);
            this.grpBetting.PerformLayout();
            this.grpActions.ResumeLayout(false);
            this.grpLog.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDealer;
        private System.Windows.Forms.PictureBox picDealer5;
        private System.Windows.Forms.PictureBox picDealer4;
        private System.Windows.Forms.PictureBox picDealer3;
        private System.Windows.Forms.PictureBox picDealer2;
        private System.Windows.Forms.PictureBox picDealer1;
        private System.Windows.Forms.PictureBox picDealer0;
        private System.Windows.Forms.Label lblDealerScore;
        private System.Windows.Forms.GroupBox grpPlayer;
        private System.Windows.Forms.Label lblPlayerScore;
        private System.Windows.Forms.PictureBox picPlayer5;
        private System.Windows.Forms.PictureBox picPlayer4;
        private System.Windows.Forms.PictureBox picPlayer3;
        private System.Windows.Forms.PictureBox picPlayer2;
        private System.Windows.Forms.PictureBox picPlayer1;
        private System.Windows.Forms.PictureBox picPlayer0;
        private System.Windows.Forms.GroupBox grpBetting;
        private System.Windows.Forms.Button btnDeal;
        private System.Windows.Forms.Label lblCustomBet;
        private System.Windows.Forms.TextBox txtCustomBet;
        private System.Windows.Forms.RadioButton rdBet250;
        private System.Windows.Forms.RadioButton rdBet100;
        private System.Windows.Forms.RadioButton rdBet50;
        private System.Windows.Forms.RadioButton rdBet25;
        private System.Windows.Forms.GroupBox grpActions;
        private System.Windows.Forms.Button btnNewRound;
        private System.Windows.Forms.Button btnDouble;
        private System.Windows.Forms.Button btnStand;
        private System.Windows.Forms.Button btnHit;
        private System.Windows.Forms.GroupBox grpLog;
        private System.Windows.Forms.Button btnClearLog;
        private System.Windows.Forms.ListBox lstGameLog;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Button btnBackToMenu;
        private System.Windows.Forms.Button btnViewHistory;
        private System.Windows.Forms.Label lblCurrentBet;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.Timer tmrDealer;
    }
}
