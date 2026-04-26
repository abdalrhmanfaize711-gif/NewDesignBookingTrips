using Guna.UI2.WinForms;
using local_Tribs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewDesignBookingTrips
{
    public partial class Form1 : Form
    {
        DatabaseHelper db=new DatabaseHelper();
        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
                    }

        private void Login_Click(object sender, EventArgs e)
        {

            string username = Username.Text.Trim();
            string password = Password.Text;

            string query = "SELECT passwordHash, passwordSalt FROM Users WHERE email = @em";

            SqlConnection conn = new SqlConnection(db.connectionString);
            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@em", username);

            conn.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                string hash = reader["passwordHash"].ToString() ?? "";
                string salt = reader["passwordSalt"].ToString() ?? "";

                bool valid = PasswordHelper.VerifyPassword(password, hash, salt);

                if (valid)
                {
                    MessageBox.Show("Login successful!");
                    using (var form = new UserForm())
                    {
                        this.Hide();
                        form.ShowDialog();
                        this.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid username or password.");
                    return;
                }


                //end of validation


                if (comboBox1.Text == "User")
                {

                    using (var form = new LoginUsercs())
                    {
                        this.Hide();
                        form.ShowDialog();
                        this.Show();
                    }
                }


                else if (comboBox1.Text == "Admin")
                {
                    using (var form = new Admin())
                    {
                        this.Hide();
                        form.ShowDialog();
                        this.Show();
                    }
                }
                else if (comboBox1.Text == "")
                {

                    MessageBox.Show("plase Select Your Role ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }

       

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox1.Text == "User" || comboBox1.Text == "")
            {
               
            }
            else
            {
                AdminRolu.Visible = true;
            }
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //___________________________founction:::::::::::::::::::

        private void LoginSaveData()
        {
            string query = "INSERT INTO Users (email) VALUES (@email)";
            SqlParameter[] parameter =
            {
                new SqlParameter("@email",guna2TextBox1.Text),
            };
            db.Insert(query, parameter);
            MessageBox.Show(" row(s) inserted successfully!");

        }
    }
}
