using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
namespace Attendance_Management_System.Classes
{
    internal class Validation
    {
        public static bool IsLoginValid(string username, string password)
        {
            List<List<string>> userPass = new List<List<string>>();
            userPass = XMLManagement.MultibleNodesToList(Configs.UsersPath, "email", "password");

            for (int i = 0; i < userPass[0].Count; i++)
            {
                if (userPass[0][i] == username && userPass[1][i] == password)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool IsEmailValid(string email)
        {
            List<string> emails = new List<string>();
            emails = XMLManagement.NodesToList(Configs.UsersPath, "email");

            for (int i = 0; i < emails.Count; i++)
            {
                if (emails[i] == email)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
