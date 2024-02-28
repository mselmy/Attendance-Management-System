using Attendance_Management_System.Classes;
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
        }
        private void Admin_Load(object sender, EventArgs e)
        {
            admindashboard1.Visible = true;
            addUser2.Visible = false;
            attendencdeReport1.Visible = false;
            edit1.Visible = false;
            SearchPanel.Visible = false;

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
            SearchPanel.Visible = false;

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            admindashboard1.Visible = false;
            addUser2.Visible = true;
            attendencdeReport1.Visible = false;
            edit1.Visible = false;
            SearchPanel.Visible = false;

        }
        private void attendenceReportButton_Click(object sender, EventArgs e)
        {
            admindashboard1.Visible = false;
            addUser2.Visible = false;
            attendencdeReport1.Visible = true;
            edit1.Visible = false;
            SearchPanel.Visible = false;

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
            SearchPanel.Visible = false;

            if (admindashboard1.Visible)
            {
                admindashboard1.NoTeacherButton.Text = Handleloadadmin.GetNumberofTeachers() + " Teachers";
                admindashboard1.NoClassButton.Text = Handleloadadmin.GetNumberofClasses() + " Classes";
                admindashboard1.NostudentsButton.Text = Handleloadadmin.GetNumberofStudents() + " Students";
                admindashboard1.GenenrateWarningTable();
            }
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
            edit1.Visible = true;
            SearchPanel.Visible = false;

        }

        private void edit1_Load(object sender, EventArgs e)
        {

        }

        private void studentSearch_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();

            var StudentList = DataXMLManagement.GetStudentData();


            foreach (var student in StudentList)
            {
                if (
                    (student.studentId.Contains(IdStudenttextBox.Text) || IdStudenttextBox.Text == "") &&
                    (student.name.Contains(nameStudenttextBox.Text) || nameStudenttextBox.Text == "") &&
                    (student.Classes.Any(c => c == classcombBox.Text || classcombBox.Text == "")
                    ))
                    dataGridView2.Rows.Add(student.studentId, student.name);

            }
        }

        private void teacherSearch_Click(object sender, EventArgs e)
        {
            dataGridVieww.Rows.Clear();

            var TeacherList = DataXMLManagement.GetTeacherData();


            foreach (var teacher in TeacherList)
            {
                if (
                    (teacher.TeacherId.Contains(textBox1.Text) || textBox1.Text == "") &&
                    (teacher.Name.Contains(textBox2.Text) || textBox2.Text == "") &&
                    (teacher.Teacher_Courses.Any(c => c == teacherClass.Text || teacherClass.Text == "")
                    ))
                    dataGridVieww.Rows.Add(teacher.TeacherId, teacher.Name);

            }
        }

        private void ClassSearch_Click(object sender, EventArgs e)
        {
            dataGridView3.Rows.Clear();

            var ClassesList = DataXMLManagement.GetClassesData();


            foreach (var clas in ClassesList)
            {
                if (
                    (clas.ID.Contains(textBox3.Text) || textBox3.Text == "") &&
                    (clas.Name.Contains(textBox4.Text) || textBox4.Text == "")
                    )
                    dataGridView3.Rows.Add(clas.ID, clas.Name);
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            admindashboard1.Visible = false;
            addUser2.Visible = false;
            attendencdeReport1.Visible = false;
            SearchPanel.Visible = true;
            search_Load();
        }

        private void search_Load()
        {
            dataGridView2.Rows.Clear();

            var ClassesList = DataXMLManagement.GetClassesData();
            foreach (var classes in ClassesList)
            {
                classcombBox.Items.Add(classes.ID);
                teacherClass.Items.Add(classes.ID);
            }


            var StudentList = DataXMLManagement.GetStudentData();
            foreach (var student in StudentList)
            {
                dataGridView2.Rows.Add(student.studentId, student.name);
            }

            var TeacherList = DataXMLManagement.GetTeacherData();
            foreach (var teacher in TeacherList)
            {
                dataGridVieww.Rows.Add(teacher.TeacherId, teacher.Name);
            }

            var ClassList = DataXMLManagement.GetClassesData();
            foreach (var clas in ClassList)
            {
                dataGridView3.Rows.Add(clas.ID, clas.Name);
            }
        }

        private void dataGridView3_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }
    }
}
