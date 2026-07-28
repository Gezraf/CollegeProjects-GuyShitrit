using System;
using System.Windows.Forms;

namespace targil3
{
    public partial class Form1 : Form
    {
        const int MAX_STUDENTS = 10;

        string[] studentNames = new string[MAX_STUDENTS];
        string[] firstLanguages = new string[MAX_STUDENTS];
        string[] secondLanguages = new string[MAX_STUDENTS];
        double[] paymentTotals = new double[MAX_STUDENTS];

        int studentCount = 0;
        int currentAge;
        double currentPayment;

        public Form1()
        {
            InitializeComponent();

            cmbFirstLanguage.Items.Add("אנגלית");
            cmbFirstLanguage.Items.Add("גרמנית");
            cmbFirstLanguage.Items.Add("ספרדית");
            cmbFirstLanguage.Items.Add("צרפתית");
            cmbFirstLanguage.Items.Add("סינית");

            cmbSecondLanguage.Items.Add("אנגלית");
            cmbSecondLanguage.Items.Add("גרמנית");
            cmbSecondLanguage.Items.Add("ספרדית");
            cmbSecondLanguage.Items.Add("צרפתית");
            cmbSecondLanguage.Items.Add("סינית");

            lstPayments.Items.Add("1");
            lstPayments.Items.Add("2");
            lstPayments.Items.Add("3");
            lstPayments.Items.Add("4");

            grpStudentDetails.Visible = true;
            grpPaymentDetails.Visible = false;

            btnSave.Enabled = false;
            btnShowStudents.Enabled = false;

            rdCash.Checked = true;
            lstPayments.SelectedIndex = -1;
            lstPayments.Enabled = false;
        }

        private void btnCheckDetails_Click(object sender, EventArgs e)
        {
            if (studentCount == MAX_STUDENTS)
            {
                MessageBox.Show(
                    "לא ניתן לרשום יותר מ-10 סטודנטים.",
                    "שגיאה",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            if (txtStudentName.Text == "")
            {
                MessageBox.Show(
                    "יש להזין את שם הסטודנט.",
                    "שגיאה",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            if (int.TryParse(txtStudentAge.Text, out currentAge) == false)
            {
                MessageBox.Show(
                    "גיל הסטודנט חייב להכיל מספר שלם בלבד.",
                    "שגיאה",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            if (currentAge < 16 || currentAge > 120)
            {
                MessageBox.Show(
                    "גיל הסטודנט חייב להיות בין 16 ל-120.",
                    "שגיאה",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            if (cmbFirstLanguage.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "יש לבחור שפה ראשונה.",
                    "שגיאה",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            if (cmbSecondLanguage.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "יש לבחור שפה שנייה.",
                    "שגיאה",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            if (cmbFirstLanguage.Text == cmbSecondLanguage.Text)
            {
                MessageBox.Show(
                    "אין לבחור את אותה השפה.",
                    "שגיאה",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            if (currentAge < 18 &&
                (cmbFirstLanguage.Text == "סינית" ||
                 cmbSecondLanguage.Text == "סינית"))
            {
                MessageBox.Show(
                    "אין אפשרות ללמוד סינית מתחת לגיל 18.",
                    "שגיאה",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            MessageBox.Show(
                "הרישום מאושר.",
                "אישור",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            grpStudentDetails.Visible = false;
            grpPaymentDetails.Visible = true;

            rdCash.Checked = true;
            lstPayments.SelectedIndex = -1;
            lstPayments.Enabled = false;
            btnSave.Enabled = false;
        }

        private void rdCash_CheckedChanged(object sender, EventArgs e)
        {
            if (rdCash.Checked == true)
            {
                lstPayments.SelectedIndex = -1;
                lstPayments.Enabled = false;
                btnSave.Enabled = false;
            }
        }

        private void rdCredit_CheckedChanged(object sender, EventArgs e)
        {
            if (rdCredit.Checked == true)
            {
                lstPayments.Enabled = true;
                lstPayments.SelectedIndex = 0;
                btnSave.Enabled = false;
            }
        }

        private double GetCreditAddition()
        {
            if (rdCredit.Checked == false)
                return 0;

            if (lstPayments.SelectedIndex == 1)
                return 0.02;

            if (lstPayments.SelectedIndex == 2)
                return 0.04;

            if (lstPayments.SelectedIndex == 3)
                return 0.07;

            return 0;
        }

        private void btnCheckPayment_Click(object sender, EventArgs e)
        {
            if (rdCredit.Checked == true &&
                lstPayments.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "יש לבחור מספר תשלומים.",
                    "שגיאה",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            double firstLanguagePrice = 1000;
            double secondLanguagePrice = 800;

            if (cmbFirstLanguage.Text == "ספרדית")
            {
                firstLanguagePrice = firstLanguagePrice - 150;
            }
            else if (currentAge < 25)
            {
                firstLanguagePrice *= 0.9;
            }

            if (currentAge < 25)
            {
                secondLanguagePrice *= 0.9;
            }

            double addition = GetCreditAddition();

            firstLanguagePrice =
                firstLanguagePrice + firstLanguagePrice * addition;

            secondLanguagePrice =
                secondLanguagePrice + secondLanguagePrice * addition;

            currentPayment =
                firstLanguagePrice + secondLanguagePrice;

            string message =
                "שם: " + txtStudentName.Text + "\n" +
                cmbFirstLanguage.Text + ": " + firstLanguagePrice.ToString("0.##") + "\n" +
                cmbSecondLanguage.Text + ": " + secondLanguagePrice.ToString("0.##") + "\n" +
                "תשלום: " +currentPayment.ToString("0.##");

            MessageBox.Show(
                message,
                "תשלום",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            btnSave.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (studentCount == MAX_STUDENTS)
            {
                MessageBox.Show(
                    ".לא ניתן לשמור יותר מ-10 סטודנטים",
                    "שגיאה",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            studentNames[studentCount] =
                txtStudentName.Text;

            firstLanguages[studentCount] =
                cmbFirstLanguage.Text;

            secondLanguages[studentCount] =
                cmbSecondLanguage.Text;

            paymentTotals[studentCount] =
                currentPayment;

            studentCount++;

            MessageBox.Show(
                "פרטי הסטודנט נשמרו בהצלחה.",
                "שמירה",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            btnShowStudents.Enabled = true;

            ClearForm();

            if (studentCount == MAX_STUDENTS)
            {
                btnCheckDetails.Enabled = false;

                MessageBox.Show(
                    ".המערכת מכילה כעת 10 סטודנטים ולא ניתן להוסיף סטודנטים נוספים",
                    "המערכת מלאה",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void ClearForm()
        {
            txtStudentName.Text = "";
            txtStudentAge.Text = "";

            cmbFirstLanguage.SelectedIndex = -1;
            cmbSecondLanguage.SelectedIndex = -1;

            rdCash.Checked = true;
            rdCredit.Checked = false;

            lstPayments.SelectedIndex = -1;
            lstPayments.Enabled = false;

            currentAge = 0;
            currentPayment = 0;

            btnSave.Enabled = false;

            grpPaymentDetails.Visible = false;
            grpStudentDetails.Visible = true;

            txtStudentName.Focus();
        }

        private void btnShowStudents_Click(object sender, EventArgs e)
        {
            string studentsText = "";

            for (int i = 0; i < studentCount; i++)
            {
                studentsText +=
                    "שם: " + studentNames[i] +
                    "    שפה ראשונה: " + firstLanguages[i] +
                    "    שפה שנייה: " + secondLanguages[i] +
                    "    הסכום לתשלום: " +
                    paymentTotals[i].ToString("0.##");

                if (i < studentCount - 1)
                    studentsText += "\n";
            }

            Form2 studentsForm =
                new Form2(studentsText);

            studentsForm.ShowDialog();
        }

        private void lstPayments_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbSecondLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbFirstLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbSecondLanguage_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void cmbFirstLanguage_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void lblStudentAge_Click(object sender, EventArgs e)
        {

        }

        private void lblStudentName_Click(object sender, EventArgs e)
        {

        }
    }
}