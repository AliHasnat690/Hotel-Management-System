namespace Hotel_Management_System.Forms
{
    partial class DashboardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            btnRooms = new Button();
            btnGuests = new Button();
            btnBookings = new Button();
            btnBilling = new Button();
            btnLogout = new Button();
            btnReports = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(101, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(476, 48);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Hotel Management System";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnRooms
            // 
            btnRooms.BackColor = Color.FromArgb(41, 128, 185);
            btnRooms.Cursor = Cursors.Hand;
            btnRooms.FlatStyle = FlatStyle.Flat;
            btnRooms.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnRooms.ForeColor = Color.White;
            btnRooms.Location = new Point(26, 194);
            btnRooms.Name = "btnRooms";
            btnRooms.Size = new Size(220, 70);
            btnRooms.TabIndex = 1;
            btnRooms.Text = "Room Management";
            btnRooms.UseVisualStyleBackColor = false;
            btnRooms.Click += btnRooms_Click;
            // 
            // btnGuests
            // 
            btnGuests.BackColor = Color.FromArgb(39, 174, 96);
            btnGuests.Cursor = Cursors.Hand;
            btnGuests.FlatStyle = FlatStyle.Flat;
            btnGuests.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnGuests.ForeColor = Color.White;
            btnGuests.Location = new Point(347, 194);
            btnGuests.Name = "btnGuests";
            btnGuests.Size = new Size(220, 70);
            btnGuests.TabIndex = 2;
            btnGuests.Text = "Guest Management";
            btnGuests.UseVisualStyleBackColor = false;
            btnGuests.Click += btnGuests_Click;
            // 
            // btnBookings
            // 
            btnBookings.BackColor = Color.FromArgb(142, 68, 173);
            btnBookings.Cursor = Cursors.Hand;
            btnBookings.FlatStyle = FlatStyle.Flat;
            btnBookings.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnBookings.ForeColor = Color.White;
            btnBookings.Location = new Point(26, 297);
            btnBookings.Name = "btnBookings";
            btnBookings.Size = new Size(220, 70);
            btnBookings.TabIndex = 3;
            btnBookings.Text = "Bookings";
            btnBookings.UseVisualStyleBackColor = false;
            btnBookings.Click += btnBookings_Click;
            // 
            // btnBilling
            // 
            btnBilling.BackColor = Color.FromArgb(230, 126, 34);
            btnBilling.Cursor = Cursors.Hand;
            btnBilling.FlatStyle = FlatStyle.Flat;
            btnBilling.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnBilling.ForeColor = Color.White;
            btnBilling.Location = new Point(347, 297);
            btnBilling.Name = "btnBilling";
            btnBilling.Size = new Size(220, 70);
            btnBilling.TabIndex = 4;
            btnBilling.Text = "Billing";
            btnBilling.UseVisualStyleBackColor = false;
            btnBilling.Click += btnBilling_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(231, 76, 60);
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(347, 400);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(220, 70);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnReports
            // 
            btnReports.BackColor = Color.FromArgb(22, 160, 133);
            btnReports.Cursor = Cursors.Hand;
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnReports.ForeColor = Color.White;
            btnReports.Location = new Point(26, 400);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(220, 70);
            btnReports.TabIndex = 6;
            btnReports.Text = "Reports";
            btnReports.UseVisualStyleBackColor = false;
            btnReports.Click += btnReports_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(201, 168, 76);
            panel1.Controls.Add(lblTitle);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(678, 80);
            panel1.TabIndex = 7;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 47, 90);
            ClientSize = new Size(678, 544);
            Controls.Add(btnReports);
            Controls.Add(btnLogout);
            Controls.Add(btnBilling);
            Controls.Add(btnBookings);
            Controls.Add(btnGuests);
            Controls.Add(btnRooms);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "DashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hotel Management System - Dashboard";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitle;
        private Button btnRooms;
        private Button btnGuests;
        private Button btnBookings;
        private Button btnBilling;
        private Button btnLogout;
        private Button btnReports;
        private Panel panel1;
    }
}