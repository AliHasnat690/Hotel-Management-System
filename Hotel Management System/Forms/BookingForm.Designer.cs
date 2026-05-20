namespace Hotel_Management_System.Forms
{
    partial class BookingForm
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            lblTitle = new Label();
            lblGuest = new Label();
            lblSearch = new Label();
            lblRoom = new Label();
            lblCheckIn = new Label();
            lblCheckOut = new Label();
            txtSearch = new TextBox();
            cmbGuest = new ComboBox();
            cmbRoom = new ComboBox();
            dtpCheckIn = new DateTimePicker();
            dtpCheckOut = new DateTimePicker();
            btnBook = new Button();
            btnCancel = new Button();
            btnClear = new Button();
            dgvBookings = new DataGridView();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvBookings).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(314, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(354, 45);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Booking Management";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGuest
            // 
            lblGuest.AutoSize = true;
            lblGuest.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblGuest.ForeColor = Color.White;
            lblGuest.Location = new Point(33, 150);
            lblGuest.Name = "lblGuest";
            lblGuest.Size = new Size(134, 28);
            lblGuest.TabIndex = 1;
            lblGuest.Text = "Select Guest:";
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSearch.ForeColor = Color.White;
            lblSearch.Location = new Point(33, 92);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(169, 28);
            lblSearch.TabIndex = 2;
            lblSearch.Text = "Search by Guest:";
            // 
            // lblRoom
            // 
            lblRoom.AutoSize = true;
            lblRoom.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblRoom.ForeColor = Color.White;
            lblRoom.Location = new Point(33, 207);
            lblRoom.Name = "lblRoom";
            lblRoom.Size = new Size(135, 28);
            lblRoom.TabIndex = 3;
            lblRoom.Text = "Select Room:";
            // 
            // lblCheckIn
            // 
            lblCheckIn.AutoSize = true;
            lblCheckIn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCheckIn.ForeColor = Color.White;
            lblCheckIn.Location = new Point(21, 275);
            lblCheckIn.Name = "lblCheckIn";
            lblCheckIn.Size = new Size(149, 28);
            lblCheckIn.TabIndex = 4;
            lblCheckIn.Text = "Check-In Date:";
            // 
            // lblCheckOut
            // 
            lblCheckOut.AutoSize = true;
            lblCheckOut.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCheckOut.ForeColor = Color.White;
            lblCheckOut.Location = new Point(18, 317);
            lblCheckOut.Name = "lblCheckOut";
            lblCheckOut.Size = new Size(166, 28);
            lblCheckOut.TabIndex = 5;
            lblCheckOut.Text = "Check-Out Date:";
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.White;
            txtSearch.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(360, 86);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(249, 34);
            txtSearch.TabIndex = 6;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // cmbGuest
            // 
            cmbGuest.BackColor = Color.White;
            cmbGuest.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGuest.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbGuest.FormattingEnabled = true;
            cmbGuest.Location = new Point(200, 150);
            cmbGuest.Name = "cmbGuest";
            cmbGuest.Size = new Size(182, 36);
            cmbGuest.TabIndex = 7;
            // 
            // cmbRoom
            // 
            cmbRoom.BackColor = Color.White;
            cmbRoom.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRoom.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbRoom.FormattingEnabled = true;
            cmbRoom.Location = new Point(200, 207);
            cmbRoom.Name = "cmbRoom";
            cmbRoom.Size = new Size(182, 36);
            cmbRoom.TabIndex = 8;
            // 
            // dtpCheckIn
            // 
            dtpCheckIn.Location = new Point(200, 270);
            dtpCheckIn.Name = "dtpCheckIn";
            dtpCheckIn.Size = new Size(300, 31);
            dtpCheckIn.TabIndex = 9;
            // 
            // dtpCheckOut
            // 
            dtpCheckOut.Location = new Point(200, 317);
            dtpCheckOut.Name = "dtpCheckOut";
            dtpCheckOut.Size = new Size(300, 31);
            dtpCheckOut.TabIndex = 10;
            // 
            // btnBook
            // 
            btnBook.BackColor = Color.FromArgb(39, 174, 96);
            btnBook.FlatStyle = FlatStyle.Flat;
            btnBook.ForeColor = Color.White;
            btnBook.Location = new Point(710, 182);
            btnBook.Name = "btnBook";
            btnBook.Size = new Size(206, 36);
            btnBook.TabIndex = 12;
            btnBook.Text = "Book Room";
            btnBook.UseVisualStyleBackColor = false;
            btnBook.Click += btnBook_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(231, 76, 60);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(710, 234);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(206, 36);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Cancel Booking";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(127, 140, 141);
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(710, 287);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(206, 36);
            btnClear.TabIndex = 14;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // dgvBookings
            // 
            dgvBookings.AllowUserToAddRows = false;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(235, 245, 251);
            dgvBookings.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvBookings.BackgroundColor = Color.White;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(26, 47, 90);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(201, 168, 76);
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvBookings.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvBookings.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBookings.EnableHeadersVisualStyles = false;
            dgvBookings.Location = new Point(2, 419);
            dgvBookings.Name = "dgvBookings";
            dgvBookings.ReadOnly = true;
            dgvBookings.RowHeadersVisible = false;
            dgvBookings.RowHeadersWidth = 62;
            dgvBookings.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBookings.Size = new Size(976, 225);
            dgvBookings.TabIndex = 15;
            dgvBookings.CellClick += dgvBookings_CellClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(201, 168, 76);
            panel1.Controls.Add(lblTitle);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(978, 60);
            panel1.TabIndex = 16;
            // 
            // BookingForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(58, 90, 64);
            ClientSize = new Size(978, 644);
            Controls.Add(dgvBookings);
            Controls.Add(btnClear);
            Controls.Add(btnCancel);
            Controls.Add(btnBook);
            Controls.Add(dtpCheckOut);
            Controls.Add(dtpCheckIn);
            Controls.Add(cmbRoom);
            Controls.Add(cmbGuest);
            Controls.Add(txtSearch);
            Controls.Add(lblCheckOut);
            Controls.Add(lblCheckIn);
            Controls.Add(lblRoom);
            Controls.Add(lblSearch);
            Controls.Add(lblGuest);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "BookingForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Booking Management";
            ((System.ComponentModel.ISupportInitialize)dgvBookings).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblGuest;
        private Label lblSearch;
        private Label lblRoom;
        private Label lblCheckIn;
        private Label lblCheckOut;
        private TextBox txtSearch;
        private ComboBox cmbGuest;
        private ComboBox cmbRoom;
        private DateTimePicker dtpCheckIn;
        private DateTimePicker dtpCheckOut;
        private Button btnBook;
        private Button btnCancel;
        private Button btnClear;
        private DataGridView dgvBookings;
        private Panel panel1;
    }
}