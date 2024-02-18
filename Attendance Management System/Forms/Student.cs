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

namespace File_Management_Class.Forms
{
    public partial class Student : Form
    {
        System.Timers.Timer timer;
        public Student()
        {
            InitializeComponent();
            timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += label_Time_Click;
            timer.Start();


            // LoadDataFromXml();
        }
     



        private void Student_Load(object sender, EventArgs e)
        { 
            label_date.Text = DateTime.Now.ToString("yyyy-MM-dd");
           
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
    }
}
