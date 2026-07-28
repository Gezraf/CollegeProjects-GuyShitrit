using System.Windows.Forms;

namespace targil3
{
    public partial class Form2 : Form
    {
        public Form2(string studentsText)
        {
            InitializeComponent();

            lblStudents.Text = studentsText;
        }
    }
}