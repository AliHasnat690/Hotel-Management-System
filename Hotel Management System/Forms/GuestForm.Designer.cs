namespace Hotel_Management_System.Forms
{
    partial class GuestForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            lblTitle = new Label();
            lblName = new Label();
            lblContact = new Label();
            lblCNIC = new Label();
            lblAddress = new Label();
            lblSearch = new Label();
            txtName = new TextBox();
            txtContact = new TextBox();
            txtCNIC = new TextBox();
            txtAddress = new TextBox();
            txtSearch = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            dgvGuests = new DataGridView();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvGuests).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(255, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(312, 45);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Guest Management";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblName.ForeColor = Color.White;
            lblName.Location = new Point(18, 129);
            lblName.Name = "lblName";
            lblName.Size = new Size(133, 28);
            lblName.TabIndex = 1;
            lblName.Text = "Guest Name:";
            // 
            // lblContact
            // 
            lblContact.AutoSize = true;
            lblContact.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblContact.ForeColor = Color.White;
            lblContact.Location = new Point(18, 174);
            lblContact.Name = "lblContact";
            lblContact.Size = new Size(90, 28);
            lblContact.TabIndex = 2;
            lblContact.Text = "Contact:";
            // 
            // lblCNIC
            // 
            lblCNIC.AutoSize = true;
            lblCNIC.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCNIC.ForeColor = Color.White;
            lblCNIC.Location = new Point(18, 214);
            lblCNIC.Name = "lblCNIC";
            lblCNIC.Size = new Size(63, 28);
            lblCNIC.TabIndex = 3;
            lblCNIC.Text = "CNIC:";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblAddress.ForeColor = Color.White;
            lblAddress.Location = new Point(18, 251);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(92, 28);
            lblAddress.TabIndex = 4;
            lblAddress.Text = "Address:";
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSearch.ForeColor = Color.White;
            lblSearch.Location = new Point(255, 70);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(80, 28);
            lblSearch.TabIndex = 5;
            lblSearch.Text = "Search:";
            // 
            // txtName
            // 
            txtName.BackColor = Color.White;
            txtName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(157, 123);
            txtName.Name = "txtName";
            txtName.Size = new Size(150, 34);
            txtName.TabIndex = 6;
            // 
            // txtContact
            // 
            txtContact.BackColor = Color.White;
            txtContact.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContact.Location = new Point(157, 169);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(150, 34);
            txtContact.TabIndex = 7;
            // 
            // txtCNIC
            // 
            txtCNIC.BackColor = Color.White;
            txtCNIC.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCNIC.Location = new Point(157, 211);
            txtCNIC.Name = "txtCNIC";
            txtCNIC.Size = new Size(150, 34);
            txtCNIC.TabIndex = 8;
            // 
            // txtAddress
            // 
            txtAddress.BackColor = Color.White;
            txtAddress.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAddress.Location = new Point(157, 251);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(150, 34);
            txtAddress.TabIndex = 9;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.White;
            txtSearch.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(347, 85);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(202, 34);
            txtSearch.TabIndex = 10;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(39, 174, 96);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(726, 117);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 34);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "Add Guest";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(41, 128, 185);
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(726, 166);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(112, 34);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(231, 76, 60);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(726, 215);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(127, 140, 141);
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(726, 267);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(112, 34);
            btnClear.TabIndex = 14;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // dgvGuests
            // 
            dgvGuests.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(235, 245, 251);
            dgvGuests.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvGuests.BackgroundColor = Color.White;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(26, 47, 90);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(201, 168, 76);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvGuests.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvGuests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGuests.EnableHeadersVisualStyles = false;
            dgvGuests.Location = new Point(2, 366);
            dgvGuests.Name = "dgvGuests";
            dgvGuests.ReadOnly = true;
            dgvGuests.RowHeadersVisible = false;
            dgvGuests.RowHeadersWidth = 62;
            dgvGuests.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGuests.Size = new Size(873, 225);
            dgvGuests.TabIndex = 15;
            dgvGuests.CellClick += dgvGuests_CellClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(201, 168, 76);
            panel1.Controls.Add(lblTitle);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(878, 60);
            panel1.TabIndex = 16;
            // 
            // GuestForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 47, 90);
            ClientSize = new Size(878, 594);
            Controls.Add(panel1);
            Controls.Add(dgvGuests);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtSearch);
            Controls.Add(txtAddress);
            Controls.Add(txtCNIC);
            Controls.Add(txtContact);
            Controls.Add(txtName);
            Controls.Add(lblSearch);
            Controls.Add(lblAddress);
            Controls.Add(lblCNIC);
            Controls.Add(lblContact);
            Controls.Add(lblName);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "GuestForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Guest Management";
            ((System.ComponentModel.ISupportInitialize)dgvGuests).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblName;
        private Label lblContact;
        private Label lblCNIC;
        private Label lblAddress;
        private Label lblSearch;
        private TextBox txtName;
        private TextBox txtContact;
        private TextBox txtCNIC;
        private TextBox txtAddress;
        private TextBox txtSearch;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private DataGridView dgvGuests;
        private Panel panel1;
    }
}