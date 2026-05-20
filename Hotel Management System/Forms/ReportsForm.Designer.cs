namespace Hotel_Management_System.Forms
{
    partial class ReportsForm
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            lblTitle = new Label();
            lblRevTitle = new Label();
            lblRevValue = new Label();
            lblActiveTitle = new Label();
            lblBookTitle = new Label();
            lblBookValue = new Label();
            lblGuestTitle = new Label();
            lblActiveValue = new Label();
            lblGuestValue = new Label();
            lblAvailTitle = new Label();
            lblAvailValue = new Label();
            lblOccTitle = new Label();
            lblOccValue = new Label();
            lblBillsTitle = new Label();
            lblSearch = new Label();
            btnRefresh = new Button();
            txtSearch = new TextBox();
            dgvBills = new DataGridView();
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
            lblTitle.Location = new Point(269, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(446, 45);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Hotel Reports and Summary";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRevTitle
            // 
            lblRevTitle.AutoSize = true;
            lblRevTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblRevTitle.ForeColor = Color.White;
            lblRevTitle.Location = new Point(32, 27);
            lblRevTitle.Name = "lblRevTitle";
            lblRevTitle.Size = new Size(146, 28);
            lblRevTitle.TabIndex = 1;
            lblRevTitle.Text = "Total Revenue";
            // 
            // lblRevValue
            // 
            lblRevValue.AutoSize = true;
            lblRevValue.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRevValue.ForeColor = Color.Green;
            lblRevValue.Location = new Point(257, 19);
            lblRevValue.Name = "lblRevValue";
            lblRevValue.Size = new Size(119, 38);
            lblRevValue.TabIndex = 2;
            lblRevValue.Text = "Rs. 0.00";
            // 
            // lblActiveTitle
            // 
            lblActiveTitle.AutoSize = true;
            lblActiveTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblActiveTitle.ForeColor = Color.White;
            lblActiveTitle.Location = new Point(37, 153);
            lblActiveTitle.Name = "lblActiveTitle";
            lblActiveTitle.Size = new Size(165, 28);
            lblActiveTitle.TabIndex = 3;
            lblActiveTitle.Text = "Active Bookings";
            // 
            // lblBookTitle
            // 
            lblBookTitle.AutoSize = true;
            lblBookTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblBookTitle.ForeColor = Color.White;
            lblBookTitle.Location = new Point(37, 116);
            lblBookTitle.Name = "lblBookTitle";
            lblBookTitle.Size = new Size(152, 28);
            lblBookTitle.TabIndex = 4;
            lblBookTitle.Text = "Total Bookings";
            // 
            // lblBookValue
            // 
            lblBookValue.AutoSize = true;
            lblBookValue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBookValue.Location = new Point(233, 110);
            lblBookValue.Name = "lblBookValue";
            lblBookValue.Size = new Size(27, 32);
            lblBookValue.TabIndex = 5;
            lblBookValue.Text = "0";
            // 
            // lblGuestTitle
            // 
            lblGuestTitle.AutoSize = true;
            lblGuestTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblGuestTitle.ForeColor = Color.White;
            lblGuestTitle.Location = new Point(44, 202);
            lblGuestTitle.Name = "lblGuestTitle";
            lblGuestTitle.Size = new Size(128, 28);
            lblGuestTitle.TabIndex = 6;
            lblGuestTitle.Text = "Total Guests";
            // 
            // lblActiveValue
            // 
            lblActiveValue.AutoSize = true;
            lblActiveValue.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblActiveValue.ForeColor = Color.Green;
            lblActiveValue.Location = new Point(233, 142);
            lblActiveValue.Name = "lblActiveValue";
            lblActiveValue.Size = new Size(33, 38);
            lblActiveValue.TabIndex = 7;
            lblActiveValue.Text = "0";
            // 
            // lblGuestValue
            // 
            lblGuestValue.AutoSize = true;
            lblGuestValue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGuestValue.Location = new Point(233, 196);
            lblGuestValue.Name = "lblGuestValue";
            lblGuestValue.Size = new Size(27, 32);
            lblGuestValue.TabIndex = 8;
            lblGuestValue.Text = "0";
            // 
            // lblAvailTitle
            // 
            lblAvailTitle.AutoSize = true;
            lblAvailTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblAvailTitle.ForeColor = Color.White;
            lblAvailTitle.Location = new Point(37, 249);
            lblAvailTitle.Name = "lblAvailTitle";
            lblAvailTitle.Size = new Size(176, 28);
            lblAvailTitle.TabIndex = 9;
            lblAvailTitle.Text = " Available Rooms";
            // 
            // lblAvailValue
            // 
            lblAvailValue.AutoSize = true;
            lblAvailValue.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAvailValue.ForeColor = Color.RoyalBlue;
            lblAvailValue.Location = new Point(233, 238);
            lblAvailValue.Name = "lblAvailValue";
            lblAvailValue.Size = new Size(33, 38);
            lblAvailValue.TabIndex = 10;
            lblAvailValue.Text = "0";
            // 
            // lblOccTitle
            // 
            lblOccTitle.AutoSize = true;
            lblOccTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblOccTitle.ForeColor = Color.White;
            lblOccTitle.Location = new Point(44, 301);
            lblOccTitle.Name = "lblOccTitle";
            lblOccTitle.Size = new Size(170, 28);
            lblOccTitle.TabIndex = 11;
            lblOccTitle.Text = "Occupied Rooms";
            // 
            // lblOccValue
            // 
            lblOccValue.AutoSize = true;
            lblOccValue.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOccValue.ForeColor = Color.DarkRed;
            lblOccValue.Location = new Point(233, 290);
            lblOccValue.Name = "lblOccValue";
            lblOccValue.Size = new Size(33, 38);
            lblOccValue.TabIndex = 12;
            lblOccValue.Text = "0";
            // 
            // lblBillsTitle
            // 
            lblBillsTitle.AutoSize = true;
            lblBillsTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblBillsTitle.ForeColor = Color.White;
            lblBillsTitle.Location = new Point(23, 39);
            lblBillsTitle.Name = "lblBillsTitle";
            lblBillsTitle.Size = new Size(128, 28);
            lblBillsTitle.TabIndex = 13;
            lblBillsTitle.Text = "Bills History";
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSearch.ForeColor = Color.White;
            lblSearch.Location = new Point(218, 30);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(169, 28);
            lblSearch.TabIndex = 14;
            lblSearch.Text = "Search by Guest:";
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(41, 128, 185);
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(740, 181);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(112, 34);
            btnRefresh.TabIndex = 15;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.White;
            txtSearch.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(415, 33);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(209, 34);
            txtSearch.TabIndex = 16;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // dgvBills
            // 
            dgvBills.AllowUserToAddRows = false;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(235, 245, 251);
            dgvBills.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvBills.BackgroundColor = Color.White;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(26, 47, 90);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(201, 168, 76);
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvBills.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvBills.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBills.EnableHeadersVisualStyles = false;
            dgvBills.Location = new Point(1, 442);
            dgvBills.Name = "dgvBills";
            dgvBills.ReadOnly = true;
            dgvBills.RowHeadersVisible = false;
            dgvBills.RowHeadersWidth = 62;
            dgvBills.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBills.Size = new Size(977, 200);
            dgvBills.TabIndex = 17;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(201, 168, 76);
            panel1.Controls.Add(lblTitle);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(978, 60);
            panel1.TabIndex = 18;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblRevValue);
            groupBox1.Controls.Add(lblRevTitle);
            groupBox1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(12, 57);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(457, 287);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            groupBox1.Text = "Summary";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblBillsTitle);
            groupBox2.Controls.Add(txtSearch);
            groupBox2.Controls.Add(lblSearch);
            groupBox2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(1, 350);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(977, 292);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Bills History";
            // 
            // ReportsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 47, 90);
            ClientSize = new Size(978, 644);
            Controls.Add(dgvBills);
            Controls.Add(btnRefresh);
            Controls.Add(lblOccValue);
            Controls.Add(lblOccTitle);
            Controls.Add(lblAvailValue);
            Controls.Add(lblAvailTitle);
            Controls.Add(lblGuestValue);
            Controls.Add(lblActiveValue);
            Controls.Add(lblGuestTitle);
            Controls.Add(lblBookValue);
            Controls.Add(lblBookTitle);
            Controls.Add(lblActiveTitle);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ReportsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reports and Summary";
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
        private Label lblRevTitle;
        private Label lblRevValue;
        private Label lblActiveTitle;
        private Label lblBookTitle;
        private Label lblBookValue;
        private Label lblGuestTitle;
        private Label lblActiveValue;
        private Label lblGuestValue;
        private Label lblAvailTitle;
        private Label lblAvailValue;
        private Label lblOccTitle;
        private Label lblOccValue;
        private Label lblBillsTitle;
        private Label lblSearch;
        private Button btnRefresh;
        private TextBox txtSearch;
        private DataGridView dgvBills;
        private Panel panel1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
    }
}