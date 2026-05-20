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
    public partial class BookingForm : Form
    {
        private int selectedBookingId = -1;
        private int selectedRoomId = -1;
        public BookingForm()
        {
            InitializeComponent();
            LoadGuests();
            LoadAvailableRooms();
            LoadBookings();

            // Set default dates
            dtpCheckIn.Value = DateTime.Today;
            dtpCheckOut.Value = DateTime.Today.AddDays(1);
        }
        // ─────────────────────────────────────────
        // LOAD GUESTS INTO COMBOBOX
        // ─────────────────────────────────────────
        private void LoadGuests()
        {
            cmbGuest.Items.Clear();
            cmbGuest.Items.Add(new ComboItem(0, "-- Select Guest --"));
            cmbGuest.SelectedIndex = 0;

            List<Guest> guests = GuestRepository.GetAllGuests();
            foreach (Guest g in guests)
                cmbGuest.Items.Add(new ComboItem(g.Id, g.Name));
        }
        // ─────────────────────────────────────────
        // LOAD AVAILABLE ROOMS INTO COMBOBOX
        // ─────────────────────────────────────────
        private void LoadAvailableRooms()
        {
            cmbRoom.Items.Clear();
            cmbRoom.Items.Add(new ComboItem(0, "-- Select Room --"));
            cmbRoom.SelectedIndex = 0;

            List<Room> rooms = RoomRepository.GetAvailableRooms();
            foreach (Room r in rooms)
                cmbRoom.Items.Add(new ComboItem(r.Id, $"Room {r.RoomNumber} - {r.Type} - Rs.{r.Price}/night"));
        }
        // ─────────────────────────────────────────
        // LOAD ALL BOOKINGS INTO GRID
        // ─────────────────────────────────────────
        private void LoadBookings(string search = "")
        {
            dgvBookings.Rows.Clear();
            dgvBookings.Columns.Clear();

            dgvBookings.Columns.Add("Id", "ID");
            dgvBookings.Columns.Add("RoomId", "RoomId");
            dgvBookings.Columns.Add("Guest", "Guest Name");
            dgvBookings.Columns.Add("Room", "Room No.");
            dgvBookings.Columns.Add("CheckIn", "Check-In");
            dgvBookings.Columns.Add("CheckOut", "Check-Out");
            dgvBookings.Columns.Add("Status", "Status");

            dgvBookings.Columns["Id"].Visible = false;
            dgvBookings.Columns["RoomId"].Visible = false;

            List<Booking> bookings = BookingRepository.GetAllBookings(search);

            foreach (Booking b in bookings)
            {
                int rowIndex = dgvBookings.Rows.Add(
                    b.Id,
                    b.RoomId,
                    b.GuestName,
                    b.RoomNumber,
                    b.CheckIn,
                    b.CheckOut,
                    b.Status
                );

                // Color code by status
                if (b.Status == "Active")
                    dgvBookings.Rows[rowIndex].DefaultCellStyle.BackColor = Color.LightGreen;
                else if (b.Status == "Cancelled")
                    dgvBookings.Rows[rowIndex].DefaultCellStyle.BackColor = Color.LightCoral;
                else
                    dgvBookings.Rows[rowIndex].DefaultCellStyle.BackColor = Color.LightYellow;
            }
        }
        // ─────────────────────────────────────────
        // BOOK ROOM BUTTON
        // ─────────────────────────────────────────
        private void btnBook_Click(object sender, EventArgs e)
        {
            if (cmbGuest.SelectedIndex == 0)
            {
                MessageBox.Show("Please select a guest!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbRoom.SelectedIndex == 0)
            {
                MessageBox.Show("Please select a room!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dtpCheckOut.Value <= dtpCheckIn.Value)
            {
                MessageBox.Show("Check-out date must be after check-in date!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ComboItem guest = (ComboItem)cmbGuest.SelectedItem;
            ComboItem room = (ComboItem)cmbRoom.SelectedItem;

            Booking booking = new Booking
            {
                GuestId = guest.Id,
                RoomId = room.Id,
                CheckIn = dtpCheckIn.Value.ToString("yyyy-MM-dd"),
                CheckOut = dtpCheckOut.Value.ToString("yyyy-MM-dd")
            };

            if (BookingRepository.AddBooking(booking))
            {
                MessageBox.Show("Room booked successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
                LoadAvailableRooms(); // Refresh — booked room removed from list
                LoadBookings();
            }
        }
        // ─────────────────────────────────────────
        // CANCEL BOOKING BUTTON
        // ─────────────────────────────────────────
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (selectedBookingId == -1)
            {
                MessageBox.Show("Please select a booking to cancel!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to cancel this booking?", "Confirm Cancel",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (BookingRepository.CancelBooking(selectedBookingId, selectedRoomId))
                {
                    MessageBox.Show("Booking cancelled successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                    LoadAvailableRooms();
                    LoadBookings();
                }
            }
        }

        // ─────────────────────────────────────────
        // CLICK ROW IN GRID
        // ─────────────────────────────────────────
        private void dgvBookings_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvBookings.Rows[e.RowIndex];
                selectedBookingId = int.Parse(row.Cells["Id"].Value.ToString());
                selectedRoomId = int.Parse(row.Cells["RoomId"].Value.ToString());
            }
        }
        // ─────────────────────────────────────────
        // SEARCH
        // ─────────────────────────────────────────
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadBookings(txtSearch.Text.Trim());
        }
        // ─────────────────────────────────────────
        // CLEAR BUTTON
        // ─────────────────────────────────────────
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
        private void ClearFields()
        {
            cmbGuest.SelectedIndex = 0;
            cmbRoom.SelectedIndex = 0;
            dtpCheckIn.Value = DateTime.Today;
            dtpCheckOut.Value = DateTime.Today.AddDays(1);
            selectedBookingId = -1;
            selectedRoomId = -1;
        }
    }
}

