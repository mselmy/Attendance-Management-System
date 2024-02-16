using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using static System.Net.Mime.MediaTypeNames;

namespace File_Management_Class
{
    internal class XMLManagement
    {
        public static XmlDocument ReadAllDocument(string path)
        {
            XmlDocument XmlDoc = new XmlDocument();
            XmlDoc.Load(path);
            return XmlDoc;
        }

        public static List<string> NodesToList(string path, string nodePath, string target)
        {
            List<string> list = new List<string>();
            XmlDocument XmlDoc = ReadAllDocument(path);
            XmlNodeList nodeList = XmlDoc.SelectNodes(nodePath);
            foreach (XmlNode node in nodeList)
            {
                list.Add(node.SelectSingleNode(target).InnerText);
            }
            return list;
        }

        public static List<List<string>> MultibleNodesToList(string path, string nodepath, string target, params string[] targets)
        {
            List<List<string>> list = new List<List<string>>();
            list.Add(NodesToList(path, nodepath, target));
            
            foreach (string t in targets)
            {
                list.Add(NodesToList(path, nodepath, t));
            }
            return list;
        }
    }
}
