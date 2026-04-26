using System;
using System.Drawing;
using System.Windows.Forms;

namespace NewDesignBookingTrips
{
    partial class SplashForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label subtitle;
        private System.Windows.Forms.Label loading;
        private Guna.UI2.WinForms.Guna2PictureBox logo;
        private Guna.UI2.WinForms.Guna2ProgressBar progressBar;
        private Guna.UI2.WinForms.Guna2Elipse elipse;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.title = new System.Windows.Forms.Label();
            this.subtitle = new System.Windows.Forms.Label();
            this.loading = new System.Windows.Forms.Label();
            this.logo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.progressBar = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.elipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(120)))));
            this.title.Location = new System.Drawing.Point(50, 200);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(800, 70);
            this.title.TabIndex = 1;
            this.title.Text = "Booking Trips System";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // subtitle
            // 
            this.subtitle.BackColor = System.Drawing.Color.Transparent;
            this.subtitle.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.subtitle.ForeColor = System.Drawing.Color.Gray;
            this.subtitle.Location = new System.Drawing.Point(50, 270);
            this.subtitle.Name = "subtitle";
            this.subtitle.Size = new System.Drawing.Size(800, 40);
            this.subtitle.TabIndex = 2;
            this.subtitle.Text = "Your Journey, Our Priority";
            this.subtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loading
            // 
            this.loading.BackColor = System.Drawing.Color.Transparent;
            this.loading.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.loading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.loading.Location = new System.Drawing.Point(150, 380);
            this.loading.Name = "loading";
            this.loading.Size = new System.Drawing.Size(600, 30);
            this.loading.TabIndex = 4;
            this.loading.Text = "Preparing your experience... 0%";
            this.loading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.Image = global::NewDesignBookingTrips.Properties.Resources.Screenshot_2026_04_25_104314;
            this.logo.ImageRotate = 0F;
            this.logo.Location = new System.Drawing.Point(360, 40);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(180, 140);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // progressBar
            // 
            this.progressBar.BorderRadius = 12;
            this.progressBar.FillColor = System.Drawing.Color.LightGray;
            this.progressBar.Location = new System.Drawing.Point(150, 350);
            this.progressBar.Name = "progressBar";
            this.progressBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.progressBar.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.progressBar.Size = new System.Drawing.Size(600, 25);
            this.progressBar.TabIndex = 3;
            this.progressBar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // elipse
            // 
            this.elipse.BorderRadius = 25;
            this.elipse.TargetControl = this;
            // 
            // SplashForm
            // 
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 550);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.title);
            this.Controls.Add(this.subtitle);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.loading);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SplashForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashForm";
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);

        }
    }
}