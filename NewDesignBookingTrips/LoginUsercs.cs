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
    public partial class LoginUsercs : Form
    {
        public LoginUsercs()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

        }

        private void Login_Click(object sender, EventArgs e)
        {
            using (var form = new UserForm()) { 
                this.Hide();
                form.ShowDialog();
                this.Show();
            }
        }

        private void guna2ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
