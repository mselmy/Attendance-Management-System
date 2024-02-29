namespace Attendance_Management_System.Forms
{
    partial class Edit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edit));
            EditTab = new TabControl();
            sstudentEditPage = new TabPage();
            StudentcomboBox = new ComboBox();
            label17 = new Label();
            emailexisterrormessage = new Label();
            emailtextBox = new TextBox();
            emailnotvaliderrormessage = new Label();
            panel13 = new Panel();
            label10 = new Label();
            classStudlistBox = new ListBox();
            passwordlabel1 = new Label();
            passswordstdtextBox = new TextBox();
            label13 = new Label();
            panel11 = new Panel();
            labelErrorMessage1 = new Label();
            panel4 = new Panel();
            label7 = new Label();
            labelErrorMessage = new Label();
            editStudentButton = new Button();
            nameStudenttextBox = new TextBox();
            label9 = new Label();
            panel6 = new Panel();
            Pdf = new PictureBox();
            label1 = new Label();
            ClassEditPage = new TabPage();
            ClasscomboBox = new ComboBox();
            label18 = new Label();
            classteachercomboBox = new ComboBox();
            labelErrorMessage8 = new Label();
            labelErrorMessage10 = new Label();
            labelErrorMessage9 = new Label();
            StudentInClasslistBox = new ListBox();
            editClassButton = new Button();
            label6 = new Label();
            panel3 = new Panel();
            label5 = new Label();
            panel2 = new Panel();
            nameClasstextBox = new TextBox();
            label4 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label11 = new Label();
            TeacherEditPage = new TabPage();
            TeachercomboBox = new ComboBox();
            label20 = new Label();
            emailexistmessage2 = new Label();
            emailTtextBox = new TextBox();
            emailnotvalidmessage2 = new Label();
            panel14 = new Panel();
            label19 = new Label();
            TeacherClasslistBox = new ListBox();
            panel15 = new Panel();
            panel12 = new Panel();
            passwordlabel2 = new Label();
            passwordtextBox2 = new TextBox();
            label14 = new Label();
            labelErrorMessage7 = new Label();
            labelErrorMessage4 = new Label();
            editTeacherButton = new Button();
            label3 = new Label();
            nameTeachertextBox = new TextBox();
            label12 = new Label();
            panel9 = new Panel();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            EditTab.SuspendLayout();
            sstudentEditPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Pdf).BeginInit();
            ClassEditPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            TeacherEditPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // EditTab
            // 
            resources.ApplyResources(EditTab, "EditTab");
            EditTab.Controls.Add(sstudentEditPage);
            EditTab.Controls.Add(ClassEditPage);
            EditTab.Controls.Add(TeacherEditPage);
            EditTab.Name = "EditTab";
            EditTab.SelectedIndex = 0;
            // 
            // sstudentEditPage
            // 
            resources.ApplyResources(sstudentEditPage, "sstudentEditPage");
            sstudentEditPage.BackColor = Color.White;
            sstudentEditPage.Controls.Add(StudentcomboBox);
            sstudentEditPage.Controls.Add(label17);
            sstudentEditPage.Controls.Add(emailexisterrormessage);
            sstudentEditPage.Controls.Add(emailtextBox);
            sstudentEditPage.Controls.Add(emailnotvaliderrormessage);
            sstudentEditPage.Controls.Add(panel13);
            sstudentEditPage.Controls.Add(label10);
            sstudentEditPage.Controls.Add(classStudlistBox);
            sstudentEditPage.Controls.Add(passwordlabel1);
            sstudentEditPage.Controls.Add(passswordstdtextBox);
            sstudentEditPage.Controls.Add(label13);
            sstudentEditPage.Controls.Add(panel11);
            sstudentEditPage.Controls.Add(labelErrorMessage1);
            sstudentEditPage.Controls.Add(panel4);
            sstudentEditPage.Controls.Add(label7);
            sstudentEditPage.Controls.Add(labelErrorMessage);
            sstudentEditPage.Controls.Add(editStudentButton);
            sstudentEditPage.Controls.Add(nameStudenttextBox);
            sstudentEditPage.Controls.Add(label9);
            sstudentEditPage.Controls.Add(panel6);
            sstudentEditPage.Controls.Add(Pdf);
            sstudentEditPage.Controls.Add(label1);
            sstudentEditPage.Name = "sstudentEditPage";
            // 
            // StudentcomboBox
            // 
            resources.ApplyResources(StudentcomboBox, "StudentcomboBox");
            StudentcomboBox.FormattingEnabled = true;
            StudentcomboBox.Name = "StudentcomboBox";
            StudentcomboBox.SelectedIndexChanged += StudentcomboBox_SelectedIndexChanged;
            // 
            // label17
            // 
            resources.ApplyResources(label17, "label17");
            label17.ForeColor = Color.SlateGray;
            label17.Name = "label17";
            // 
            // emailexisterrormessage
            // 
            resources.ApplyResources(emailexisterrormessage, "emailexisterrormessage");
            emailexisterrormessage.ForeColor = Color.FromArgb(192, 0, 0);
            emailexisterrormessage.Name = "emailexisterrormessage";
            // 
            // emailtextBox
            // 
            resources.ApplyResources(emailtextBox, "emailtextBox");
            emailtextBox.BorderStyle = BorderStyle.None;
            emailtextBox.Name = "emailtextBox";
            // 
            // emailnotvaliderrormessage
            // 
            resources.ApplyResources(emailnotvaliderrormessage, "emailnotvaliderrormessage");
            emailnotvaliderrormessage.ForeColor = Color.FromArgb(192, 0, 0);
            emailnotvaliderrormessage.Name = "emailnotvaliderrormessage";
            // 
            // panel13
            // 
            resources.ApplyResources(panel13, "panel13");
            panel13.BackColor = Color.Goldenrod;
            panel13.Name = "panel13";
            // 
            // label10
            // 
            resources.ApplyResources(label10, "label10");
            label10.ForeColor = Color.SlateGray;
            label10.Name = "label10";
            // 
            // classStudlistBox
            // 
            resources.ApplyResources(classStudlistBox, "classStudlistBox");
            classStudlistBox.BorderStyle = BorderStyle.None;
            classStudlistBox.FormattingEnabled = true;
            classStudlistBox.Name = "classStudlistBox";
            classStudlistBox.SelectionMode = SelectionMode.MultiSimple;
            // 
            // passwordlabel1
            // 
            resources.ApplyResources(passwordlabel1, "passwordlabel1");
            passwordlabel1.ForeColor = Color.FromArgb(192, 0, 0);
            passwordlabel1.Name = "passwordlabel1";
            // 
            // passswordstdtextBox
            // 
            resources.ApplyResources(passswordstdtextBox, "passswordstdtextBox");
            passswordstdtextBox.BorderStyle = BorderStyle.None;
            passswordstdtextBox.Name = "passswordstdtextBox";
            // 
            // label13
            // 
            resources.ApplyResources(label13, "label13");
            label13.ForeColor = Color.SlateGray;
            label13.Name = "label13";
            // 
            // panel11
            // 
            resources.ApplyResources(panel11, "panel11");
            panel11.BackColor = Color.Goldenrod;
            panel11.Name = "panel11";
            // 
            // labelErrorMessage1
            // 
            resources.ApplyResources(labelErrorMessage1, "labelErrorMessage1");
            labelErrorMessage1.ForeColor = Color.FromArgb(192, 0, 0);
            labelErrorMessage1.Name = "labelErrorMessage1";
            // 
            // panel4
            // 
            resources.ApplyResources(panel4, "panel4");
            panel4.BackColor = Color.Goldenrod;
            panel4.Name = "panel4";
            // 
            // label7
            // 
            resources.ApplyResources(label7, "label7");
            label7.ForeColor = Color.SlateGray;
            label7.Name = "label7";
            // 
            // labelErrorMessage
            // 
            resources.ApplyResources(labelErrorMessage, "labelErrorMessage");
            labelErrorMessage.ForeColor = Color.FromArgb(192, 0, 0);
            labelErrorMessage.Name = "labelErrorMessage";
            // 
            // editStudentButton
            // 
            resources.ApplyResources(editStudentButton, "editStudentButton");
            editStudentButton.BackColor = Color.SteelBlue;
            editStudentButton.ForeColor = SystemColors.ButtonHighlight;
            editStudentButton.Name = "editStudentButton";
            editStudentButton.UseVisualStyleBackColor = false;
            editStudentButton.Click += editStudentButton_Click;
            // 
            // nameStudenttextBox
            // 
            resources.ApplyResources(nameStudenttextBox, "nameStudenttextBox");
            nameStudenttextBox.BorderStyle = BorderStyle.None;
            nameStudenttextBox.Name = "nameStudenttextBox";
            // 
            // label9
            // 
            resources.ApplyResources(label9, "label9");
            label9.ForeColor = Color.SlateGray;
            label9.Name = "label9";
            // 
            // panel6
            // 
            resources.ApplyResources(panel6, "panel6");
            panel6.BackColor = Color.Goldenrod;
            panel6.Name = "panel6";
            // 
            // Pdf
            // 
            resources.ApplyResources(Pdf, "Pdf");
            Pdf.Name = "Pdf";
            Pdf.TabStop = false;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.ForeColor = Color.Goldenrod;
            label1.Name = "label1";
            // 
            // ClassEditPage
            // 
            resources.ApplyResources(ClassEditPage, "ClassEditPage");
            ClassEditPage.BackColor = Color.White;
            ClassEditPage.Controls.Add(ClasscomboBox);
            ClassEditPage.Controls.Add(label18);
            ClassEditPage.Controls.Add(classteachercomboBox);
            ClassEditPage.Controls.Add(labelErrorMessage8);
            ClassEditPage.Controls.Add(labelErrorMessage10);
            ClassEditPage.Controls.Add(labelErrorMessage9);
            ClassEditPage.Controls.Add(StudentInClasslistBox);
            ClassEditPage.Controls.Add(editClassButton);
            ClassEditPage.Controls.Add(label6);
            ClassEditPage.Controls.Add(panel3);
            ClassEditPage.Controls.Add(label5);
            ClassEditPage.Controls.Add(panel2);
            ClassEditPage.Controls.Add(nameClasstextBox);
            ClassEditPage.Controls.Add(label4);
            ClassEditPage.Controls.Add(panel1);
            ClassEditPage.Controls.Add(pictureBox1);
            ClassEditPage.Controls.Add(label11);
            ClassEditPage.Name = "ClassEditPage";
            // 
            // ClasscomboBox
            // 
            resources.ApplyResources(ClasscomboBox, "ClasscomboBox");
            ClasscomboBox.FormattingEnabled = true;
            ClasscomboBox.Name = "ClasscomboBox";
            ClasscomboBox.SelectedIndexChanged += ClasscomboBox_SelectedIndexChanged;
            // 
            // label18
            // 
            resources.ApplyResources(label18, "label18");
            label18.ForeColor = Color.SlateGray;
            label18.Name = "label18";
            // 
            // classteachercomboBox
            // 
            resources.ApplyResources(classteachercomboBox, "classteachercomboBox");
            classteachercomboBox.FormattingEnabled = true;
            classteachercomboBox.Name = "classteachercomboBox";
            // 
            // labelErrorMessage8
            // 
            resources.ApplyResources(labelErrorMessage8, "labelErrorMessage8");
            labelErrorMessage8.ForeColor = Color.FromArgb(192, 0, 0);
            labelErrorMessage8.Name = "labelErrorMessage8";
            // 
            // labelErrorMessage10
            // 
            resources.ApplyResources(labelErrorMessage10, "labelErrorMessage10");
            labelErrorMessage10.BackColor = Color.Transparent;
            labelErrorMessage10.ForeColor = Color.FromArgb(192, 0, 0);
            labelErrorMessage10.Name = "labelErrorMessage10";
            // 
            // labelErrorMessage9
            // 
            resources.ApplyResources(labelErrorMessage9, "labelErrorMessage9");
            labelErrorMessage9.ForeColor = Color.FromArgb(192, 0, 0);
            labelErrorMessage9.Name = "labelErrorMessage9";
            // 
            // StudentInClasslistBox
            // 
            resources.ApplyResources(StudentInClasslistBox, "StudentInClasslistBox");
            StudentInClasslistBox.BorderStyle = BorderStyle.None;
            StudentInClasslistBox.FormattingEnabled = true;
            StudentInClasslistBox.Name = "StudentInClasslistBox";
            StudentInClasslistBox.SelectionMode = SelectionMode.MultiSimple;
            // 
            // editClassButton
            // 
            resources.ApplyResources(editClassButton, "editClassButton");
            editClassButton.BackColor = Color.SteelBlue;
            editClassButton.ForeColor = SystemColors.ButtonHighlight;
            editClassButton.Name = "editClassButton";
            editClassButton.UseVisualStyleBackColor = false;
            editClassButton.Click += editClassButton_Click;
            // 
            // label6
            // 
            resources.ApplyResources(label6, "label6");
            label6.ForeColor = Color.SlateGray;
            label6.Name = "label6";
            // 
            // panel3
            // 
            resources.ApplyResources(panel3, "panel3");
            panel3.BackColor = Color.Goldenrod;
            panel3.Name = "panel3";
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            label5.ForeColor = Color.SlateGray;
            label5.Name = "label5";
            // 
            // panel2
            // 
            resources.ApplyResources(panel2, "panel2");
            panel2.BackColor = Color.Goldenrod;
            panel2.Name = "panel2";
            // 
            // nameClasstextBox
            // 
            resources.ApplyResources(nameClasstextBox, "nameClasstextBox");
            nameClasstextBox.BorderStyle = BorderStyle.None;
            nameClasstextBox.Name = "nameClasstextBox";
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.ForeColor = Color.SlateGray;
            label4.Name = "label4";
            // 
            // panel1
            // 
            resources.ApplyResources(panel1, "panel1");
            panel1.BackColor = Color.Goldenrod;
            panel1.Name = "panel1";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // label11
            // 
            resources.ApplyResources(label11, "label11");
            label11.ForeColor = Color.Goldenrod;
            label11.Name = "label11";
            // 
            // TeacherEditPage
            // 
            resources.ApplyResources(TeacherEditPage, "TeacherEditPage");
            TeacherEditPage.BackColor = Color.White;
            TeacherEditPage.Controls.Add(TeachercomboBox);
            TeacherEditPage.Controls.Add(label20);
            TeacherEditPage.Controls.Add(emailexistmessage2);
            TeacherEditPage.Controls.Add(emailTtextBox);
            TeacherEditPage.Controls.Add(emailnotvalidmessage2);
            TeacherEditPage.Controls.Add(panel14);
            TeacherEditPage.Controls.Add(label19);
            TeacherEditPage.Controls.Add(TeacherClasslistBox);
            TeacherEditPage.Controls.Add(panel15);
            TeacherEditPage.Controls.Add(panel12);
            TeacherEditPage.Controls.Add(passwordlabel2);
            TeacherEditPage.Controls.Add(passwordtextBox2);
            TeacherEditPage.Controls.Add(label14);
            TeacherEditPage.Controls.Add(labelErrorMessage7);
            TeacherEditPage.Controls.Add(labelErrorMessage4);
            TeacherEditPage.Controls.Add(editTeacherButton);
            TeacherEditPage.Controls.Add(label3);
            TeacherEditPage.Controls.Add(nameTeachertextBox);
            TeacherEditPage.Controls.Add(label12);
            TeacherEditPage.Controls.Add(panel9);
            TeacherEditPage.Controls.Add(pictureBox2);
            TeacherEditPage.Controls.Add(label2);
            TeacherEditPage.Name = "TeacherEditPage";
            // 
            // TeachercomboBox
            // 
            resources.ApplyResources(TeachercomboBox, "TeachercomboBox");
            TeachercomboBox.FormattingEnabled = true;
            TeachercomboBox.Name = "TeachercomboBox";
            TeachercomboBox.SelectedIndexChanged += TeachercomboBox_SelectedIndexChanged;
            // 
            // label20
            // 
            resources.ApplyResources(label20, "label20");
            label20.ForeColor = Color.SlateGray;
            label20.Name = "label20";
            // 
            // emailexistmessage2
            // 
            resources.ApplyResources(emailexistmessage2, "emailexistmessage2");
            emailexistmessage2.ForeColor = Color.FromArgb(192, 0, 0);
            emailexistmessage2.Name = "emailexistmessage2";
            // 
            // emailTtextBox
            // 
            resources.ApplyResources(emailTtextBox, "emailTtextBox");
            emailTtextBox.BorderStyle = BorderStyle.None;
            emailTtextBox.Name = "emailTtextBox";
            // 
            // emailnotvalidmessage2
            // 
            resources.ApplyResources(emailnotvalidmessage2, "emailnotvalidmessage2");
            emailnotvalidmessage2.ForeColor = Color.FromArgb(192, 0, 0);
            emailnotvalidmessage2.Name = "emailnotvalidmessage2";
            // 
            // panel14
            // 
            resources.ApplyResources(panel14, "panel14");
            panel14.BackColor = Color.Goldenrod;
            panel14.Name = "panel14";
            // 
            // label19
            // 
            resources.ApplyResources(label19, "label19");
            label19.ForeColor = Color.SlateGray;
            label19.Name = "label19";
            // 
            // TeacherClasslistBox
            // 
            resources.ApplyResources(TeacherClasslistBox, "TeacherClasslistBox");
            TeacherClasslistBox.BorderStyle = BorderStyle.None;
            TeacherClasslistBox.FormattingEnabled = true;
            TeacherClasslistBox.Name = "TeacherClasslistBox";
            TeacherClasslistBox.SelectionMode = SelectionMode.MultiSimple;
            // 
            // panel15
            // 
            resources.ApplyResources(panel15, "panel15");
            panel15.BackColor = Color.Goldenrod;
            panel15.Name = "panel15";
            // 
            // panel12
            // 
            resources.ApplyResources(panel12, "panel12");
            panel12.BackColor = Color.Goldenrod;
            panel12.Name = "panel12";
            // 
            // passwordlabel2
            // 
            resources.ApplyResources(passwordlabel2, "passwordlabel2");
            passwordlabel2.ForeColor = Color.FromArgb(192, 0, 0);
            passwordlabel2.Name = "passwordlabel2";
            // 
            // passwordtextBox2
            // 
            resources.ApplyResources(passwordtextBox2, "passwordtextBox2");
            passwordtextBox2.BorderStyle = BorderStyle.None;
            passwordtextBox2.Name = "passwordtextBox2";
            // 
            // label14
            // 
            resources.ApplyResources(label14, "label14");
            label14.ForeColor = Color.SlateGray;
            label14.Name = "label14";
            // 
            // labelErrorMessage7
            // 
            resources.ApplyResources(labelErrorMessage7, "labelErrorMessage7");
            labelErrorMessage7.ForeColor = Color.FromArgb(192, 0, 0);
            labelErrorMessage7.Name = "labelErrorMessage7";
            // 
            // labelErrorMessage4
            // 
            resources.ApplyResources(labelErrorMessage4, "labelErrorMessage4");
            labelErrorMessage4.ForeColor = Color.FromArgb(192, 0, 0);
            labelErrorMessage4.Name = "labelErrorMessage4";
            // 
            // editTeacherButton
            // 
            resources.ApplyResources(editTeacherButton, "editTeacherButton");
            editTeacherButton.BackColor = Color.SteelBlue;
            editTeacherButton.ForeColor = SystemColors.ButtonHighlight;
            editTeacherButton.Name = "editTeacherButton";
            editTeacherButton.UseVisualStyleBackColor = false;
            editTeacherButton.Click += editTeacherButton_Click;
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.ForeColor = Color.SlateGray;
            label3.Name = "label3";
            // 
            // nameTeachertextBox
            // 
            resources.ApplyResources(nameTeachertextBox, "nameTeachertextBox");
            nameTeachertextBox.BorderStyle = BorderStyle.None;
            nameTeachertextBox.Name = "nameTeachertextBox";
            // 
            // label12
            // 
            resources.ApplyResources(label12, "label12");
            label12.ForeColor = Color.SlateGray;
            label12.Name = "label12";
            // 
            // panel9
            // 
            resources.ApplyResources(panel9, "panel9");
            panel9.BackColor = Color.Goldenrod;
            panel9.Name = "panel9";
            // 
            // pictureBox2
            // 
            resources.ApplyResources(pictureBox2, "pictureBox2");
            pictureBox2.Name = "pictureBox2";
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.ForeColor = Color.Goldenrod;
            label2.Name = "label2";
            // 
            // Edit
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            Controls.Add(EditTab);
            Name = "Edit";
            Load += Edit_Load;
            EditTab.ResumeLayout(false);
            sstudentEditPage.ResumeLayout(false);
            sstudentEditPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Pdf).EndInit();
            ClassEditPage.ResumeLayout(false);
            ClassEditPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            TeacherEditPage.ResumeLayout(false);
            TeacherEditPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl EditTab;
        private TabPage sstudentEditPage;
        private Label label1;
        private TabPage ClassEditPage;
        private Label label11;
        private TabPage TeacherEditPage;
        private Label label2;
        private PictureBox Pdf;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label emailexisterrormessage;
        private TextBox emailtextBox;
        private Label emailnotvaliderrormessage;
        private Panel panel13;
        private Label label10;
        private ListBox classStudlistBox;
        private Label passwordlabel1;
        private TextBox passswordstdtextBox;
        private Label label13;
        private Panel panel11;
        private Label labelErrorMessage1;
        private Panel panel4;
        private Label label7;
        private Label labelErrorMessage;
        private Button editStudentButton;
        private TextBox nameStudenttextBox;
        private Label label9;
        private Panel panel6;
        private Label emailexistmessage2;
        private TextBox emailTtextBox;
        private Label emailnotvalidmessage2;
        private Panel panel14;
        private Label label19;
        private ListBox TeacherClasslistBox;
        private Panel panel15;
        private Panel panel12;
        private Label passwordlabel2;
        private TextBox passwordtextBox2;
        private Label label14;
        private Label labelErrorMessage7;
        private Label labelErrorMessage4;
        private Button editTeacherButton;
        private Label label3;
        private TextBox nameTeachertextBox;
        private Label label12;
        private Panel panel9;
        private Label label17;
        private ComboBox classteachercomboBox;
        private Label labelErrorMessage8;
        private Label labelErrorMessage10;
        private Label labelErrorMessage9;
        private ListBox StudentInClasslistBox;
        private Button editClassButton;
        private Label label6;
        private Panel panel3;
        private Label label5;
        private Panel panel2;
        private TextBox nameClasstextBox;
        private Label label4;
        private Panel panel1;
        private ComboBox StudentcomboBox;
        private ComboBox ClasscomboBox;
        private Label label18;
        private ComboBox TeachercomboBox;
        private Label label20;
    }
}
