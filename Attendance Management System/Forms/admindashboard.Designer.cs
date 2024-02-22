namespace Attendance_Management_System
{
    partial class admindashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admindashboard));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            NoClassButton = new Button();
            NostudentsButton = new Button();
            NoTeacherButton = new Button();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            mostAbStTable = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mostAbStTable).BeginInit();
            SuspendLayout();
            // 
            // NoClassButton
            // 
            NoClassButton.BackColor = Color.PaleGoldenrod;
            NoClassButton.Cursor = Cursors.Hand;
            NoClassButton.FlatStyle = FlatStyle.Flat;
            NoClassButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            NoClassButton.ForeColor = SystemColors.ButtonHighlight;
            NoClassButton.Location = new Point(33, 93);
            NoClassButton.Margin = new Padding(4);
            NoClassButton.Name = "NoClassButton";
            NoClassButton.Size = new Size(424, 194);
            NoClassButton.TabIndex = 18;
            NoClassButton.Text = "33 class";
            NoClassButton.UseVisualStyleBackColor = false;
            // 
            // NostudentsButton
            // 
            NostudentsButton.BackColor = Color.DarkSeaGreen;
            NostudentsButton.Cursor = Cursors.Hand;
            NostudentsButton.FlatStyle = FlatStyle.Flat;
            NostudentsButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            NostudentsButton.ForeColor = SystemColors.ButtonHighlight;
            NostudentsButton.Location = new Point(948, 93);
            NostudentsButton.Margin = new Padding(4);
            NostudentsButton.Name = "NostudentsButton";
            NostudentsButton.Size = new Size(404, 194);
            NostudentsButton.TabIndex = 19;
            NostudentsButton.Text = "105 student";
            NostudentsButton.UseVisualStyleBackColor = false;
            // 
            // NoTeacherButton
            // 
            NoTeacherButton.BackColor = Color.Thistle;
            NoTeacherButton.Cursor = Cursors.Hand;
            NoTeacherButton.FlatStyle = FlatStyle.Flat;
            NoTeacherButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            NoTeacherButton.ForeColor = SystemColors.ButtonHighlight;
            NoTeacherButton.Location = new Point(476, 93);
            NoTeacherButton.Margin = new Padding(4);
            NoTeacherButton.Name = "NoTeacherButton";
            NoTeacherButton.Size = new Size(444, 194);
            NoTeacherButton.TabIndex = 17;
            NoTeacherButton.Text = "10 teachers";
            NoTeacherButton.UseVisualStyleBackColor = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.None;
            pictureBox3.BackColor = Color.DarkSeaGreen;
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(950, 114);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(119, 148);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 22;
            pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackColor = Color.PaleGoldenrod;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(42, 103);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(127, 159);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.BackColor = Color.Thistle;
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(480, 124);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(133, 122);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 24;
            pictureBox2.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.SlateGray;
            flowLayoutPanel1.Location = new Point(4, 405);
            flowLayoutPanel1.Margin = new Padding(4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1769, 10);
            flowLayoutPanel1.TabIndex = 25;
            // 
            // mostAbStTable
            // 
            mostAbStTable.BackgroundColor = Color.White;
            mostAbStTable.BorderStyle = BorderStyle.None;
            mostAbStTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            mostAbStTable.Location = new Point(87, 454);
            mostAbStTable.MinimumSize = new Size(1000, 500);
            mostAbStTable.Name = "mostAbStTable";
            mostAbStTable.ReadOnly = true;
            mostAbStTable.RowHeadersWidth = 62;
            dataGridViewCellStyle1.BackColor = Color.AliceBlue;
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(0, 0, 64);
            dataGridViewCellStyle1.SelectionBackColor = Color.SkyBlue;
            mostAbStTable.RowsDefaultCellStyle = dataGridViewCellStyle1;
            mostAbStTable.Size = new Size(1265, 500);
            mostAbStTable.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(33, 339);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(236, 45);
            label1.TabIndex = 21;
            label1.Text = "Need Warning";
            // 
            // admindashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            Controls.Add(flowLayoutPanel1);
            Controls.Add(pictureBox2);
            Controls.Add(mostAbStTable);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox3);
            Controls.Add(label1);
            Controls.Add(NoTeacherButton);
            Controls.Add(NostudentsButton);
            Controls.Add(NoClassButton);
            Name = "admindashboard";
            Size = new Size(1400, 947);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)mostAbStTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Button NoClassButton;
        public Button NostudentsButton;
        public Button NoTeacherButton;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private FlowLayoutPanel flowLayoutPanel1;
        private DataGridView mostAbStTable;
        private Label label1;
    }
}
