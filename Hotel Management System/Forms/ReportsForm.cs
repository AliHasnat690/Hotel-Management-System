using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Hotel_Management_System.Database;
using Hotel_Management_System.Models;

namespace Hotel_Management_System.Forms
{
    public partial class ReportsForm : Form
    {
        public ReportsForm()
        {
            InitializeComponent();
            LoadSummary();
            LoadBillsReport();
        }
        // ─────────────────────────────────────────
        // LOAD SUMMARY CARDS
        // ─────────────────────────────────────────
        private void LoadSummary()
        {
            lblRevValue.Text = $"Rs. {ReportRepository.GetTotalRevenue():F2}";
            lblBookValue.Text = ReportRepository.GetTotalBookings().ToString();
            lblActiveValue.Text = ReportRepository.GetActiveBookingsCount().ToString();
            lblGuestValue.Text = ReportRepository.GetTotalGuests().ToString();
            lblAvailValue.Text = ReportRepository.GetAvailableRoomsCount().ToString();
            lblOccValue.Text = ReportRepository.GetOccupiedRoomsCount().ToString();
        }
        // ─────────────────────────────────────────
        // LOAD BILLS INTO GRID
        // ─────────────────────────────────────────
        private void LoadBillsReport(string search = "")
        {
            dgvBills.Rows.Clear();
            dgvBills.Columns.Clear();

            dgvBills.Columns.Add("Id", "Bill ID");
            dgvBills.Columns.Add("Guest", "Guest Name");
            dgvBills.Columns.Add("Room", "Room No.");
            dgvBills.Columns.Add("Total", "Total (Rs.)");
            dgvBills.Columns.Add("Date", "Date");

            List<Bill> bills = ReportRepository.GetBillsReport(search);

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
        // SEARCH
        // ─────────────────────────────────────────
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadBillsReport(txtSearch.Text.Trim());
        }
        // ─────────────────────────────────────────
        // REFRESH BUTTON
        // ─────────────────────────────────────────
        private void btnRefresh_Click(object sender, EventArgs e)
        {
             LoadSummary();
            LoadBillsReport();
            txtSearch.Clear();
            MessageBox.Show("Report refreshed!", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
