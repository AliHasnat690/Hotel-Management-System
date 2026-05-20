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
       public class RoomRepository
        {
        // ─────────────────────────────────────────
        // GET ALL ROOMS (with optional search)
        // ─────────────────────────────────────────
        /// <summary>
        /// Retrieves all rooms from database, filtered by optional search term.
        /// Returns a List of Room model objects.
        /// </summary>
        public static List<Room> GetAllRooms(string search = "")
            {
                List<Room> rooms = new List<Room>();

                try
                {
                    using (SQLiteConnection conn = DatabaseHelper.GetConnection())
                    {
                        conn.Open();
                        string sql = "SELECT * FROM Rooms WHERE RoomNumber LIKE @search ORDER BY RoomNumber";

                        using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue("@search", "%" + search + "%");

                            using (SQLiteDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    rooms.Add(new Room
                                    {
                                        Id = Convert.ToInt32(reader["Id"]),
                                        RoomNumber = reader["RoomNumber"].ToString(),
                                        Type = reader["Type"].ToString(),
                                        Price = Convert.ToDecimal(reader["Price"]),
                                        Status = reader["Status"].ToString()
                                    });
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading rooms: " + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                return rooms;
            }

            // ─────────────────────────────────────────
            // GET AVAILABLE ROOMS ONLY (for Booking form)
            // ─────────────────────────────────────────
            public static List<Room> GetAvailableRooms()
            {
                List<Room> rooms = new List<Room>();

                try
                {
                    using (SQLiteConnection conn = DatabaseHelper.GetConnection())
                    {
                        conn.Open();
                        string sql = "SELECT * FROM Rooms WHERE Status='Available' ORDER BY RoomNumber";

                        using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                rooms.Add(new Room
                                {
                                    Id = Convert.ToInt32(reader["Id"]),
                                    RoomNumber = reader["RoomNumber"].ToString(),
                                    Type = reader["Type"].ToString(),
                                    Price = Convert.ToDecimal(reader["Price"]),
                                    Status = reader["Status"].ToString()
                                });
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading rooms: " + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                return rooms;
            }

        // ─────────────────────────────────────────
        // ADD ROOM
        // ─────────────────────────────────────────
        /// <summary>
        /// Inserts a new room record into the Rooms table.
        /// Returns true if successful, false if an error occurs.
        /// </summary
        public static bool AddRoom(Room room)
            {
                try
                {
                    using (SQLiteConnection conn = DatabaseHelper.GetConnection())
                    {
                        conn.Open();
                        string sql = @"INSERT INTO Rooms (RoomNumber, Type, Price, Status) 
                                   VALUES (@roomNo, @type, @price, @status)";

                        using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue("@roomNo", room.RoomNumber);
                            cmd.Parameters.AddWithValue("@type", room.Type);
                            cmd.Parameters.AddWithValue("@price", room.Price);
                            cmd.Parameters.AddWithValue("@status", room.Status);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding room: " + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

        // ─────────────────────────────────────────
        // UPDATE ROOM
        // ─────────────────────────────────────────
        /// <summary>
        /// Updates an existing room record identified by room.Id.
        /// </summary>
        public static bool UpdateRoom(Room room)
            {
                try
                {
                    using (SQLiteConnection conn = DatabaseHelper.GetConnection())
                    {
                        conn.Open();
                        string sql = @"UPDATE Rooms 
                                   SET RoomNumber=@roomNo, Type=@type, 
                                       Price=@price, Status=@status 
                                   WHERE Id=@id";

                        using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue("@roomNo", room.RoomNumber);
                            cmd.Parameters.AddWithValue("@type", room.Type);
                            cmd.Parameters.AddWithValue("@price", room.Price);
                            cmd.Parameters.AddWithValue("@status", room.Status);
                            cmd.Parameters.AddWithValue("@id", room.Id);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating room: " + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

        // ─────────────────────────────────────────
        // DELETE ROOM
        // ─────────────────────────────────────────
        /// <summary>
        /// Deletes a room only if it has no active bookings.
        /// Shows a warning message if deletion is not allowed.
        /// </summary>
        public static bool DeleteRoom(int roomId)
            {
                try
                {
                    using (SQLiteConnection conn = DatabaseHelper.GetConnection())
                    {
                        conn.Open();

                        // Check active bookings first
                        string checkSql = "SELECT COUNT(*) FROM Bookings WHERE RoomId=@id AND Status='Active'";
                        using (SQLiteCommand cmd = new SQLiteCommand(checkSql, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", roomId);
                            int count = Convert.ToInt32(cmd.ExecuteScalar());

                            if (count > 0)
                            {
                                MessageBox.Show(
                                    "Cannot delete! This room has active bookings.",
                                    "Cannot Delete",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return false;
                            }
                        }

                        string deleteSql = "DELETE FROM Rooms WHERE Id=@id";
                        using (SQLiteCommand cmd = new SQLiteCommand(deleteSql, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", roomId);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting room: " + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            // ─────────────────────────────────────────
            // UPDATE ROOM STATUS (used by Booking/Billing)
            // ─────────────────────────────────────────
            public static void UpdateRoomStatus(int roomId, string status)
            {
                try
                {
                    using (SQLiteConnection conn = DatabaseHelper.GetConnection())
                    {
                        conn.Open();
                        string sql = "UPDATE Rooms SET Status=@status WHERE Id=@id";

                        using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue("@status", status);
                            cmd.Parameters.AddWithValue("@id", roomId);
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating room status: " + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
 }

