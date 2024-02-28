using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Xsl;
using static System.Net.Mime.MediaTypeNames;

namespace Attendance_Management_System.Classes
{

    public class XMLManagement
    {
        public static XmlDocument ReadAllDocument()
        {
            XmlDocument XmlDoc = new XmlDocument();
            XmlDoc.Load(Configs.DataPath);
            return XmlDoc;
        }

        public static List<string> NodesToList(string nodePath, string target)
        {
            List<string> list = new List<string>();
            XmlDocument XmlDoc = ReadAllDocument();
            XmlNodeList nodeList = XmlDoc.SelectNodes(nodePath);
            foreach (XmlNode node in nodeList)
            {
                list.Add(node.SelectSingleNode(target).InnerText);
            }
            return list;
        }

        /*public static List<string> AttributesToList(string nodePath, string target)
        {
            List<string> list = new List<string>();
            XmlDocument XmlDoc = ReadAllDocument();
            XmlNodeList nodeList = XmlDoc.SelectNodes(nodePath);
            list.AddRange(from XmlNode node in nodeList select node.Attributes[target].Value);
            return list;
        }*/
        /*public static List<string> GetSingleNodeAttributes(string nodePath, string target)
        {
            List<string> list = new List<string>();
            XmlDocument XmlDoc = ReadAllDocument();
            XmlNode node = XmlDoc.SelectSingleNode(nodePath);
            list.Add(node.Attributes[target].Value);
            return list;
        }*/

        public static List<List<string>> MultibleNodesToList(string nodepath, string target, params string[] targets)
        {
            List<List<string>> list = new List<List<string>>();
            list.Add(NodesToList(nodepath, target));

            foreach (string t in targets)
            {
                list.Add(NodesToList(nodepath, t));
            }
            return list;
        }

        public static XmlNode? GetNode(string nodePath, string target, string value)
        {
            XmlDocument XmlDoc = ReadAllDocument();
            return GetNode(XmlDoc, nodePath, target, value);
        }

        public static XmlNode? GetNode(XmlDocument XmlDoc, string nodePath, string target, string value)
        {
            string xPath = string.Format("{0}[{1}='{2}']", nodePath, target, value);
            XmlNode? userNode = XmlDoc.SelectSingleNode(xPath);
            return userNode;
        }

        public static string GetNodeValue(string xPath)
        {
            XmlDocument XmlDoc = ReadAllDocument();
            XmlNode? userNode = XmlDoc.SelectSingleNode(xPath);
            return userNode?.InnerText ?? "";
        }

        public static bool AddnewStudent(string name, string password,string email, string id, List<string> classname)
        {
            try
            {
                XmlDocument XmlDoc = ReadAllDocument();
                XmlNode target = XmlDoc.SelectSingleNode("/school/students");
                XmlNode targetuser = XmlDoc.SelectSingleNode("/school/users");

                XmlNode newstudent = XmlDoc.CreateElement("student");
                XmlNode namenewstudent = XmlDoc.CreateElement("name");
                namenewstudent.InnerText = name;
                newstudent.AppendChild(namenewstudent);

                XmlAttribute idAttribute = XmlDoc.CreateAttribute("id");
                idAttribute.Value = id;
                newstudent.Attributes.Append(idAttribute);

                XmlNode classesnewstudent = XmlDoc.CreateElement("classes");
                foreach (string item in classname)
                {
                    XmlNode classnewstudent = XmlDoc.CreateElement("class");
                    XmlAttribute idclassAttribute = XmlDoc.CreateAttribute("id");
                    idclassAttribute.Value = item;
                    classnewstudent.Attributes.Append(idclassAttribute);
                    classesnewstudent.AppendChild(classnewstudent);

                }
                newstudent.AppendChild(classesnewstudent);


               
                target.AppendChild(newstudent);



                XmlNode newuser = XmlDoc.CreateElement("user");

                XmlNode idnewuser = XmlDoc.CreateElement("id");
                idnewuser.InnerText = id;
                newuser.AppendChild(idnewuser);

                XmlNode emailnewuser = XmlDoc.CreateElement("email");
                emailnewuser.InnerText = email;
                newuser.AppendChild(emailnewuser);

                XmlNode passnewstudent = XmlDoc.CreateElement("password");
                passnewstudent.InnerText = password;
                newuser.AppendChild(passnewstudent);

                XmlNode rolenewstudent = XmlDoc.CreateElement("role");
                rolenewstudent.InnerText = "Student";
                newuser.AppendChild(rolenewstudent);

                targetuser.AppendChild(newuser);


                XmlDoc.Save(Configs.DataPath);
                return true;

            }
            catch
            {
                return false;
            }


        }
        public static bool AddnewTeacher(string name, string password,string email, string id, List<string> classname)
        {
            try
            {
                XmlDocument XmlDoc = ReadAllDocument();
                XmlNode target = XmlDoc.SelectSingleNode("/school/teachers");
                XmlNode targetuser = XmlDoc.SelectSingleNode("/school/users");


                XmlNode newteacher = XmlDoc.CreateElement("teacher");
                XmlAttribute idAttribute = XmlDoc.CreateAttribute("id");
                idAttribute.Value = id;
                newteacher.Attributes.Append(idAttribute);

                XmlNode namenewteacher = XmlDoc.CreateElement("name");
                namenewteacher.InnerText = name;
                newteacher.AppendChild(namenewteacher);

                XmlNode classesnewteacher = XmlDoc.CreateElement("courses");

                foreach (string item in classname)
                {
                    XmlNode classnewteacher = XmlDoc.CreateElement("course");
                    XmlAttribute idclassAttribute = XmlDoc.CreateAttribute("id");
                    idclassAttribute.Value = item;
                    classnewteacher.Attributes.Append(idclassAttribute);
                    classesnewteacher.AppendChild(classnewteacher);
                }
                newteacher.AppendChild(classesnewteacher);
                target.AppendChild(newteacher);
                XmlNode newuser = XmlDoc.CreateElement("user");

                XmlNode idnewuser = XmlDoc.CreateElement("id");
                idnewuser.InnerText = id;
                newuser.AppendChild(idnewuser);

                XmlNode emailnewuser = XmlDoc.CreateElement("email");
                emailnewuser.InnerText = email;
                newuser.AppendChild(emailnewuser);

                XmlNode passnewuser = XmlDoc.CreateElement("password");
                passnewuser.InnerText = password;
                newuser.AppendChild(passnewuser);

                XmlNode rolenewuser = XmlDoc.CreateElement("role");
                rolenewuser.InnerText = "Teacher";
                newuser.AppendChild(rolenewuser);

                targetuser.AppendChild(newuser);

                XmlDoc.Save(Configs.DataPath);
                return true;

            }
            catch
            {
                return false;
            }


        }
        public static bool AddnewClass(string name, string id, string teacherid, List<string> students)
        {
            try
            {
                XmlDocument XmlDoc = ReadAllDocument();
                XmlNode target = XmlDoc.SelectSingleNode("/school/classes");

                XmlNode newclass = XmlDoc.CreateElement("class");
                XmlNode namenewclass = XmlDoc.CreateElement("name");
                namenewclass.InnerText = name;
                newclass.AppendChild(namenewclass);



                XmlNode newclassid = XmlDoc.CreateElement("id");
                newclassid.InnerText = id;
                newclass.AppendChild(newclassid);


                XmlNode newteacher = XmlDoc.CreateElement("teacher");
                XmlAttribute idAttribute = XmlDoc.CreateAttribute("id");
                idAttribute.Value = teacherid;
                newteacher.Attributes.Append(idAttribute);
                newclass.AppendChild(newteacher);

                foreach (string item in students)
                {
                    XmlNode classesnewstudent = XmlDoc.CreateElement("student");
                    XmlAttribute idAttributestudent = XmlDoc.CreateAttribute("id");
                    idAttributestudent.Value = item;
                    classesnewstudent.Attributes.Append(idAttributestudent);
                    newclass.AppendChild(classesnewstudent);

                }
                target.AppendChild(newclass);
                XmlDoc.Save(Configs.DataPath);
                return true;

            }
            catch
            {
                return false;
            }


        }
        public static List<string> GetIdofAllSt_Th(string nodePath, string target)
        {
            List<string> list = new List<string>();
            XmlDocument XmlDoc = ReadAllDocument();
            XmlNodeList nodeList = XmlDoc.SelectNodes(nodePath);
            foreach (XmlNode node in nodeList)
            {
                XmlAttribute idAttribute = node.Attributes["id"];
                string idValue = idAttribute.Value;
                list.Add(idValue);
            }
            return list;
        }
        public static List<string> GetClassesForTeacher(string nodePath, string targetTeacherId)
        {
            List<string> classIds = new List<string>();
            XmlDocument xmlDoc = ReadAllDocument();

            string xPathExpression = $"{nodePath}[@id='{targetTeacherId}']/courses/course/@id";

            XmlNodeList nodeList = xmlDoc.SelectNodes(xPathExpression);

            foreach (XmlNode node in nodeList)
            {
                classIds.Add(node.Value);
            }

            return classIds;
        }
        public static HashSet<string> GetStudentsForTeacher(List<string> TargetClasses)
        {
            HashSet<string> studentIds = new HashSet<string>(); 
            XmlDocument xmlDoc = ReadAllDocument();

            string xPathExpression;

            foreach (string classId in TargetClasses)
            {
                xPathExpression = $"school/classes/class[id='{classId}']/student/@id";
                XmlNodeList nodeList = xmlDoc.SelectNodes(xPathExpression);
                foreach (XmlNode node in nodeList)
                {
                    studentIds.Add(node.Value);
                }
            }

            return studentIds;
        }
        public static HashSet<string> GetClassForStudent(string Targetstudent)
        {
            HashSet<string> classIds = new HashSet<string>();
            XmlDocument xmlDoc = ReadAllDocument();

            string xPathExpression;

                xPathExpression = $"school/students/student[@id='{Targetstudent}']/classes/class/@id";
                XmlNodeList nodeList = xmlDoc.SelectNodes(xPathExpression);
                foreach (XmlNode node in nodeList)
                {
                    classIds.Add(node.Value);
                }
          
            return classIds;
        }


        public static XmlNode? GetNode(string xPath)
        {
            XmlDocument XmlDoc = ReadAllDocument();
            XmlNode? userNode = XmlDoc.SelectSingleNode(xPath);
            return userNode;
        }

        public static void UpdateNode(string nodePath, string target, string value,string updatedTarger, string newValue)
        {
            XmlDocument XmlDoc = ReadAllDocument();
            XmlNode? node = GetNode(XmlDoc, nodePath, target, value);
            if (node != null)
            {
                node.SelectSingleNode(updatedTarger).InnerText = newValue;
                XmlDoc.Save(Configs.DataPath);
            }
        }

        public static void UpdateNode(string ParentXPath, string Targer, string newValue)
        {
            XmlDocument XmlDoc = ReadAllDocument();
            XmlNode? node = XmlDoc.SelectSingleNode(ParentXPath);
            if (node != null)
            {
                node.SelectSingleNode(Targer).InnerText = newValue;
                XmlDoc.Save(Configs.DataPath);
            }
        }

        public static void AddNode(string parentNodePath, XmlNode newNode)
        {
            XmlDocument XmlDoc = ReadAllDocument();
            XmlNode? node = XmlDoc.SelectSingleNode(parentNodePath);
            if (node != null)
            {
                node.AppendChild(newNode);
                XmlDoc.Save(Configs.DataPath);
            }
        }

        public static void CreateNode(string parentNodePath, string nodeName, string[] targets, string[] values)
        {
            XmlDocument XmlDoc = ReadAllDocument();
            XmlNode? node = XmlDoc.SelectSingleNode(parentNodePath);
            if (node != null)
            {
                XmlNode newNode = XmlDoc.CreateElement(nodeName);
                for (int i = 0; i < targets.Length; i++)
                {
                    XmlNode newChild = XmlDoc.CreateElement(targets[i]);
                    newChild.InnerText = values[i];
                    newNode.AppendChild(newChild);
                }
                node.AppendChild(newNode);
                XmlDoc.Save(Configs.DataPath);
            }
        }

        public static void DeleteNode(string nodePath, string target, string value)
        {
            XmlDocument XmlDoc = ReadAllDocument();
            XmlNode? node = GetNode(XmlDoc, nodePath, target, value);
            if (node != null)
            {
                node.ParentNode?.RemoveChild(node);
                XmlDoc.Save(Configs.DataPath);
            }
        }

        public static bool SaveXMLFile(string path)
        {
            try
            {
                XmlDocument XmlDoc = ReadAllDocument();
                XmlDoc.Save(path);
            }
            catch (Exception)
            {
                return false;
                throw;
            }
            return true;
        }

        public static void SaveXMLFileWindow()
        {
            SaveFileDialog saveFi1eDialog = new SaveFileDialog();
            saveFi1eDialog.Filter = "XML Files (*.xml)|*.xml";
            saveFi1eDialog.RestoreDirectory = true;
            if (saveFi1eDialog.ShowDialog() == DialogResult.OK)
            {
                string path = saveFi1eDialog.FileName;
                if (XMLManagement.SaveXMLFile(path))
                {
                    MessageBox.Show("File Saved Successfully");
                }
                else
                {
                    MessageBox.Show("File Not Saved");
                }
            }
        }








}
}
