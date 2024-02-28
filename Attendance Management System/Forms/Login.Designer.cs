namespace Attendance_Management_System
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label4 = new Label();
            groupBox3 = new GroupBox();
            pictureBoxInvisible = new PictureBox();
            labelErrorMessage = new Label();
            pictureBoxErrorMessage = new PictureBox();
            pictureBoxVisible = new PictureBox();
            linkLabel3 = new LinkLabel();
            label9 = new Label();
            label10 = new Label();
            buttonLogin = new Button();
            textBoxEmail = new TextBox();
            textBoxPassword = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxInvisible).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxErrorMessage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxVisible).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            resources.ApplyResources(pictureBox2, "pictureBox2");
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Name = "pictureBox2";
            pictureBox2.TabStop = false;
            pictureBox2.Click += Exit;
            // 
            // pictureBox3
            // 
            resources.ApplyResources(pictureBox3, "pictureBox3");
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Name = "pictureBox3";
            pictureBox3.TabStop = false;
            pictureBox3.Click += Minimize;
            // 
            // pictureBox1
            // 
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel1
            // 
            resources.ApplyResources(panel1, "panel1");
            panel1.BackColor = SystemColors.Control;
            panel1.Name = "panel1";
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.ForeColor = Color.FromArgb(128, 128, 255);
            label4.Name = "label4";
            label4.Click += label4_Click;
            // 
            // groupBox3
            // 
            resources.ApplyResources(groupBox3, "groupBox3");
            groupBox3.Controls.Add(pictureBoxInvisible);
            groupBox3.Controls.Add(labelErrorMessage);
            groupBox3.Controls.Add(pictureBoxErrorMessage);
            groupBox3.Controls.Add(pictureBoxVisible);
            groupBox3.Controls.Add(linkLabel3);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(buttonLogin);
            groupBox3.Controls.Add(textBoxEmail);
            groupBox3.Controls.Add(textBoxPassword);
            groupBox3.Name = "groupBox3";
            groupBox3.TabStop = false;
            // 
            // pictureBoxInvisible
            // 
            resources.ApplyResources(pictureBoxInvisible, "pictureBoxInvisible");
            pictureBoxInvisible.Cursor = Cursors.Hand;
            pictureBoxInvisible.Name = "pictureBoxInvisible";
            pictureBoxInvisible.TabStop = false;
            pictureBoxInvisible.Click += ShowPassword;
            // 
            // labelErrorMessage
            // 
            resources.ApplyResources(labelErrorMessage, "labelErrorMessage");
            labelErrorMessage.ForeColor = Color.FromArgb(192, 0, 0);
            labelErrorMessage.Name = "labelErrorMessage";
            // 
            // pictureBoxErrorMessage
            // 
            resources.ApplyResources(pictureBoxErrorMessage, "pictureBoxErrorMessage");
            pictureBoxErrorMessage.Name = "pictureBoxErrorMessage";
            pictureBoxErrorMessage.TabStop = false;
            // 
            // pictureBoxVisible
            // 
            resources.ApplyResources(pictureBoxVisible, "pictureBoxVisible");
            pictureBoxVisible.Cursor = Cursors.Hand;
            pictureBoxVisible.Name = "pictureBoxVisible";
            pictureBoxVisible.TabStop = false;
            pictureBoxVisible.Click += HidePassword;
            // 
            // linkLabel3
            // 
            resources.ApplyResources(linkLabel3, "linkLabel3");
            linkLabel3.LinkColor = Color.FromArgb(128, 128, 255);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.TabStop = true;
            linkLabel3.Click += click_forgetPassword;
            // 
            // label9
            // 
            resources.ApplyResources(label9, "label9");
            label9.Name = "label9";
            // 
            // label10
            // 
            resources.ApplyResources(label10, "label10");
            label10.Name = "label10";
            // 
            // buttonLogin
            // 
            resources.ApplyResources(buttonLogin, "buttonLogin");
            buttonLogin.BackColor = Color.FromArgb(128, 128, 255);
            buttonLogin.Cursor = Cursors.Hand;
            buttonLogin.FlatAppearance.BorderSize = 0;
            buttonLogin.ForeColor = Color.White;
            buttonLogin.Name = "buttonLogin";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += click_Login;
            // 
            // textBoxEmail
            // 
            resources.ApplyResources(textBoxEmail, "textBoxEmail");
            textBoxEmail.Name = "textBoxEmail";
            // 
            // textBoxPassword
            // 
            resources.ApplyResources(textBoxPassword, "textBoxPassword");
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.UseSystemPasswordChar = true;
            textBoxPassword.TextChanged += textBoxPassword_TextChanged;
            // 
            // Login
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(groupBox3);
            Controls.Add(label4);
            Controls.Add(panel1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxInvisible).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxErrorMessage).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxVisible).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label4;
        private GroupBox groupBox3;
        private Label labelErrorMessage;
        private PictureBox pictureBoxErrorMessage;
        private PictureBox pictureBoxVisible;
        private PictureBox pictureBoxInvisible;
        private LinkLabel linkLabel3;
        private Label label9;
        private Label label10;
        private Button buttonLogin;
        private TextBox textBoxEmail;
        private TextBox textBoxPassword;
    }
}
