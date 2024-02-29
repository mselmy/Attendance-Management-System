using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Attendance_Management_System.Classes;
using Microsoft.VisualBasic;

namespace Attendance_Management_System
{
    public partial class Setting : Form
    {
        private Action? refresh = null;

        public Setting()
        {
            InitializeComponent();
        }

        public Setting(Action _refresh)
        {
            refresh = _refresh;
            InitializeComponent();
        }

        private void click_Exit(object sender, EventArgs e)
        {
            Close();
        }

        private void SaveChangesbutton_Click(object sender, EventArgs e)
        {
            if (LanguageComboBox.Text == "Arabic")
            {
                Configs.setLanguage("AR");
            }
            else
            {
                Configs.setLanguage("EN");
            }
            if (refresh != null)
            { refresh(); }
            Hide();
        }


        private void LanguageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}