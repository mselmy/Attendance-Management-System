namespace File_Management_Class.Forms
{
    partial class Student
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student));
            panel1 = new Panel();
            label_Time = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            label_username = new Label();
            label_date = new Label();
            pictureBox2 = new PictureBox();
            dataGridView1 = new DataGridView();
            label3_studentName = new Label();
            pictureBox1 = new PictureBox();
            label_titl = new Label();
            label2 = new Label();
            toolStripSplitButton1 = new ToolStripSplitButton();
            languageToolStripMenuItem = new ToolStripMenuItem();
            englishToolStripMenuItem = new ToolStripMenuItem();
            arabicToolStripMenuItem = new ToolStripMenuItem();
            dateFormateToolStripMenuItem = new ToolStripMenuItem();
            dDMMYYYYToolStripMenuItem = new ToolStripMenuItem();
            yYYMMDDToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            saveToolStripButton = new ToolStripButton();
            printToolStripButton = new ToolStripButton();
            toolStripSeparator = new ToolStripSeparator();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripButton1 = new ToolStripButton();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.BackColor = Color.Teal;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label_Time);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label_username);
            panel1.Controls.Add(label_date);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(label3_studentName);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label_titl);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1122, 562);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label_Time
            // 
            label_Time.AutoSize = true;
            label_Time.BackColor = Color.White;
            label_Time.Location = new Point(413, 153);
            label_Time.Name = "label_Time";
            label_Time.Size = new Size(50, 25);
            label_Time.TabIndex = 18;
            label_Time.Text = "{y}";
            label_Time.Click += label_Time_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(73, 25);
            label5.TabIndex = 17;
            label5.Text = "label5";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(73, 25);
            label4.TabIndex = 16;
            label4.Text = "label4";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(73, 25);
            label3.TabIndex = 15;
            label3.Text = "label3";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Teal;
            label1.Cursor = Cursors.AppStarting;
            label1.ForeColor = Color.White;
            label1.Location = new Point(413, 103);
            label1.Name = "label1";
            label1.Size = new Size(61, 25);
            label1.TabIndex = 14;
            label1.Text = "Time";
            // 
            // label_username
            // 
            label_username.BackColor = Color.White;
            label_username.FlatStyle = FlatStyle.Popup;
            label_username.Location = new Point(32, 153);
            label_username.Name = "label_username";
            label_username.Size = new Size(138, 25);
            label_username.TabIndex = 13;
            label_username.Text = "y";
            // 
            // label_date
            // 
            label_date.BackColor = Color.White;
            label_date.Location = new Point(233, 153);
            label_date.Name = "label_date";
            label_date.Size = new Size(146, 25);
            label_date.TabIndex = 12;
            label_date.Text = "x";
            label_date.Click += label1_Click_2;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Teal;
            pictureBox2.ErrorImage = (Image)resources.GetObject("pictureBox2.ErrorImage");
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.InitialImage = (Image)resources.GetObject("pictureBox2.InitialImage");
            pictureBox2.Location = new Point(650, 467);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(78, 62);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click_2;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(21, 225);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(465, 304);
            dataGridView1.TabIndex = 8;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label3_studentName
            // 
            label3_studentName.AutoSize = true;
            label3_studentName.BackColor = Color.Teal;
            label3_studentName.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3_studentName.ForeColor = Color.White;
            label3_studentName.Location = new Point(21, 103);
            label3_studentName.Name = "label3_studentName";
            label3_studentName.Size = new Size(164, 25);
            label3_studentName.TabIndex = 4;
            label3_studentName.Text = "Student Name ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(547, 41);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(201, 154);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label_titl
            // 
            label_titl.AutoSize = true;
            label_titl.BackColor = Color.Teal;
            label_titl.BorderStyle = BorderStyle.Fixed3D;
            label_titl.Font = new Font("Verdana", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label_titl.ForeColor = Color.White;
            label_titl.Location = new Point(165, 41);
            label_titl.Name = "label_titl";
            label_titl.Size = new Size(291, 31);
            label_titl.TabIndex = 0;
            label_titl.Text = "Student  Attendance";
            label_titl.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Teal;
            label2.ForeColor = Color.White;
            label2.Location = new Point(234, 103);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 3;
            label2.Text = "Date";
            // 
            // toolStripSplitButton1
            // 
            toolStripSplitButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripSplitButton1.DropDownItems.AddRange(new ToolStripItem[] { languageToolStripMenuItem, dateFormateToolStripMenuItem });
            toolStripSplitButton1.Image = (Image)resources.GetObject("toolStripSplitButton1.Image");
            toolStripSplitButton1.ImageTransparentColor = Color.Magenta;
            toolStripSplitButton1.Name = "toolStripSplitButton1";
            toolStripSplitButton1.Size = new Size(39, 24);
            toolStripSplitButton1.Text = "toolStripSplitButton1";
            // 
            // languageToolStripMenuItem
            // 
            languageToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { englishToolStripMenuItem, arabicToolStripMenuItem });
            languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            languageToolStripMenuItem.Size = new Size(183, 26);
            languageToolStripMenuItem.Text = "Language";
            // 
            // englishToolStripMenuItem
            // 
            englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            englishToolStripMenuItem.Size = new Size(139, 26);
            englishToolStripMenuItem.Text = "English";
            // 
            // arabicToolStripMenuItem
            // 
            arabicToolStripMenuItem.Name = "arabicToolStripMenuItem";
            arabicToolStripMenuItem.Size = new Size(139, 26);
            arabicToolStripMenuItem.Text = "Arabic";
            // 
            // dateFormateToolStripMenuItem
            // 
            dateFormateToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dDMMYYYYToolStripMenuItem, yYYMMDDToolStripMenuItem });
            dateFormateToolStripMenuItem.Name = "dateFormateToolStripMenuItem";
            dateFormateToolStripMenuItem.Size = new Size(183, 26);
            dateFormateToolStripMenuItem.Text = "Date Formate";
            // 
            // dDMMYYYYToolStripMenuItem
            // 
            dDMMYYYYToolStripMenuItem.Name = "dDMMYYYYToolStripMenuItem";
            dDMMYYYYToolStripMenuItem.Size = new Size(184, 26);
            dDMMYYYYToolStripMenuItem.Text = "DD/MM/YYYY";
            // 
            // yYYMMDDToolStripMenuItem
            // 
            yYYMMDDToolStripMenuItem.Name = "yYYMMDDToolStripMenuItem";
            yYYMMDDToolStripMenuItem.Size = new Size(184, 26);
            yYYMMDDToolStripMenuItem.Text = "YYYY/MM/DD";
            // 
            // toolStrip1
            // 
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripSplitButton1, saveToolStripButton, printToolStripButton, toolStripSeparator, toolStripSeparator1, toolStripButton1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1122, 27);
            toolStrip1.TabIndex = 6;
            toolStrip1.Text = "toolStrip1";
            // 
            // saveToolStripButton
            // 
            saveToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            saveToolStripButton.Image = (Image)resources.GetObject("saveToolStripButton.Image");
            saveToolStripButton.ImageTransparentColor = Color.Magenta;
            saveToolStripButton.Name = "saveToolStripButton";
            saveToolStripButton.Size = new Size(29, 24);
            saveToolStripButton.Text = "&Save";
            // 
            // printToolStripButton
            // 
            printToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            printToolStripButton.Image = (Image)resources.GetObject("printToolStripButton.Image");
            printToolStripButton.ImageTransparentColor = Color.Magenta;
            printToolStripButton.Name = "printToolStripButton";
            printToolStripButton.Size = new Size(29, 24);
            printToolStripButton.Text = "&Print";
            // 
            // toolStripSeparator
            // 
            toolStripSeparator.Name = "toolStripSeparator";
            toolStripSeparator.Size = new Size(6, 27);
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 27);
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(29, 24);
            toolStripButton1.Text = "toolStripButton1";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Student
            // 
            AutoScaleDimensions = new SizeF(13F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1122, 562);
            Controls.Add(toolStrip1);
            Controls.Add(panel1);
            Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Student";
            Text = "Student";
            Load += Student_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label_titl;
        private Label label2;
        private Label label3_studentName;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private ToolStripSplitButton toolStripSplitButton1;
        private ToolStripMenuItem languageToolStripMenuItem;
        private ToolStripMenuItem englishToolStripMenuItem;
        private ToolStripMenuItem arabicToolStripMenuItem;
        private ToolStripMenuItem dateFormateToolStripMenuItem;
        private ToolStripMenuItem dDMMYYYYToolStripMenuItem;
        private ToolStripMenuItem yYYMMDDToolStripMenuItem;
        private ToolStrip toolStrip1;
        private DataGridView dataGridView1;
        private ToolStripButton toolStripButton1;
        private PictureBox pictureBox2;
        private Label label_date;
        private ToolStripButton saveToolStripButton;
        private ToolStripButton printToolStripButton;
        private ToolStripSeparator toolStripSeparator;
        private ToolStripSeparator toolStripSeparator1;
        private Label label_username;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label_Time;
        private Label label5;
        private System.Windows.Forms.Timer timer1;
    }
}