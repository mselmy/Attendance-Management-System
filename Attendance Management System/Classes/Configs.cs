﻿using Org.BouncyCastle.Tls;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendance_Management_System.Classes
{
    internal class Configs
    {
        // Debug paths
        public static string DataPath = @"../../../Data/Data.xml";
        public static string BackupPath = @"../../../Data/Backup/Backup";
        public static string FilterDateRangePath = @"../../../Data/RangeDates.xslt";
        public static string FilterClassIdPath = @"../../../Data/ClassById.xslt";
        public static string FilterStudentIdPath = @"../../../Data/StudentById.xslt";
        public static string FilterClassDateRange = @"../../../Data/ClassdateRange.xslt";
        public static string FilterStudentDateRange = @"../../../Data/StudentdateRange.xslt";
        public static string FilterTeacherClasses = @"../../../Data/TeacherReport.xslt";
        public static string FilterTeacherStudent = @"../../../Data/TeacheRportForStudent.xslt";
        public static string FilterStudentClass = @"../../../Data/StudentClassDateRange.xslt";
        public static string FilterWarning = @"../../../Data/NoAbsent.xslt";

        // Production paths
        /*public static string DataPath = @"./Data/Data.xml";
        public static string BackupPath = @"./Data/Backup/Backup";
        public static string FilterDateRangePath = @"./Data/RangeDates.xslt";
        public static string FilterClassIdPath = @"./Data/ClassById.xslt";
        public static string FilterStudentIdPath = @"./Data/StudentById.xslt";
        public static string FilterClassDateRange = @"./Data/ClassdateRange.xslt";
        public static string FilterStudentDateRange = @"./Data/StudentdateRange.xslt";
        public static string FilterTeacherClasses = @"./Data/TeacherReport.xslt";
        public static string FilterTeacherStudent = @"./Data/TeacheRportForStudent.xslt";
        public static string FilterStudentClass = @"./Data/StudentClassDateRange.xslt";
        public static string FilterWarning = @"./Data/NoAbsent.xslt";*/

        public static string UsersPath = "/school/users/user";
        public static string StudentsPath = "/school/students/student";
        public static string TeachersPath = "/school/teachers/teacher";
        public static string TeachersCoursesPath = "/school/teachers/teacher";
        public static string StudentsClassesPath = "/school/students/student";
        public static string AdminsPath = "/school/admins/admin";
        public static string ClassesPath = "/school/classes/class";
        public static string EmailPath = "/school/users/user";
        public static string CoursesPath = "/school/teachers/teacher/courses/course";
        public static string AttendenceRecordpath = @"/ school/attendance-records/attendance-record";
        public static string language = "en-US";
        public static string dateFormate = "Short";

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

        public static void setLanguage(string lang)
        {
            language = lang;
            XMLManagement.UpdateNode("/school/configs", "language", language);
            ChangeLanguage();
        }

        public static void checkLanguage()
        {
            language = XMLManagement.GetNodeValue("/school/configs/language");
            ChangeLanguage();
        }

        public static void ChangeDateFormat(string df)
        {
            if (df == "Short")
            {
                dateFormate = "Short";
                XMLManagement.UpdateNode("/school/configs", "dateFormats", "Short");
            }
            else
            {
                dateFormate = "Long";
                XMLManagement.UpdateNode("/school/configs", "dateFormats", "Long");
            }
        }

        public static void checkDateFormat()
        {
            dateFormate = XMLManagement.GetNodeValue("/school/configs/dateFormats");
        }

        public static DateTimePickerFormat GetDateFormate()
        {
            if (dateFormate == "Short")
            {
                return DateTimePickerFormat.Short;
            }
            else
            {
                return DateTimePickerFormat.Long;
            }
        }

        public static string GetDateFormateString()
        {
            if (dateFormate == "Short")
            {
                return "yyyy-MM-dd";
            }
            else
            {
                return "dddd, dd MMMM yyyy";
            }
        }
    }
}
