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

        public void GenenrateWarningTable()
        {
            AttendencdeReport attendencdeReport = new AttendencdeReport();
            Dictionary<string,string> map = new Dictionary<string,string>();
            map.Add("Warning", "3");
            string resultXml= attendencdeReport.AttendenceReport(Configs.FilterWarning, map);
            if (string.IsNullOrEmpty(resultXml))
            {
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
    }
}
