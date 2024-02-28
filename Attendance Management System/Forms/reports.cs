using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendance_Management_System.Forms
{
    public partial class reports : Form
    {
        public reports()
        {
            InitializeComponent();
        }

        private void reports_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            teacherReport1.Visible = true;
            studentReport1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            teacherReport1.Visible = false;
            studentReport1.Visible = true;
        }

        private void studentReport1_Load(object sender, EventArgs e)
        {

        }
    }
}
