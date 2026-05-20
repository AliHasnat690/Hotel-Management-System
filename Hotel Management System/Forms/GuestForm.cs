using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hotel_Management_System.Database;
using Hotel_Management_System.Models;

namespace Hotel_Management_System.Forms
{
    public partial class GuestForm : Form
    {
        private int selectedGuestId = -1;
        public GuestForm()
        {
            InitializeComponent();
            LoadGuests();
        }
        private void LoadGuests(string search = "")
        {
            dgvGuests.Rows.Clear();
            dgvGuests.Columns.Clear();

            dgvGuests.Columns.Add("Id", "ID");
            dgvGuests.Columns.Add("Name", "Guest Name");
            dgvGuests.Columns.Add("Contact", "Contact");
            dgvGuests.Columns.Add("CNIC", "CNIC");
            dgvGuests.Columns.Add("Address", "Address");

            dgvGuests.Columns["Id"].Visible = false;

            List<Guest> guests = GuestRepository.GetAllGuests(search);

            foreach (Guest guest in guests)
            {
                dgvGuests.Rows.Add(
                    guest.Id,
                    guest.Name,
                    guest.Contact,
                    guest.CNIC,
                    guest.Address
                );
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            Guest guest = new Guest
            {
                Name = txtName.Text.Trim(),
                Contact = txtContact.Text.Trim(),
                CNIC = txtCNIC.Text.Trim(),
                Address = txtAddress.Text.Trim()
            };

            if (GuestRepository.AddGuest(guest))
            {
                MessageBox.Show("Guest added successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
                LoadGuests();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedGuestId == -1)
            {
                MessageBox.Show("Please select a guest to update!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateInputs()) return;

            Guest guest = new Guest
            {
                Id = selectedGuestId,
                Name = txtName.Text.Trim(),
                Contact = txtContact.Text.Trim(),
                CNIC = txtCNIC.Text.Trim(),
                Address = txtAddress.Text.Trim()
            };

            if (GuestRepository.UpdateGuest(guest))
            {
                MessageBox.Show("Guest updated successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
                LoadGuests();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedGuestId == -1)
            {
                MessageBox.Show("Please select a guest to delete!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this guest?", "Confirm Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (GuestRepository.DeleteGuest(selectedGuestId))
                {
                    MessageBox.Show("Guest deleted successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                    LoadGuests();
                }
            }
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadGuests(txtSearch.Text.Trim());
        }

        private void dgvGuests_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvGuests.Rows[e.RowIndex];
                selectedGuestId = int.Parse(row.Cells["Id"].Value.ToString());
                txtName.Text = row.Cells["Name"].Value.ToString();
                txtContact.Text = row.Cells["Contact"].Value.ToString();
                txtCNIC.Text = row.Cells["CNIC"].Value.ToString();
                txtAddress.Text = row.Cells["Address"].Value.ToString();
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
        private void ClearFields()
        {
            txtName.Clear();
            txtContact.Clear();
            txtCNIC.Clear();
            txtAddress.Clear();
            selectedGuestId = -1;
        }
        private bool ValidateInputs()
        {
            if (string.IsNullOrEmpty(txtName.Text.Trim()))
            {
                MessageBox.Show("Please enter guest name!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(txtContact.Text.Trim()))
            {
                MessageBox.Show("Please enter contact number!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
    }
}

