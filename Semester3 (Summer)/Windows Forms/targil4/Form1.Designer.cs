using System.Windows.Forms;
using System.Drawing;

namespace targil4
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private GroupBox grpCreate;

        private TextBox txtNumber;
        private Button btnStart;

        private Label lblAverageTitle;
        private Label lblCommonTitle;
        private Label lblLowTitle;
        private Label lblHighTitle;

        private Label lblAverage;
        private Label lblCommon;
        private Label lblLow;
        private Label lblHigh;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.grpCreate = new System.Windows.Forms.GroupBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblNumber = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.lblAverageTitle = new System.Windows.Forms.Label();
            this.lblCommonTitle = new System.Windows.Forms.Label();
            this.lblLowTitle = new System.Windows.Forms.Label();
            this.lblHighTitle = new System.Windows.Forms.Label();
            this.lblAverage = new System.Windows.Forms.Label();
            this.lblCommon = new System.Windows.Forms.Label();
            this.lblLow = new System.Windows.Forms.Label();
            this.lblHigh = new System.Windows.Forms.Label();
            this.grpCreate.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCreate
            // 
            this.grpCreate.Controls.Add(this.btnStart);
            this.grpCreate.Controls.Add(this.lblNumber);
            this.grpCreate.Controls.Add(this.txtNumber);
            this.grpCreate.Location = new System.Drawing.Point(20, 20);
            this.grpCreate.Name = "grpCreate";
            this.grpCreate.Size = new System.Drawing.Size(220, 170);
            this.grpCreate.TabIndex = 0;
            this.grpCreate.TabStop = false;
            this.grpCreate.Text = "Create";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(63, 38);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(90, 35);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(33, 95);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(44, 13);
            this.lblNumber.TabIndex = 2;
            this.lblNumber.Text = "Number";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(83, 92);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(80, 20);
            this.txtNumber.TabIndex = 3;
            // 
            // lblAverageTitle
            // 
            this.lblAverageTitle.AutoSize = true;
            this.lblAverageTitle.Location = new System.Drawing.Point(330, 30);
            this.lblAverageTitle.Name = "lblAverageTitle";
            this.lblAverageTitle.Size = new System.Drawing.Size(47, 13);
            this.lblAverageTitle.TabIndex = 1;
            this.lblAverageTitle.Text = "Average";
            // 
            // lblCommonTitle
            // 
            this.lblCommonTitle.AutoSize = true;
            this.lblCommonTitle.Location = new System.Drawing.Point(330, 80);
            this.lblCommonTitle.Name = "lblCommonTitle";
            this.lblCommonTitle.Size = new System.Drawing.Size(48, 13);
            this.lblCommonTitle.TabIndex = 3;
            this.lblCommonTitle.Text = "Common";
            // 
            // lblLowTitle
            // 
            this.lblLowTitle.AutoSize = true;
            this.lblLowTitle.Location = new System.Drawing.Point(330, 140);
            this.lblLowTitle.Name = "lblLowTitle";
            this.lblLowTitle.Size = new System.Drawing.Size(40, 13);
            this.lblLowTitle.TabIndex = 5;
            this.lblLowTitle.Text = "1 to 50";
            // 
            // lblHighTitle
            // 
            this.lblHighTitle.AutoSize = true;
            this.lblHighTitle.Location = new System.Drawing.Point(330, 285);
            this.lblHighTitle.Name = "lblHighTitle";
            this.lblHighTitle.Size = new System.Drawing.Size(52, 13);
            this.lblHighTitle.TabIndex = 7;
            this.lblHighTitle.Text = "51 to 100";
            // 
            // lblAverage
            // 
            this.lblAverage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAverage.Location = new System.Drawing.Point(430, 25);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(120, 25);
            this.lblAverage.TabIndex = 2;
            // 
            // lblCommon
            // 
            this.lblCommon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCommon.Location = new System.Drawing.Point(430, 75);
            this.lblCommon.Name = "lblCommon";
            this.lblCommon.Size = new System.Drawing.Size(120, 25);
            this.lblCommon.TabIndex = 4;
            // 
            // lblLow
            // 
            this.lblLow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLow.Location = new System.Drawing.Point(330, 165);
            this.lblLow.Name = "lblLow";
            this.lblLow.Size = new System.Drawing.Size(300, 100);
            this.lblLow.TabIndex = 6;
            // 
            // lblHigh
            // 
            this.lblHigh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHigh.Location = new System.Drawing.Point(330, 310);
            this.lblHigh.Name = "lblHigh";
            this.lblHigh.Size = new System.Drawing.Size(300, 100);
            this.lblHigh.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 450);
            this.Controls.Add(this.grpCreate);
            this.Controls.Add(this.lblAverageTitle);
            this.Controls.Add(this.lblAverage);
            this.Controls.Add(this.lblCommonTitle);
            this.Controls.Add(this.lblCommon);
            this.Controls.Add(this.lblLowTitle);
            this.Controls.Add(this.lblLow);
            this.Controls.Add(this.lblHighTitle);
            this.Controls.Add(this.lblHigh);
            this.Name = "Form1";
            this.Text = "Numbers";
            this.grpCreate.ResumeLayout(false);
            this.grpCreate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Label lblNumber;
    }
}