using Attendance_Management_System.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;
using System.Xml.Xsl;
using System.Xml;

namespace Attendance_Management_System.Forms
{
    public partial class AttendencdeReport : UserControl
    {
        DateTime FirstDate;
        DateTime LastDate;
        string ClassId;
        string StudId;
        List<string> classidList;
        List<string> studidList;



        public AttendencdeReport()
        {
            InitializeComponent();
            LastDate = DateTime.Today;
            FirstDate = DateTime.Today.AddMonths(-1);
            classcombBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            StudentcomboBox2.DropDownStyle = ComboBoxStyle.DropDownList;



        }
       
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            LastDate = dateTimePicker2.Value;
            GetData();
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            FirstDate = dateTimePicker1.Value;
            if (dateTimePicker1.Value > dateTimePicker2.Value)
            {
                MessageBox.Show("Start date cannot be after end date.");
                return;
            }
            GetData();
        }

        private void classcombBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClassId = classcombBox1.Text;
            GetData();
        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {
            FirstDate = dateTimePicker3.Value;
            if (dateTimePicker3.Value > dateTimePicker4.Value)
            {
                MessageBox.Show("Start date cannot be after end date.");
                return;
            }
            GetStudentData();
        }

        private void dateTimePicker4_ValueChanged(object sender, EventArgs e)
        {
            LastDate = dateTimePicker4.Value;
            GetStudentData();

        }

        private void StudentcomboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            StudId = StudentcomboBox2.Text;
            GetStudentData();

        }

        public void GetData()
        {
            if (string.IsNullOrEmpty(ClassId))
            {
                new MyClass
                {
                    FirstDate = FirstDate,
                    LastDate = LastDate
                };
                String fdate = FirstDate.ToString("yyyy-MM-dd");
                String ldate = LastDate.ToString("yyyy-MM-dd");

                Dictionary<string, string> parameters = new Dictionary<string, string>();
                parameters.Add("startDate", fdate);
                parameters.Add("endDate", ldate);

                SelectTableFromClassPage(Configs.FilterDateRangePath, parameters);
            }
            else
            {
                new MyClass
                {
                    FirstDate = FirstDate,
                    LastDate = LastDate,
                    ClassId = ClassId
                };
                String fdate = FirstDate.ToString("yyyy-MM-dd");
                String ldate = LastDate.ToString("yyyy-MM-dd");

                Dictionary<string, string> parameters = new Dictionary<string, string>();
                parameters.Add("startDate", fdate);
                parameters.Add("endDate", ldate);
                parameters.Add("Id", ClassId);

                SelectTableFromClassPage(Configs.FilterClassDateRange, parameters);
            }
        }
        public void GetStudentData()
        {
            if (string.IsNullOrEmpty(StudId))
            {
                new MyStud
                {
                    FirstDate = FirstDate,
                    LastDate = LastDate
                };
                String fdate = FirstDate.ToString("yyyy-MM-dd");
                String ldate = LastDate.ToString("yyyy-MM-dd");

                Dictionary<string, string> parameters = new Dictionary<string, string>();
                parameters.Add("startDate", fdate);
                parameters.Add("endDate", ldate);

                SelectTableFromStudentPage(Configs.FilterDateRangePath, parameters);
            }
            else
            {
                new MyStud
                {
                    FirstDate = FirstDate,
                    LastDate = LastDate,
                    StudId = StudId
                };
                String fdate = FirstDate.ToString("yyyy-MM-dd");
                String ldate = LastDate.ToString("yyyy-MM-dd");

                Dictionary<string, string> parameters = new Dictionary<string, string>();
                parameters.Add("startDate", fdate);
                parameters.Add("endDate", ldate);
                parameters.Add("Id", StudId);

                SelectTableFromStudentPage(Configs.FilterStudentDateRange, parameters);
            }
        }

        public void FillClassCombo()
        {
            classidList = XMLManagement.NodesToList(Configs.ClassesPath, "id");
            studidList = XMLManagement.GetIdofAllSt_Th(Configs.StudentsPath, "id");
        }
        private void populateTheList()
        {
            foreach (string id in classidList)
            {
                classcombBox1.Items.Add(id);
            }
            foreach (string id in studidList)
            {
                StudentcomboBox2.Items.Add(id);
            }

        }
        public class MyClass
        {
            public DateTime FirstDate { get; set; }
            public DateTime LastDate { get; set; }
            public string ClassId { get; set; }

        }
        public class MyStud
        {
            public DateTime FirstDate { get; set; }
            public DateTime LastDate { get; set; }
            public string StudId { get; set; }
        }
        private void AttendencdeReport_Load(object sender, EventArgs e)
        {
            FillClassCombo();
            populateTheList();
        }
        public  string AttendenceReport(string path, Dictionary<string, string> parameters)
        {
                XmlDocument XmlDoc = XMLManagement.ReadAllDocument();
                XslCompiledTransform transform = new XslCompiledTransform();
                transform.Load(path);
                XsltArgumentList args = new XsltArgumentList();
                foreach (var parameter in parameters)
                {
                    args.AddParam(parameter.Key, "", parameter.Value);
                }
                using (StringWriter sw = new StringWriter())
                {
                    using (XmlTextWriter writer = new XmlTextWriter(sw))
                    {
                            transform.Transform(XmlDoc, args, writer);
                    }
                    string resultXml = sw.ToString();
                    if (resultXml == "<records />")
                    {
                        MessageBox.Show("No data found.", "Message ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return "";
                    }
                    return resultXml;
                }
        }
        public void SelectTableFromStudentPage(string path, Dictionary<string, string> parameters)
        {
            string resultXml = AttendenceReport(path, parameters);
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
            Sattendence.DataSource = dt;
            Sattendence.Visible = true;
            foreach (DataGridViewColumn column in Sattendence.Columns)
            {
                column.Width = 300; 
            }
            Sattendence.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        public void SelectTableFromClassPage(string path, Dictionary<string, string> parameters)
        {
            string resultXml = AttendenceReport(path, parameters);
            if(string.IsNullOrEmpty(resultXml))
            {
                return;
            }
            DataSet ds = new DataSet();
            using (StringReader sr = new StringReader(resultXml))
            {
                ds.ReadXml(sr);
            }
            DataTable dt = ds.Tables[0];
            Attendence.DataSource = dt;
            Attendence.Visible = true;
            foreach (DataGridViewColumn column in Attendence.Columns)
            {
                column.Width = 300;
            }
            Attendence.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }


      

        


    }
}
