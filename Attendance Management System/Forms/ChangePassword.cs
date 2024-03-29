﻿using Attendance_Management_System.Classes;
using iText.StyledXmlParser.Jsoup.Nodes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Attendance_Management_System.Forms
{
    public partial class ChangePassword : Form
    {
        Session session;

        public ChangePassword(Session _session)
        {
            session = _session;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (Validation.IsLoginValid(session.CurrentUser.Email, oldPassword.Text))
            {
                oldError.Visible = false;
                oldT.Visible = false;

                if (Validation.IspasswordComplexValid(newPassword.Text))
                {
                    newError.Visible = false;
                    newT.Visible = false;

                    if (newPassword.Text == confirmPassword.Text)
                    {
                        confirmError.Visible = false;
                        confirmT.Visible = false;
                        DataXMLManagement.UpdatePassword(session.CurrentUser.Email, newPassword.Text);
                        MessageBox.Show("Password updated successfully ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        confirmError.Visible = true;
                        confirmT.Visible = true;
                    }
                }
                else
                {
                    newError.Visible = true;
                    newT.Visible = true;
                }
            }
            else
            {
                oldError.Visible = true;
                oldT.Visible = true;
            }
        }

        private void pictureBoxErrorMessage_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void labelErrorMessage_Click(object sender, EventArgs e)
        {

        }

        private void showOld_Click(object sender, EventArgs e)
        {
            oldPassword.UseSystemPasswordChar = !oldPassword.UseSystemPasswordChar;
        }

        private void showNew_Click(object sender, EventArgs e)
        {
            newPassword.UseSystemPasswordChar = !newPassword.UseSystemPasswordChar;

        }

        private void showConfirm_Click(object sender, EventArgs e)
        {
            confirmPassword.UseSystemPasswordChar = !confirmPassword.UseSystemPasswordChar;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void confirmPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
