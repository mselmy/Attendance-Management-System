namespace Attendance_Management_System.Forms
{
    partial class reports
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            studentReport1 = new StudentReport();
            teacherReport1 = new TeacherReport();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // studentReport1
            // 
            studentReport1.BackColor = SystemColors.ButtonHighlight;
            studentReport1.Location = new Point(113, 3);
            studentReport1.Name = "studentReport1";
            studentReport1.Size = new Size(1370, 832);
            studentReport1.TabIndex = 0;
            studentReport1.Load += studentReport1_Load;
            // 
            // teacherReport1
            // 
            teacherReport1.Location = new Point(145, 12);
            teacherReport1.Name = "teacherReport1";
            teacherReport1.Size = new Size(1312, 728);
            teacherReport1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(1526, 73);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(1526, 166);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 3;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // reports
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1674, 881);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(teacherReport1);
            Controls.Add(studentReport1);
            Name = "reports";
            Text = "reports";
            Load += reports_Load;
            ResumeLayout(false);
        }

        #endregion

        private StudentReport studentReport1;
        private TeacherReport teacherReport1;
        private Button button1;
        private Button button2;
    }
}