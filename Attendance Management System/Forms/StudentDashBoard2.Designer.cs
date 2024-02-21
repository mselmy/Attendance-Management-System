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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentDashBoard2));
            panel1 = new Panel();
            panel6 = new Panel();
            lodoutpic = new PictureBox();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            panelside = new Panel();
            button1 = new Button();
            panel2 = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel5 = new Panel();
            label7 = new Label();
            label6 = new Label();
            labelstudentname = new Label();
            label4 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            paneltop = new Panel();
            labelsearchclass = new Label();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            labelDate = new Label();
            labeldatetoday = new Label();
            label5 = new Label();
            labeltimenow = new Label();
            ExitPic = new PictureBox();
            label2 = new Label();
            labelsearchbydate = new Label();
            dateTimePicker1 = new DateTimePicker();
            comboBox1 = new ComboBox();
            buttonclear = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            labelwlcom = new Label();
            labelusername = new Label();
            labelrole = new Label();
            label11 = new Label();
            dataGridView2 = new DataGridView();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)lodoutpic).BeginInit();
            panelside.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel5.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ExitPic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(67, 3, 125);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(258, 738);
            panel1.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Teal;
            panel6.Controls.Add(lodoutpic);
            panel6.Controls.Add(button6);
            panel6.Controls.Add(button5);
            panel6.Controls.Add(button4);
            panel6.Controls.Add(button3);
            panel6.Controls.Add(button2);
            panel6.Controls.Add(panelside);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(0, 180);
            panel6.Name = "panel6";
            panel6.Size = new Size(258, 558);
            panel6.TabIndex = 6;
            // 
            // lodoutpic
            // 
            lodoutpic.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lodoutpic.Image = (Image)resources.GetObject("lodoutpic.Image");
            lodoutpic.Location = new Point(49, 455);
            lodoutpic.Name = "lodoutpic";
            lodoutpic.Size = new Size(125, 82);
            lodoutpic.SizeMode = PictureBoxSizeMode.Zoom;
            lodoutpic.TabIndex = 20;
            lodoutpic.TabStop = false;
            lodoutpic.Click += lodoutpic_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.Teal;
            button6.Dock = DockStyle.Top;
            button6.ForeColor = Color.White;
            button6.Location = new Point(0, 208);
            button6.Name = "button6";
            button6.Size = new Size(258, 52);
            button6.TabIndex = 10;
            button6.Text = "Print";
            button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.Teal;
            button5.Dock = DockStyle.Top;
            button5.ForeColor = Color.White;
            button5.Location = new Point(0, 156);
            button5.Name = "button5";
            button5.Size = new Size(258, 52);
            button5.TabIndex = 9;
            button5.Text = "Report";
            button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.Teal;
            button4.Dock = DockStyle.Top;
            button4.ForeColor = Color.White;
            button4.Location = new Point(0, 104);
            button4.Name = "button4";
            button4.Size = new Size(258, 52);
            button4.TabIndex = 8;
            button4.Text = "Arabic";
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Teal;
            button3.Dock = DockStyle.Top;
            button3.ForeColor = Color.White;
            button3.Location = new Point(0, 52);
            button3.Name = "button3";
            button3.Size = new Size(258, 52);
            button3.TabIndex = 7;
            button3.Text = "English";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Top;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(0, 0);
            button2.Name = "button2";
            button2.Size = new Size(258, 52);
            button2.TabIndex = 6;
            button2.Text = "Dashboard";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panelside
            // 
            panelside.BackColor = Color.White;
            panelside.Controls.Add(button1);
            panelside.Location = new Point(0, 0);
            panelside.Name = "panelside";
            panelside.Size = new Size(8, 47);
            panelside.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Teal;
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(panel5);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(258, 180);
            panel2.TabIndex = 0;
            panel2.Paint += panel2_Paint_2;
            // 
            // panel4
            // 
            panel4.Location = new Point(258, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(942, 165);
            panel4.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.Location = new Point(261, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(250, 125);
            panel3.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(32, 112);
            label1.Name = "label1";
            label1.Size = new Size(203, 25);
            label1.TabIndex = 1;
            label1.Text = "Student Attendance";
            label1.Click += label1_Click;
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
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel5.BackColor = Color.Teal;
            panel5.Controls.Add(label7);
            panel5.Controls.Add(label6);
            panel5.Controls.Add(labelstudentname);
            panel5.Controls.Add(label4);
            panel5.Location = new Point(258, 84);
            panel5.Name = "panel5";
            panel5.Size = new Size(1044, 125);
            panel5.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Teal;
            label7.ForeColor = Color.White;
            label7.Location = new Point(166, 80);
            label7.Name = "label7";
            label7.Size = new Size(87, 25);
            label7.TabIndex = 8;
            label7.Text = "Student";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Teal;
            label6.ForeColor = Color.White;
            label6.Location = new Point(67, 79);
            label6.Name = "label6";
            label6.Size = new Size(62, 25);
            label6.TabIndex = 7;
            label6.Text = "Role:";
            // 
            // labelstudentname
            // 
            labelstudentname.AutoSize = true;
            labelstudentname.BackColor = Color.Teal;
            labelstudentname.ForeColor = Color.White;
            labelstudentname.Location = new Point(200, 23);
            labelstudentname.Name = "labelstudentname";
            labelstudentname.Size = new Size(23, 25);
            labelstudentname.TabIndex = 6;
            labelstudentname.Text = "x";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Teal;
            label4.ForeColor = Color.White;
            label4.Location = new Point(50, 23);
            label4.Name = "label4";
            label4.Size = new Size(109, 25);
            label4.TabIndex = 5;
            label4.Text = "Welcome:";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.White;
            flowLayoutPanel1.Controls.Add(paneltop);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(258, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1042, 0);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // paneltop
            // 
            paneltop.BackColor = Color.FromArgb(67, 3, 125);
            paneltop.Dock = DockStyle.Bottom;
            paneltop.Location = new Point(3, 3);
            paneltop.Name = "paneltop";
            paneltop.Size = new Size(942, 165);
            paneltop.TabIndex = 0;
            // 
            // labelsearchclass
            // 
            labelsearchclass.AutoSize = true;
            labelsearchclass.BackColor = Color.White;
            labelsearchclass.Font = new Font("Century", 12F, FontStyle.Bold);
            labelsearchclass.Location = new Point(308, 307);
            labelsearchclass.Name = "labelsearchclass";
            labelsearchclass.Size = new Size(105, 23);
            labelsearchclass.TabIndex = 1;
            labelsearchclass.Text = "By Class ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(336, 35);
            label3.Name = "label3";
            label3.Size = new Size(0, 25);
            label3.TabIndex = 4;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1122, 635);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(166, 91);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelDate.Location = new Point(329, 13);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(73, 23);
            labelDate.TabIndex = 13;
            labelDate.Text = "Date :";
            // 
            // labeldatetoday
            // 
            labeldatetoday.AutoSize = true;
            labeldatetoday.Location = new Point(438, 11);
            labeldatetoday.Name = "labeldatetoday";
            labeldatetoday.Size = new Size(70, 25);
            labeldatetoday.TabIndex = 0;
            labeldatetoday.Text = "label5";
            labeldatetoday.Click += labeldatetoday_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century", 12F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ControlText;
            label5.Location = new Point(643, 13);
            label5.Name = "label5";
            label5.Size = new Size(68, 23);
            label5.TabIndex = 14;
            label5.Text = "Time:";
            label5.Click += label5_Click;
            // 
            // labeltimenow
            // 
            labeltimenow.AutoSize = true;
            labeltimenow.Location = new Point(748, 13);
            labeltimenow.Name = "labeltimenow";
            labeltimenow.Size = new Size(70, 25);
            labeltimenow.TabIndex = 15;
            labeltimenow.Text = "label8";
            labeltimenow.Click += labeltimenow_Click;
            // 
            // ExitPic
            // 
            ExitPic.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ExitPic.Image = (Image)resources.GetObject("ExitPic.Image");
            ExitPic.Location = new Point(1163, 7);
            ExitPic.Name = "ExitPic";
            ExitPic.Size = new Size(125, 62);
            ExitPic.SizeMode = PictureBoxSizeMode.Zoom;
            ExitPic.TabIndex = 16;
            ExitPic.TabStop = false;
            ExitPic.Click += ExitPic_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century", 12F, FontStyle.Bold);
            label2.ForeColor = Color.Teal;
            label2.Location = new Point(308, 246);
            label2.Name = "label2";
            label2.Size = new Size(94, 23);
            label2.TabIndex = 18;
            label2.Text = "Search :";
            // 
            // labelsearchbydate
            // 
            labelsearchbydate.AutoSize = true;
            labelsearchbydate.Font = new Font("Century", 12F, FontStyle.Bold);
            labelsearchbydate.Location = new Point(652, 307);
            labelsearchbydate.Name = "labelsearchbydate";
            labelsearchbydate.Size = new Size(59, 23);
            labelsearchbydate.TabIndex = 19;
            labelsearchbydate.Text = "Date";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            dateTimePicker1.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(748, 304);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(178, 32);
            dateTimePicker1.TabIndex = 20;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(419, 303);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 33);
            comboBox1.TabIndex = 21;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // buttonclear
            // 
            buttonclear.Location = new Point(962, 301);
            buttonclear.Name = "buttonclear";
            buttonclear.Size = new Size(94, 29);
            buttonclear.TabIndex = 22;
            buttonclear.Text = "clear";
            buttonclear.UseVisualStyleBackColor = true;
            buttonclear.Click += buttonclear_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // labelwlcom
            // 
            labelwlcom.AutoSize = true;
            labelwlcom.Font = new Font("Century", 15F, FontStyle.Bold);
            labelwlcom.ForeColor = Color.Teal;
            labelwlcom.Location = new Point(317, 112);
            labelwlcom.Name = "labelwlcom";
            labelwlcom.Size = new Size(126, 29);
            labelwlcom.TabIndex = 23;
            labelwlcom.Text = "Welcom :";
            // 
            // labelusername
            // 
            labelusername.AutoSize = true;
            labelusername.Font = new Font("Century", 15F, FontStyle.Bold);
            labelusername.Location = new Point(447, 112);
            labelusername.Name = "labelusername";
            labelusername.Size = new Size(27, 29);
            labelusername.TabIndex = 24;
            labelusername.Text = "x";
            labelusername.Click += labelusername_Click;
            // 
            // labelrole
            // 
            labelrole.AutoSize = true;
            labelrole.BackColor = Color.White;
            labelrole.Font = new Font("Century", 15F, FontStyle.Bold);
            labelrole.ForeColor = Color.Teal;
            labelrole.Location = new Point(667, 114);
            labelrole.Name = "labelrole";
            labelrole.Size = new Size(76, 29);
            labelrole.TabIndex = 25;
            labelrole.Text = "Role:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century", 15F, FontStyle.Bold);
            label11.Location = new Point(787, 114);
            label11.Name = "label11";
            label11.Size = new Size(113, 29);
            label11.TabIndex = 26;
            label11.Text = "Student";
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.BackgroundColor = Color.White;
            dataGridView2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Column4, Column5, Column6 });
            dataGridView2.Location = new Point(317, 375);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(760, 188);
            dataGridView2.TabIndex = 27;
            // 
            // Column4
            // 
            Column4.HeaderText = "Date";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.HeaderText = "Class";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.HeaderText = "Status";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // StudentDashBoard2
            // 
            AutoScaleDimensions = new SizeF(13F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1300, 738);
            Controls.Add(dataGridView2);
            Controls.Add(label11);
            Controls.Add(labelrole);
            Controls.Add(labelusername);
            Controls.Add(labelwlcom);
            Controls.Add(buttonclear);
            Controls.Add(comboBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(labelsearchbydate);
            Controls.Add(label2);
            Controls.Add(ExitPic);
            Controls.Add(labeltimenow);
            Controls.Add(label5);
            Controls.Add(labeldatetoday);
            Controls.Add(labelDate);
            Controls.Add(pictureBox2);
            Controls.Add(label3);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(labelsearchclass);
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
            Load += StudentDashBoard2_Load;
            panel1.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)lodoutpic).EndInit();
            panelside.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)ExitPic).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
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
        private Label labelsearchclass;
        private Panel panel4;
        private Panel panel3;
        private Panel panel5;
        private Label label3;
        private Label label4;
        private Label labelstudentname;
        private Label label6;
        private Label label7;
        private PictureBox pictureBox2;
        private Panel panel6;
        private Panel panelside;
        private Button button2;
        private Button button1;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Label labelDate;
        private Label labeldatetoday;
        private Label label5;
        private Label labeltimenow;
        private PictureBox ExitPic;
        private Label label2;
        private PictureBox lodoutpic;
        private Label labelsearchbydate;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox1;
        private Button buttonclear;
        private System.Windows.Forms.Timer timer1;
        private Label labelwlcom;
        private Label labelusername;
        private Label labelrole;
        private Label label11;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
    }
}