using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Attendance_Management_System.Classes;
using Attendance_Management_System.Forms;

namespace Attendance_Management_System
{
    public partial class admindashboard : UserControl
    {
        public admindashboard()
        {
            InitializeComponent();

        }

        public void GenenrateWarningTable(string threshold="1")
        {
            AttendencdeReport attendencdeReport = new AttendencdeReport();
            Dictionary<string, string> map = new Dictionary<string, string>();
            map.Add("WarningThreshold", threshold);
            string resultXml = attendencdeReport.AttendenceReport(Configs.FilterWarning, map);
            if (string.IsNullOrEmpty(resultXml))
            {
                MessageBox.Show("No Data Found", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            if(resultXml=="<absent-students />")
            {
                MessageBox.Show("No Data Found", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DataSet ds = new DataSet();
            using (StringReader sr = new StringReader(resultXml))
            {
                ds.ReadXml(sr);
            }
            DataTable dt = ds.Tables[0];
            mostAbStTable.DataSource = dt;
            mostAbStTable.Visible = true;

            foreach (DataGridViewColumn column in mostAbStTable.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                column.Width = 300;
            }
            mostAbStTable.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

        }

        private void warningtextbox_TextChanged(object sender, EventArgs e)
        {
            string newThreshold = warningtextbox.Text;

            if (!string.IsNullOrEmpty(newThreshold))
            {
                if (int.TryParse(newThreshold, out int threshold) && threshold > 0)
                {
                    GenenrateWarningTable(threshold.ToString());
                }
                else
                {
                    MessageBox.Show("Please enter a valid positive integer", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
