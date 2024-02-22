using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Attendance_Management_System.Classes
{
    internal class Handleloadadmin
    {
        public static int GetNumberofClasses()
        {
            List<string> classes = XMLManagement.NodesToList(Configs.ClassesPath  ,"id");
            int numberofClasses = classes.Count;
            return numberofClasses; 
        }
        public static int GetNumberofTeachers()
        {
            int result = 0;
            List<string> users = XMLManagement.GetIdofAllSt_Th(Configs.TeachersPath, "id");
            foreach (string user in users)
            {
                if(IsuserTeacher(user))
                {
                    result++;

                }
            }
            return result;
        }
        public static int GetNumberofStudents()
        {
            int result = 0;
            List<string> users = XMLManagement.GetIdofAllSt_Th(Configs.StudentsPath, "id");
            foreach (string user in users)
            {
                if (IsuserStudent(user))
                {
                    result++;

                }
            }
            return result;
        }
        public static bool IsuserStudent(string check)
        {
            string result = check.Substring(0,2);
            if (result=="ST")
            {

                return true;

            }
            return false;
        }
        public static bool IsuserTeacher(string check)
        {
            string result =check.Substring(0,2);
             if (result == "TE")
            {

                return true;

            }
            return false;
        }
        
        public static void GetAllStudentNeedWarning()
        {
            List<string> classes = XMLManagement.NodesToList(Configs.AttendenceRecordpath, "student");

        }


    }
}
