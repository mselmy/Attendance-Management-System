namespace Attendance_Management_System.Forms
{
    partial class AttendencdeReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AttendencdeReport));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            Start = new Label();
            StudenttabPage = new TabPage();
            excel2 = new PictureBox();
            Pdf2 = new PictureBox();
            Sattendence = new DataGridView();
            dateTimePicker4 = new DateTimePicker();
            dateTimePicker3 = new DateTimePicker();
            label2 = new Label();
            label8 = new Label();
            StudentcomboBox2 = new ComboBox();
            label11 = new Label();
            label9 = new Label();
            panel8 = new Panel();
            panel7 = new Panel();
            panel9 = new Panel();
            classReporttabPage = new TabPage();
            excel = new PictureBox();
            Pdf = new PictureBox();
            Attendence = new DataGridView();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            endlabel = new Label();
            panel5 = new Panel();
            endtextBox = new TextBox();
            classcombBox1 = new ComboBox();
            panel4 = new Panel();
            label7 = new Label();
            panel6 = new Panel();
            label1 = new Label();
            Reporttab = new TabControl();
            StudenttabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)excel2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Pdf2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Sattendence).BeginInit();
            classReporttabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)excel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Pdf).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Attendence).BeginInit();
            Reporttab.SuspendLayout();
            SuspendLayout();
            // 
            // Start
            // 
            resources.ApplyResources(Start, "Start");
            Start.ForeColor = Color.SlateGray;
            Start.Name = "Start";
            // 
            // StudenttabPage
            // 
            resources.ApplyResources(StudenttabPage, "StudenttabPage");
            StudenttabPage.BackColor = Color.White;
            StudenttabPage.Controls.Add(excel2);
            StudenttabPage.Controls.Add(Pdf2);
            StudenttabPage.Controls.Add(Sattendence);
            StudenttabPage.Controls.Add(dateTimePicker4);
            StudenttabPage.Controls.Add(dateTimePicker3);
            StudenttabPage.Controls.Add(label2);
            StudenttabPage.Controls.Add(label8);
            StudenttabPage.Controls.Add(StudentcomboBox2);
            StudenttabPage.Controls.Add(label11);
            StudenttabPage.Controls.Add(label9);
            StudenttabPage.Controls.Add(panel8);
            StudenttabPage.Controls.Add(panel7);
            StudenttabPage.Controls.Add(panel9);
            StudenttabPage.Name = "StudenttabPage";
            // 
            // excel2
            // 
            resources.ApplyResources(excel2, "excel2");
            excel2.Name = "excel2";
            excel2.TabStop = false;
            excel2.Click += excel2_Click;
            // 
            // Pdf2
            // 
            resources.ApplyResources(Pdf2, "Pdf2");
            Pdf2.Name = "Pdf2";
            Pdf2.TabStop = false;
            Pdf2.Click += Pdf2_Click_1;
            // 
            // Sattendence
            // 
            resources.ApplyResources(Sattendence, "Sattendence");
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
            // StudentcomboBox2
            // 
            resources.ApplyResources(StudentcomboBox2, "StudentcomboBox2");
            StudentcomboBox2.FormattingEnabled = true;
            StudentcomboBox2.Name = "StudentcomboBox2";
            StudentcomboBox2.SelectedIndexChanged += StudentcomboBox2_SelectedIndexChanged;
            // 
            // label11
            // 
            resources.ApplyResources(label11, "label11");
            label11.ForeColor = Color.Goldenrod;
            label11.Name = "label11";
            // 
            // label9
            // 
            resources.ApplyResources(label9, "label9");
            label9.ForeColor = Color.SlateGray;
            label9.Name = "label9";
            // 
            // panel8
            // 
            resources.ApplyResources(panel8, "panel8");
            panel8.BackColor = Color.Goldenrod;
            panel8.Name = "panel8";
            // 
            // panel7
            // 
            resources.ApplyResources(panel7, "panel7");
            panel7.BackColor = Color.Goldenrod;
            panel7.Name = "panel7";
            // 
            // panel9
            // 
            resources.ApplyResources(panel9, "panel9");
            panel9.BackColor = Color.Goldenrod;
            panel9.Name = "panel9";
            // 
            // classReporttabPage
            // 
            resources.ApplyResources(classReporttabPage, "classReporttabPage");
            classReporttabPage.BackColor = Color.White;
            classReporttabPage.Controls.Add(excel);
            classReporttabPage.Controls.Add(Pdf);
            classReporttabPage.Controls.Add(Attendence);
            classReporttabPage.Controls.Add(dateTimePicker2);
            classReporttabPage.Controls.Add(dateTimePicker1);
            classReporttabPage.Controls.Add(Start);
            classReporttabPage.Controls.Add(endlabel);
            classReporttabPage.Controls.Add(panel5);
            classReporttabPage.Controls.Add(endtextBox);
            classReporttabPage.Controls.Add(classcombBox1);
            classReporttabPage.Controls.Add(panel4);
            classReporttabPage.Controls.Add(label7);
            classReporttabPage.Controls.Add(panel6);
            classReporttabPage.Controls.Add(label1);
            classReporttabPage.Name = "classReporttabPage";
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
            // Attendence
            // 
            resources.ApplyResources(Attendence, "Attendence");
            Attendence.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            Attendence.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            Attendence.BackgroundColor = SystemColors.ButtonHighlight;
            Attendence.BorderStyle = BorderStyle.None;
            Attendence.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.DimGray;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.Window;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.InactiveCaptionText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            Attendence.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            Attendence.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.InactiveCaption;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.InactiveCaptionText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            Attendence.DefaultCellStyle = dataGridViewCellStyle5;
            Attendence.Name = "Attendence";
            Attendence.ReadOnly = true;
            Attendence.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.Green;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = SystemColors.Window;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            Attendence.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(224, 224, 224);
            Attendence.RowsDefaultCellStyle = dataGridViewCellStyle7;
            Attendence.RowTemplate.DefaultCellStyle.BackColor = Color.Honeydew;
            Attendence.RowTemplate.DefaultCellStyle.ForeColor = Color.FromArgb(0, 0, 64);
            Attendence.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.Green;
            Attendence.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.White;
            // 
            // dateTimePicker2
            // 
            resources.ApplyResources(dateTimePicker2, "dateTimePicker2");
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // dateTimePicker1
            // 
            resources.ApplyResources(dateTimePicker1, "dateTimePicker1");
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // endlabel
            // 
            resources.ApplyResources(endlabel, "endlabel");
            endlabel.ForeColor = Color.SlateGray;
            endlabel.Name = "endlabel";
            // 
            // panel5
            // 
            resources.ApplyResources(panel5, "panel5");
            panel5.BackColor = Color.Goldenrod;
            panel5.Name = "panel5";
            // 
            // endtextBox
            // 
            resources.ApplyResources(endtextBox, "endtextBox");
            endtextBox.BorderStyle = BorderStyle.None;
            endtextBox.Name = "endtextBox";
            // 
            // classcombBox1
            // 
            resources.ApplyResources(classcombBox1, "classcombBox1");
            classcombBox1.FormattingEnabled = true;
            classcombBox1.Name = "classcombBox1";
            classcombBox1.SelectedIndexChanged += classcombBox1_SelectedIndexChanged;
            // 
            // panel4
            // 
            resources.ApplyResources(panel4, "panel4");
            panel4.BackColor = Color.Goldenrod;
            panel4.Name = "panel4";
            // 
            // label7
            // 
            resources.ApplyResources(label7, "label7");
            label7.ForeColor = Color.SlateGray;
            label7.Name = "label7";
            // 
            // panel6
            // 
            resources.ApplyResources(panel6, "panel6");
            panel6.BackColor = Color.Goldenrod;
            panel6.Name = "panel6";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.ForeColor = Color.Goldenrod;
            label1.Name = "label1";
            // 
            // Reporttab
            // 
            resources.ApplyResources(Reporttab, "Reporttab");
            Reporttab.Controls.Add(classReporttabPage);
            Reporttab.Controls.Add(StudenttabPage);
            Reporttab.Name = "Reporttab";
            Reporttab.SelectedIndex = 0;
            // 
            // AttendencdeReport
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            Controls.Add(Reporttab);
            Name = "AttendencdeReport";
            Load += AttendencdeReport_Load;
            StudenttabPage.ResumeLayout(false);
            StudenttabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)excel2).EndInit();
            ((System.ComponentModel.ISupportInitialize)Pdf2).EndInit();
            ((System.ComponentModel.ISupportInitialize)Sattendence).EndInit();
            classReporttabPage.ResumeLayout(false);
            classReporttabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)excel).EndInit();
            ((System.ComponentModel.ISupportInitialize)Pdf).EndInit();
            ((System.ComponentModel.ISupportInitialize)Attendence).EndInit();
            Reporttab.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label label;
        private Label Start;
        private TabPage StudenttabPage;
        private Label label8;
        private ComboBox StudentcomboBox2;
        private Label label11;
        private Label label9;
        private Panel panel8;
        private Panel panel7;
        private Panel panel9;
        private TabPage classReporttabPage;
        private Label endlabel;
        private Panel panel5;
        private TextBox endtextBox;
        private ComboBox classcombBox1;
        private Panel panel4;
        private Label label7;
        private Panel panel6;
        private Label label1;
        private TabControl Reporttab;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker4;
        private DateTimePicker dateTimePicker3;
        private DataGridView Attendence;
        private DataGridViewTextBoxColumn Class_ID;
        private DataGridViewTextBoxColumn namestudent;
        private DataGridViewTextBoxColumn Class;
        private DataGridViewTextBoxColumn Noabsent;
        private DataGridView Sattendence;
        private PictureBox Pdf;
        private PictureBox excel;
        private PictureBox excel2;
        private PictureBox Pdf2;
    }
}
