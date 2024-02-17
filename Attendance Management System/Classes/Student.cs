using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Attendance_Management_System.Classes
{
    internal class Student : User
    {
        // Variables
        private string name;
        private List<string> classesid;

        // Properties
        public string Name { get { return name; } private set { { name = value; } } }
        public List<string> Classesid { get { return classesid; } private set { { classesid = value; } } }

        // Constructor
        public Student(string email) : base(email)
        {
            Name = XMLManagement.GetNode(Configs.StudentsPath, "@id", base.ID).SelectSingleNode("name").InnerText;

            XmlNode student = XMLManagement.GetNode(Configs.StudentsClassesPath, "@id", base.ID);

            XmlNodeList classes = student.SelectSingleNode("classes").SelectNodes("class");
            
            // add id attribute of each class to the list
            classesid = new List<string>();

            foreach (XmlNode c in classes)
            {
                Classesid.Add(c.Attributes["id"].Value);
            }
        }
    }
}
