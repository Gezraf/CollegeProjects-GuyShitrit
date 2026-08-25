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

        public Form1()
        {
            InitializeComponent();
            ShowStudents();
        }

        private void ShowStudents()
        {
            SqlConnection con =
                new SqlConnection(connectionString);

            con.Open();

            string sql =
                "SELECT fname, grade, picture FROM studentsPictures";

            SqlCommand cmd =
                new SqlCommand(sql, con);

            SqlDataReader reader =
                cmd.ExecuteReader();

            while (reader.Read())
            {
                string picturePath =
                    reader["picture"].ToString();

                if (File.Exists(picturePath))
                {
                    PictureBox pic = new PictureBox();

                    pic.Width = 220;
                    pic.Height = 220;

                    pic.Image =
                        Image.FromFile(picturePath);

                    pic.SizeMode =
                        PictureBoxSizeMode.Zoom;

                    pic.Margin =
                        new Padding(15);

                    pnlGallery.Controls.Add(pic);
                }
            }

            reader.Close();
            con.Close();
        }
    }
}