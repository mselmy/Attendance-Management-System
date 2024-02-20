using Attendance_Management_System.Classes;
using File_Management_Class.Forms;

namespace Attendance_Management_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBoxVisible.Hide();
            labelErrorMessage.Hide();
            pictureBoxErrorMessage.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Exit(object sender, EventArgs e)
        {
            Close();
        }

        private void Minimize(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Maximize(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void HidePassword(object sender, EventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = true;
            pictureBoxVisible.Hide();
            pictureBoxInvisible.Show();
        }

        private void ShowPassword(object sender, EventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = false;
            pictureBoxVisible.Show();
            pictureBoxInvisible.Hide();
        }

        private void click_Login(object sender, EventArgs e)
        {
            if (Validation.IsLoginValid(textBoxEmail.Text, textBoxPassword.Text))
            {
                Session session = new Session(textBoxEmail.Text);
                if(session.CurrentUser.Role == "Admin")
                {
                    Admin Admin = new Admin();
                    Admin.Show();
                }
                else if(session.CurrentUser.Role == "Teacher")
                {
                    Teacher Teacher = new Teacher(session);
                    Teacher.Show();
                }
                else if(session.CurrentUser.Role == "Student")
                {
                    StudentDashboard studentDashboard = new StudentDashboard();
                    studentDashboard.Show();
                }
                Hide();
            }
            else
            {
                labelErrorMessage.Show();
                pictureBoxErrorMessage.Show();
                textBoxEmail.Focus();
            }

        }

        private void click_forgetPassword(object sender, EventArgs e)
        {
            FormForgetPassword formForgetPassword = new FormForgetPassword();
            formForgetPassword.Show();

        }
    }
}
