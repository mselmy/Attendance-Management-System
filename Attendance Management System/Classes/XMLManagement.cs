using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using static System.Net.Mime.MediaTypeNames;

namespace Attendance_Management_System.Classes
{
    internal class XMLManagement
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
    }
}