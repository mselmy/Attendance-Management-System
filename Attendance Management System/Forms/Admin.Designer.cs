namespace Attendance_Management_System
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            panel1 = new Panel();
            DeleteButton = new Button();
            EditButton = new Button();
            pictureBox1 = new PictureBox();
            loadButton = new Button();
            saveButton = new Button();
            searchButton = new Button();
            logoutButton = new Button();
            ExitButton = new Button();
            attendenceReportButton = new Button();
            AddButton = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            adminDashboard = new GroupBox();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            mostAbStTable = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            namestudent = new DataGridViewTextBoxColumn();
            Class = new DataGridViewTextBoxColumn();
            Noabsent = new DataGridViewTextBoxColumn();
            flowLayoutPanel2 = new FlowLayoutPanel();
            label1 = new Label();
            title1label = new Label();
            title2label = new Label();
            pictureBox2 = new PictureBox();
            nameLabel = new Label();
            admindashboard1 = new admindashboard();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            adminDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mostAbStTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SlateGray;
            panel1.Controls.Add(DeleteButton);
            panel1.Controls.Add(EditButton);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(loadButton);
            panel1.Controls.Add(saveButton);
            panel1.Controls.Add(searchButton);
            panel1.Controls.Add(logoutButton);
            panel1.Controls.Add(ExitButton);
            panel1.Controls.Add(attendenceReportButton);
            panel1.Controls.Add(AddButton);
            panel1.Location = new Point(0, -16);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(322, 1279);
            panel1.TabIndex = 1;
            // 
            // DeleteButton
            // 
            DeleteButton.BackColor = Color.SlateGray;
            DeleteButton.Cursor = Cursors.Hand;
            DeleteButton.FlatStyle = FlatStyle.Flat;
            DeleteButton.Location = new Point(0, 684);
            DeleteButton.Margin = new Padding(4);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(322, 89);
            DeleteButton.TabIndex = 13;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = false;
            // 
            // EditButton
            // 
            EditButton.BackColor = Color.SlateGray;
            EditButton.Cursor = Cursors.Hand;
            EditButton.FlatStyle = FlatStyle.Flat;
            EditButton.Location = new Point(0, 596);
            EditButton.Margin = new Padding(4);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(322, 89);
            EditButton.TabIndex = 12;
            EditButton.Text = "Edit";
            EditButton.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackColor = Color.SlateGray;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(0, 14);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(322, 161);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // loadButton
            // 
            loadButton.BackColor = Color.SlateGray;
            loadButton.Cursor = Cursors.Hand;
            loadButton.FlatStyle = FlatStyle.Flat;
            loadButton.Location = new Point(0, 421);
            loadButton.Margin = new Padding(4);
            loadButton.Name = "loadButton";
            loadButton.Size = new Size(322, 89);
            loadButton.TabIndex = 11;
            loadButton.Text = "load";
            loadButton.UseVisualStyleBackColor = false;
            // 
            // saveButton
            // 
            saveButton.BackColor = Color.SlateGray;
            saveButton.Cursor = Cursors.Hand;
            saveButton.FlatStyle = FlatStyle.Flat;
            saveButton.Location = new Point(0, 334);
            saveButton.Margin = new Padding(4);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(322, 89);
            saveButton.TabIndex = 4;
            saveButton.Text = "save";
            saveButton.UseVisualStyleBackColor = false;
            // 
            // searchButton
            // 
            searchButton.BackColor = Color.SlateGray;
            searchButton.Cursor = Cursors.Hand;
            searchButton.FlatStyle = FlatStyle.Flat;
            searchButton.Location = new Point(0, 247);
            searchButton.Margin = new Padding(4);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(322, 89);
            searchButton.TabIndex = 9;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = false;
            // 
            // logoutButton
            // 
            logoutButton.BackColor = Color.SlateGray;
            logoutButton.Cursor = Cursors.Hand;
            logoutButton.FlatAppearance.BorderSize = 0;
            logoutButton.FlatStyle = FlatStyle.Flat;
            logoutButton.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            logoutButton.ForeColor = SystemColors.ButtonHighlight;
            logoutButton.Location = new Point(0, 860);
            logoutButton.Margin = new Padding(4);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(322, 89);
            logoutButton.TabIndex = 8;
            logoutButton.Text = "Log out";
            logoutButton.UseVisualStyleBackColor = false;
            // 
            // ExitButton
            // 
            ExitButton.BackColor = Color.SlateGray;
            ExitButton.Cursor = Cursors.Hand;
            ExitButton.FlatStyle = FlatStyle.Flat;
            ExitButton.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            ExitButton.ForeColor = SystemColors.ButtonHighlight;
            ExitButton.Location = new Point(0, 771);
            ExitButton.Margin = new Padding(4);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(322, 89);
            ExitButton.TabIndex = 7;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = false;
            // 
            // attendenceReportButton
            // 
            attendenceReportButton.BackColor = Color.SlateGray;
            attendenceReportButton.Cursor = Cursors.Hand;
            attendenceReportButton.FlatStyle = FlatStyle.Flat;
            attendenceReportButton.Location = new Point(0, 508);
            attendenceReportButton.Margin = new Padding(4);
            attendenceReportButton.Name = "attendenceReportButton";
            attendenceReportButton.Size = new Size(322, 89);
            attendenceReportButton.TabIndex = 6;
            attendenceReportButton.Text = "Attendence report";
            attendenceReportButton.UseVisualStyleBackColor = false;
            // 
            // AddButton
            // 
            AddButton.BackColor = Color.SlateGray;
            AddButton.Cursor = Cursors.Hand;
            AddButton.FlatAppearance.BorderSize = 0;
            AddButton.FlatStyle = FlatStyle.Flat;
            AddButton.Location = new Point(0, 179);
            AddButton.Margin = new Padding(4);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(322, 89);
            AddButton.TabIndex = 3;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.SlateGray;
            flowLayoutPanel1.Controls.Add(adminDashboard);
            flowLayoutPanel1.Location = new Point(322, 65);
            flowLayoutPanel1.Margin = new Padding(4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1988, 10);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // adminDashboard
            // 
            adminDashboard.Controls.Add(pictureBox5);
            adminDashboard.Controls.Add(pictureBox4);
            adminDashboard.Controls.Add(pictureBox3);
            adminDashboard.Controls.Add(mostAbStTable);
            adminDashboard.Controls.Add(flowLayoutPanel2);
            adminDashboard.Controls.Add(label1);
            adminDashboard.Location = new Point(3, 3);
            adminDashboard.Name = "adminDashboard";
            adminDashboard.Size = new Size(1601, 973);
            adminDashboard.TabIndex = 22;
            adminDashboard.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox5.BackColor = Color.Thistle;
            pictureBox5.Cursor = Cursors.Hand;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(659, 137);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(87, 92);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 24;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox4.BackColor = Color.DarkSeaGreen;
            pictureBox4.Cursor = Cursors.Hand;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(1143, 137);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(80, 92);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 23;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox3.BackColor = Color.PaleGoldenrod;
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(168, 137);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(90, 92);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 22;
            pictureBox3.TabStop = false;
            // 
            // mostAbStTable
            // 
            mostAbStTable.BackgroundColor = SystemColors.GradientInactiveCaption;
            mostAbStTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            mostAbStTable.Columns.AddRange(new DataGridViewColumn[] { ID, namestudent, Class, Noabsent });
            mostAbStTable.Location = new Point(150, 451);
            mostAbStTable.Name = "mostAbStTable";
            mostAbStTable.RowHeadersWidth = 62;
            mostAbStTable.Size = new Size(1266, 234);
            mostAbStTable.TabIndex = 20;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 8;
            ID.Name = "ID";
            ID.Width = 300;
            // 
            // namestudent
            // 
            namestudent.HeaderText = "Name";
            namestudent.MinimumWidth = 8;
            namestudent.Name = "namestudent";
            namestudent.Width = 300;
            // 
            // Class
            // 
            Class.HeaderText = "Class";
            Class.MinimumWidth = 8;
            Class.Name = "Class";
            Class.Width = 300;
            // 
            // Noabsent
            // 
            Noabsent.HeaderText = "No Absent";
            Noabsent.MinimumWidth = 8;
            Noabsent.Name = "Noabsent";
            Noabsent.Width = 300;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BackColor = Color.SlateGray;
            flowLayoutPanel2.Location = new Point(0, 416);
            flowLayoutPanel2.Margin = new Padding(4);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(1988, 10);
            flowLayoutPanel2.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(5, 367);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(236, 45);
            label1.TabIndex = 21;
            label1.Text = "Need Warning";
            // 
            // title1label
            // 
            title1label.AutoSize = true;
            title1label.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            title1label.ForeColor = Color.Goldenrod;
            title1label.Location = new Point(326, -2);
            title1label.Margin = new Padding(0);
            title1label.Name = "title1label";
            title1label.Size = new Size(263, 60);
            title1label.TabIndex = 15;
            title1label.Text = "Attendence";
            // 
            // title2label
            // 
            title2label.AutoSize = true;
            title2label.BackColor = Color.White;
            title2label.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            title2label.ForeColor = Color.SlateGray;
            title2label.Location = new Point(575, -2);
            title2label.Margin = new Padding(0);
            title2label.Name = "title2label";
            title2label.Size = new Size(461, 60);
            title2label.TabIndex = 14;
            title2label.Text = "Management System";
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1835, 14);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(77, 54);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.BackColor = Color.White;
            nameLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nameLabel.ForeColor = Color.SlateGray;
            nameLabel.Location = new Point(1730, 23);
            nameLabel.Margin = new Padding(0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(103, 38);
            nameLabel.TabIndex = 16;
            nameLabel.Text = "Nayira";
            // 
            // admindashboard1
            // 
            admindashboard1.BackColor = SystemColors.ButtonHighlight;
            admindashboard1.Location = new Point(442, 104);
            admindashboard1.Name = "admindashboard1";
            admindashboard1.Size = new Size(1410, 943);
            admindashboard1.TabIndex = 17;
            admindashboard1.VisibleChanged += admindashboard1_VisibleChanged;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(13F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1924, 1050);
            Controls.Add(admindashboard1);
            Controls.Add(nameLabel);
            Controls.Add(title2label);
            Controls.Add(title1label);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            Controls.Add(pictureBox2);
            Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            ForeColor = SystemColors.ButtonHighlight;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5);
            Name = "Admin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Search";
            WindowState = FormWindowState.Maximized;
            Load += Admin_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            adminDashboard.ResumeLayout(false);
            adminDashboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)mostAbStTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button AddButton;
        private Button loadButton;
        private Button saveButton;
        private Button searchButton;
        private Button logoutButton;
        private Button ExitButton;
        private Button attendenceReportButton;
        private PictureBox pictureBox1;
        private Label title2label;
        private Label title1label;
        private PictureBox pictureBox2;
        private Label nameLabel;
        private Button EditButton;
        private Button DeleteButton;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel2;
        private DataGridView mostAbStTable;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn namestudent;
        private DataGridViewTextBoxColumn Class;
        private DataGridViewTextBoxColumn Noabsent;
        private GroupBox adminDashboard;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private admindashboard admindashboard1;
    }
}