using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace File_Management_Class
{
    public partial class FormForgetPassword : Form
    {
        public FormForgetPassword()
        {
            InitializeComponent();
        }

        private void click_Exit(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBox2, "close");
        }

        private void buttonVerify_Click(object sender, EventArgs e)
        {
            if (Validation.IsEmailValid(textBoxEmail.Text))
            {
                MessageBox.Show("Your password is: " + XMLManagement.MultibleNodesToList(Configs.UsersPath, "email", "password")[1][XMLManagement.NodesToList(Configs.UsersPath, "email").IndexOf(textBoxEmail.Text)]);
            }
            else
            {
                MessageBox.Show("Email is not valid");
            }
        }
    }
}
