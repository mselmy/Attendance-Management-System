using Attendance_Management_System.Classes;
using Attendance_Management_System.Forms;

namespace Attendance_Management_System
{
    internal static class Program
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
            TimerManager.StartTimer();
            Application.Run(new Login());
        }
    }
}