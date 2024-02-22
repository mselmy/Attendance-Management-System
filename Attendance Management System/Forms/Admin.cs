using Attendance_Management_System.Classes;
using Attendance_Management_System.Forms;

namespace Attendance_Management_System
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }
        private void Admin_Load(object sender, EventArgs e)
        {
            admindashboard1.Visible = true;
            addUser2.Visible = false;
            attendencdeReport1.Visible = false;
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

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            admindashboard1.Visible = false;
            addUser2.Visible = true;
            attendencdeReport1.Visible = false;
        }
        private void attendenceReportButton_Click(object sender, EventArgs e)
        {
            admindashboard1.Visible = false;
            addUser2.Visible = false;
            attendencdeReport1.Visible = true;
        }
    }
}
