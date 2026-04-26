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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void A_ETrips_Click(object sender, EventArgs e)
        {
            using(var form = new TripEaitandAdd())
            {
                this.Hide();
                form.ShowDialog();
                this.Show();
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
            using (var form = new Form1()) { 
               form.Show();
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            using (var form = new AdminUsers()) {
                this.Hide();
                form.ShowDialog();
                this.Show();
            }
        }
    }
}
