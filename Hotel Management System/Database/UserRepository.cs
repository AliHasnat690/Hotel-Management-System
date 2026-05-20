using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using BCrypt.Net;


namespace Hotel_Management_System.Database
{
    public class UserRepository
    {
        public static bool ValidateLogin(string username, string password)
        {
            try
            {
                using (SQLiteConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string sql = "SELECT Password FROM Users WHERE Username=@u";

                    using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@u", username);
                        string hashedPassword = cmd.ExecuteScalar()?.ToString();

                        if (hashedPassword == null) return false;


                        // BCrypt.Verify compares plain password with stored hash
                        // It never decrypts — one-way comparison only

                        return BCrypt.Net.BCrypt.Verify(password, hashedPassword);
                    }
                }
            }
            catch { return false; }
        }
    }
}
