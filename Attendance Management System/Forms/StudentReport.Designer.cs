namespace Attendance_Management_System.Forms
{
    partial class StudentReport
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentReport));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Reporttab = new TabControl();
            StudenttabPage = new TabPage();
            classcomboBox = new ComboBox();
            label1 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            excel = new PictureBox();
            Pdf = new PictureBox();
            Sattendence = new DataGridView();
            dateTimePicker4 = new DateTimePicker();
            dateTimePicker3 = new DateTimePicker();
            label2 = new Label();
            label8 = new Label();
            label11 = new Label();
            panel7 = new Panel();
            panel9 = new Panel();
            Reporttab.SuspendLayout();
            StudenttabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)excel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Pdf).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Sattendence).BeginInit();
            SuspendLayout();
            // 
            // Reporttab
            // 
            resources.ApplyResources(Reporttab, "Reporttab");
            Reporttab.Controls.Add(StudenttabPage);
            Reporttab.Name = "Reporttab";
            Reporttab.SelectedIndex = 0;
            // 
            // StudenttabPage
            // 
            StudenttabPage.BackColor = Color.White;
            StudenttabPage.Controls.Add(classcomboBox);
            StudenttabPage.Controls.Add(label1);
            StudenttabPage.Controls.Add(panel1);
            StudenttabPage.Controls.Add(pictureBox1);
            StudenttabPage.Controls.Add(excel);
            StudenttabPage.Controls.Add(Pdf);
            StudenttabPage.Controls.Add(Sattendence);
            StudenttabPage.Controls.Add(dateTimePicker4);
            StudenttabPage.Controls.Add(dateTimePicker3);
            StudenttabPage.Controls.Add(label2);
            StudenttabPage.Controls.Add(label8);
            StudenttabPage.Controls.Add(label11);
            StudenttabPage.Controls.Add(panel7);
            StudenttabPage.Controls.Add(panel9);
            resources.ApplyResources(StudenttabPage, "StudenttabPage");
            StudenttabPage.Name = "StudenttabPage";
            // 
            // classcomboBox
            // 
            classcomboBox.FormattingEnabled = true;
            resources.ApplyResources(classcomboBox, "classcomboBox");
            classcomboBox.Name = "classcomboBox";
            classcomboBox.SelectedIndexChanged += classcomboBox_SelectedIndexChanged;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.ForeColor = Color.SlateGray;
            label1.Name = "label1";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Goldenrod;
            resources.ApplyResources(panel1, "panel1");
            panel1.Name = "panel1";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // excel
            // 
            resources.ApplyResources(excel, "excel");
            excel.Name = "excel";
            excel.TabStop = false;
            excel.Click += excel_Click;
            // 
            // Pdf
            // 
            resources.ApplyResources(Pdf, "Pdf");
            Pdf.Name = "Pdf";
            Pdf.TabStop = false;
            Pdf.Click += Pdf_Click;
            // 
            // Sattendence
            // 
            Sattendence.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            Sattendence.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            Sattendence.BackgroundColor = SystemColors.ButtonHighlight;
            Sattendence.BorderStyle = BorderStyle.None;
            Sattendence.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.DarkSeaGreen;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.InactiveCaptionText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            Sattendence.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            Sattendence.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.ControlLight;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.InactiveCaptionText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            Sattendence.DefaultCellStyle = dataGridViewCellStyle2;
            resources.ApplyResources(Sattendence, "Sattendence");
            Sattendence.Name = "Sattendence";
            Sattendence.ReadOnly = true;
            Sattendence.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            Sattendence.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            Sattendence.RowTemplate.DefaultCellStyle.BackColor = Color.Honeydew;
            Sattendence.RowTemplate.DefaultCellStyle.ForeColor = Color.FromArgb(0, 0, 64);
            Sattendence.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.Green;
            Sattendence.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.White;
            // 
            // dateTimePicker4
            // 
            resources.ApplyResources(dateTimePicker4, "dateTimePicker4");
            dateTimePicker4.Name = "dateTimePicker4";
            dateTimePicker4.ValueChanged += dateTimePicker4_ValueChanged;
            // 
            // dateTimePicker3
            // 
            resources.ApplyResources(dateTimePicker3, "dateTimePicker3");
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.ValueChanged += dateTimePicker3_ValueChanged;
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.ForeColor = Color.SlateGray;
            label2.Name = "label2";
            // 
            // label8
            // 
            resources.ApplyResources(label8, "label8");
            label8.ForeColor = Color.SlateGray;
            label8.Name = "label8";
            // 
            // label11
            // 
            resources.ApplyResources(label11, "label11");
            label11.ForeColor = Color.Goldenrod;
            label11.Name = "label11";
            // 
            // panel7
            // 
            panel7.BackColor = Color.Goldenrod;
            resources.ApplyResources(panel7, "panel7");
            panel7.Name = "panel7";
            // 
            // panel9
            // 
            panel9.BackColor = Color.Goldenrod;
            resources.ApplyResources(panel9, "panel9");
            panel9.Name = "panel9";
            // 
            // StudentReport
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            Controls.Add(Reporttab);
            Name = "StudentReport";
            Load += StudentReport_Load;
            Reporttab.ResumeLayout(false);
            StudenttabPage.ResumeLayout(false);
            StudenttabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)excel).EndInit();
            ((System.ComponentModel.ISupportInitialize)Pdf).EndInit();
            ((System.ComponentModel.ISupportInitialize)Sattendence).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl Reporttab;
        private TabPage StudenttabPage;
        private PictureBox excel;
        private PictureBox Pdf;
        private DataGridView Sattendence;
        private DateTimePicker dateTimePicker4;
        private DateTimePicker dateTimePicker3;
        private Label label2;
        private Label label8;
        private Label label11;
        private Panel panel7;
        private Panel panel9;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel1;
        private ComboBox classcomboBox;
    }
}
