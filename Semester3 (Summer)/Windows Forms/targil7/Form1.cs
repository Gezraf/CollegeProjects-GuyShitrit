using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace targil7
{
    public partial class Form1 : Form
    {
        string connectionString =
            @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SchoolDB;Integrated Security=True";

        ImageList studentImages = new ImageList();

        public Form1()
        {
            InitializeComponent();

            studentImages.ImageSize = new Size(150, 150);
            studentImages.ColorDepth = ColorDepth.Depth32Bit;

            lstPictures.LargeImageList = studentImages;
            lstPictures.View = View.LargeIcon;
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            lstPictures.Items.Clear();
            studentImages.Images.Clear();

            SqlConnection con =
                new SqlConnection(connectionString);

            con.Open();

            string sql =
                "SELECT picture FROM studentsPictures";

            SqlCommand cmd =
                new SqlCommand(sql, con);

            SqlDataReader reader =
                cmd.ExecuteReader();

            int imageIndex = 0;

            while (reader.Read())
            {
                string picturePath =
                    reader["picture"].ToString();

                if (File.Exists(picturePath))
                {
                    Image image =
                        Image.FromFile(picturePath);

                    studentImages.Images.Add(image);

                    string student =
                        reader["fname"].ToString() +
                        "                         " +
                        reader["grade"].ToString();

                    lstStudents.Items.Add(student);

                    imageIndex++;
                }
            }

            reader.Close();
            con.Close();
        }

        private void btnFindStudent_Click(object sender, EventArgs e)
        {
            lstStudents.Items.Clear();

            string name =
                txtStudentName.Text;

            SqlConnection con =
                new SqlConnection(connectionString);

            con.Open();

            string sql =
                "SELECT fname, grade FROM studentsPictures " +
                "WHERE fname = @fname";

            SqlCommand cmd =
                new SqlCommand(sql, con);

            cmd.Parameters.AddWithValue(
                "@fname",
                name);

            SqlDataReader reader =
                cmd.ExecuteReader();

            while (reader.Read())
            {
                ListViewItem item =
                    new ListViewItem(
                        reader["fname"].ToString());

                item.SubItems.Add(
                    reader["grade"].ToString());

                lstStudents.Items.Add(item);
            }

            reader.Close();
            con.Close();
        }
    }
}