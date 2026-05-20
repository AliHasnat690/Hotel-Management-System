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
        public class GuestRepository
        {
            // ─────────────────────────────────────────
            // GET ALL GUESTS (with optional search)
            // ─────────────────────────────────────────
            public static List<Guest> GetAllGuests(string search = "")
            {
                List<Guest> guests = new List<Guest>();

                try
                {
                    using (SQLiteConnection conn = DatabaseHelper.GetConnection())
                    {
                        conn.Open();
                        string sql = "SELECT * FROM Guests WHERE Name LIKE @search ORDER BY Name";

                        using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue("@search", "%" + search + "%");

                            using (SQLiteDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    guests.Add(new Guest
                                    {
                                        Id = Convert.ToInt32(reader["Id"]),
                                        Name = reader["Name"].ToString(),
                                        Contact = reader["Contact"].ToString(),
                                        CNIC = reader["CNIC"].ToString(),
                                        Address = reader["Address"].ToString()
                                    });
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading guests: " + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                return guests;
            }

            // ─────────────────────────────────────────
            // ADD GUEST
            // ─────────────────────────────────────────
            public static bool AddGuest(Guest guest)
            {
                try
                {
                    using (SQLiteConnection conn = DatabaseHelper.GetConnection())
                    {
                        conn.Open();
                        string sql = @"INSERT INTO Guests (Name, Contact, CNIC, Address) 
                                   VALUES (@name, @contact, @cnic, @address)";

                        using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue("@name", guest.Name);
                            cmd.Parameters.AddWithValue("@contact", guest.Contact);
                            cmd.Parameters.AddWithValue("@cnic", guest.CNIC);
                            cmd.Parameters.AddWithValue("@address", guest.Address);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding guest: " + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            // ─────────────────────────────────────────
            // UPDATE GUEST
            // ─────────────────────────────────────────
            public static bool UpdateGuest(Guest guest)
            {
                try
                {
                    using (SQLiteConnection conn = DatabaseHelper.GetConnection())
                    {
                        conn.Open();
                        string sql = @"UPDATE Guests 
                                   SET Name=@name, Contact=@contact, 
                                       CNIC=@cnic, Address=@address 
                                   WHERE Id=@id";

                        using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue("@name", guest.Name);
                            cmd.Parameters.AddWithValue("@contact", guest.Contact);
                            cmd.Parameters.AddWithValue("@cnic", guest.CNIC);
                            cmd.Parameters.AddWithValue("@address", guest.Address);
                            cmd.Parameters.AddWithValue("@id", guest.Id);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating guest: " + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            // ─────────────────────────────────────────
            // DELETE GUEST
            // ─────────────────────────────────────────
            public static bool DeleteGuest(int guestId)
            {
                try
                {
                    using (SQLiteConnection conn = DatabaseHelper.GetConnection())
                    {
                        conn.Open();

                        // Check if guest has bookings
                        string checkSql = "SELECT COUNT(*) FROM Bookings WHERE GuestId=@id";
                        using (SQLiteCommand cmd = new SQLiteCommand(checkSql, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", guestId);
                            int count = Convert.ToInt32(cmd.ExecuteScalar());

                            if (count > 0)
                            {
                                MessageBox.Show(
                                    "Cannot delete! This guest has booking records.",
                                    "Cannot Delete",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return false;
                            }
                        }

                        string deleteSql = "DELETE FROM Guests WHERE Id=@id";
                        using (SQLiteCommand cmd = new SQLiteCommand(deleteSql, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", guestId);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting guest: " + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
    }
}

