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
            Start.AutoSize = true;
            Start.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Start.ForeColor = Color.SlateGray;
            Start.Location = new Point(68, 76);
            Start.Name = "Start";
            Start.Size = new Size(80, 32);
            Start.TabIndex = 38;
            Start.Text = "From:";
            // 
            // StudenttabPage
            // 
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
            StudenttabPage.Location = new Point(4, 4);
            StudenttabPage.Name = "StudenttabPage";
            StudenttabPage.Padding = new Padding(3);
            StudenttabPage.Size = new Size(1220, 593);
            StudenttabPage.TabIndex = 1;
            StudenttabPage.Text = "Student Report";
            // 
            // excel2
            // 
            excel2.Image = (Image)resources.GetObject("excel2.Image");
            excel2.Location = new Point(1078, 6);
            excel2.Name = "excel2";
            excel2.Size = new Size(65, 78);
            excel2.SizeMode = PictureBoxSizeMode.Zoom;
            excel2.TabIndex = 50;
            excel2.TabStop = false;
            excel2.Click += excel2_Click;
            // 
            // Pdf2
            // 
            Pdf2.Image = (Image)resources.GetObject("Pdf2.Image");
            Pdf2.Location = new Point(1149, 6);
            Pdf2.Name = "Pdf2";
            Pdf2.Size = new Size(65, 78);
            Pdf2.SizeMode = PictureBoxSizeMode.Zoom;
            Pdf2.TabIndex = 49;
            Pdf2.TabStop = false;
            Pdf2.Click += Pdf2_Click_1;
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
            Sattendence.Location = new Point(80, 210);
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
            Sattendence.RowHeadersWidth = 80;
            Sattendence.RowTemplate.DefaultCellStyle.BackColor = Color.Honeydew;
            Sattendence.RowTemplate.DefaultCellStyle.ForeColor = Color.FromArgb(0, 0, 64);
            Sattendence.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.Green;
            Sattendence.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.White;
            Sattendence.ScrollBars = ScrollBars.Vertical;
            Sattendence.Size = new Size(1078, 348);
            Sattendence.TabIndex = 48;
            Sattendence.Visible = false;
            // 
            // dateTimePicker4
            // 
            dateTimePicker4.Location = new Point(386, 102);
            dateTimePicker4.Name = "dateTimePicker4";
            dateTimePicker4.Size = new Size(218, 31);
            dateTimePicker4.TabIndex = 40;
            dateTimePicker4.ValueChanged += dateTimePicker4_ValueChanged;
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Location = new Point(77, 102);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(256, 31);
            dateTimePicker3.TabIndex = 47;
            dateTimePicker3.ValueChanged += dateTimePicker3_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SlateGray;
            label2.Location = new Point(80, 67);
            label2.Name = "label2";
            label2.Size = new Size(80, 32);
            label2.TabIndex = 46;
            label2.Text = "From:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.SlateGray;
            label8.Location = new Point(384, 67);
            label8.Name = "label8";
            label8.Size = new Size(48, 32);
            label8.TabIndex = 45;
            label8.Text = "To:";
            // 
            // StudentcomboBox2
            // 
            StudentcomboBox2.FlatStyle = FlatStyle.Flat;
            StudentcomboBox2.FormattingEnabled = true;
            StudentcomboBox2.Location = new Point(883, 104);
            StudentcomboBox2.Name = "StudentcomboBox2";
            StudentcomboBox2.Size = new Size(254, 33);
            StudentcomboBox2.TabIndex = 42;
            StudentcomboBox2.SelectedIndexChanged += StudentcomboBox2_SelectedIndexChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Goldenrod;
            label11.Location = new Point(9, 9);
            label11.Name = "label11";
            label11.Size = new Size(187, 32);
            label11.TabIndex = 35;
            label11.Text = "Student Report";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.SlateGray;
            label9.Location = new Point(866, 69);
            label9.Name = "label9";
            label9.Size = new Size(120, 32);
            label9.TabIndex = 40;
            label9.Text = "Students:";
            // 
            // panel8
            // 
            panel8.BackColor = Color.Goldenrod;
            panel8.Location = new Point(869, 139);
            panel8.Name = "panel8";
            panel8.Size = new Size(270, 2);
            panel8.TabIndex = 41;
            // 
            // panel7
            // 
            panel7.BackColor = Color.Goldenrod;
            panel7.Location = new Point(384, 139);
            panel7.Name = "panel7";
            panel7.Size = new Size(230, 2);
            panel7.TabIndex = 37;
            // 
            // panel9
            // 
            panel9.BackColor = Color.Goldenrod;
            panel9.Location = new Point(80, 139);
            panel9.Name = "panel9";
            panel9.Size = new Size(255, 2);
            panel9.TabIndex = 36;
            // 
            // classReporttabPage
            // 
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
            classReporttabPage.Location = new Point(4, 4);
            classReporttabPage.Name = "classReporttabPage";
            classReporttabPage.Padding = new Padding(3);
            classReporttabPage.Size = new Size(1220, 593);
            classReporttabPage.TabIndex = 0;
            classReporttabPage.Text = "Class Report";
            // 
            // excel
            // 
            excel.Image = (Image)resources.GetObject("excel.Image");
            excel.Location = new Point(1078, 0);
            excel.Name = "excel";
            excel.Size = new Size(65, 78);
            excel.SizeMode = PictureBoxSizeMode.Zoom;
            excel.TabIndex = 43;
            excel.TabStop = false;
            excel.Click += excel_Click;
            // 
            // Pdf
            // 
            Pdf.Image = (Image)resources.GetObject("Pdf.Image");
            Pdf.Location = new Point(1149, 0);
            Pdf.Name = "Pdf";
            Pdf.Size = new Size(65, 78);
            Pdf.SizeMode = PictureBoxSizeMode.Zoom;
            Pdf.TabIndex = 42;
            Pdf.TabStop = false;
            Pdf.Click += Pdf_Click;
            // 
            // Attendence
            // 
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
            Attendence.Location = new Point(68, 214);
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
            Attendence.RowHeadersWidth = 80;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(224, 224, 224);
            Attendence.RowsDefaultCellStyle = dataGridViewCellStyle7;
            Attendence.RowTemplate.DefaultCellStyle.BackColor = Color.Honeydew;
            Attendence.RowTemplate.DefaultCellStyle.ForeColor = Color.FromArgb(0, 0, 64);
            Attendence.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.Green;
            Attendence.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.White;
            Attendence.ScrollBars = ScrollBars.Vertical;
            Attendence.Size = new Size(1130, 344);
            Attendence.TabIndex = 41;
            Attendence.Visible = false;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(390, 106);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(290, 31);
            dateTimePicker2.TabIndex = 40;
            dateTimePicker2.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(68, 105);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(298, 31);
            dateTimePicker1.TabIndex = 39;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // endlabel
            // 
            endlabel.AutoSize = true;
            endlabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            endlabel.ForeColor = Color.SlateGray;
            endlabel.Location = new Point(393, 76);
            endlabel.Name = "endlabel";
            endlabel.Size = new Size(48, 32);
            endlabel.TabIndex = 34;
            endlabel.Text = "To:";
            // 
            // panel5
            // 
            panel5.BackColor = Color.Goldenrod;
            panel5.Location = new Point(389, 141);
            panel5.Name = "panel5";
            panel5.Size = new Size(297, 2);
            panel5.TabIndex = 12;
            // 
            // endtextBox
            // 
            endtextBox.BorderStyle = BorderStyle.None;
            endtextBox.Location = new Point(395, 111);
            endtextBox.Name = "endtextBox";
            endtextBox.Size = new Size(297, 24);
            endtextBox.TabIndex = 32;
            // 
            // classcombBox1
            // 
            classcombBox1.FlatStyle = FlatStyle.Flat;
            classcombBox1.FormattingEnabled = true;
            classcombBox1.Location = new Point(858, 102);
            classcombBox1.Name = "classcombBox1";
            classcombBox1.Size = new Size(275, 33);
            classcombBox1.TabIndex = 23;
            classcombBox1.SelectedIndexChanged += classcombBox1_SelectedIndexChanged;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Goldenrod;
            panel4.Location = new Point(863, 141);
            panel4.Name = "panel4";
            panel4.Size = new Size(270, 2);
            panel4.TabIndex = 22;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.SlateGray;
            label7.Location = new Point(861, 67);
            label7.Name = "label7";
            label7.Size = new Size(78, 32);
            label7.TabIndex = 21;
            label7.Text = "Class:";
            // 
            // panel6
            // 
            panel6.BackColor = Color.Goldenrod;
            panel6.Location = new Point(69, 141);
            panel6.Name = "panel6";
            panel6.Size = new Size(297, 2);
            panel6.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Goldenrod;
            label1.Location = new Point(8, 8);
            label1.Name = "label1";
            label1.Size = new Size(156, 32);
            label1.TabIndex = 0;
            label1.Text = "Class Report";
            // 
            // Reporttab
            // 
            Reporttab.Alignment = TabAlignment.Bottom;
            Reporttab.Anchor = AnchorStyles.None;
            Reporttab.Controls.Add(classReporttabPage);
            Reporttab.Controls.Add(StudenttabPage);
            Reporttab.Location = new Point(48, 43);
            Reporttab.Name = "Reporttab";
            Reporttab.SelectedIndex = 0;
            Reporttab.Size = new Size(1228, 631);
            Reporttab.TabIndex = 1;
            // 
            // AttendencdeReport
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            Controls.Add(Reporttab);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "AttendencdeReport";
            Size = new Size(1324, 697);
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
