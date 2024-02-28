using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Xsl;
using System.Xml;
using Attendance_Management_System.Forms;


namespace Attendance_Management_System.Classes
{
    internal class GenerateReport
    {
        public static string AttendenceReport(string path, Dictionary<string, string> parameters)
        {
            XmlDocument XmlDoc = XMLManagement.ReadAllDocument();
            XslCompiledTransform transform = new XslCompiledTransform();
            transform.Load(path);
            XsltArgumentList args = new XsltArgumentList();
            foreach (var parameter in parameters)
            {
                args.AddParam(parameter.Key, "", parameter.Value);
            }
            using (StringWriter sw = new StringWriter())
            {
                using (XmlTextWriter writer = new XmlTextWriter(sw))
                {
                    transform.Transform(XmlDoc, args, writer);
                }
                string resultXml = sw.ToString();
                if (resultXml == "<records />")
                {
                    MessageBox.Show("No data found.", "Message ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return "";
                }
                return resultXml;
            }
        }
      
    }
}
