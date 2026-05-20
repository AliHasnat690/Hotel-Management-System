namespace Hotel_Management_System.Forms
{
    partial class BillingForm
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
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            lblTitle = new Label();
            lblBooking = new Label();
            lblGuestInfo = new Label();
            lblGuestValue = new Label();
            lblRoomInfo = new Label();
            lblRoomValue = new Label();
            lblCheckInInfo = new Label();
            lblCheckInValue = new Label();
            lblCheckOutInfo = new Label();
            lblCheckOutValue = new Label();
            lblNightsInfo = new Label();
            lblNightsValue = new Label();
            cmbBooking = new ComboBox();
            btnCheckout = new Button();
            btnClear = new Button();
            lblPriceInfo = new Label();
            lblPriceValue = new Label();
            lblTotalInfo = new Label();
            lblTotalValue = new Label();
            lblHistory = new Label();
            lblSearch = new Label();
            dgvBills = new DataGridView();
            txtSearch = new TextBox();
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvBills).BeginInit();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(401, 10);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(330, 45);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Billing and Checkout";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBooking
            // 
            lblBooking.AutoSize = true;
            lblBooking.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblBooking.ForeColor = Color.White;
            lblBooking.Location = new Point(197, 35);
            lblBooking.Margin = new Padding(4, 0, 4, 0);
            lblBooking.Name = "lblBooking";
            lblBooking.Size = new Size(224, 28);
            lblBooking.TabIndex = 1;
            lblBooking.Text = "Select Active Booking:";
            // 
            // lblGuestInfo
            // 
            lblGuestInfo.AutoSize = true;
            lblGuestInfo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblGuestInfo.ForeColor = Color.White;
            lblGuestInfo.Location = new Point(13, 88);
            lblGuestInfo.Margin = new Padding(4, 0, 4, 0);
            lblGuestInfo.Name = "lblGuestInfo";
            lblGuestInfo.Size = new Size(71, 28);
            lblGuestInfo.TabIndex = 2;
            lblGuestInfo.Text = "Guest:";
            // 
            // lblGuestValue
            // 
            lblGuestValue.AutoSize = true;
            lblGuestValue.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblGuestValue.ForeColor = Color.White;
            lblGuestValue.Location = new Point(113, 101);
            lblGuestValue.Margin = new Padding(4, 0, 4, 0);
            lblGuestValue.Name = "lblGuestValue";
            lblGuestValue.Size = new Size(36, 28);
            lblGuestValue.TabIndex = 3;
            lblGuestValue.Text = "---";
            // 
            // lblRoomInfo
            // 
            lblRoomInfo.AutoSize = true;
            lblRoomInfo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblRoomInfo.ForeColor = Color.White;
            lblRoomInfo.Location = new Point(253, 88);
            lblRoomInfo.Margin = new Padding(4, 0, 4, 0);
            lblRoomInfo.Name = "lblRoomInfo";
            lblRoomInfo.Size = new Size(72, 28);
            lblRoomInfo.TabIndex = 4;
            lblRoomInfo.Text = "Room:";
            // 
            // lblRoomValue
            // 
            lblRoomValue.AutoSize = true;
            lblRoomValue.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblRoomValue.ForeColor = Color.White;
            lblRoomValue.Location = new Point(350, 116);
            lblRoomValue.Margin = new Padding(4, 0, 4, 0);
            lblRoomValue.Name = "lblRoomValue";
            lblRoomValue.Size = new Size(36, 28);
            lblRoomValue.TabIndex = 5;
            lblRoomValue.Text = "---";
            // 
            // lblCheckInInfo
            // 
            lblCheckInInfo.AutoSize = true;
            lblCheckInInfo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCheckInInfo.ForeColor = Color.White;
            lblCheckInInfo.Location = new Point(463, 88);
            lblCheckInInfo.Margin = new Padding(4, 0, 4, 0);
            lblCheckInInfo.Name = "lblCheckInInfo";
            lblCheckInInfo.Size = new Size(98, 28);
            lblCheckInInfo.TabIndex = 6;
            lblCheckInInfo.Text = "Check-In:";
            // 
            // lblCheckInValue
            // 
            lblCheckInValue.AutoSize = true;
            lblCheckInValue.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCheckInValue.ForeColor = Color.White;
            lblCheckInValue.Location = new Point(596, 116);
            lblCheckInValue.Margin = new Padding(4, 0, 4, 0);
            lblCheckInValue.Name = "lblCheckInValue";
            lblCheckInValue.Size = new Size(36, 28);
            lblCheckInValue.TabIndex = 7;
            lblCheckInValue.Text = "---";
            // 
            // lblCheckOutInfo
            // 
            lblCheckOutInfo.AutoSize = true;
            lblCheckOutInfo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCheckOutInfo.ForeColor = Color.White;
            lblCheckOutInfo.Location = new Point(705, 77);
            lblCheckOutInfo.Margin = new Padding(4, 0, 4, 0);
            lblCheckOutInfo.Name = "lblCheckOutInfo";
            lblCheckOutInfo.Size = new Size(115, 28);
            lblCheckOutInfo.TabIndex = 8;
            lblCheckOutInfo.Text = "Check-Out:";
            // 
            // lblCheckOutValue
            // 
            lblCheckOutValue.AutoSize = true;
            lblCheckOutValue.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCheckOutValue.ForeColor = Color.White;
            lblCheckOutValue.Location = new Point(871, 116);
            lblCheckOutValue.Margin = new Padding(4, 0, 4, 0);
            lblCheckOutValue.Name = "lblCheckOutValue";
            lblCheckOutValue.Size = new Size(36, 28);
            lblCheckOutValue.TabIndex = 9;
            lblCheckOutValue.Text = "---";
            // 
            // lblNightsInfo
            // 
            lblNightsInfo.AutoSize = true;
            lblNightsInfo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNightsInfo.ForeColor = Color.White;
            lblNightsInfo.Location = new Point(32, 267);
            lblNightsInfo.Margin = new Padding(4, 0, 4, 0);
            lblNightsInfo.Name = "lblNightsInfo";
            lblNightsInfo.Size = new Size(150, 28);
            lblNightsInfo.TabIndex = 10;
            lblNightsInfo.Text = "Nights Stayed:";
            // 
            // lblNightsValue
            // 
            lblNightsValue.AutoSize = true;
            lblNightsValue.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNightsValue.ForeColor = Color.White;
            lblNightsValue.Location = new Point(216, 267);
            lblNightsValue.Margin = new Padding(4, 0, 4, 0);
            lblNightsValue.Name = "lblNightsValue";
            lblNightsValue.Size = new Size(36, 28);
            lblNightsValue.TabIndex = 11;
            lblNightsValue.Text = "---";
            // 
            // cmbBooking
            // 
            cmbBooking.BackColor = Color.White;
            cmbBooking.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBooking.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbBooking.FormattingEnabled = true;
            cmbBooking.Location = new Point(463, 27);
            cmbBooking.Margin = new Padding(4, 3, 4, 3);
            cmbBooking.Name = "cmbBooking";
            cmbBooking.Size = new Size(218, 36);
            cmbBooking.TabIndex = 12;
            cmbBooking.SelectedIndexChanged += cmbBooking_SelectedIndexChanged;
            // 
            // btnCheckout
            // 
            btnCheckout.BackColor = Color.FromArgb(39, 174, 96);
            btnCheckout.FlatStyle = FlatStyle.Flat;
            btnCheckout.Location = new Point(1024, 100);
            btnCheckout.Margin = new Padding(4, 3, 4, 3);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.Size = new Size(124, 126);
            btnCheckout.TabIndex = 13;
            btnCheckout.Text = "Generate Bill and Checkout";
            btnCheckout.UseVisualStyleBackColor = false;
            btnCheckout.Click += btnCheckout_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(127, 140, 141);
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Location = new Point(1024, 243);
            btnClear.Margin = new Padding(4, 3, 4, 3);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(124, 38);
            btnClear.TabIndex = 14;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // lblPriceInfo
            // 
            lblPriceInfo.AutoSize = true;
            lblPriceInfo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPriceInfo.ForeColor = Color.White;
            lblPriceInfo.Location = new Point(310, 194);
            lblPriceInfo.Margin = new Padding(4, 0, 4, 0);
            lblPriceInfo.Name = "lblPriceInfo";
            lblPriceInfo.Size = new Size(160, 28);
            lblPriceInfo.TabIndex = 15;
            lblPriceInfo.Text = "Price Per Night:";
            // 
            // lblPriceValue
            // 
            lblPriceValue.AutoSize = true;
            lblPriceValue.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPriceValue.ForeColor = Color.White;
            lblPriceValue.Location = new Point(478, 218);
            lblPriceValue.Margin = new Padding(4, 0, 4, 0);
            lblPriceValue.Name = "lblPriceValue";
            lblPriceValue.Size = new Size(36, 28);
            lblPriceValue.TabIndex = 16;
            lblPriceValue.Text = "---";
            // 
            // lblTotalInfo
            // 
            lblTotalInfo.AutoSize = true;
            lblTotalInfo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTotalInfo.ForeColor = Color.White;
            lblTotalInfo.Location = new Point(596, 194);
            lblTotalInfo.Margin = new Padding(4, 0, 4, 0);
            lblTotalInfo.Name = "lblTotalInfo";
            lblTotalInfo.Size = new Size(146, 28);
            lblTotalInfo.TabIndex = 17;
            lblTotalInfo.Text = "Total Amount:";
            // 
            // lblTotalValue
            // 
            lblTotalValue.AutoSize = true;
            lblTotalValue.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalValue.ForeColor = Color.Green;
            lblTotalValue.Location = new Point(805, 210);
            lblTotalValue.Margin = new Padding(4, 0, 4, 0);
            lblTotalValue.Name = "lblTotalValue";
            lblTotalValue.Size = new Size(119, 38);
            lblTotalValue.TabIndex = 18;
            lblTotalValue.Text = "Rs. 0.00";
            // 
            // lblHistory
            // 
            lblHistory.AutoSize = true;
            lblHistory.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblHistory.ForeColor = Color.White;
            lblHistory.Location = new Point(151, 78);
            lblHistory.Margin = new Padding(4, 0, 4, 0);
            lblHistory.Name = "lblHistory";
            lblHistory.Size = new Size(128, 28);
            lblHistory.TabIndex = 19;
            lblHistory.Text = "Bills History";
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSearch.ForeColor = Color.White;
            lblSearch.Location = new Point(327, 30);
            lblSearch.Margin = new Padding(4, 0, 4, 0);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(169, 28);
            lblSearch.TabIndex = 20;
            lblSearch.Text = "Search by Guest:";
            // 
            // dgvBills
            // 
            dgvBills.AllowUserToAddRows = false;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(235, 245, 251);
            dgvBills.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            dgvBills.BackgroundColor = Color.White;
            dgvBills.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBills.EnableHeadersVisualStyles = false;
            dgvBills.Location = new Point(2, 467);
            dgvBills.Margin = new Padding(4, 3, 4, 3);
            dgvBills.Name = "dgvBills";
            dgvBills.ReadOnly = true;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = Color.FromArgb(26, 47, 90);
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle10.ForeColor = Color.FromArgb(201, 168, 76);
            dataGridViewCellStyle10.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            dgvBills.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            dgvBills.RowHeadersVisible = false;
            dgvBills.RowHeadersWidth = 62;
            dgvBills.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBills.Size = new Size(1172, 252);
            dgvBills.TabIndex = 21;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.White;
            txtSearch.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(508, 63);
            txtSearch.Margin = new Padding(4, 3, 4, 3);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(179, 34);
            txtSearch.TabIndex = 22;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(201, 168, 76);
            panel1.Controls.Add(lblTitle);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1174, 67);
            panel1.TabIndex = 23;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbBooking);
            groupBox1.Controls.Add(lblBooking);
            groupBox1.Controls.Add(lblGuestInfo);
            groupBox1.Controls.Add(lblGuestValue);
            groupBox1.Controls.Add(lblPriceValue);
            groupBox1.Controls.Add(lblTotalValue);
            groupBox1.Controls.Add(lblPriceInfo);
            groupBox1.Controls.Add(lblRoomInfo);
            groupBox1.Controls.Add(lblTotalInfo);
            groupBox1.Controls.Add(lblRoomValue);
            groupBox1.Controls.Add(lblCheckInInfo);
            groupBox1.Controls.Add(lblCheckInValue);
            groupBox1.Controls.Add(lblCheckOutInfo);
            groupBox1.Controls.Add(lblCheckOutValue);
            groupBox1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(19, 73);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(984, 266);
            groupBox1.TabIndex = 24;
            groupBox1.TabStop = false;
            groupBox1.Text = "Checkout Details";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtSearch);
            groupBox2.Controls.Add(lblHistory);
            groupBox2.Controls.Add(lblSearch);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(2, 341);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1172, 378);
            groupBox2.TabIndex = 19;
            groupBox2.TabStop = false;
            groupBox2.Text = "Bills History";
            // 
            // BillingForm
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 43, 45);
            ClientSize = new Size(1174, 721);
            Controls.Add(dgvBills);
            Controls.Add(btnClear);
            Controls.Add(btnCheckout);
            Controls.Add(lblNightsValue);
            Controls.Add(lblNightsInfo);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "BillingForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Billing - Checkout";
            ((System.ComponentModel.ISupportInitialize)dgvBills).EndInit();
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblBooking;
        private Label lblGuestInfo;
        private Label lblGuestValue;
        private Label lblRoomInfo;
        private Label lblRoomValue;
        private Label lblCheckInInfo;
        private Label lblCheckInValue;
        private Label lblCheckOutInfo;
        private Label lblCheckOutValue;
        private Label lblNightsInfo;
        private Label lblNightsValue;
        private ComboBox cmbBooking;
        private Button btnCheckout;
        private Button btnClear;
        private Label lblPriceInfo;
        private Label lblPriceValue;
        private Label lblTotalInfo;
        private Label lblTotalValue;
        private Label lblHistory;
        private Label lblSearch;
        private DataGridView dgvBills;
        private TextBox txtSearch;
        private Panel panel1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
    }
}