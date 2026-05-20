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
        public class BookingRepository
        {
            // ─────────────────────────────────────────
            // GET ALL BOOKINGS
            // ─────────────────────────────────────────
            public static List<Booking> GetAllBookings(string search = "")
            {
                List<Booking> bookings = new List<Booking>();

                try
                {
                    using (SQLiteConnection conn = DatabaseHelper.GetConnection())
                    {
                        conn.Open();
                        string sql = @"SELECT b.Id, g.Name AS GuestName, r.RoomNumber, 
                                          b.CheckIn, b.CheckOut, b.Status,
                                          b.GuestId, b.RoomId
                                   FROM Bookings b
                                   JOIN Guests g ON b.GuestId = g.Id
                                   JOIN Rooms  r ON b.RoomId  = r.Id
                                   WHERE g.Name LIKE @search
                                   ORDER BY b.Id DESC";

                        using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue("@search", "%" + search + "%");

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
                                        CheckOut = reader["CheckOut"].ToString(),
                                        Status = reader["Status"].ToString()
                                    });
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading bookings: " + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                return bookings;
            }

            // ─────────────────────────────────────────
            // ADD BOOKING
            // ─────────────────────────────────────────
            public static bool AddBooking(Booking booking)
            {
                try
                {
                    using (SQLiteConnection conn = DatabaseHelper.GetConnection())
                    {
                        conn.Open();

                        // Save the booking
                        string sql = @"INSERT INTO Bookings 
                                   (GuestId, RoomId, CheckIn, CheckOut, Status)
                                   VALUES (@guestId, @roomId, @checkIn, @checkOut, 'Active')";

                        using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue("@guestId", booking.GuestId);
                            cmd.Parameters.AddWithValue("@roomId", booking.RoomId);
                            cmd.Parameters.AddWithValue("@checkIn", booking.CheckIn);
                            cmd.Parameters.AddWithValue("@checkOut", booking.CheckOut);
                            cmd.ExecuteNonQuery();
                        }

                    // Mark room as Occupied
                    // Automatically mark room as Occupied when booking is created
                    string updateRoom = "UPDATE Rooms SET Status='Occupied' WHERE Id=@id";
                        using (SQLiteCommand cmd = new SQLiteCommand(updateRoom, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", booking.RoomId);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding booking: " + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            // ─────────────────────────────────────────
            // CANCEL BOOKING
            // ─────────────────────────────────────────
            public static bool CancelBooking(int bookingId, int roomId)
            {
                try
                {
                    using (SQLiteConnection conn = DatabaseHelper.GetConnection())
                    {
                        conn.Open();

                        // Mark booking as Cancelled
                        string sql = "UPDATE Bookings SET Status='Cancelled' WHERE Id=@id";
                        using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", bookingId);
                            cmd.ExecuteNonQuery();
                        }

                        // Mark room back to Available
                        string updateRoom = "UPDATE Rooms SET Status='Available' WHERE Id=@id";
                        using (SQLiteCommand cmd = new SQLiteCommand(updateRoom, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", roomId);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error cancelling booking: " + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            // ─────────────────────────────────────────
            // GET BOOKING BY ID (used by Billing)
            // ─────────────────────────────────────────
            public static Booking GetBookingById(int bookingId)
            {
                try
                {
                    using (SQLiteConnection conn = DatabaseHelper.GetConnection())
                    {
                        conn.Open();
                        string sql = @"SELECT b.Id, g.Name AS GuestName, r.RoomNumber,
                                          r.Price, b.CheckIn, b.CheckOut, 
                                          b.Status, b.GuestId, b.RoomId
                                   FROM Bookings b
                                   JOIN Guests g ON b.GuestId = g.Id
                                   JOIN Rooms  r ON b.RoomId  = r.Id
                                   WHERE b.Id = @id";

                        using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", bookingId);

                            using (SQLiteDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    return new Booking
                                    {
                                        Id = Convert.ToInt32(reader["Id"]),
                                        GuestId = Convert.ToInt32(reader["GuestId"]),
                                        GuestName = reader["GuestName"].ToString(),
                                        RoomId = Convert.ToInt32(reader["RoomId"]),
                                        RoomNumber = reader["RoomNumber"].ToString(),
                                        CheckIn = reader["CheckIn"].ToString(),
                                        CheckOut = reader["CheckOut"].ToString(),
                                        Status = reader["Status"].ToString()
                                    };
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error fetching booking: " + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                return null;
            }
        }
}
