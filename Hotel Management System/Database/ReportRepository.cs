using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Hotel_Management_System.Database
{
       public class ReportRepository
        {
            // ─────────────────────────────────────────
            // TOTAL REVENUE FROM ALL BILLS
            // ─────────────────────────────────────────
            public static decimal GetTotalRevenue()
            {
                try
                {
                    using (SQLiteConnection conn = DatabaseHelper.GetConnection())
                    {
                        conn.Open();
                        string sql = "SELECT IFNULL(SUM(Total), 0) FROM Bills";

                        using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                            return Convert.ToDecimal(cmd.ExecuteScalar());
                    }
                }
                catch { return 0; }
            }

            // ─────────────────────────────────────────
            // TOTAL NUMBER OF BOOKINGS
            // ─────────────────────────────────────────
            public static int GetTotalBookings()
            {
                try
                {
                    using (SQLiteConnection conn = DatabaseHelper.GetConnection())
                    {
                        conn.Open();
                        string sql = "SELECT COUNT(*) FROM Bookings";

                        using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                            return Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
                catch { return 0; }
            }

            // ─────────────────────────────────────────
            // ACTIVE BOOKINGS COUNT
            // ─────────────────────────────────────────
            public static int GetActiveBookingsCount()
            {
                try
                {
                    using (SQLiteConnection conn = DatabaseHelper.GetConnection())
                    {
                        conn.Open();
                        string sql = "SELECT COUNT(*) FROM Bookings WHERE Status='Active'";

                        using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                            return Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
                catch { return 0; }
            }

            // ─────────────────────────────────────────
            // AVAILABLE ROOMS COUNT
            // ─────────────────────────────────────────
            public static int GetAvailableRoomsCount()
            {
                try
                {
                    using (SQLiteConnection conn = DatabaseHelper.GetConnection())
                    {
                        conn.Open();
                        string sql = "SELECT COUNT(*) FROM Rooms WHERE Status='Available'";

                        using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                            return Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
                catch { return 0; }
            }

            // ─────────────────────────────────────────
            // OCCUPIED ROOMS COUNT
            // ─────────────────────────────────────────
            public static int GetOccupiedRoomsCount()
            {
                try
                {
                    using (SQLiteConnection conn = DatabaseHelper.GetConnection())
                    {
                        conn.Open();
                        string sql = "SELECT COUNT(*) FROM Rooms WHERE Status='Occupied'";

                        using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                            return Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
                catch { return 0; }
            }

            // ─────────────────────────────────────────
            // TOTAL GUESTS REGISTERED
            // ─────────────────────────────────────────
            public static int GetTotalGuests()
            {
                try
                {
                    using (SQLiteConnection conn = DatabaseHelper.GetConnection())
                    {
                        conn.Open();
                        string sql = "SELECT COUNT(*) FROM Guests";

                        using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                            return Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
                catch { return 0; }
            }

            // ─────────────────────────────────────────
            // GET ALL BILLS FOR REPORT TABLE
            // ─────────────────────────────────────────
            public static System.Collections.Generic.List<Models.Bill> GetBillsReport(string search = "")
            {
                var bills = new System.Collections.Generic.List<Models.Bill>();

                try
                {
                    using (SQLiteConnection conn = DatabaseHelper.GetConnection())
                    {
                        conn.Open();
                        string sql = @"SELECT bl.Id, g.Name AS GuestName, r.RoomNumber,
                                          bl.Total, bl.Date
                                   FROM Bills bl
                                   JOIN Bookings bk ON bl.BookingId = bk.Id
                                   JOIN Guests   g  ON bk.GuestId  = g.Id
                                   JOIN Rooms    r  ON bk.RoomId   = r.Id
                                   WHERE g.Name LIKE @search
                                   ORDER BY bl.Id DESC";

                        using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue("@search", "%" + search + "%");

                            using (SQLiteDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    bills.Add(new Models.Bill
                                    {
                                        Id = Convert.ToInt32(reader["Id"]),
                                        GuestName = reader["GuestName"].ToString(),
                                        RoomNumber = reader["RoomNumber"].ToString(),
                                        Total = Convert.ToDecimal(reader["Total"]),
                                        Date = reader["Date"].ToString()
                                    });
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading report: " + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                return bills;
            }
      }
}

