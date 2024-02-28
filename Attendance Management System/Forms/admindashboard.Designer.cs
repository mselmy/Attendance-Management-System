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
            warningtextbox = new TextBox();
            panel13 = new Panel();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mostAbStTable).BeginInit();
            SuspendLayout();
            // 
            // NoClassButton
            // 
            resources.ApplyResources(NoClassButton, "NoClassButton");
            NoClassButton.BackColor = Color.PaleGoldenrod;
            NoClassButton.Cursor = Cursors.Hand;
            NoClassButton.ForeColor = SystemColors.ButtonHighlight;
            NoClassButton.Name = "NoClassButton";
            NoClassButton.UseVisualStyleBackColor = false;
            // 
            // NostudentsButton
            // 
            resources.ApplyResources(NostudentsButton, "NostudentsButton");
            NostudentsButton.BackColor = Color.DarkSeaGreen;
            NostudentsButton.Cursor = Cursors.Hand;
            NostudentsButton.ForeColor = SystemColors.ButtonHighlight;
            NostudentsButton.Name = "NostudentsButton";
            NostudentsButton.UseVisualStyleBackColor = false;
            // 
            // NoTeacherButton
            // 
            resources.ApplyResources(NoTeacherButton, "NoTeacherButton");
            NoTeacherButton.BackColor = Color.Thistle;
            NoTeacherButton.Cursor = Cursors.Hand;
            NoTeacherButton.ForeColor = SystemColors.ButtonHighlight;
            NoTeacherButton.Name = "NoTeacherButton";
            NoTeacherButton.UseVisualStyleBackColor = false;
            // 
            // pictureBox3
            // 
            resources.ApplyResources(pictureBox3, "pictureBox3");
            pictureBox3.BackColor = Color.DarkSeaGreen;
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Name = "pictureBox3";
            pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.BackColor = Color.PaleGoldenrod;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            resources.ApplyResources(pictureBox2, "pictureBox2");
            pictureBox2.BackColor = Color.Thistle;
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Name = "pictureBox2";
            pictureBox2.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            resources.ApplyResources(flowLayoutPanel1, "flowLayoutPanel1");
            flowLayoutPanel1.BackColor = Color.SlateGray;
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // mostAbStTable
            // 
            resources.ApplyResources(mostAbStTable, "mostAbStTable");
            mostAbStTable.BackgroundColor = Color.White;
            mostAbStTable.BorderStyle = BorderStyle.None;
            mostAbStTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            mostAbStTable.Name = "mostAbStTable";
            mostAbStTable.ReadOnly = true;
            dataGridViewCellStyle1.BackColor = Color.AliceBlue;
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(0, 0, 64);
            dataGridViewCellStyle1.SelectionBackColor = Color.SkyBlue;
            mostAbStTable.RowsDefaultCellStyle = dataGridViewCellStyle1;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.BackColor = Color.White;
            label1.ForeColor = Color.DarkRed;
            label1.Name = "label1";
            // 
            // warningtextbox
            // 
            resources.ApplyResources(warningtextbox, "warningtextbox");
            warningtextbox.BorderStyle = BorderStyle.None;
            warningtextbox.Name = "warningtextbox";
            warningtextbox.TextChanged += warningtextbox_TextChanged;
            // 
            // panel13
            // 
            resources.ApplyResources(panel13, "panel13");
            panel13.BackColor = Color.Goldenrod;
            panel13.Name = "panel13";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.ForeColor = Color.SlateGray;
            label2.Name = "label2";
            // 
            // admindashboard
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            Controls.Add(label2);
            Controls.Add(panel13);
            Controls.Add(warningtextbox);
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
        private TextBox warningtextbox;
        private Panel panel13;
        private Label label2;
    }
}
