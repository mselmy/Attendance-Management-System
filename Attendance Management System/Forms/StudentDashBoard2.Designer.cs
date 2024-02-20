namespace Attendance_Management_System.Forms
{
    partial class StudentDashBoard2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentDashBoard2));
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            paneltop = new Panel();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(67, 3, 125);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(258, 720);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(258, 180);
            panel2.TabIndex = 0;
            panel2.Paint += panel2_Paint_2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(81, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(93, 87);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(23, 106);
            label1.Name = "label1";
            label1.Size = new Size(203, 25);
            label1.TabIndex = 1;
            label1.Text = "Student Attendance";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(67, 3, 125);
            flowLayoutPanel1.Controls.Add(paneltop);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(258, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1042, 100);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // paneltop
            // 
            paneltop.BackColor = Color.White;
            paneltop.Dock = DockStyle.Bottom;
            paneltop.Location = new Point(3, 3);
            paneltop.Name = "paneltop";
            paneltop.Size = new Size(942, 165);
            paneltop.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Red;
            label2.Location = new Point(922, 243);
            label2.Name = "label2";
            label2.Size = new Size(70, 25);
            label2.TabIndex = 1;
            label2.Text = "label2";
            // 
            // StudentDashBoard2
            // 
            AutoScaleDimensions = new SizeF(13F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1300, 720);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label2);
            Controls.Add(panel1);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 4, 5, 4);
            Name = "StudentDashBoard2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel paneltop;
        private Label label2;
    }
}