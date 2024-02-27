using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;

namespace Attendance_Management_System.Classes
{
    internal static class TimerManager
    {
        private static System.Timers.Timer timer;

        public static void StartTimer()
        {
            if (timer == null)
            {
                // Create a timer with a 10 minute interval
                timer = new System.Timers.Timer();
                timer.Interval = 600000; // 10 minute
                timer.Elapsed += Timer_Tick; 
                timer.AutoReset = true; 
            }

            // Start the timer
            timer.Start();
        }

        private static void Timer_Tick(object sender, ElapsedEventArgs e)
        {
            XMLManagement.BackupXMLFile();
        }
    }
}
