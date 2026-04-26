using System;
using System.Windows.Forms;

namespace NewDesignBookingTrips
{
    public partial class SplashForm : Form
    {
        int progress = 0;

        public SplashForm()
        {
            InitializeComponent();
        }

        private void SplashForm_Load(object sender, EventArgs e)
        {
            timer1.Interval = 50; // سرعة الحركة (أسرع من 500)
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progress++;

            progressBar.Value = progress;
            loading.Text = "Preparing your experience... " + progress + "%";

            if (progress >= 100)
            {
                timer1.Stop();

                Form1 f = new Form1();
                f.Show();

                this.Hide();
            }
        }
    }
}