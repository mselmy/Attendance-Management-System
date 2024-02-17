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
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1154, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(31, 31);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            pictureBox2.Click += Exit;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.None;
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(1117, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(31, 31);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            pictureBox3.Click += Minimize;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(740, 104);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(354, 316);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = SystemColors.Control;
            panel1.Location = new Point(642, 108);
            panel1.Name = "panel1";
            panel1.Size = new Size(5, 408);
            panel1.TabIndex = 0;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(128, 128, 255);
            label4.Location = new Point(734, 452);
            label4.Name = "label4";
            label4.Size = new Size(367, 68);
            label4.TabIndex = 14;
            label4.Text = "Attendance Management\r\nSystem";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            label4.Click += label4_Click;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.None;
            groupBox3.AutoSize = true;
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
            groupBox3.Location = new Point(97, 138);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(452, 348);
            groupBox3.TabIndex = 15;
            groupBox3.TabStop = false;
            groupBox3.Text = "Please Login First";
            // 
            // pictureBoxInvisible
            // 
            pictureBoxInvisible.Anchor = AnchorStyles.None;
            pictureBoxInvisible.Cursor = Cursors.Hand;
            pictureBoxInvisible.Image = (Image)resources.GetObject("pictureBoxInvisible.Image");
            pictureBoxInvisible.Location = new Point(303, 134);
            pictureBoxInvisible.Name = "pictureBoxInvisible";
            pictureBoxInvisible.Size = new Size(25, 20);
            pictureBoxInvisible.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxInvisible.TabIndex = 10;
            pictureBoxInvisible.TabStop = false;
            pictureBoxInvisible.Click += ShowPassword;
            // 
            // labelErrorMessage
            // 
            labelErrorMessage.AutoSize = true;
            labelErrorMessage.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelErrorMessage.ForeColor = Color.FromArgb(192, 0, 0);
            labelErrorMessage.Location = new Point(129, 175);
            labelErrorMessage.Name = "labelErrorMessage";
            labelErrorMessage.Size = new Size(217, 21);
            labelErrorMessage.TabIndex = 13;
            labelErrorMessage.Text = "Invalid Email or Password";
            // 
            // pictureBoxErrorMessage
            // 
            pictureBoxErrorMessage.Image = (Image)resources.GetObject("pictureBoxErrorMessage.Image");
            pictureBoxErrorMessage.Location = new Point(98, 175);
            pictureBoxErrorMessage.Name = "pictureBoxErrorMessage";
            pictureBoxErrorMessage.Size = new Size(25, 23);
            pictureBoxErrorMessage.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxErrorMessage.TabIndex = 12;
            pictureBoxErrorMessage.TabStop = false;
            // 
            // pictureBoxVisible
            // 
            pictureBoxVisible.Anchor = AnchorStyles.None;
            pictureBoxVisible.Cursor = Cursors.Hand;
            pictureBoxVisible.Image = (Image)resources.GetObject("pictureBoxVisible.Image");
            pictureBoxVisible.Location = new Point(303, 134);
            pictureBoxVisible.Name = "pictureBoxVisible";
            pictureBoxVisible.Size = new Size(25, 20);
            pictureBoxVisible.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxVisible.TabIndex = 11;
            pictureBoxVisible.TabStop = false;
            pictureBoxVisible.Click += HidePassword;
            // 
            // linkLabel3
            // 
            linkLabel3.AutoSize = true;
            linkLabel3.LinkColor = Color.FromArgb(128, 128, 255);
            linkLabel3.Location = new Point(165, 299);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(114, 17);
            linkLabel3.TabIndex = 3;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "Forget Password";
            linkLabel3.Click += click_forgetPassword;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            label9.Location = new Point(98, 111);
            label9.Name = "label9";
            label9.Size = new Size(92, 19);
            label9.TabIndex = 2;
            label9.Text = "Password:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(98, 58);
            label10.Name = "label10";
            label10.Size = new Size(58, 19);
            label10.TabIndex = 1;
            label10.Text = "Email:";
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.FromArgb(128, 128, 255);
            buttonLogin.Cursor = Cursors.Hand;
            buttonLogin.FlatAppearance.BorderSize = 0;
            buttonLogin.FlatStyle = FlatStyle.Flat;
            buttonLogin.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLogin.ForeColor = Color.White;
            buttonLogin.Location = new Point(129, 219);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(186, 52);
            buttonLogin.TabIndex = 4;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += click_Login;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(98, 80);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(230, 23);
            textBoxEmail.TabIndex = 1;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(98, 133);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(230, 23);
            textBoxPassword.TabIndex = 2;
            textBoxPassword.UseSystemPasswordChar = true;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1200, 720);
            Controls.Add(groupBox3);
            Controls.Add(label4);
            Controls.Add(panel1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Font = new Font("Microsoft Sans Serif", 8.25F);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
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
