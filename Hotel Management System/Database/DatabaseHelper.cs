using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using BCrypt.Net;
using System.IO;
using System.Windows.Forms;

namespace Hotel_Management_System.Database
{
    /// <summary>
    /// Initializes the SQLite database and creates all tables if they don't exist.
    /// Also inserts the default admin user with BCrypt hashed password.
    /// Called once at application startup from Program.cs
    /// </summary>
    public class DatabaseHelper
    {
        private static string dbPath = "hotel.db";
        public static string ConnectionString = $"Data Source={dbPath};Version=3;";

        public static void InitializeDatabase()
        {
            try
            {
                // Create database file if it doesn't exist
                if (!File.Exists(dbPath))
                    SQLiteConnection.CreateFile(dbPath);

                using (SQLiteConnection conn = new SQLiteConnection(ConnectionString))
                {
                    conn.Open();

                    string[] tables = {

                        @"CREATE TABLE IF NOT EXISTS Users (
                            Id       INTEGER PRIMARY KEY AUTOINCREMENT,
                            Username TEXT NOT NULL UNIQUE,
                            Password TEXT NOT NULL
                        );",

                        @"CREATE TABLE IF NOT EXISTS Rooms (
                            Id         INTEGER PRIMARY KEY AUTOINCREMENT,
                            RoomNumber TEXT NOT NULL UNIQUE,
                            Type       TEXT NOT NULL,
                            Price      REAL NOT NULL DEFAULT 0,
                            Status     TEXT NOT NULL DEFAULT 'Available'
                        );",

                        @"CREATE TABLE IF NOT EXISTS Guests (
                            Id      INTEGER PRIMARY KEY AUTOINCREMENT,
                            Name    TEXT NOT NULL,
                            Contact TEXT,
                            CNIC    TEXT,
                            Address TEXT
                        );",

                        @"CREATE TABLE IF NOT EXISTS Bookings (
                            Id       INTEGER PRIMARY KEY AUTOINCREMENT,
                            GuestId  INTEGER NOT NULL,
                            RoomId   INTEGER NOT NULL,
                            CheckIn  TEXT NOT NULL,
                            CheckOut TEXT NOT NULL,
                            Status   TEXT NOT NULL DEFAULT 'Active',
                            FOREIGN KEY (GuestId) REFERENCES Guests(Id),
                            FOREIGN KEY (RoomId)  REFERENCES Rooms(Id)
                        );",

                        @"CREATE TABLE IF NOT EXISTS Bills (
                            Id        INTEGER PRIMARY KEY AUTOINCREMENT,
                            BookingId INTEGER NOT NULL,
                            Total     REAL NOT NULL DEFAULT 0,
                            Date      TEXT NOT NULL,
                            FOREIGN KEY (BookingId) REFERENCES Bookings(Id)
                        );"
                    };

                    foreach (string sql in tables)
                    {
                        using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                            cmd.ExecuteNonQuery();
                    }

                    // Insert default admin with BCrypt hashed password
                    string checkAdmin = "SELECT COUNT(*) FROM Users WHERE Username='admin'";
                    using (SQLiteCommand cmd = new SQLiteCommand(checkAdmin, conn))
                    {
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        if (count == 0)
                        {
                            // Hash the password using BCrypt before storing
                            // BCrypt is a one-way hash — original password cannot be recovered
                            string hashedPassword = BCrypt.Net.BCrypt.HashPassword("1234");
                            string insertAdmin = $"INSERT INTO Users (Username, Password) VALUES ('admin', '{hashedPassword}')";
                            using (SQLiteCommand insertCmd = new SQLiteCommand(insertAdmin, conn))
                                insertCmd.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// Returns a new SQLite connection using the configured connection string.
        /// All Repository classes use this method to get database connections.
        /// </summary>

        public static SQLiteConnection GetConnection()
        {
            return new SQLiteConnection(ConnectionString);
        }
    }
}
