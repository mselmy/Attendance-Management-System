namespace Attendance_Management_System
{
    partial class Setting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Setting));
            panel1 = new Panel();
            DateFormatecomboBox = new ComboBox();
            panel3 = new Panel();
            label1 = new Label();
            LanguageComboBox = new ComboBox();
            panel2 = new Panel();
            label10 = new Label();
            SaveChangesbutton = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            toolTip1 = new ToolTip(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            resources.ApplyResources(panel1, "panel1");
            panel1.BackColor = Color.White;
            panel1.Controls.Add(DateFormatecomboBox);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(LanguageComboBox);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(SaveChangesbutton);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(pictureBox2);
            panel1.Name = "panel1";
            toolTip1.SetToolTip(panel1, resources.GetString("panel1.ToolTip"));
            // 
            // DateFormatecomboBox
            // 
            resources.ApplyResources(DateFormatecomboBox, "DateFormatecomboBox");
            DateFormatecomboBox.FormattingEnabled = true;
            DateFormatecomboBox.Items.AddRange(new object[] { resources.GetString("DateFormatecomboBox.Items"), resources.GetString("DateFormatecomboBox.Items1") });
            DateFormatecomboBox.Name = "DateFormatecomboBox";
            toolTip1.SetToolTip(DateFormatecomboBox, resources.GetString("DateFormatecomboBox.ToolTip"));
            // 
            // panel3
            // 
            resources.ApplyResources(panel3, "panel3");
            panel3.BackColor = Color.DarkGray;
            panel3.Name = "panel3";
            toolTip1.SetToolTip(panel3, resources.GetString("panel3.ToolTip"));
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.AllowDrop = true;
            label1.Name = "label1";
            toolTip1.SetToolTip(label1, resources.GetString("label1.ToolTip"));
            // 
            // LanguageComboBox
            // 
            resources.ApplyResources(LanguageComboBox, "LanguageComboBox");
            LanguageComboBox.FormattingEnabled = true;
            LanguageComboBox.Items.AddRange(new object[] { resources.GetString("LanguageComboBox.Items"), resources.GetString("LanguageComboBox.Items1") });
            LanguageComboBox.Name = "LanguageComboBox";
            toolTip1.SetToolTip(LanguageComboBox, resources.GetString("LanguageComboBox.ToolTip"));
            // 
            // panel2
            // 
            resources.ApplyResources(panel2, "panel2");
            panel2.BackColor = Color.DarkGray;
            panel2.Name = "panel2";
            toolTip1.SetToolTip(panel2, resources.GetString("panel2.ToolTip"));
            // 
            // label10
            // 
            resources.ApplyResources(label10, "label10");
            label10.AllowDrop = true;
            label10.Name = "label10";
            toolTip1.SetToolTip(label10, resources.GetString("label10.ToolTip"));
            // 
            // SaveChangesbutton
            // 
            resources.ApplyResources(SaveChangesbutton, "SaveChangesbutton");
            SaveChangesbutton.BackColor = Color.SlateGray;
            SaveChangesbutton.Cursor = Cursors.Hand;
            SaveChangesbutton.FlatAppearance.BorderSize = 0;
            SaveChangesbutton.ForeColor = Color.White;
            SaveChangesbutton.Name = "SaveChangesbutton";
            toolTip1.SetToolTip(SaveChangesbutton, resources.GetString("SaveChangesbutton.ToolTip"));
            SaveChangesbutton.UseVisualStyleBackColor = false;
            SaveChangesbutton.Click += SaveChangesbutton_Click;
            // 
            // pictureBox1
            // 
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            toolTip1.SetToolTip(pictureBox1, resources.GetString("pictureBox1.ToolTip"));
            // 
            // pictureBox2
            // 
            resources.ApplyResources(pictureBox2, "pictureBox2");
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Name = "pictureBox2";
            pictureBox2.TabStop = false;
            toolTip1.SetToolTip(pictureBox2, resources.GetString("pictureBox2.ToolTip"));
            pictureBox2.Click += click_Exit;
            // 
            // Setting
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Setting";
            ShowIcon = false;
            ShowInTaskbar = false;
            toolTip1.SetToolTip(this, resources.GetString("$this.ToolTip"));
            Click += click_Exit;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label10;
        private Button SaveChangesbutton;
        private Panel panel2;
        private ToolTip toolTip1;
        private ComboBox LanguageComboBox;
        private ComboBox DateFormatecomboBox;
        private Panel panel3;
        private Label label1;
    }
}