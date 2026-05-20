using Hotel_Management_System.Database;
using Hotel_Management_System.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management_System.Forms
{
    public partial class BillingForm : Form
    {
        private int selectedBookingId = -1;
        private int selectedRoomId = -1;
        private decimal roomPrice = 0;
        private decimal totalAmount = 0;
        public BillingForm()
        {
            InitializeComponent();
            LoadActiveBookings();
            LoadBills();
        }
        // ─────────────────────────────────────────
        // LOAD ACTIVE BOOKINGS INTO COMBOBOX
        // ─────────────────────────────────────────
        private void LoadActiveBookings()
        {
            cmbBooking.Items.Clear();
            cmbBooking.Items.Add(new ComboItem(0, "-- Select Active Booking --"));
            cmbBooking.SelectedIndex = 0;

            List<Booking> bookings = BillRepository.GetActiveBookings();
            foreach (Booking b in bookings)
                cmbBooking.Items.Add(new ComboItem(
                    b.Id,
                    $"#{b.Id} - {b.GuestName} - Room {b.RoomNumber}"
                ));
        }
        // ─────────────────────────────────────────
        // WHEN BOOKING IS SELECTED FROM DROPDOWN
        // ─────────────────────────────────────────
        private void cmbBooking_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBooking.SelectedIndex == 0)
            {
                ClearDetails();
                return;
            }

            ComboItem selected = (ComboItem)cmbBooking.SelectedItem;
            selectedBookingId = selected.Id;

            // Get full booking details
            Booking booking = BookingRepository.GetBookingById(selectedBookingId);
            if (booking == null) return;

            selectedRoomId = booking.RoomId;
            roomPrice = BillRepository.GetRoomPrice(selectedRoomId);

            // Calculate nights stayed
            DateTime checkIn = DateTime.Parse(booking.CheckIn);
            DateTime checkOut = DateTime.Parse(booking.CheckOut);
            int nights = (checkOut - checkIn).Days;
            if (nights < 1) nights = 1;

            totalAmount = nights * roomPrice;

            // Fill the detail labels
            lblGuestValue.Text = booking.GuestName;
            lblRoomValue.Text = booking.RoomNumber;
            lblCheckInValue.Text = booking.CheckIn;
            lblCheckOutValue.Text = booking.CheckOut;
            lblNightsValue.Text = nights.ToString();
            lblPriceValue.Text = $"Rs. {roomPrice:F2}";
            lblTotalValue.Text = $"Rs. {totalAmount:F2}";
        }
        // ─────────────────────────────────────────
        // GENERATE BILL AND CHECKOUT
        // ─────────────────────────────────────────
        private void btnCheckout_Click(object sender, EventArgs e)
        {
            if (selectedBookingId == -1)
            {
                MessageBox.Show("Please select an active booking!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show(
                $"Generate bill for {lblGuestValue.Text}?\n" +
                $"Room: {lblRoomValue.Text}\n" +
                $"Nights: {lblNightsValue.Text}\n" +
                $"Total: Rs. {totalAmount:F2}",
                "Confirm Checkout",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (BillRepository.GenerateBill(selectedBookingId, selectedRoomId, totalAmount))
                {
                    MessageBox.Show(
                        $"Checkout successful!\n" +
                        $"Total Bill: Rs. {totalAmount:F2}\n" +
                        $"Room {lblRoomValue.Text} is now Available.",
                        "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ClearDetails();
                    LoadActiveBookings();
                    LoadBills();
                }
            }
        }
        // ─────────────────────────────────────────
        // LOAD BILLS HISTORY INTO GRID
        // ─────────────────────────────────────────
        private void LoadBills(string search = "")
        {
            dgvBills.Rows.Clear();
            dgvBills.Columns.Clear();

            dgvBills.Columns.Add("Id", "Bill ID");
            dgvBills.Columns.Add("Guest", "Guest Name");
            dgvBills.Columns.Add("Room", "Room No.");
            dgvBills.Columns.Add("Total", "Total (Rs.)");
            dgvBills.Columns.Add("Date", "Date");

            List<Bill> bills = BillRepository.GetAllBills(search);

            foreach (Bill b in bills)
            {
                dgvBills.Rows.Add(
                    b.Id,
                    b.GuestName,
                    b.RoomNumber,
                    $"Rs. {b.Total:F2}",
                    b.Date
                );
            }
        }
        // ─────────────────────────────────────────
        // SEARCH BILLS
        // ─────────────────────────────────────────
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadBills(txtSearch.Text.Trim());
        }
        // ─────────────────────────────────────────
        // CLEAR BUTTON
        // ─────────────────────────────────────────
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearDetails();
        }
        private void ClearDetails()
        {
            cmbBooking.SelectedIndex = 0;
            lblGuestValue.Text = "---";
            lblRoomValue.Text = "---";
            lblCheckInValue.Text = "---";
            lblCheckOutValue.Text = "---";
            lblNightsValue.Text = "---";
            lblPriceValue.Text = "---";
            lblTotalValue.Text = "Rs. 0.00";
            selectedBookingId = -1;
            selectedRoomId = -1;
            roomPrice = 0;
            totalAmount = 0;
        }
    }
}
