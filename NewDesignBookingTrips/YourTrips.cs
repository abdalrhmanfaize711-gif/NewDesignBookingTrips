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
    public partial class YourTrips : Form
    {
        public YourTrips()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

        }

        private void YourTrips_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void YourTrips_Load(object sender, EventArgs e)
        {

        }

        private void headerPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            using (var form = new UserForm()) {
                this.Hide();
                form.Show();
            }
        }
    }
}
