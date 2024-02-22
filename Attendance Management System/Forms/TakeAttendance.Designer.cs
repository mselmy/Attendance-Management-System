using System.Windows.Forms;

namespace Attendance_Management_System.Forms
{
    partial class TakeAttendance
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            CourseComboBox = new ComboBox();
            HelloLable = new Label();
            label1 = new Label();
            dateTimePicker = new DateTimePicker();
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            StudentName = new DataGridViewTextBoxColumn();
            StatusCheckBox = new DataGridViewCheckBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            labelErrorMessage = new Label();
            SaveAttendanceButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // CourseComboBox
            // 
            CourseComboBox.Anchor = AnchorStyles.None;
            CourseComboBox.ForeColor = Color.SlateGray;
            CourseComboBox.FormattingEnabled = true;
            CourseComboBox.Location = new Point(157, 37);
            CourseComboBox.Name = "CourseComboBox";
            CourseComboBox.Size = new Size(336, 28);
            CourseComboBox.TabIndex = 1;
            CourseComboBox.SelectedIndexChanged += CourseComboBox_SelectedIndexChanged;
            // 
            // HelloLable
            // 
            HelloLable.Anchor = AnchorStyles.None;
            HelloLable.AutoSize = true;
            HelloLable.BackColor = Color.White;
            HelloLable.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            HelloLable.ForeColor = Color.SlateGray;
            HelloLable.ImeMode = ImeMode.NoControl;
            HelloLable.Location = new Point(35, 28);
            HelloLable.Margin = new Padding(0);
            HelloLable.Name = "HelloLable";
            HelloLable.Size = new Size(99, 46);
            HelloLable.TabIndex = 0;
            HelloLable.Text = "Class";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            label1.ForeColor = Color.SlateGray;
            label1.ImeMode = ImeMode.NoControl;
            label1.Location = new Point(540, 28);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(94, 46);
            label1.TabIndex = 0;
            label1.Text = "Date";
            // 
            // dateTimePicker
            // 
            dateTimePicker.Anchor = AnchorStyles.None;
            dateTimePicker.CustomFormat = "yyyy-MM-dd";
            dateTimePicker.Format = DateTimePickerFormat.Short;
            dateTimePicker.Location = new Point(657, 38);
            dateTimePicker.MaxDate = new DateTime(2024, 2, 21, 2, 4, 5, 928);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(336, 27);
            dateTimePicker.TabIndex = 2;
            dateTimePicker.Value = new DateTime(2024, 2, 21, 0, 0, 0, 0);
            dateTimePicker.ValueChanged += dateTimePicker_ValueChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.DodgerBlue;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Anchor = AnchorStyles.None;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, StudentName, StatusCheckBox, Status });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.EditMode = DataGridViewEditMode.EditOnEnter;
            dataGridView1.Location = new Point(35, 152);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = Color.DodgerBlue;
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.ScrollBars = ScrollBars.Vertical;
            dataGridView1.Size = new Size(1429, 635);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            // 
            // StudentName
            // 
            StudentName.HeaderText = "Student Name";
            StudentName.MinimumWidth = 6;
            StudentName.Name = "StudentName";
            // 
            // StatusCheckBox
            // 
            StatusCheckBox.FalseValue = "Absent";
            StatusCheckBox.HeaderText = "Present";
            StatusCheckBox.MinimumWidth = 6;
            StatusCheckBox.Name = "StatusCheckBox";
            StatusCheckBox.Resizable = DataGridViewTriState.True;
            StatusCheckBox.SortMode = DataGridViewColumnSortMode.Automatic;
            StatusCheckBox.TrueValue = "Present";
            // 
            // Status
            // 
            Status.HeaderText = "Current Attendance Status";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            // 
            // labelErrorMessage
            // 
            labelErrorMessage.AutoSize = true;
            labelErrorMessage.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelErrorMessage.ForeColor = Color.FromArgb(192, 0, 0);
            labelErrorMessage.Location = new Point(157, 99);
            labelErrorMessage.Name = "labelErrorMessage";
            labelErrorMessage.Size = new Size(1255, 34);
            labelErrorMessage.TabIndex = 14;
            labelErrorMessage.Text = "Attendance is already recorded any changes will change in the original attendance record";
            // 
            // SaveAttendanceButton
            // 
            SaveAttendanceButton.BackColor = Color.SlateGray;
            SaveAttendanceButton.Cursor = Cursors.Hand;
            SaveAttendanceButton.FlatAppearance.BorderSize = 0;
            SaveAttendanceButton.FlatStyle = FlatStyle.Flat;
            SaveAttendanceButton.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold);
            SaveAttendanceButton.ForeColor = Color.White;
            SaveAttendanceButton.ImeMode = ImeMode.NoControl;
            SaveAttendanceButton.Location = new Point(594, 823);
            SaveAttendanceButton.Name = "SaveAttendanceButton";
            SaveAttendanceButton.Size = new Size(310, 47);
            SaveAttendanceButton.TabIndex = 15;
            SaveAttendanceButton.Text = "Save Attendance";
            SaveAttendanceButton.UseVisualStyleBackColor = false;
            SaveAttendanceButton.Click += SaveAttendanceButton_Click;
            // 
            // TakeAttendance
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(SaveAttendanceButton);
            Controls.Add(labelErrorMessage);
            Controls.Add(dataGridView1);
            Controls.Add(dateTimePicker);
            Controls.Add(label1);
            Controls.Add(HelloLable);
            Controls.Add(CourseComboBox);
            Name = "TakeAttendance";
            Size = new Size(1500, 900);
            Load += TakeAttendance_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox CourseComboBox;
        private Label HelloLable;
        private Label label1;
        private DateTimePicker dateTimePicker;
        private DataGridView dataGridView1;
        private Label labelErrorMessage;
        private Button SaveAttendanceButton;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn StudentName;
        private DataGridViewCheckBoxColumn StatusCheckBox;
        private DataGridViewTextBoxColumn Status;
    }
}
