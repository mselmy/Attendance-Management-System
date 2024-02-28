using Attendance_Management_System.Classes;
using Attendance_Management_System.Forms;
using System.CodeDom.Compiler;
using System.Drawing.Text;
using System.Globalization;
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
        }
    }
}
