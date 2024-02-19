using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendance_Management_System.Classes
{
    public class Session
    {
        // Variables
        private User? currentUser = null;

        // Properties
        internal User? CurrentUser { get { return currentUser; } private set { { currentUser = value; } } }

        // Constructor
        public Session(string email)
        {
            string role = XMLManagement.GetNode(Configs.UsersPath, "email", email).SelectSingleNode("role").InnerText;
            if (role == "Admin")
            {
                CurrentUser = new AdminData(email);
            }
            else if (role == "Teacher")
            {
                CurrentUser = new TeacherData(email);
            }
            else if (role == "Student")
            {
                //CurrentUser = new StudentData(email);
            }
        }

        // Methods
        public void Logout()
        {
            CurrentUser = null;
        }
    }
}
