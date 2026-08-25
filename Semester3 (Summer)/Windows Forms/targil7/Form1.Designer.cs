using System.Drawing;
using System.Windows.Forms;

namespace targil7
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblName;
        private Label lblGrade;

        private ListView lstStudents;
        private ListView lstPictures;

        private TextBox txtStudentName;

        private Button btnFindStudent;
        private Button btnShowAll;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblName = new Label();
            this.lblGrade = new Label();

            this.lstStudents = new ListView();
            this.lstPictures = new ListView();

            this.txtStudentName = new TextBox();

            this.btnFindStudent = new Button();
            this.btnShowAll = new Button();

            this.SuspendLayout();

            //
            // lblName
            //
            this.lblName.AutoSize = true;
            this.lblName.Font =
                new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
            this.lblName.Location = new Point(65, 30);
            this.lblName.Name = "lblName";
            this.lblName.Text = "Name";

            //
            // lblGrade
            //
            this.lblGrade.AutoSize = true;
            this.lblGrade.Font =
                new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
            this.lblGrade.Location = new Point(245, 30);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Text = "Grade";

            //
            // lstStudents
            //
            this.lstStudents.Location = new Point(30, 60);
            this.lstStudents.Name = "lstStudents";
            this.lstStudents.Size = new Size(330, 390);
            this.lstStudents.View = View.List;

            //
            // txtStudentName
            //
            this.txtStudentName.Location = new Point(75, 480);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new Size(240, 22);

            //
            // btnFindStudent
            //
            this.btnFindStudent.Location = new Point(95, 525);
            this.btnFindStudent.Name = "btnFindStudent";
            this.btnFindStudent.Size = new Size(200, 45);
            this.btnFindStudent.Text = "Find Student";
            this.btnFindStudent.UseVisualStyleBackColor = true;
            this.btnFindStudent.Click +=
                new System.EventHandler(this.btnFindStudent_Click);

            //
            // lstPictures
            //
            this.lstPictures.Location = new Point(410, 30);
            this.lstPictures.Name = "lstPictures";
            this.lstPictures.Size = new Size(700, 490);
            this.lstPictures.View = View.LargeIcon;

            //
            // btnShowAll
            //
            this.btnShowAll.Location = new Point(660, 545);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new Size(200, 50);
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click +=
                new System.EventHandler(this.btnShowAll_Click);

            //
            // Form1
            //
            this.AutoScaleDimensions = new SizeF(8F, 16F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(1140, 630);

            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblGrade);

            this.Controls.Add(this.lstStudents);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.btnFindStudent);

            this.Controls.Add(this.lstPictures);
            this.Controls.Add(this.btnShowAll);

            this.Name = "Form1";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Students";

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}