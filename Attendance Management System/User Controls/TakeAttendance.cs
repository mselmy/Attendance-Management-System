using Attendance_Management_System.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Attendance_Management_System.Forms
{
    public partial class TakeAttendance : UserControl
    {
        Session? session;
        XmlNode teacher;
        XmlNode teacherCourses;
        XmlNode courses;
        string teacherXPath;
        List<string> studentIds = new List<string>();
        List<XmlNode> students = new List<XmlNode>();

        public TakeAttendance(Session _session)
        {
            InitializeComponent();
            session = _session;
            teacherXPath = "/school/teachers/teacher[@id='" + session.CurrentUser.ID + "']";
            teacher = XMLManagement.GetNode(teacherXPath);
            teacherCourses = teacher.SelectSingleNode("courses");
            courses = XMLManagement.GetNode("/school/classes");
            labelErrorMessage.Visible = false;
            //dataGridView1.Columns["status"].Visible = false;
            dateTimePicker.Format = Configs.GetDateFormate();

        }

        private void TakeAttendance_Load(object sender, EventArgs e)
        {
            List<string> courseIds = new List<string>();
            List<string> courseNames = new List<string>();

            foreach (XmlNode course in teacherCourses.ChildNodes)
            {
                courseIds.Add(course.Attributes["id"].Value);
            }

            foreach (string courseId in courseIds)
            {
                XmlNode course = courses.SelectSingleNode("class[id='" + courseId + "']");
                courseNames.Add(course.SelectSingleNode("name").InnerText + ", " + courseId);
            }
            CourseComboBox.DataSource = courseNames;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CourseComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            showAttendance();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void showAttendance()
        {
            dataGridView1.Rows.Clear();
            studentIds.Clear();
            students.Clear();
            string courseId = CourseComboBox.SelectedValue.ToString().Split(", ")[1];
            XmlNode course = courses.SelectSingleNode("class[id='" + courseId + "']");
            List<string> attendanceStatus = new List<string>();
            XmlNode? attendanceRecord = AttendanceManager.isAttendanceTaken(courseId, date: dateTimePicker.Value);

            if (attendanceRecord != null)
            {
                labelErrorMessage.Visible = true;

                foreach (XmlNode student in course.SelectNodes("student"))
                {
                    studentIds.Add(student.Attributes["id"].Value);
                    students.Add(XMLManagement.GetNode("/school/students/student[@id='" + student.Attributes["id"].Value + "']"));
                    attendanceStatus.Add(attendanceRecord.SelectSingleNode("student[@id='" + student.Attributes["id"].Value + "']/status").InnerText);
                }

                for (int i = 0; i < students.Count; i++)
                {
                    dataGridView1.Rows.Add(students[i].Attributes["id"].Value, students[i].SelectSingleNode("name").InnerText, attendanceStatus[i], attendanceStatus[i]);
                }
            }
            else
            {
                labelErrorMessage.Visible = false;

                foreach (XmlNode student in course.SelectNodes("student"))
                {
                    studentIds.Add(student.Attributes["id"].Value);
                    students.Add(XMLManagement.GetNode("/school/students/student[@id='" + student.Attributes["id"].Value + "']"));
                }

                foreach (XmlNode student in students)
                {
                    dataGridView1.Rows.Add(student.Attributes["id"].Value, student.SelectSingleNode("name").InnerText, "Absent");
                }
            }
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            showAttendance();
        }

        private void SaveAttendanceButton_Click(object sender, EventArgs e)
        {
            XmlDocument xmlDoc = XMLManagement.ReadAllDocument();
            string courseId = CourseComboBox.SelectedValue.ToString().Split(", ")[1];
            XmlNode? attendanceRecord = AttendanceManager.isAttendanceTaken(courseId, date: dateTimePicker.Value);

            if (attendanceRecord != null)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    XmlNode? student = xmlDoc.SelectSingleNode("/school/attendance-records/attendance-record[date='"+ dateTimePicker.Value.ToString("yyyy-MM-dd") + "' and class[id='"+ courseId + "']]/student[@id='" + row.Cells[0].Value.ToString() + "']");
                    student.SelectSingleNode("status").InnerText = row.Cells[2].Value.ToString();
                }
                xmlDoc.Save(Configs.DataPath);
                MessageBox.Show("Attendance Updated Successfully");
            }
            else
            {
                List<string> status = new List<string>();
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    status.Add(row.Cells[2].Value.ToString());
                }
                AttendanceManager.TakeAttendance(courseId, dateTimePicker.Value, studentIds, status);
                MessageBox.Show("Attendance Taken Successfully");
            }
            showAttendance();
        }
    }
}