using System;
using System.Collections.Generic;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

        public static bool IsnameValid(string name)
        {
            string pattern = @"^[a-zA-Z]+(?:\s+[a-zA-Z]+)*$";
            Regex namereg =new Regex(pattern);
            Match match= namereg.Match(name);
            bool result = name.Trim().Length < 20;
            if (match.Success && result)
            {
                return true;
            }
            return false;
        }
        public static bool IsclassValid(string className,List<string> Validvalues)
        {
            bool flag = false;
            foreach(string value in Validvalues)
            {
                if (className == value)
                {
                    flag= true;
                }
            }
            return flag;
        }
        public static bool IsIdValid(String requied,string id) 
        {
            string pattern = @"^"+requied+@"-\d+$";
            Regex idreg = new Regex(pattern);
            Match match = idreg.Match(id);
            if(match.Success)
            {
                return true;
            }
            return false;
        
        }
        public static bool IsIdUnique(string id,List<string> idValues)
        {
            bool flag = false;
            foreach (string value in idValues)
            {
                if (id == value)
                {
                    flag = true;
                }
            }
            return flag;

        }

    }
}
