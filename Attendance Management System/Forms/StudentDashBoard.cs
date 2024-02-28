using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Xml;
using System.Threading.Tasks;
using System.Windows.Forms;
using Attendance_Management_System;
using Attendance_Management_System.Classes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Globalization;

namespace Attendance_Management_System.Forms
{
    public partial class StudentDashBoard : Form
    {
        System.Timers.Timer timer;
        Session session;
        public StudentDashBoard(Session _session)
        {
            InitializeComponent();
            session = _session;
            mainPanel.Visible = false;
            timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += labeltimenow_Click;
            timer.Start();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            mainPanel.Visible = false;
        }

        private void lodoutpic_Click(object sender, EventArgs e)
        {
            logOut();
        }



        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void StudentDashBoard2_Load(object sender, EventArgs e)
        {

            FillPage();
        }



        private void ExitPic_Click(object sender, EventArgs e)
        {
            Exist();
        }

        public void Exist()
        {
            Close();
        }

        public void logOut()
        {
            this.Hide();
            Login loginForm = new Login();
            loginForm.Show();
            session.Logout();
        }

        private void buttonclear_Click(object sender, EventArgs e)
        {
            viewAttendance();
            comboBox1.SelectedItem = null;
        }

        private void Minimize(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Maximize(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }


        private void viewAttendance()
        {
            dataGridView2.Rows.Clear();

            var AttendanceRecordList = StudentXMLManagement.GetStudentAttendanceRecords();

            foreach (var AttendanceRecord in AttendanceRecordList)
            {
                foreach (var student in AttendanceRecord.Students)
                {
                    if (student.StudentId == session.CurrentUser.ID)
                        dataGridView2.Rows.Add(AttendanceRecord.Date, AttendanceRecord.ClassId, student.Status);
                }
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();

            var AttendanceRecordList = StudentXMLManagement.GetStudentAttendanceRecords();

            foreach (var AttendanceRecord in AttendanceRecordList)
            {
                if (comboBox1.Text == AttendanceRecord.ClassId || comboBox1.Text == "")
                {
                    foreach (var student in AttendanceRecord.Students)
                    {
                        if (student.StudentId == session.CurrentUser.ID)
                            dataGridView2.Rows.Add(AttendanceRecord.Date, AttendanceRecord.ClassId, student.Status);
                    }
                }
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();

            var AttendanceRecordList = StudentXMLManagement.GetStudentAttendanceRecords();

            foreach (var AttendanceRecord in AttendanceRecordList)
            {
                if (dateTimePicker1.Text == AttendanceRecord.Date)
                {
                    foreach (var student in AttendanceRecord.Students)
                    {
                        if (student.StudentId == session.CurrentUser.ID)
                            dataGridView2.Rows.Add(AttendanceRecord.Date, AttendanceRecord.ClassId, student.Status);
                    }
                }
            }
        }

        private void labeltimenow_Click(object sender, EventArgs e)
        {

            if (InvokeRequired)
            {
                Invoke((MethodInvoker)delegate { labeltimenow.Text = DateTime.Now.ToString("h:mm:ss tt"); });
            }
            else
            {
                { labeltimenow.Text = DateTime.Now.ToString("h:mm:ss tt"); }
            }
        }

        private void labeldatetoday_Click(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void labelusername_Click(object sender, EventArgs e)
        {

        }

        private void FillPage()
        {
            labeldatetoday.Text = DateTime.Now.ToString("yyyy-MM-dd");

            StudentData studentData = (StudentData)session.CurrentUser;
            labelusername.Text = studentData.Name;

            comboBox1.DataSource = studentData.ClassesIds;
            comboBox1.SelectedItem = null;

            viewAttendance();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("ar-EG");
            Thread.CurrentThread.CurrentCulture = new CultureInfo("ar-EG");
            Controls.Clear();
            InitializeComponent();
            FillPage();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            Controls.Clear();
            InitializeComponent();

            FillPage();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            mainPanel.Visible = true;
            StudentReport studentReport = new StudentReport(session);
            mainPanel.Controls.Add(studentReport);
            mainPanel.Size = new Size(1150, 700);
        }
    }
}
