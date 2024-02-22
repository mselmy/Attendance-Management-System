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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TakeAttendance));
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
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
            resources.ApplyResources(CourseComboBox, "CourseComboBox");
            CourseComboBox.ForeColor = Color.SlateGray;
            CourseComboBox.FormattingEnabled = true;
            CourseComboBox.Name = "CourseComboBox";
            CourseComboBox.SelectedIndexChanged += CourseComboBox_SelectedIndexChanged;
            // 
            // HelloLable
            // 
            resources.ApplyResources(HelloLable, "HelloLable");
            HelloLable.BackColor = Color.White;
            HelloLable.ForeColor = Color.SlateGray;
            HelloLable.Name = "HelloLable";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.BackColor = Color.White;
            label1.ForeColor = Color.SlateGray;
            label1.Name = "label1";
            // 
            // dateTimePicker
            // 
            resources.ApplyResources(dateTimePicker, "dateTimePicker");
            dateTimePicker.Format = DateTimePickerFormat.Short;
            dateTimePicker.MaxDate = new DateTime(2024, 2, 21, 2, 4, 5, 928);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Value = new DateTime(2024, 2, 21, 0, 0, 0, 0);
            dateTimePicker.ValueChanged += dateTimePicker_ValueChanged;
            // 
            // dataGridView1
            // 
            resources.ApplyResources(dataGridView1, "dataGridView1");
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = Color.DodgerBlue;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, StudentName, StatusCheckBox, Status });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle8;
            dataGridView1.EditMode = DataGridViewEditMode.EditOnEnter;
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.White;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewCellStyle10.BackColor = Color.White;
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle10.ForeColor = Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = Color.DodgerBlue;
            dataGridViewCellStyle10.SelectionForeColor = Color.White;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle10;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ID
            // 
            resources.ApplyResources(ID, "ID");
            ID.Name = "ID";
            // 
            // StudentName
            // 
            resources.ApplyResources(StudentName, "StudentName");
            StudentName.Name = "StudentName";
            // 
            // StatusCheckBox
            // 
            StatusCheckBox.FalseValue = "Absent";
            resources.ApplyResources(StatusCheckBox, "StatusCheckBox");
            StatusCheckBox.Name = "StatusCheckBox";
            StatusCheckBox.Resizable = DataGridViewTriState.True;
            StatusCheckBox.SortMode = DataGridViewColumnSortMode.Automatic;
            StatusCheckBox.TrueValue = "Present";
            // 
            // Status
            // 
            resources.ApplyResources(Status, "Status");
            Status.Name = "Status";
            // 
            // labelErrorMessage
            // 
            resources.ApplyResources(labelErrorMessage, "labelErrorMessage");
            labelErrorMessage.ForeColor = Color.FromArgb(192, 0, 0);
            labelErrorMessage.Name = "labelErrorMessage";
            // 
            // SaveAttendanceButton
            // 
            resources.ApplyResources(SaveAttendanceButton, "SaveAttendanceButton");
            SaveAttendanceButton.BackColor = Color.SlateGray;
            SaveAttendanceButton.Cursor = Cursors.Hand;
            SaveAttendanceButton.FlatAppearance.BorderSize = 0;
            SaveAttendanceButton.ForeColor = Color.White;
            SaveAttendanceButton.Name = "SaveAttendanceButton";
            SaveAttendanceButton.UseVisualStyleBackColor = false;
            SaveAttendanceButton.Click += SaveAttendanceButton_Click;
            // 
            // TakeAttendance
            // 
            resources.ApplyResources(this, "$this");
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
