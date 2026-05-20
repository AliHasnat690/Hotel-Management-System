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
    public partial class RoomForm : Form
    {
        private int selectedRoomId = -1;
        public RoomForm()
        {
            InitializeComponent();
            LoadRooms();
        }
        private void LoadRooms(string search = "")
        {
            dgvRooms.Rows.Clear();
            dgvRooms.Columns.Clear();

            dgvRooms.Columns.Add("Id", "ID");
            dgvRooms.Columns.Add("RoomNumber", "Room No.");
            dgvRooms.Columns.Add("Type", "Type");
            dgvRooms.Columns.Add("Price", "Price/Night (Rs.)");
            dgvRooms.Columns.Add("Status", "Status");

            dgvRooms.Columns["Id"].Visible = false;

            // All data comes from RoomRepository — no SQL in this form!
            List<Room> rooms = RoomRepository.GetAllRooms(search);

            foreach (Room room in rooms)
            {
                int rowIndex = dgvRooms.Rows.Add(
                    room.Id,
                    room.RoomNumber,
                    room.Type,
                    room.Price.ToString("F2"),
                    room.Status
                );

                // Color code by status
                if (room.Status == "Occupied")
                    dgvRooms.Rows[rowIndex].DefaultCellStyle.BackColor = Color.LightCoral;
                else if (room.Status == "Under Maintenance")
                    dgvRooms.Rows[rowIndex].DefaultCellStyle.BackColor = Color.LightYellow;
                else
                    dgvRooms.Rows[rowIndex].DefaultCellStyle.BackColor = Color.LightGreen;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            Room room = new Room
            {
                RoomNumber = txtRoomNo.Text.Trim(),
                Type = cmbType.SelectedItem.ToString(),
                Price = decimal.Parse(txtPrice.Text.Trim()),
                Status = cmbStatus.SelectedItem.ToString()
            };

            if (RoomRepository.AddRoom(room))
            {
                MessageBox.Show("Room added successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
                LoadRooms();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedRoomId == -1)
            {
                MessageBox.Show("Please select a room to update!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateInputs()) return;

            Room room = new Room
            {
                Id = selectedRoomId,
                RoomNumber = txtRoomNo.Text.Trim(),
                Type = cmbType.SelectedItem.ToString(),
                Price = decimal.Parse(txtPrice.Text.Trim()),
                Status = cmbStatus.SelectedItem.ToString()
            };

            if (RoomRepository.UpdateRoom(room))
            {
                MessageBox.Show("Room updated successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
                LoadRooms();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedRoomId == -1)
            {
                MessageBox.Show("Please select a room to delete!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this room?", "Confirm Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (RoomRepository.DeleteRoom(selectedRoomId))
                {
                    MessageBox.Show("Room deleted successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                    LoadRooms();
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadRooms(txtSearch.Text.Trim());
        }

        private void dgvRooms_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvRooms.Rows[e.RowIndex];
                selectedRoomId = int.Parse(row.Cells["Id"].Value.ToString());
                txtRoomNo.Text = row.Cells["RoomNumber"].Value.ToString();
                cmbType.SelectedItem = row.Cells["Type"].Value.ToString();
                txtPrice.Text = row.Cells["Price"].Value.ToString();
                cmbStatus.SelectedItem = row.Cells["Status"].Value.ToString();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
        private void ClearFields()
        {
            txtRoomNo.Clear();
            cmbType.SelectedIndex = -1;
            txtPrice.Clear();
            cmbStatus.SelectedIndex = -1;
            selectedRoomId = -1;
        }
        private bool ValidateInputs()
        {
            if (string.IsNullOrEmpty(txtRoomNo.Text.Trim()))
            {
                MessageBox.Show("Please enter room number!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cmbType.SelectedIndex == -1)
            {
                MessageBox.Show("Please select room type!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(txtPrice.Text.Trim()))
            {
                MessageBox.Show("Please enter price!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cmbStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Please select status!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
    }
}
