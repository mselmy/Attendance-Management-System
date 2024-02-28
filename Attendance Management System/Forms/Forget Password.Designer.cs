namespace Attendance_Management_System
{
    partial class FormForgetPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormForgetPassword));
            panel1 = new Panel();
            panel2 = new Panel();
            label10 = new Label();
            buttonVerify = new Button();
            textBoxEmail = new TextBox();
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
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(buttonVerify);
            panel1.Controls.Add(textBoxEmail);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(pictureBox2);
            panel1.Name = "panel1";
            toolTip1.SetToolTip(panel1, resources.GetString("panel1.ToolTip"));
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
            label10.Name = "label10";
            toolTip1.SetToolTip(label10, resources.GetString("label10.ToolTip"));
            // 
            // buttonVerify
            // 
            resources.ApplyResources(buttonVerify, "buttonVerify");
            buttonVerify.BackColor = Color.FromArgb(128, 128, 255);
            buttonVerify.Cursor = Cursors.Hand;
            buttonVerify.FlatAppearance.BorderSize = 0;
            buttonVerify.ForeColor = Color.White;
            buttonVerify.Name = "buttonVerify";
            toolTip1.SetToolTip(buttonVerify, resources.GetString("buttonVerify.ToolTip"));
            buttonVerify.UseVisualStyleBackColor = false;
            buttonVerify.Click += buttonVerify_Click;
            // 
            // textBoxEmail
            // 
            resources.ApplyResources(textBoxEmail, "textBoxEmail");
            textBoxEmail.BorderStyle = BorderStyle.None;
            textBoxEmail.ForeColor = Color.DarkGray;
            textBoxEmail.Name = "textBoxEmail";
            toolTip1.SetToolTip(textBoxEmail, resources.GetString("textBoxEmail.ToolTip"));
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
            pictureBox2.MouseHover += pictureBox2_MouseHover;
            // 
            // FormForgetPassword
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormForgetPassword";
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
        private Button buttonVerify;
        private TextBox textBoxEmail;
        private Panel panel2;
        private ToolTip toolTip1;
    }
}