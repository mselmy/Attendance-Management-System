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
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(buttonVerify);
            panel1.Controls.Add(textBoxEmail);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(569, 482);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkGray;
            panel2.Location = new Point(141, 338);
            panel2.Name = "panel2";
            panel2.Size = new Size(310, 2);
            panel2.TabIndex = 0;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(141, 292);
            label10.Name = "label10";
            label10.Size = new Size(58, 19);
            label10.TabIndex = 0;
            label10.Text = "Email:";
            // 
            // buttonVerify
            // 
            buttonVerify.BackColor = Color.FromArgb(128, 128, 255);
            buttonVerify.Cursor = Cursors.Hand;
            buttonVerify.FlatAppearance.BorderSize = 0;
            buttonVerify.FlatStyle = FlatStyle.Flat;
            buttonVerify.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonVerify.ForeColor = Color.White;
            buttonVerify.Location = new Point(141, 388);
            buttonVerify.Name = "buttonVerify";
            buttonVerify.Size = new Size(310, 47);
            buttonVerify.TabIndex = 2;
            buttonVerify.Text = "Verify";
            buttonVerify.UseVisualStyleBackColor = false;
            buttonVerify.Click += buttonVerify_Click;
            // 
            // textBoxEmail
            // 
            textBoxEmail.BorderStyle = BorderStyle.None;
            textBoxEmail.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxEmail.ForeColor = Color.DarkGray;
            textBoxEmail.Location = new Point(141, 314);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(310, 20);
            textBoxEmail.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(184, 39);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(224, 214);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(526, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(31, 31);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            pictureBox2.Click += click_Exit;
            pictureBox2.MouseHover += pictureBox2_MouseHover;
            // 
            // FormForgetPassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(593, 506);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormForgetPassword";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Forget Password";
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