using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendance_Management_System.Classes
{
    internal class AdminData : User
    {
        // Variables
        private string name;

        // Properties
        public string Name { get { return name; } private set { { name = value; } } }

        // Constructor
        public AdminData(string email) : base(email)
        {
            Name = XMLManagement.GetNode(Configs.AdminsPath, "@id", base.ID).SelectSingleNode("name").InnerText;
        }
    }
}
