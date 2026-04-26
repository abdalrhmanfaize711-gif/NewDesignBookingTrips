using Guna.UI2.WinForms;

namespace NewDesignBookingTrips
{
    partial class UserForm
    {
        private System.ComponentModel.IContainer components = null;

        private Guna.UI2.WinForms.Guna2Panel sidebar;
        private Guna.UI2.WinForms.Guna2Panel userPanel;

        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblUserName;

        private Guna.UI2.WinForms.Guna2Button btnTrips;
        private Guna.UI2.WinForms.Guna2Button btnBack;
        private Guna.UI2.WinForms.Guna2Button btnUserIcon;

        private Guna.UI2.WinForms.Guna2DataGridView dgvTrips;

        private System.Windows.Forms.DataGridViewTextBoxColumn colTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDestination;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewButtonColumn colAction;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            this.sidebar = new Guna.UI2.WinForms.Guna2Panel();
            this.lblAppName = new System.Windows.Forms.Label();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.btnTrips = new Guna.UI2.WinForms.Guna2Button();
            this.btnBack = new Guna.UI2.WinForms.Guna2Button();
            this.userPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.btnUserIcon = new Guna.UI2.WinForms.Guna2Button();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.dgvTrips = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDestination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAction = new System.Windows.Forms.DataGridViewButtonColumn();
            this.sidebar.SuspendLayout();
            this.userPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrips)).BeginInit();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(34)))), ((int)(((byte)(45)))));
            this.sidebar.Controls.Add(this.lblAppName);
            this.sidebar.Controls.Add(this.lblSubTitle);
            this.sidebar.Controls.Add(this.btnTrips);
            this.sidebar.Controls.Add(this.btnBack);
            this.sidebar.Controls.Add(this.userPanel);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(274, 820);
            this.sidebar.TabIndex = 2;
            // 
            // lblAppName
            // 
            this.lblAppName.AutoSize = true;
            this.lblAppName.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblAppName.ForeColor = System.Drawing.Color.White;
            this.lblAppName.Location = new System.Drawing.Point(3, 30);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(269, 54);
            this.lblAppName.TabIndex = 0;
            this.lblAppName.Text = "BookingTrips";
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubTitle.ForeColor = System.Drawing.Color.Gray;
            this.lblSubTitle.Location = new System.Drawing.Point(3, 96);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(250, 28);
            this.lblSubTitle.TabIndex = 1;
            this.lblSubTitle.Text = "Travel Management System";
            // 
            // btnTrips
            // 
            this.btnTrips.FillColor = System.Drawing.Color.Transparent;
            this.btnTrips.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnTrips.ForeColor = System.Drawing.Color.White;
            this.btnTrips.Image = global::NewDesignBookingTrips.Properties.Resources.airplane_icon_png_2515;
            this.btnTrips.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTrips.Location = new System.Drawing.Point(10, 300);
            this.btnTrips.Name = "btnTrips";
            this.btnTrips.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnTrips.Size = new System.Drawing.Size(240, 45);
            this.btnTrips.TabIndex = 2;
            this.btnTrips.Text = "Your Trips";
            this.btnTrips.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTrips.Click += new System.EventHandler(this.btnTrips_Click);
            // 
            // btnBack
            // 
            this.btnBack.FillColor = System.Drawing.Color.Transparent;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Image = global::NewDesignBookingTrips.Properties.Resources.circled_left__v1;
            this.btnBack.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnBack.Location = new System.Drawing.Point(10, 360);
            this.btnBack.Name = "btnBack";
            this.btnBack.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnBack.Size = new System.Drawing.Size(240, 45);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // userPanel
            // 
            this.userPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.userPanel.Controls.Add(this.btnUserIcon);
            this.userPanel.Controls.Add(this.lblEmail);
            this.userPanel.Controls.Add(this.lblUserName);
            this.userPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.userPanel.Location = new System.Drawing.Point(0, 750);
            this.userPanel.Name = "userPanel";
            this.userPanel.Size = new System.Drawing.Size(274, 70);
            this.userPanel.TabIndex = 4;
            // 
            // btnUserIcon
            // 
            this.btnUserIcon.FillColor = System.Drawing.Color.Transparent;
            this.btnUserIcon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUserIcon.ForeColor = System.Drawing.Color.White;
            this.btnUserIcon.Image = global::NewDesignBookingTrips.Properties.Resources.Screenshot_2026_04_25_170240;
            this.btnUserIcon.ImageSize = new System.Drawing.Size(40, 40);
            this.btnUserIcon.Location = new System.Drawing.Point(10, 10);
            this.btnUserIcon.Name = "btnUserIcon";
            this.btnUserIcon.Size = new System.Drawing.Size(50, 50);
            this.btnUserIcon.TabIndex = 0;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(70, 10);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(177, 25);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "User739@gmail.com";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblUserName.ForeColor = System.Drawing.Color.Gray;
            this.lblUserName.Location = new System.Drawing.Point(70, 30);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(99, 25);
            this.lblUserName.TabIndex = 2;
            this.lblUserName.Text = "User Name";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblWelcome.Location = new System.Drawing.Point(300, 30);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(398, 70);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome back ";
            // 
            // dgvTrips
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.dgvTrips.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvTrips.BackgroundColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTrips.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvTrips.ColumnHeadersHeight = 50;
            this.dgvTrips.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTitle,
            this.colDestination,
            this.colPrice,
            this.colDate,
            this.colStatus,
            this.colAction});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTrips.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvTrips.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTrips.Location = new System.Drawing.Point(280, 120);
            this.dgvTrips.Name = "dgvTrips";
            this.dgvTrips.RowHeadersVisible = false;
            this.dgvTrips.RowHeadersWidth = 62;
            this.dgvTrips.RowTemplate.Height = 45;
            this.dgvTrips.Size = new System.Drawing.Size(1240, 660);
            this.dgvTrips.TabIndex = 1;
            this.dgvTrips.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvTrips.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvTrips.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvTrips.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvTrips.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvTrips.ThemeStyle.BackColor = System.Drawing.Color.Snow;
            this.dgvTrips.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTrips.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.dgvTrips.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvTrips.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.dgvTrips.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvTrips.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvTrips.ThemeStyle.HeaderStyle.Height = 50;
            this.dgvTrips.ThemeStyle.ReadOnly = false;
            this.dgvTrips.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvTrips.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTrips.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dgvTrips.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvTrips.ThemeStyle.RowsStyle.Height = 45;
            this.dgvTrips.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.dgvTrips.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvTrips.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTrips_CellContentClick);
            // 
            // colTitle
            // 
            this.colTitle.HeaderText = "Title";
            this.colTitle.MinimumWidth = 8;
            this.colTitle.Name = "colTitle";
            // 
            // colDestination
            // 
            this.colDestination.HeaderText = "Destination";
            this.colDestination.MinimumWidth = 8;
            this.colDestination.Name = "colDestination";
            // 
            // colPrice
            // 
            this.colPrice.HeaderText = "Price";
            this.colPrice.MinimumWidth = 8;
            this.colPrice.Name = "colPrice";
            // 
            // colDate
            // 
            this.colDate.HeaderText = "Date";
            this.colDate.MinimumWidth = 8;
            this.colDate.Name = "colDate";
            // 
            // colStatus
            // 
            this.colStatus.HeaderText = "Status";
            this.colStatus.MinimumWidth = 8;
            this.colStatus.Name = "colStatus";
            // 
            // colAction
            // 
            this.colAction.HeaderText = "Action";
            this.colAction.MinimumWidth = 8;
            this.colAction.Name = "colAction";
            this.colAction.Text = "Book";
            this.colAction.UseColumnTextForButtonValue = true;
            // 
            // UserForm
            // 
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1528, 820);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.dgvTrips);
            this.Controls.Add(this.sidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.UserForm_Load_1);
            this.sidebar.ResumeLayout(false);
            this.sidebar.PerformLayout();
            this.userPanel.ResumeLayout(false);
            this.userPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrips)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}