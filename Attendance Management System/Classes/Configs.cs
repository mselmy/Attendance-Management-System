using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendance_Management_System.Classes
{
    internal class Configs
    {
        public static string DataPath = @"../../../Data/Data.xml";
        public static string UsersPath = "/school/users/user";
        public static string StudentsPath = "/school/students/student";
        public static string TeachersPath = "/school/teachers/teacher";
        public static string TeachersCoursesPath = "/school/teachers/teacher";
        public static string StudentsClassesPath = "/school/students/student";
        public static string AdminsPath = "/school/admins/admin";
        public static string ClassesPath = "/school/classes/class";
        public static string AttendenceRecordpath = @"/school/attendance-records/attendance-record";
        public static string language = "EN";
        public static string dateFormate = "dd/MM/yyyy";

        public static void ChangeLanguage()
        {
            CultureInfo newCulture;
            if (language == "AR")
            {
                newCulture = new CultureInfo("ar-EG");
            }
            else
            {
                newCulture = new CultureInfo("en-US");
            }
            Thread.CurrentThread.CurrentUICulture = newCulture;
            Thread.CurrentThread.CurrentCulture = newCulture;
        }
    }
}
