using Attendance_Management_System.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;
using System.Xml.Xsl;
using System.Xml;
using OfficeOpenXml;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;

using iText.Pdfa;
using System.Diagnostics.Eventing.Reader;
using iTextSharp.text.pdf;
using iTextSharp.text;

namespace Attendance_Management_System.Forms
{
    public partial class StudentReport : UserControl
    {
        DateTime FirstDate;
        DateTime LastDate;
        string StudId;
        string Data;
        string ClassId;
        HashSet<string> classidList;
        Session session;

        public StudentReport(Session _session)
        {
            InitializeComponent();
            LastDate = DateTime.Today;
            FirstDate = DateTime.Today.AddMonths(-1);
            session = _session;
            StudId = session.CurrentUser.ID;
        }
        public void FillClassCombo()
        {
            classidList = XMLManagement.GetClassForStudent(StudId);
        }
        private void populateTheList()
        {
            foreach (string id in classidList)
            {
                classcomboBox.Items.Add(id);
            }


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
        public void GetStudentData()
        {
            if (string.IsNullOrEmpty(ClassId))
            {
                String fdate = FirstDate.ToString("yyyy-MM-dd");
                String ldate = LastDate.ToString("yyyy-MM-dd");

                Dictionary<string, string> parameters = new Dictionary<string, string>();
                parameters.Add("startDate", fdate);
                parameters.Add("endDate", ldate);
                parameters.Add("Id", StudId);
                SelectTableFromStudentPage(Configs.FilterStudentDateRange, parameters);
            }
            else
            {
                String fdate = FirstDate.ToString("yyyy-MM-dd");
                String ldate = LastDate.ToString("yyyy-MM-dd");

                Dictionary<string, string> parameters = new Dictionary<string, string>();
                parameters.Add("startDate", fdate);
                parameters.Add("endDate", ldate);
                parameters.Add("studId", StudId);
                parameters.Add("classId", ClassId);

                SelectTableFromStudentPage(Configs.FilterStudentClass, parameters);
            }

        }
        public void SelectTableFromStudentPage(string path, Dictionary<string, string> parameters)
        {
            string resultXml = GenerateReport.AttendenceReport(path, parameters);
            Data = resultXml;
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

        private void Pdf_Click(object sender, EventArgs e)
        {
            ConvertToPdf();
        }

        private void excel_Click(object sender, EventArgs e)
        {
            SaveExcelFile();

        }

        public void ConvertToPdf()
        {
            if (!string.IsNullOrEmpty(Data))
            {
                using (SaveFileDialog save = new SaveFileDialog() { Filter = "PDF file|*.pdf", ValidateNames = true })
                {
                    if (save.ShowDialog() == DialogResult.OK)
                    {
                        iTextSharp.text.Document doc = new iTextSharp.text.Document();
                        try
                        {
                            iTextSharp.text.pdf.PdfWriter.GetInstance(doc, new FileStream(save.FileName, FileMode.Create));

                            doc.Open();

                            iTextSharp.text.Paragraph attendanceReportParagraph = new iTextSharp.text.Paragraph("Attendance Report", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 20f));
                            attendanceReportParagraph.Font.Color = BaseColor.ORANGE;
                            attendanceReportParagraph.Alignment = Element.ALIGN_CENTER;
                            doc.Add(attendanceReportParagraph);

                            string currentDate = DateTime.Now.ToString("yyyy-MM-dd");
                            iTextSharp.text.Paragraph dateParagraph = new iTextSharp.text.Paragraph($"Date: {currentDate}");
                            dateParagraph.Alignment = Element.ALIGN_LEFT;
                            doc.Add(dateParagraph);

                            string currentTime = DateTime.Now.ToString("HH:mm:ss");
                            iTextSharp.text.Paragraph timeParagraph = new iTextSharp.text.Paragraph($"Time: {currentTime}");
                            timeParagraph.Alignment = Element.ALIGN_LEFT;
                            doc.Add(timeParagraph);

                            iTextSharp.text.Paragraph dateRangeParagraph = new iTextSharp.text.Paragraph($"Report Date Range: {FirstDate.ToString("yyyy-MM-dd")} to {LastDate.ToString("yyyy-MM-dd")}");
                            dateRangeParagraph.Font.Color = BaseColor.DARK_GRAY;
                            dateRangeParagraph.Alignment = Element.ALIGN_CENTER;
                            doc.Add(dateRangeParagraph);



                            doc.Add(new Chunk("\n"));

                            PdfPTable table = LoadXmlDataToPdfTable();


                            doc.Add(table);
                            MessageBox.Show("PDF file created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Error");
                        }
                        finally
                        {
                            doc.Close();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("There is no data to save", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private PdfPTable LoadXmlDataToPdfTable()
        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.LoadXml(Data);

            PdfPTable table = new PdfPTable(6);

            table.AddCell("ClassID");
            table.AddCell("ClassName");
            table.AddCell("StudentID");
            table.AddCell("StudentName");
            table.AddCell("Satus");
            table.AddCell("Date");
            XmlNodeList studentNodes = xmlDocument.SelectNodes("/records/record");

            foreach (XmlNode studentNode in studentNodes)
            {
                string classID = studentNode.SelectSingleNode("classId").InnerText;
                string className = studentNode.SelectSingleNode("ClassName").InnerText;
                string studentID = studentNode.SelectSingleNode("StudentId").InnerText;
                string studentName = studentNode.SelectSingleNode("StudentName").InnerText;
                string status = studentNode.SelectSingleNode("State").InnerText;
                string date = studentNode.SelectSingleNode("date").InnerText;

                table.AddCell(classID);
                table.AddCell(className);
                table.AddCell(studentID);
                table.AddCell(studentName);
                table.AddCell(status);
                table.AddCell(date);
            }

            return table;
        }
        public void SaveExcelFile()
        {
            if (!string.IsNullOrEmpty(Data))
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Excel Files|*.xlsx";
                    saveFileDialog.Title = "Save Excel File";
                    saveFileDialog.FileName = "AttendanceReport.xlsx";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        ConvertToExcel(saveFileDialog.FileName);
                    }
                }
            }
            else
            {
                MessageBox.Show("There is no data to save", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConvertToExcel(string excelFilePath)
        {
            try
            {
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

                using (ExcelPackage excelPackage = new ExcelPackage(new FileInfo(excelFilePath)))
                {
                    ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Attendance");

                    worksheet.Cells[1, 1].Value = "ClassID";
                    worksheet.Cells[1, 2].Value = "ClassName";
                    worksheet.Cells[1, 3].Value = "StudentID";
                    worksheet.Cells[1, 4].Value = "StudentName";
                    worksheet.Cells[1, 5].Value = "Status";
                    worksheet.Cells[1, 6].Value = "Date";

                    XmlDocument xmlDocument = new XmlDocument();
                    xmlDocument.LoadXml(Data);
                    XmlNodeList studentNodes = xmlDocument.SelectNodes("/records/record");

                    int row = 2;
                    foreach (XmlNode studentNode in studentNodes)
                    {
                        worksheet.Cells[row, 1].Value = studentNode.SelectSingleNode("classId").InnerText;
                        worksheet.Cells[row, 2].Value = studentNode.SelectSingleNode("ClassName").InnerText;
                        worksheet.Cells[row, 3].Value = studentNode.SelectSingleNode("StudentId").InnerText;
                        worksheet.Cells[row, 4].Value = studentNode.SelectSingleNode("StudentName").InnerText;
                        worksheet.Cells[row, 5].Value = studentNode.SelectSingleNode("State").InnerText;
                        worksheet.Cells[row, 6].Value = studentNode.SelectSingleNode("date").InnerText;

                        row++;
                    }

                    excelPackage.Save();
                    MessageBox.Show("Excel file created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating Excel file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void classcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClassId = classcomboBox.Text;
            GetStudentData();
        }
        private void StudentReport_Load(object sender, EventArgs e)
        {
            FillClassCombo();
            populateTheList();

        }

    }
}
