using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Attendance_Management_System.Classes
{
    internal class UpdateData
    {
        public static bool CheckExist(string id, string email, List<string> emails)
        {
            bool emailExists = emails.Contains(email);
            bool emailNotMine = !IsEmailMine(id, email);

            return emailExists && emailNotMine;
        }

        public static bool IsEmailMine(string id, string email)
        {
            XmlDocument doc = XMLManagement.ReadAllDocument();
            XmlNode userNode = doc.SelectSingleNode($"//users/user[id='{id}']");
            string emailfound = userNode.SelectSingleNode("email").InnerText;
       
            if (userNode != null)
            {
                return emailfound == email;
            }

            return false;
        }

        public static void UpdateStudent(string id, string newName, string newEmail, string newPassword, HashSet<string> selectedClasses)
        {
            try
            {
                XmlDocument xmlDoc = XMLManagement.ReadAllDocument();
                XmlNode studentNode = xmlDoc.SelectSingleNode($"//students/student[@id='{id}']");

                studentNode.SelectSingleNode("name").InnerText = newName;

                XmlNode userNode = xmlDoc.SelectSingleNode($"//users/user[id='{id}']");
                if (userNode != null)
                {
                    userNode.SelectSingleNode("email").InnerText = newEmail;
                    userNode.SelectSingleNode("password").InnerText = newPassword;
                }

                XmlNode classesNode = studentNode.SelectSingleNode("classes");
                classesNode.RemoveAll();

                foreach (string classId in selectedClasses)
                {
                    XmlNode newClassNode = xmlDoc.CreateElement("class");
                    XmlAttribute classIdAttribute = xmlDoc.CreateAttribute("id");
                    classIdAttribute.Value = classId;
                    newClassNode.Attributes.Append(classIdAttribute);
                    classesNode.AppendChild(newClassNode);
                }
                xmlDoc.Save(Configs.DataPath);
                MessageBox.Show("Updated successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Failed to update!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void UpdateTeacher(string id, string newName, string newEmail, string newPassword, HashSet<string> selectedClasses)
        {
            try
            {
                XmlDocument xmlDoc = XMLManagement.ReadAllDocument();

                XmlNode teacherNode = xmlDoc.SelectSingleNode($"//teachers/teacher[@id='{id}']");

                teacherNode.SelectSingleNode("name").InnerText = newName;

                XmlNode userNode = xmlDoc.SelectSingleNode($"//users/user[id='{id}']");
                if (userNode != null)
                {
                    userNode.SelectSingleNode("email").InnerText = newEmail;
                    userNode.SelectSingleNode("password").InnerText = newPassword;
                }

                XmlNode classesNode = teacherNode.SelectSingleNode("courses");
                classesNode.RemoveAll();

                foreach (string classId in selectedClasses)
                {
                    XmlNode newClassNode = xmlDoc.CreateElement("course");
                    XmlAttribute classIdAttribute = xmlDoc.CreateAttribute("id");
                    classIdAttribute.Value = classId;
                    newClassNode.Attributes.Append(classIdAttribute);
                    classesNode.AppendChild(newClassNode);
                }

                xmlDoc.Save(Configs.DataPath);
                MessageBox.Show("Updated successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Failed to update!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void UpdateClass(string id, string newClassName, string newTeacherId, HashSet<string> selectedStudents)
        {
            try
            {
                XmlDocument xmlDoc = XMLManagement.ReadAllDocument();

                XmlNode classNode = xmlDoc.SelectSingleNode($"//classes/class[id='{id}']");

                classNode.SelectSingleNode("name").InnerText = newClassName;

                XmlNode teacherNode = classNode.SelectSingleNode("teacher");
                if (teacherNode != null)
                {
                    teacherNode.Attributes["id"].Value = newTeacherId;
                }


                XmlNodeList studentNodes = classNode.SelectNodes("student");
                foreach (XmlNode studentNode in studentNodes)
                {
                    classNode.RemoveChild(studentNode);
                }

                foreach (string studentId in selectedStudents)
                {
                    XmlNode newStudentNode = xmlDoc.CreateElement("student");
                    XmlAttribute studentIdAttribute = xmlDoc.CreateAttribute("id");
                    studentIdAttribute.Value = studentId;
                    newStudentNode.Attributes.Append(studentIdAttribute);
                    classNode.AppendChild(newStudentNode);
                }

                xmlDoc.Save(Configs.DataPath);
                MessageBox.Show("updated succcesfully!", "message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch
            {
                MessageBox.Show("Failed to update!", "message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }


}
