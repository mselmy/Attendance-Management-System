using System.Xml;

namespace Attendance_Management_System.Classes
{
    public class StudentXMLManagement
    {
        public static List<AttendanceRecord> GetStudentAttendanceRecords()
        {
            XmlDocument XmlDoc = XMLManagement.ReadAllDocument();
            XmlNodeList nodeList = XmlDoc.SelectNodes(Configs.AttendenceRecordpath);

            var AttendanceRecordList = new List<AttendanceRecord>();

            foreach (XmlNode Data in nodeList)
            {
                AttendanceRecord attendanceRecord = new AttendanceRecord();
                attendanceRecord.Date = Data.SelectSingleNode("date").InnerText;
                attendanceRecord.ClassId = Data.SelectSingleNode("class/id").InnerText;

                XmlNodeList studentsNods = Data.SelectNodes("student");

                var studentAttendanceList = new List<StudentAttendance>();

                foreach (XmlNode student in studentsNods)
                {
                    StudentAttendance studentAttendance = new StudentAttendance();

                    studentAttendance.StudentId = student.Attributes["id"].Value;
                    studentAttendance.Status = student.SelectSingleNode("status").InnerText;

                    studentAttendanceList.Add(studentAttendance);
                }
                attendanceRecord.Students = studentAttendanceList;

                AttendanceRecordList.Add(attendanceRecord);
            }
            return AttendanceRecordList;
        }
    }
}
