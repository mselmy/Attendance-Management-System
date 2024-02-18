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

        }

        private void admindashboard1_VisibleChanged(object sender, EventArgs e)
        {
            // Check if the admindashboard1 UserControl is visible
            if (admindashboard1.Visible)
            {
                // Update the text of the buttons in admindashboard1 UserControl
                admindashboard1.NoTeacherButton.Text = Handleloadadmin.GetNumberofTeachers() + " Teachers";
                admindashboard1.NoClassButton.Text = Handleloadadmin.GetNumberofClasses() + " Classes";
                admindashboard1.NostudentsButton.Text = Handleloadadmin.GetNumberofStudents() + " Students";
            }

        }
    }
}
