using Attendance_Management_System.Classes;
using Attendance_Management_System.Forms;
using System.CodeDom.Compiler;
using System.Drawing.Text;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Attendance_Management_System
{
    public partial class Teacher : Form
    {
        Session session;
        TeacherData? user;

        public Teacher()
        {
            Configs.ChangeLanguage();
            InitializeComponent();
        }

        public Teacher(Session _session)
        {
            Configs.ChangeLanguage();
            InitializeComponent();
            session = _session;
            user = _session.CurrentUser as TeacherData;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void MinimizePictureBox_Click(object sender, EventArgs e)
        {
        }

        private void Teacher_Load(object sender, EventArgs e)
        {
            NameLabel.Text = user?.Name;
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

        private void EditPasswordButton_Click(object sender, EventArgs e)
        {
            ChangePassword formChangePassword = new ChangePassword(session);
            formChangePassword.Show();
        }

        private void ViewAttendanceButton_Click(object sender, EventArgs e)
        {

        }

        private void HelloLable_Click(object sender, EventArgs e)
        {

        }

        private void SettingButton_Click(object sender, EventArgs e)
        {
            Setting setting = new Setting(refresh);
            setting.Show();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
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
            }


            var StudentList = DataXMLManagement.GetStudentData();
            foreach (var student in StudentList)
            {
                dataGridView2.Rows.Add(student.studentId, student.name);
            }

            var ClassList = DataXMLManagement.GetClassesData();
            foreach (var clas in ClassList)
            {
                dataGridView3.Rows.Add(clas.ID, clas.Name);
            }
        }

        public void refresh()
        {
            Controls.Clear();
            InitializeComponent();
            NameLabel.Text = user?.Name;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            XMLManagement.SaveXMLFileWindow();
        }

        private void TakeAttendanceButton_Click(object sender, EventArgs e)
        {
            ViewPanel.Controls.Clear();
            TakeAttendance takeAttendance = new TakeAttendance(session);
            ViewPanel.Controls.Add(takeAttendance);
            SearchPanel.Visible = false;

        }

        private void TakeAttendance_Load(object sender, EventArgs e)
        {

        }

        private void ViewPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void attendenceReportButton_Click(object sender, EventArgs e)
        {
            ViewPanel.Controls.Clear();
            TeacherReport teacherReport = new TeacherReport(session);
            ViewPanel.Controls.Add(teacherReport);
            SearchPanel.Visible = false;
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
                    (student.Classes.Any(c => c == classcombBox.Text || classcombBox.Text == "") &&
                    user.Coursesid.Any(Tc => student.Classes.Any(c => c == Tc))
                    ))
                    dataGridView2.Rows.Add(student.studentId, student.name);

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
                    (clas.Name.Contains(textBox4.Text) || textBox4.Text == "") &&
                    user.Coursesid.Any(c => c == clas.ID)
                    )
                    dataGridView3.Rows.Add(clas.ID, clas.Name);
            }
        }
    }
}
