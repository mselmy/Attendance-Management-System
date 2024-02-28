using System.Xml;
using Attendance_Management_System.Classes.DataClasses;

namespace Attendance_Management_System.Classes
{
    public class DataXMLManagement
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




        public static List<StudentDataXml> GetStudentData()
        {
            XmlDocument XmlDoc = XMLManagement.ReadAllDocument();
            XmlNodeList nodeList = XmlDoc.SelectNodes(Configs.StudentsPath);

            var StudentList = new List<StudentDataXml>();


            foreach (XmlNode Data in nodeList)
            {
                StudentDataXml studentData = new StudentDataXml();
                studentData.studentId = Data.Attributes["id"].Value;
                studentData.name = Data.SelectSingleNode("name").InnerText;

                XmlNodeList classNods = Data.SelectNodes("classes/class");

                var studentClassesList = new List<string>();

                foreach (XmlNode @class in classNods)
                {
                    studentClassesList.Add(@class.Attributes["id"].Value);
                }

                studentData.Classes = studentClassesList;

                StudentList.Add(studentData);

            }
            return StudentList;

        }

        public static List<TeacherDataXml> GetTeacherData()
        {
            XmlDocument XmlDoc = XMLManagement.ReadAllDocument();
            XmlNodeList nodeList = XmlDoc.SelectNodes(Configs.TeachersPath);

            var TeacherList = new List<TeacherDataXml>();


            foreach (XmlNode Data in nodeList)
            {
                TeacherDataXml TeacherData = new TeacherDataXml();
                TeacherData.TeacherId = Data.Attributes["id"].Value;
                TeacherData.Name = Data.SelectSingleNode("name").InnerText;

                XmlNodeList coursesNods = Data.SelectNodes("courses/course");


                var TeacherCourseList = new List<string>();

                foreach (XmlNode course in coursesNods)
                {
                    TeacherCourseList.Add(course.Attributes["id"].Value);
                }

                TeacherData.Teacher_Courses = TeacherCourseList;

                TeacherList.Add(TeacherData);

            }
            return TeacherList;

        }

        public static List<ClassesDataXML> GetClassesData()
        {
            XmlDocument XmlDoc = XMLManagement.ReadAllDocument();
            XmlNodeList nodeList = XmlDoc.SelectNodes(Configs.ClassesPath);

            var ClassesList = new List<ClassesDataXML>();


            foreach (XmlNode Data in nodeList)
            {
                ClassesDataXML ClassesData = new ClassesDataXML();
                ClassesData.ID = Data.SelectSingleNode("id").InnerText;
                ClassesData.Name = Data.SelectSingleNode("name").InnerText;
                ClassesList.Add(ClassesData);

            }
            return ClassesList;

        }

        public static void UpdatePassword(string email, string newPassword)
        {
            XmlDocument xmlDoc = XMLManagement.ReadAllDocument();
            XmlNode? userNode = xmlDoc.SelectSingleNode($"{Configs.UsersPath}[email='{email}']");
            if (userNode != null)
            {
                userNode.SelectSingleNode("password").InnerText = newPassword;
                xmlDoc.Save(Configs.DataPath);
            }
        }

    }
}