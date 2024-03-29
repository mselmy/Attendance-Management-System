﻿using Attendance_Management_System.Classes;
using Attendance_Management_System.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using System.Xml;

namespace Attendance_Management_System
{
    public partial class Admin : Form
    {
        Session session;
        AdminData? user;

        public Admin()
        {
            InitializeComponent();
        }

        public Admin(Session _session)
        {
            Configs.ChangeLanguage();
            session = _session;
            user = _session.CurrentUser as AdminData;
            InitializeComponent();
            SearchForAdmin searchForAdmin = new SearchForAdmin();
            panelView.Controls.Add(searchForAdmin);
        }
        private void Admin_Load(object sender, EventArgs e)
        {
            admindashboard1.Visible = true;
            addUser2.Visible = false;
            attendencdeReport1.Visible = false;
            edit1.Visible = false;
            panelView.Visible = false;
        }

        private void admindashboard1_VisibleChanged(object sender, EventArgs e)
        {
            if (admindashboard1.Visible)
            {
                admindashboard1.NoTeacherButton.Text = Handleloadadmin.GetNumberofTeachers() + " Teachers";
                admindashboard1.NoClassButton.Text = Handleloadadmin.GetNumberofClasses() + " Classes";
                admindashboard1.NostudentsButton.Text = Handleloadadmin.GetNumberofStudents() + " Students";
                admindashboard1.GenenrateWarningTable();
            }

        }

        private void DashboardButton_Click(object sender, EventArgs e)
        {
            admindashboard1.Visible = true;
            addUser2.Visible = false;
            attendencdeReport1.Visible = false;
            edit1.Visible = false;
            panelView.Visible = false;

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            admindashboard1.Visible = false;
            addUser2.Visible = true;
            attendencdeReport1.Visible = false;
            edit1.Visible = false;
            panelView.Visible = false;

        }
        private void attendenceReportButton_Click(object sender, EventArgs e)
        {
            admindashboard1.Visible = false;
            addUser2.Visible = false;
            attendencdeReport1.Visible = true;
            edit1.Visible = false;
            panelView.Visible = false;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            XMLManagement.SaveXMLFileWindow();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            session.Logout();
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        public void refresh()
        {
            Controls.Clear();
            InitializeComponent();
            admindashboard1.Visible = true;
            addUser2.Visible = false;
            attendencdeReport1.Visible = false;
            edit1.Visible = false;
            panelView.Visible = false;
            if (admindashboard1.Visible)
            {
                admindashboard1.NoTeacherButton.Text = Handleloadadmin.GetNumberofTeachers() + " Teachers";
                admindashboard1.NoClassButton.Text = Handleloadadmin.GetNumberofClasses() + " Classes";
                admindashboard1.NostudentsButton.Text = Handleloadadmin.GetNumberofStudents() + " Students";
                admindashboard1.GenenrateWarningTable();
            }
            SearchForAdmin searchForAdmin = new SearchForAdmin();
            panelView.Controls.Add(searchForAdmin);
        }

        private void SettingButton_Click(object sender, EventArgs e)
        {
            Setting setting = new Setting(refresh);
            setting.Show();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            admindashboard1.Visible = false;
            addUser2.Visible = false;
            attendencdeReport1.Visible = false;
            panelView.Visible = false;
            edit1.Visible = true;
            

        }

        private void edit1_Load(object sender, EventArgs e)
        {

        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            XMLManagement.LoadXMLFileWindow();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            admindashboard1.Visible = false;
            addUser2.Visible = false;
            attendencdeReport1.Visible = false;
            edit1.Visible = false;
            panelView.Visible = true;
        }
    }
}
