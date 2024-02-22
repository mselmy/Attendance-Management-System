using Attendance_Management_System.Classes;

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
            addUser1.Visible = false;

        }

        private void admindashboard1_VisibleChanged(object sender, EventArgs e)
        {
            if (admindashboard1.Visible)
            {
                admindashboard1.NoTeacherButton.Text = Handleloadadmin.GetNumberofTeachers() + " Teachers";
                admindashboard1.NoClassButton.Text = Handleloadadmin.GetNumberofClasses() + " Classes";
                admindashboard1.NostudentsButton.Text = Handleloadadmin.GetNumberofStudents() + " Students";
            }

        }

        private void DashboardButton_Click(object sender, EventArgs e)
        {
            admindashboard1.Visible = true;
            addUser1.Visible = false;

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            admindashboard1.Visible = false;
            addUser1.Visible = true;
        }
    }
}
