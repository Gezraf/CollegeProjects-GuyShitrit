using System.Drawing;
using System.Windows.Forms;

namespace targil5
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private GroupBox grpQuestion;

        private Label lblNum1;
        private Label lblSign;
        private Label lblNum2;
        private Label lblEqual;

        private TextBox txtAnswer;

        private ListBox lstResults;

        private Button btnBad;
        private Button btnGood;
        private Button btnNewTargil;
        private Button btnCheck;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.grpQuestion = new GroupBox();

            this.lblNum1 = new Label();
            this.lblSign = new Label();
            this.lblNum2 = new Label();
            this.lblEqual = new Label();

            this.txtAnswer = new TextBox();

            this.lstResults = new ListBox();

            this.btnBad = new Button();
            this.btnGood = new Button();
            this.btnNewTargil = new Button();
            this.btnCheck = new Button();

            this.grpQuestion.SuspendLayout();
            this.SuspendLayout();

            //
            // grpQuestion
            //
            this.grpQuestion.BackColor = Color.FromArgb(245, 245, 245);
            this.grpQuestion.Controls.Add(this.lblNum1);
            this.grpQuestion.Controls.Add(this.lblSign);
            this.grpQuestion.Controls.Add(this.lblNum2);
            this.grpQuestion.Controls.Add(this.lblEqual);
            this.grpQuestion.Controls.Add(this.txtAnswer);
            this.grpQuestion.Location = new Point(25, 70);
            this.grpQuestion.Name = "grpQuestion";
            this.grpQuestion.Size = new Size(620, 315);
            this.grpQuestion.TabStop = false;

            //
            // lblNum1
            //
            this.lblNum1.AutoSize = true;
            this.lblNum1.Font = new Font(
                "Microsoft Sans Serif",
                20F,
                FontStyle.Regular);

            this.lblNum1.Location = new Point(130, 135);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Text = "9";

            //
            // lblSign
            //
            this.lblSign.AutoSize = true;
            this.lblSign.Font = new Font(
                "Microsoft Sans Serif",
                20F,
                FontStyle.Regular);

            this.lblSign.Location = new Point(200, 135);
            this.lblSign.Name = "lblSign";
            this.lblSign.Text = "-";

            //
            // lblNum2
            //
            this.lblNum2.AutoSize = true;
            this.lblNum2.Font = new Font(
                "Microsoft Sans Serif",
                20F,
                FontStyle.Regular);

            this.lblNum2.Location = new Point(255, 135);
            this.lblNum2.Name = "lblNum2";
            this.lblNum2.Text = "3";

            //
            // lblEqual
            //
            this.lblEqual.AutoSize = true;
            this.lblEqual.Font = new Font(
                "Microsoft Sans Serif",
                20F,
                FontStyle.Regular);

            this.lblEqual.Location = new Point(320, 135);
            this.lblEqual.Name = "lblEqual";
            this.lblEqual.Text = "=";

            //
            // txtAnswer
            //
            this.txtAnswer.Font = new Font(
                "Microsoft Sans Serif",
                16F,
                FontStyle.Regular);

            this.txtAnswer.Location = new Point(365, 132);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new Size(150, 38);

            //
            // lstResults
            //
            this.lstResults.Font = new Font(
                "Microsoft Sans Serif",
                11F,
                FontStyle.Regular);

            this.lstResults.FormattingEnabled = true;
            this.lstResults.ItemHeight = 22;
            this.lstResults.Location = new Point(685, 70);
            this.lstResults.Name = "lstResults";
            this.lstResults.Size = new Size(275, 312);

            //
            // btnBad
            //
            this.btnBad.Location = new Point(50, 425);
            this.btnBad.Name = "btnBad";
            this.btnBad.Size = new Size(190, 90);
            this.btnBad.Text = "Bad";
            this.btnBad.UseVisualStyleBackColor = true;
            this.btnBad.Click +=
                new System.EventHandler(this.btnBad_Click);

            //
            // btnGood
            //
            this.btnGood.Location = new Point(275, 425);
            this.btnGood.Name = "btnGood";
            this.btnGood.Size = new Size(190, 90);
            this.btnGood.Text = "Good";
            this.btnGood.UseVisualStyleBackColor = true;
            this.btnGood.Click +=
                new System.EventHandler(this.btnGood_Click);

            //
            // btnNewTargil
            //
            this.btnNewTargil.Enabled = false;
            this.btnNewTargil.Location = new Point(530, 425);
            this.btnNewTargil.Name = "btnNewTargil";
            this.btnNewTargil.Size = new Size(190, 90);
            this.btnNewTargil.Text = "New Targil";
            this.btnNewTargil.UseVisualStyleBackColor = true;
            this.btnNewTargil.Click +=
                new System.EventHandler(this.btnNewTargil_Click);

            //
            // btnCheck
            //
            this.btnCheck.Location = new Point(758, 425);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new Size(190, 90);
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click +=
                new System.EventHandler(this.btnCheck_Click);

            //
            // Form1
            //
            this.AutoScaleDimensions = new SizeF(8F, 16F);
            this.AutoScaleMode = AutoScaleMode.Font;

            this.ClientSize = new Size(990, 550);

            this.Controls.Add(this.grpQuestion);
            this.Controls.Add(this.lstResults);
            this.Controls.Add(this.btnBad);
            this.Controls.Add(this.btnGood);
            this.Controls.Add(this.btnNewTargil);
            this.Controls.Add(this.btnCheck);

            this.Name = "Form1";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Math Quiz For Kids";

            this.grpQuestion.ResumeLayout(false);
            this.grpQuestion.PerformLayout();

            this.ResumeLayout(false);
        }
    }
}