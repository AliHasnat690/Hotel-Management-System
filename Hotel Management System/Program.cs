using System;
using System.Windows.Forms;
using Hotel_Management_System.Forms;
using Hotel_Management_System.Database;

namespace Hotel_Management_System
{
       static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            DatabaseHelper.InitializeDatabase();
            Application.Run(new LoginForm());
        }
    }
}