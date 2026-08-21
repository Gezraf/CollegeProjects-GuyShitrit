using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace targil6
{
    public partial class Form1 : Form
    {
        string connectionString =
            @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SchoolDB;Integrated Security=True";

        public Form1()
        {
            InitializeComponent();
        }

        private void ClearLists()
        {
            lstName.Items.Clear();
            lstPhone.Items.Clear();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            ClearLists();

            SqlConnection con =
                new SqlConnection(connectionString);

            con.Open();

            string sql = "SELECT * FROM students";

            SqlCommand cmd =
                new SqlCommand(sql, con);

            SqlDataReader reader =
                cmd.ExecuteReader();

            while (reader.Read())
            {
                lstName.Items.Add(reader["name"].ToString());
                lstPhone.Items.Add(reader["phone"].ToString());
            }

            reader.Close();
            con.Close();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            ClearLists();

            int id = int.Parse(txtInsert.Text);

            SqlConnection con =
                new SqlConnection(connectionString);

            con.Open();

            string sql =
                "SELECT * FROM students WHERE id = @id";

            SqlCommand cmd =
                new SqlCommand(sql, con);

            cmd.Parameters.AddWithValue("@id", id);

            SqlDataReader reader =
                cmd.ExecuteReader();

            while (reader.Read())
            {
                lstName.Items.Add(reader["name"].ToString());
                lstPhone.Items.Add(reader["phone"].ToString());
            }

            reader.Close();
            con.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtInsert.Text);

            SqlConnection con =
                new SqlConnection(connectionString);

            con.Open();

            string sql =
                "DELETE FROM students WHERE id = @id";

            SqlCommand cmd =
                new SqlCommand(sql, con);

            cmd.Parameters.AddWithValue("@id", id);

            cmd.ExecuteNonQuery();

            con.Close();

            btnShow_Click(sender, e);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string name = txtNameInput.Text;
            string phone = txtPhoneInput.Text;

            SqlConnection con =
                new SqlConnection(connectionString);

            con.Open();

            string sql =
                "UPDATE students SET phone = @phone WHERE name = @name";

            SqlCommand cmd =
                new SqlCommand(sql, con);

            cmd.Parameters.AddWithValue("@phone", phone);
            cmd.Parameters.AddWithValue("@name", name);

            cmd.ExecuteNonQuery();

            con.Close();

            btnShow_Click(sender, e);
        }
    }
}