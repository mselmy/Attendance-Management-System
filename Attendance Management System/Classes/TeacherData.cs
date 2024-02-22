using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Attendance_Management_System.Classes
{
    internal class TeacherData : User
    {
        // Variables
        private string name;
        private List<string> coursesid;

        // Properties
        public string Name { get { return name; } private set { { name = value; } } }
        public List<string> Coursesid { get { return coursesid; } private set { { coursesid = value; } } }

        // Constructor
        public TeacherData(string email) : base(email)
        {
            Name = XMLManagement.GetNode(Configs.TeachersPath, "@id", base.ID).SelectSingleNode("name").InnerText;
            
            XmlNode teacher = XMLManagement.GetNode(Configs.TeachersCoursesPath, "@id", base.ID);

            XmlNodeList courses = teacher.SelectSingleNode("courses").SelectNodes("course");

            // add id attribute of each class to the list
            coursesid = new List<string>();

            foreach (XmlNode c in courses)
            {
                Coursesid.Add(c.Attributes["id"].Value);
            }
        }
    }
}
