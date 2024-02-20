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

namespace File_Management_Class.Forms
{
    public partial class StudentDashboard : Form
    {
        System.Timers.Timer timer;
        Session session;
        public StudentDashboard(Session _session)
        {
            InitializeComponent();
            timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += label_Time_Click;
            timer.Start();
            session = _session;

            // LoadDataFromXml();
        }


        private void Student_Load(object sender, EventArgs e)
        {
            label_date.Text = DateTime.Now.ToString("yyyy-MM-dd");

            StudentData studentData = (StudentData)session.CurrentUser;
            label_username.Text = studentData.Name;

            viewAttendance();

            comboBox1.DataSource = studentData.ClassesIds;

        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        /* private void Minimize(object sender, EventArgs e)
         {
             WindowState = FormWindowState.Minimized;
         }*/

        private void Maximize(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Exist();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_2(object sender, EventArgs e)
        {
            logOut();
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
        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {


        }

        private void label_Time_Click(object sender, EventArgs e)
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)delegate { label_Time.Text = DateTime.Now.ToString("h:mm:ss tt"); });
            }
            else
            {
                { label_Time.Text = DateTime.Now.ToString("h:mm:ss tt"); }
            }

        }

        private void label_username_Click(object sender, EventArgs e)
        {


        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            var AttendanceRecordList = StudentXMLManagement.GetStudentAttendanceRecords();

            foreach (var AttendanceRecord in AttendanceRecordList)
            {
                if (dateTimePicker1.Text == AttendanceRecord.Date)
                {
                    foreach (var student in AttendanceRecord.Students)
                    {
                        if (student.StudentId == session.CurrentUser.ID)
                            dataGridView1.Rows.Add(AttendanceRecord.Date, AttendanceRecord.ClassId, student.Status);
                    }
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            var AttendanceRecordList = StudentXMLManagement.GetStudentAttendanceRecords();

            foreach (var AttendanceRecord in AttendanceRecordList)
            {
                if (comboBox1.Text == AttendanceRecord.ClassId || comboBox1.Text == "")
                {
                    foreach (var student in AttendanceRecord.Students)
                    {
                        if (student.StudentId == session.CurrentUser.ID)
                            dataGridView1.Rows.Add(AttendanceRecord.Date, AttendanceRecord.ClassId, student.Status);
                    }
                }
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            viewAttendance();
            comboBox1.SelectedItem = null;
        }

        private void viewAttendance()
        {
            dataGridView1.Rows.Clear();

            var AttendanceRecordList = StudentXMLManagement.GetStudentAttendanceRecords();

            foreach (var AttendanceRecord in AttendanceRecordList)
            {
                foreach (var student in AttendanceRecord.Students)
                {
                    if (student.StudentId == session.CurrentUser.ID)
                        dataGridView1.Rows.Add(AttendanceRecord.Date, AttendanceRecord.ClassId, student.Status);
                }
            }

        }

        private void viewAttendanceWithFilter()
        {

        }

    }
}
