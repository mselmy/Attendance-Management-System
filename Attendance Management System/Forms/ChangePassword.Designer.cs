namespace Attendance_Management_System.Forms
{
    partial class ChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePassword));
            panel1 = new Panel();
            confirmError = new Label();
            confirmT = new PictureBox();
            newError = new Label();
            newT = new PictureBox();
            showConfirm = new PictureBox();
            showNew = new PictureBox();
            showOld = new PictureBox();
            oldError = new Label();
            oldT = new PictureBox();
            panel4 = new Panel();
            label2 = new Label();
            newPassword = new TextBox();
            panel3 = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            label10 = new Label();
            oldPassword = new TextBox();
            buttonVerify = new Button();
            confirmPassword = new TextBox();
            close = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)confirmT).BeginInit();
            ((System.ComponentModel.ISupportInitialize)newT).BeginInit();
            ((System.ComponentModel.ISupportInitialize)showConfirm).BeginInit();
            ((System.ComponentModel.ISupportInitialize)showNew).BeginInit();
            ((System.ComponentModel.ISupportInitialize)showOld).BeginInit();
            ((System.ComponentModel.ISupportInitialize)oldT).BeginInit();
            ((System.ComponentModel.ISupportInitialize)close).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(confirmError);
            panel1.Controls.Add(confirmT);
            panel1.Controls.Add(newError);
            panel1.Controls.Add(newT);
            panel1.Controls.Add(showConfirm);
            panel1.Controls.Add(showNew);
            panel1.Controls.Add(showOld);
            panel1.Controls.Add(oldError);
            panel1.Controls.Add(oldT);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(newPassword);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(oldPassword);
            panel1.Controls.Add(buttonVerify);
            panel1.Controls.Add(confirmPassword);
            panel1.Controls.Add(close);
            resources.ApplyResources(panel1, "panel1");
            panel1.Name = "panel1";
            // 
            // confirmError
            // 
            resources.ApplyResources(confirmError, "confirmError");
            confirmError.ForeColor = Color.FromArgb(192, 0, 0);
            confirmError.Name = "confirmError";
            // 
            // confirmT
            // 
            resources.ApplyResources(confirmT, "confirmT");
            confirmT.Name = "confirmT";
            confirmT.TabStop = false;
            // 
            // newError
            // 
            resources.ApplyResources(newError, "newError");
            newError.ForeColor = Color.FromArgb(192, 0, 0);
            newError.Name = "newError";
            newError.Click += label3_Click;
            // 
            // newT
            // 
            resources.ApplyResources(newT, "newT");
            newT.Name = "newT";
            newT.TabStop = false;
            // 
            // showConfirm
            // 
            resources.ApplyResources(showConfirm, "showConfirm");
            showConfirm.Cursor = Cursors.Hand;
            showConfirm.Name = "showConfirm";
            showConfirm.TabStop = false;
            showConfirm.Click += showConfirm_Click;
            // 
            // showNew
            // 
            resources.ApplyResources(showNew, "showNew");
            showNew.Cursor = Cursors.Hand;
            showNew.Name = "showNew";
            showNew.TabStop = false;
            showNew.Click += showNew_Click;
            // 
            // showOld
            // 
            resources.ApplyResources(showOld, "showOld");
            showOld.Cursor = Cursors.Hand;
            showOld.Name = "showOld";
            showOld.TabStop = false;
            showOld.Click += showOld_Click;
            // 
            // oldError
            // 
            resources.ApplyResources(oldError, "oldError");
            oldError.ForeColor = Color.FromArgb(192, 0, 0);
            oldError.Name = "oldError";
            oldError.Click += labelErrorMessage_Click;
            // 
            // oldT
            // 
            resources.ApplyResources(oldT, "oldT");
            oldT.Name = "oldT";
            oldT.TabStop = false;
            oldT.Click += pictureBoxErrorMessage_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.DarkGray;
            resources.ApplyResources(panel4, "panel4");
            panel4.Name = "panel4";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // newPassword
            // 
            newPassword.BorderStyle = BorderStyle.None;
            resources.ApplyResources(newPassword, "newPassword");
            newPassword.ForeColor = Color.DarkGray;
            newPassword.Name = "newPassword";
            newPassword.UseSystemPasswordChar = true;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkGray;
            resources.ApplyResources(panel3, "panel3");
            panel3.Name = "panel3";
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkGray;
            resources.ApplyResources(panel2, "panel2");
            panel2.Name = "panel2";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            label1.Click += label1_Click;
            // 
            // label10
            // 
            resources.ApplyResources(label10, "label10");
            label10.Name = "label10";
            // 
            // oldPassword
            // 
            oldPassword.BorderStyle = BorderStyle.None;
            resources.ApplyResources(oldPassword, "oldPassword");
            oldPassword.ForeColor = Color.DarkGray;
            oldPassword.Name = "oldPassword";
            oldPassword.UseSystemPasswordChar = true;
            // 
            // buttonVerify
            // 
            buttonVerify.BackColor = Color.FromArgb(128, 128, 255);
            buttonVerify.Cursor = Cursors.Hand;
            buttonVerify.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(buttonVerify, "buttonVerify");
            buttonVerify.ForeColor = Color.White;
            buttonVerify.Name = "buttonVerify";
            buttonVerify.UseVisualStyleBackColor = false;
            buttonVerify.Click += Save_Click;
            // 
            // confirmPassword
            // 
            confirmPassword.BorderStyle = BorderStyle.None;
            resources.ApplyResources(confirmPassword, "confirmPassword");
            confirmPassword.ForeColor = Color.DarkGray;
            confirmPassword.Name = "confirmPassword";
            confirmPassword.UseSystemPasswordChar = true;
            // 
            // close
            // 
            resources.ApplyResources(close, "close");
            close.Cursor = Cursors.Hand;
            close.Name = "close";
            close.TabStop = false;
            close.Click += pictureBox2_Click;
            // 
            // ChangePassword
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ChangePassword";
            ShowIcon = false;
            ShowInTaskbar = false;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)confirmT).EndInit();
            ((System.ComponentModel.ISupportInitialize)newT).EndInit();
            ((System.ComponentModel.ISupportInitialize)showConfirm).EndInit();
            ((System.ComponentModel.ISupportInitialize)showNew).EndInit();
            ((System.ComponentModel.ISupportInitialize)showOld).EndInit();
            ((System.ComponentModel.ISupportInitialize)oldT).EndInit();
            ((System.ComponentModel.ISupportInitialize)close).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel4;
        private Label label2;
        private Panel panel3;
        private Panel panel2;
        private Label label1;
        private Label label10;
        private Button buttonVerify;
        private TextBox confirmPassword;
        private PictureBox close;
        private Label oldError;
        private PictureBox oldT;
        private TextBox newPassword;
        private TextBox oldPassword;
        private PictureBox showConfirm;
        private PictureBox showNew;
        private PictureBox showOld;
        private Label confirmError;
        private PictureBox confirmT;
        private Label newError;
        private PictureBox newT;
    }
}