using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewDesignBookingTrips
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

        }



        private void UserForm_Load(object sender, EventArgs e)
        {
            gridViwe();
        }
   //_____________________________function______________________________________________??
   void gridViwe()
        {
            dgvTrips.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTrips.RowTemplate.Height = 70;
            dgvTrips.BorderStyle = BorderStyle.None;
            dgvTrips.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTrips.AllowUserToAddRows = false;
        }

        private void dgvTrips_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void yourTrip_Click(object sender, EventArgs e)
        {
            using (var form = new YourTrips()) {
                this.Hide();
                form.ShowDialog();
                this.Show();
                
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            using (var form = new Form1())
            {
                this.Close();
                form.ShowDialog();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UserForm_Load_1(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            using (var form = new LoginUsercs())
            {
                this.Hide();
                form.Show();
            }
        }

        private void btnTrips_Click(object sender, EventArgs e)
        {
            using (var form = new YourTrips()) {
                this.Hide();
                form.ShowDialog();
                this.Show();
            }
        }
    }
}
