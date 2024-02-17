using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Attendance_Management_System.Classes
{
    internal class User
    {
        // Variables
        private string id;
        private string email;
        private string password;
        private string role;

        // Properties
        public string ID { get { return id; } private set { { id = value; } } }
        public string Email { get { return email; } private set { { email = value; } } }
        public string Password { get { return password; } private set { { password = value; } } }
        public string Role { get { return role; } private set { { role = value; } } }

        // Constructor
        public User(string email)
        {
            XmlNode? user = XMLManagement.GetNode(Configs.UsersPath, "email", email);

            if (user != null)
            {
                ID = user.SelectSingleNode("id").InnerText;
                Email = user.SelectSingleNode("email").InnerText;
                Password = user.SelectSingleNode("password").InnerText;
                Role = user.SelectSingleNode("role").InnerText;
            }
            else {}
        }
    }
}
