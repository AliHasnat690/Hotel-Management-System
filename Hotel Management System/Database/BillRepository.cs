using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;
using Hotel_Management_System.Models;

namespace Hotel_Management_System.Database
{
    public class BillRepository
    {
        // ─────────────────────────────────────────
        // GET ALL BILLS
        // ─────────────────────────────────────────
        public static List<Bill> GetAllBills(string search = "")
        {
            List<Bill> bills = new List<Bill>();

            try
            {
                using (SQLiteConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string sql = @"SELECT bl.Id, g.Name AS GuestName, r.RoomNumber,
                                          bl.Total, bl.Date, bk.CheckIn, bk.CheckOut
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
                                bills.Add(new Bill
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
                MessageBox.Show("Error loading bills: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return bills;
        }
        // ─────────────────────────────────────────
        // GENERATE BILL (checkout)
        // ─────────────────────────────────────────
        public static bool GenerateBill(int bookingId, int roomId, decimal total)
        {
            try
            {
                using (SQLiteConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    // Save the bill
                    string billSql = @"INSERT INTO Bills (BookingId, Total, Date)
                                       VALUES (@bookingId, @total, @date)";

                    using (SQLiteCommand cmd = new SQLiteCommand(billSql, conn))
                    {
                        cmd.Parameters.AddWithValue("@bookingId", bookingId);
                        cmd.Parameters.AddWithValue("@total", total);
                        cmd.Parameters.AddWithValue("@date", DateTime.Now.ToString("yyyy-MM-dd"));
                        cmd.ExecuteNonQuery();
                    }

                    // Mark booking as Completed
                    string completeSql = "UPDATE Bookings SET Status='Completed' WHERE Id=@id";
                    using (SQLiteCommand cmd = new SQLiteCommand(completeSql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", bookingId);
                        cmd.ExecuteNonQuery();
                    }

                    // Mark room back to Available
                    string roomSql = "UPDATE Rooms SET Status='Available' WHERE Id=@id";
                    using (SQLiteCommand cmd = new SQLiteCommand(roomSql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", roomId);
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating bill: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        // ─────────────────────────────────────────
        // GET ACTIVE BOOKINGS (for billing dropdown)
        // ─────────────────────────────────────────
        public static List<Booking> GetActiveBookings()
        {
            List<Booking> bookings = new List<Booking>();

            try
            {
                using (SQLiteConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string sql = @"SELECT b.Id, g.Name AS GuestName, r.RoomNumber,
                                          r.Price, b.CheckIn, b.CheckOut,
                                          b.GuestId, b.RoomId
                                   FROM Bookings b
                                   JOIN Guests g ON b.GuestId = g.Id
                                   JOIN Rooms  r ON b.RoomId  = r.Id
                                   WHERE b.Status = 'Active'
                                   ORDER BY b.Id DESC";

                    using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            bookings.Add(new Booking
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                GuestId = Convert.ToInt32(reader["GuestId"]),
                                GuestName = reader["GuestName"].ToString(),
                                RoomId = Convert.ToInt32(reader["RoomId"]),
                                RoomNumber = reader["RoomNumber"].ToString(),
                                CheckIn = reader["CheckIn"].ToString(),
                                CheckOut = reader["CheckOut"].ToString()
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading active bookings: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return bookings;
        }

        // ─────────────────────────────────────────
        // GET ROOM PRICE (for bill calculation)
        // ─────────────────────────────────────────
        public static decimal GetRoomPrice(int roomId)
        {
            try
            {
                using (SQLiteConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string sql = "SELECT Price FROM Rooms WHERE Id=@id";

                    using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", roomId);
                        return Convert.ToDecimal(cmd.ExecuteScalar());
                    }
                }
            }
            catch { return 0; }
        }
    }
}
