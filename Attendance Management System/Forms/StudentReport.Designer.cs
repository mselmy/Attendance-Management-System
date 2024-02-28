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
            Reporttab.Alignment = TabAlignment.Bottom;
            Reporttab.Anchor = AnchorStyles.None;
            Reporttab.Controls.Add(StudenttabPage);
            Reporttab.Location = new Point(48, 33);
            Reporttab.Name = "Reporttab";
            Reporttab.SelectedIndex = 0;
            Reporttab.Size = new Size(1228, 631);
            Reporttab.TabIndex = 2;
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
            StudenttabPage.Location = new Point(4, 4);
            StudenttabPage.Name = "StudenttabPage";
            StudenttabPage.Padding = new Padding(3);
            StudenttabPage.Size = new Size(1220, 593);
            StudenttabPage.TabIndex = 1;
            StudenttabPage.Text = "Student Report";
            // 
            // classcomboBox
            // 
            classcomboBox.FormattingEnabled = true;
            classcomboBox.Location = new Point(875, 100);
            classcomboBox.Name = "classcomboBox";
            classcomboBox.Size = new Size(246, 33);
            classcomboBox.TabIndex = 54;
            classcomboBox.SelectedIndexChanged += classcomboBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SlateGray;
            label1.Location = new Point(875, 70);
            label1.Name = "label1";
            label1.Size = new Size(78, 32);
            label1.TabIndex = 53;
            label1.Text = "Class:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Goldenrod;
            panel1.Location = new Point(875, 139);
            panel1.Name = "panel1";
            panel1.Size = new Size(246, 2);
            panel1.TabIndex = 38;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(10, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(103, 130);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 51;
            pictureBox1.TabStop = false;
            // 
            // excel
            // 
            excel.Image = (Image)resources.GetObject("excel.Image");
            excel.Location = new Point(1078, 6);
            excel.Name = "excel";
            excel.Size = new Size(65, 78);
            excel.SizeMode = PictureBoxSizeMode.Zoom;
            excel.TabIndex = 50;
            excel.TabStop = false;
            excel.Click += excel_Click;
            // 
            // Pdf
            // 
            Pdf.Image = (Image)resources.GetObject("Pdf.Image");
            Pdf.Location = new Point(1149, 6);
            Pdf.Name = "Pdf";
            Pdf.Size = new Size(65, 78);
            Pdf.SizeMode = PictureBoxSizeMode.Zoom;
            Pdf.TabIndex = 49;
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
            dateTimePicker4.Location = new Point(433, 102);
            dateTimePicker4.Name = "dateTimePicker4";
            dateTimePicker4.Size = new Size(241, 31);
            dateTimePicker4.TabIndex = 40;
            dateTimePicker4.ValueChanged += dateTimePicker4_ValueChanged;
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Location = new Point(126, 102);
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
            label2.Location = new Point(132, 70);
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
            label8.Location = new Point(436, 70);
            label8.Name = "label8";
            label8.Size = new Size(48, 32);
            label8.TabIndex = 45;
            label8.Text = "To:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Goldenrod;
            label11.Location = new Point(119, 18);
            label11.Name = "label11";
            label11.Size = new Size(92, 32);
            label11.TabIndex = 35;
            label11.Text = "Report";
            // 
            // panel7
            // 
            panel7.BackColor = Color.Goldenrod;
            panel7.Location = new Point(436, 139);
            panel7.Name = "panel7";
            panel7.Size = new Size(246, 2);
            panel7.TabIndex = 37;
            // 
            // panel9
            // 
            panel9.BackColor = Color.Goldenrod;
            panel9.Location = new Point(129, 139);
            panel9.Name = "panel9";
            panel9.Size = new Size(255, 2);
            panel9.TabIndex = 36;
            // 
            // StudentReport
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            Controls.Add(Reporttab);
            Name = "StudentReport";
            Size = new Size(1324, 697);
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
