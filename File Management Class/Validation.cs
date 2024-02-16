using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
namespace File_Management_Class
{
    internal class Validation
    {
        public static bool IsLoginValid(string username, string password)
        {
            List<List<string>> userPass = new List<List<string>>();
            userPass = XMLManagement.MultibleNodesToList(@"../../../../Data/Data.xml", "/school/users/user", "email", "password");

            for (int i = 0; i < userPass[0].Count; i++)
            {
                if (userPass[0][i] == username && userPass[1][i] == password)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
