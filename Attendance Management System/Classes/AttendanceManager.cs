using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Attendance_Management_System.Classes
{
    internal class AttendanceManager
    {
        public static XmlNode? isAttendanceTaken(string courseId, DateTime date)
        {
            string xpath = "/school/attendance-records/attendance-record[date='"+ date.ToString("yyyy-MM-dd") + "']/class[id='"+ courseId +"']";
            XmlNode? course = XMLManagement.GetNode(xpath);
            if (course != null)
            {
                return course.ParentNode;
            }
            return null;
        }

        public static bool TakeAttendance(string courseId, DateTime date, List<string> studentIds, List<string> status)
        {
            if (isAttendanceTaken(courseId, date) != null)
            {
                return false;
            }
            else
            {
                XmlDocument xmlDoc = XMLManagement.ReadAllDocument();
                XmlNode? root = xmlDoc.DocumentElement;
                XmlNode? attendanceRecords = root.SelectSingleNode("attendance-records");
                XmlNode attendanceRecord = xmlDoc.CreateElement("attendance-record");
                XmlNode dateNode = xmlDoc.CreateElement("date");
                dateNode.InnerText = date.ToString("yyyy-MM-dd");
                XmlNode classNode = xmlDoc.CreateElement("class");
                classNode.InnerXml = "<id>" + courseId + "</id>";
                attendanceRecord.AppendChild(dateNode);
                attendanceRecord.AppendChild(classNode);
                for (int i = 0; i < studentIds.Count; i++)
                {
                    XmlNode studentNode = xmlDoc.CreateElement("student");
                    studentNode.Attributes.Append(xmlDoc.CreateAttribute("id")).Value = studentIds[i];
                    studentNode.InnerXml = "<status>" + status[i] + "</status>";
                    attendanceRecord.AppendChild(studentNode);
                }
                attendanceRecords.AppendChild(attendanceRecord);
                xmlDoc.Save(Configs.DataPath);
                return true;
            }
        }

        public static bool UpdateAttendance(string courseId, DateTime date, List<string> studentIds, List<string> status)
        {
            XmlNode? attendanceRecord = isAttendanceTaken(courseId, date);
            if (attendanceRecord != null)
            {
                for (int i = 0; i < studentIds.Count; i++)
                {
                    XmlNode student = attendanceRecord.SelectSingleNode("student[@id='" + studentIds[i] + "']");
                    student.SelectSingleNode("status").InnerText = status[i];
                }
                return true;
            }
            return false;
        }
    }
}
