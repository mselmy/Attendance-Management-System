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
            EditTab.Alignment = TabAlignment.Bottom;
            EditTab.Anchor = AnchorStyles.None;
            EditTab.Controls.Add(sstudentEditPage);
            EditTab.Controls.Add(ClassEditPage);
            EditTab.Controls.Add(TeacherEditPage);
            EditTab.Location = new Point(69, 38);
            EditTab.Name = "EditTab";
            EditTab.SelectedIndex = 0;
            EditTab.Size = new Size(1119, 619);
            EditTab.TabIndex = 2;
            // 
            // sstudentEditPage
            // 
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
            sstudentEditPage.Location = new Point(4, 4);
            sstudentEditPage.Name = "sstudentEditPage";
            sstudentEditPage.Padding = new Padding(3);
            sstudentEditPage.Size = new Size(1111, 581);
            sstudentEditPage.TabIndex = 0;
            sstudentEditPage.Text = "Student";
            // 
            // StudentcomboBox
            // 
            StudentcomboBox.FormattingEnabled = true;
            StudentcomboBox.Location = new Point(830, 10);
            StudentcomboBox.Name = "StudentcomboBox";
            StudentcomboBox.Size = new Size(258, 33);
            StudentcomboBox.TabIndex = 74;
            StudentcomboBox.SelectedIndexChanged += StudentcomboBox_SelectedIndexChanged;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.ForeColor = Color.SlateGray;
            label17.Location = new Point(707, 7);
            label17.Name = "label17";
            label17.Size = new Size(125, 32);
            label17.TabIndex = 73;
            label17.Text = "Get By Id:";
            // 
            // emailexisterrormessage
            // 
            emailexisterrormessage.AutoSize = true;
            emailexisterrormessage.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailexisterrormessage.ForeColor = Color.FromArgb(192, 0, 0);
            emailexisterrormessage.Location = new Point(742, 345);
            emailexisterrormessage.Name = "emailexisterrormessage";
            emailexisterrormessage.Size = new Size(262, 24);
            emailexisterrormessage.TabIndex = 72;
            emailexisterrormessage.Text = "This email is already exists";
            // 
            // emailtextBox
            // 
            emailtextBox.BorderStyle = BorderStyle.None;
            emailtextBox.Location = new Point(730, 307);
            emailtextBox.Name = "emailtextBox";
            emailtextBox.Size = new Size(270, 24);
            emailtextBox.TabIndex = 71;
            // 
            // emailnotvaliderrormessage
            // 
            emailnotvaliderrormessage.AutoSize = true;
            emailnotvaliderrormessage.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailnotvaliderrormessage.ForeColor = Color.FromArgb(192, 0, 0);
            emailnotvaliderrormessage.Location = new Point(720, 345);
            emailnotvaliderrormessage.Name = "emailnotvaliderrormessage";
            emailnotvaliderrormessage.Size = new Size(274, 24);
            emailnotvaliderrormessage.TabIndex = 70;
            emailnotvaliderrormessage.Text = "please Enter a valid email";
            // 
            // panel13
            // 
            panel13.BackColor = Color.Goldenrod;
            panel13.Location = new Point(730, 340);
            panel13.Name = "panel13";
            panel13.Size = new Size(270, 2);
            panel13.TabIndex = 48;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.SlateGray;
            label10.Location = new Point(730, 272);
            label10.Name = "label10";
            label10.Size = new Size(83, 32);
            label10.TabIndex = 69;
            label10.Text = "Email:";
            // 
            // classStudlistBox
            // 
            classStudlistBox.BorderStyle = BorderStyle.None;
            classStudlistBox.FormattingEnabled = true;
            classStudlistBox.ItemHeight = 25;
            classStudlistBox.Location = new Point(730, 134);
            classStudlistBox.Name = "classStudlistBox";
            classStudlistBox.ScrollAlwaysVisible = true;
            classStudlistBox.SelectionMode = SelectionMode.MultiSimple;
            classStudlistBox.Size = new Size(282, 75);
            classStudlistBox.TabIndex = 68;
            // 
            // passwordlabel1
            // 
            passwordlabel1.AutoSize = true;
            passwordlabel1.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordlabel1.ForeColor = Color.FromArgb(192, 0, 0);
            passwordlabel1.Location = new Point(90, 328);
            passwordlabel1.Name = "passwordlabel1";
            passwordlabel1.Size = new Size(560, 24);
            passwordlabel1.TabIndex = 66;
            passwordlabel1.Text = "Make the password complex and not less than 8 char";
            // 
            // passswordstdtextBox
            // 
            passswordstdtextBox.BorderStyle = BorderStyle.None;
            passswordstdtextBox.Location = new Point(90, 279);
            passswordstdtextBox.Name = "passswordstdtextBox";
            passswordstdtextBox.Size = new Size(270, 24);
            passswordstdtextBox.TabIndex = 65;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.SlateGray;
            label13.Location = new Point(89, 243);
            label13.Name = "label13";
            label13.Size = new Size(129, 32);
            label13.TabIndex = 64;
            label13.Text = "Password:";
            // 
            // panel11
            // 
            panel11.BackColor = Color.Goldenrod;
            panel11.Location = new Point(90, 317);
            panel11.Name = "panel11";
            panel11.Size = new Size(270, 2);
            panel11.TabIndex = 63;
            // 
            // labelErrorMessage1
            // 
            labelErrorMessage1.AutoSize = true;
            labelErrorMessage1.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelErrorMessage1.ForeColor = Color.FromArgb(192, 0, 0);
            labelErrorMessage1.Location = new Point(713, 230);
            labelErrorMessage1.Name = "labelErrorMessage1";
            labelErrorMessage1.Size = new Size(320, 24);
            labelErrorMessage1.TabIndex = 57;
            labelErrorMessage1.Text = "Please select one from the List";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Goldenrod;
            panel4.Location = new Point(727, 223);
            panel4.Name = "panel4";
            panel4.Size = new Size(289, 2);
            panel4.TabIndex = 56;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.SlateGray;
            label7.Location = new Point(730, 92);
            label7.Name = "label7";
            label7.Size = new Size(78, 32);
            label7.TabIndex = 55;
            label7.Text = "Class:";
            // 
            // labelErrorMessage
            // 
            labelErrorMessage.AutoSize = true;
            labelErrorMessage.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelErrorMessage.ForeColor = Color.FromArgb(192, 0, 0);
            labelErrorMessage.Location = new Point(90, 194);
            labelErrorMessage.Name = "labelErrorMessage";
            labelErrorMessage.Size = new Size(283, 24);
            labelErrorMessage.TabIndex = 53;
            labelErrorMessage.Text = "Please Enter  a valid name";
            // 
            // editStudentButton
            // 
            editStudentButton.BackColor = Color.SteelBlue;
            editStudentButton.FlatStyle = FlatStyle.Flat;
            editStudentButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editStudentButton.ForeColor = SystemColors.ButtonHighlight;
            editStudentButton.Location = new Point(944, 508);
            editStudentButton.Name = "editStudentButton";
            editStudentButton.Size = new Size(151, 59);
            editStudentButton.TabIndex = 51;
            editStudentButton.Text = "Edit";
            editStudentButton.UseVisualStyleBackColor = false;
            editStudentButton.Click += editStudentButton_Click;
            // 
            // nameStudenttextBox
            // 
            nameStudenttextBox.BorderStyle = BorderStyle.None;
            nameStudenttextBox.Location = new Point(90, 157);
            nameStudenttextBox.Name = "nameStudenttextBox";
            nameStudenttextBox.Size = new Size(270, 24);
            nameStudenttextBox.TabIndex = 46;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.SlateGray;
            label9.Location = new Point(90, 127);
            label9.Name = "label9";
            label9.Size = new Size(88, 32);
            label9.TabIndex = 45;
            label9.Text = "Name:";
            // 
            // panel6
            // 
            panel6.BackColor = Color.Goldenrod;
            panel6.Location = new Point(90, 187);
            panel6.Name = "panel6";
            panel6.Size = new Size(270, 2);
            panel6.TabIndex = 44;
            // 
            // Pdf
            // 
            Pdf.Image = (Image)resources.GetObject("Pdf.Image");
            Pdf.Location = new Point(8, 7);
            Pdf.Name = "Pdf";
            Pdf.Size = new Size(76, 79);
            Pdf.SizeMode = PictureBoxSizeMode.Zoom;
            Pdf.TabIndex = 43;
            Pdf.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Goldenrod;
            label1.Location = new Point(90, 32);
            label1.Name = "label1";
            label1.Size = new Size(153, 32);
            label1.TabIndex = 0;
            label1.Text = "Edit Student";
            // 
            // ClassEditPage
            // 
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
            ClassEditPage.Location = new Point(4, 4);
            ClassEditPage.Name = "ClassEditPage";
            ClassEditPage.Padding = new Padding(3);
            ClassEditPage.Size = new Size(1111, 581);
            ClassEditPage.TabIndex = 1;
            ClassEditPage.Text = "Class";
            // 
            // ClasscomboBox
            // 
            ClasscomboBox.FormattingEnabled = true;
            ClasscomboBox.Location = new Point(822, 23);
            ClasscomboBox.Name = "ClasscomboBox";
            ClasscomboBox.Size = new Size(258, 33);
            ClasscomboBox.TabIndex = 76;
            ClasscomboBox.SelectedIndexChanged += ClasscomboBox_SelectedIndexChanged;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.ForeColor = Color.SlateGray;
            label18.Location = new Point(699, 20);
            label18.Name = "label18";
            label18.Size = new Size(125, 32);
            label18.TabIndex = 75;
            label18.Text = "Get By Id:";
            // 
            // classteachercomboBox
            // 
            classteachercomboBox.FlatStyle = FlatStyle.Flat;
            classteachercomboBox.FormattingEnabled = true;
            classteachercomboBox.Location = new Point(85, 303);
            classteachercomboBox.Name = "classteachercomboBox";
            classteachercomboBox.Size = new Size(275, 33);
            classteachercomboBox.TabIndex = 64;
            // 
            // labelErrorMessage8
            // 
            labelErrorMessage8.AutoSize = true;
            labelErrorMessage8.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelErrorMessage8.ForeColor = Color.FromArgb(192, 0, 0);
            labelErrorMessage8.Location = new Point(91, 183);
            labelErrorMessage8.Name = "labelErrorMessage8";
            labelErrorMessage8.Size = new Size(283, 24);
            labelErrorMessage8.TabIndex = 62;
            labelErrorMessage8.Text = "Please Enter  a valid name";
            // 
            // labelErrorMessage10
            // 
            labelErrorMessage10.AutoSize = true;
            labelErrorMessage10.BackColor = Color.Transparent;
            labelErrorMessage10.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelErrorMessage10.ForeColor = Color.FromArgb(192, 0, 0);
            labelErrorMessage10.Location = new Point(706, 270);
            labelErrorMessage10.Name = "labelErrorMessage10";
            labelErrorMessage10.Size = new Size(268, 24);
            labelErrorMessage10.TabIndex = 61;
            labelErrorMessage10.Text = "Please select from the list";
            // 
            // labelErrorMessage9
            // 
            labelErrorMessage9.AutoSize = true;
            labelErrorMessage9.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelErrorMessage9.ForeColor = Color.FromArgb(192, 0, 0);
            labelErrorMessage9.Location = new Point(90, 347);
            labelErrorMessage9.Name = "labelErrorMessage9";
            labelErrorMessage9.Size = new Size(288, 24);
            labelErrorMessage9.TabIndex = 60;
            labelErrorMessage9.Text = "Please select one of the list";
            // 
            // StudentInClasslistBox
            // 
            StudentInClasslistBox.BorderStyle = BorderStyle.None;
            StudentInClasslistBox.FormattingEnabled = true;
            StudentInClasslistBox.ItemHeight = 25;
            StudentInClasslistBox.Location = new Point(695, 171);
            StudentInClasslistBox.Name = "StudentInClasslistBox";
            StudentInClasslistBox.ScrollAlwaysVisible = true;
            StudentInClasslistBox.SelectionMode = SelectionMode.MultiSimple;
            StudentInClasslistBox.Size = new Size(270, 75);
            StudentInClasslistBox.TabIndex = 59;
            // 
            // editClassButton
            // 
            editClassButton.BackColor = Color.SteelBlue;
            editClassButton.FlatStyle = FlatStyle.Flat;
            editClassButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editClassButton.ForeColor = SystemColors.ButtonHighlight;
            editClassButton.Location = new Point(948, 510);
            editClassButton.Name = "editClassButton";
            editClassButton.Size = new Size(151, 59);
            editClassButton.TabIndex = 57;
            editClassButton.Text = "Edit";
            editClassButton.UseVisualStyleBackColor = false;
            editClassButton.Click += editClassButton_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.SlateGray;
            label6.Location = new Point(86, 271);
            label6.Name = "label6";
            label6.Size = new Size(109, 32);
            label6.TabIndex = 56;
            label6.Text = "Teacher:";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Goldenrod;
            panel3.Location = new Point(86, 342);
            panel3.Name = "panel3";
            panel3.Size = new Size(270, 2);
            panel3.TabIndex = 55;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.SlateGray;
            label5.Location = new Point(693, 136);
            label5.Name = "label5";
            label5.Size = new Size(120, 32);
            label5.TabIndex = 54;
            label5.Text = "Students:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Goldenrod;
            panel2.Location = new Point(695, 262);
            panel2.Name = "panel2";
            panel2.Size = new Size(270, 2);
            panel2.TabIndex = 53;
            // 
            // nameClasstextBox
            // 
            nameClasstextBox.BorderStyle = BorderStyle.None;
            nameClasstextBox.Location = new Point(86, 148);
            nameClasstextBox.Name = "nameClasstextBox";
            nameClasstextBox.Size = new Size(270, 24);
            nameClasstextBox.TabIndex = 52;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.SlateGray;
            label4.Location = new Point(86, 107);
            label4.Name = "label4";
            label4.Size = new Size(88, 32);
            label4.TabIndex = 51;
            label4.Text = "Name:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Goldenrod;
            panel1.Location = new Point(86, 178);
            panel1.Name = "panel1";
            panel1.Size = new Size(270, 2);
            panel1.TabIndex = 50;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(9, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(76, 79);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 49;
            pictureBox1.TabStop = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Goldenrod;
            label11.Location = new Point(92, 28);
            label11.Name = "label11";
            label11.Size = new Size(122, 32);
            label11.TabIndex = 35;
            label11.Text = "Edit Class";
            // 
            // TeacherEditPage
            // 
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
            TeacherEditPage.Location = new Point(4, 4);
            TeacherEditPage.Name = "TeacherEditPage";
            TeacherEditPage.Padding = new Padding(3);
            TeacherEditPage.Size = new Size(1111, 581);
            TeacherEditPage.TabIndex = 2;
            TeacherEditPage.Text = "Teacher";
            // 
            // TeachercomboBox
            // 
            TeachercomboBox.FormattingEnabled = true;
            TeachercomboBox.Location = new Point(798, 29);
            TeachercomboBox.Name = "TeachercomboBox";
            TeachercomboBox.Size = new Size(258, 33);
            TeachercomboBox.TabIndex = 83;
            TeachercomboBox.SelectedIndexChanged += TeachercomboBox_SelectedIndexChanged;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.ForeColor = Color.SlateGray;
            label20.Location = new Point(675, 26);
            label20.Name = "label20";
            label20.Size = new Size(125, 32);
            label20.TabIndex = 82;
            label20.Text = "Get By Id:";
            // 
            // emailexistmessage2
            // 
            emailexistmessage2.AutoSize = true;
            emailexistmessage2.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailexistmessage2.ForeColor = Color.FromArgb(192, 0, 0);
            emailexistmessage2.Location = new Point(670, 401);
            emailexistmessage2.Name = "emailexistmessage2";
            emailexistmessage2.Size = new Size(262, 24);
            emailexistmessage2.TabIndex = 81;
            emailexistmessage2.Text = "This email is already exists";
            // 
            // emailTtextBox
            // 
            emailTtextBox.BorderStyle = BorderStyle.None;
            emailTtextBox.Location = new Point(669, 366);
            emailTtextBox.Name = "emailTtextBox";
            emailTtextBox.Size = new Size(270, 24);
            emailTtextBox.TabIndex = 80;
            // 
            // emailnotvalidmessage2
            // 
            emailnotvalidmessage2.AutoSize = true;
            emailnotvalidmessage2.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailnotvalidmessage2.ForeColor = Color.FromArgb(192, 0, 0);
            emailnotvalidmessage2.Location = new Point(671, 401);
            emailnotvalidmessage2.Name = "emailnotvalidmessage2";
            emailnotvalidmessage2.Size = new Size(274, 24);
            emailnotvalidmessage2.TabIndex = 79;
            emailnotvalidmessage2.Text = "please Enter a valid email";
            // 
            // panel14
            // 
            panel14.BackColor = Color.Goldenrod;
            panel14.Location = new Point(669, 396);
            panel14.Name = "panel14";
            panel14.Size = new Size(270, 2);
            panel14.TabIndex = 75;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.ForeColor = Color.SlateGray;
            label19.Location = new Point(673, 326);
            label19.Name = "label19";
            label19.Size = new Size(83, 32);
            label19.TabIndex = 78;
            label19.Text = "Email:";
            // 
            // TeacherClasslistBox
            // 
            TeacherClasslistBox.BorderStyle = BorderStyle.None;
            TeacherClasslistBox.FormattingEnabled = true;
            TeacherClasslistBox.ItemHeight = 25;
            TeacherClasslistBox.Location = new Point(669, 164);
            TeacherClasslistBox.Name = "TeacherClasslistBox";
            TeacherClasslistBox.ScrollAlwaysVisible = true;
            TeacherClasslistBox.SelectionMode = SelectionMode.MultiSimple;
            TeacherClasslistBox.Size = new Size(282, 75);
            TeacherClasslistBox.TabIndex = 77;
            // 
            // panel15
            // 
            panel15.BackColor = Color.Goldenrod;
            panel15.Location = new Point(669, 256);
            panel15.Name = "panel15";
            panel15.Size = new Size(289, 2);
            panel15.TabIndex = 76;
            // 
            // panel12
            // 
            panel12.BackColor = Color.Goldenrod;
            panel12.Location = new Point(88, 351);
            panel12.Name = "panel12";
            panel12.Size = new Size(270, 2);
            panel12.TabIndex = 74;
            // 
            // passwordlabel2
            // 
            passwordlabel2.AutoSize = true;
            passwordlabel2.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordlabel2.ForeColor = Color.FromArgb(192, 0, 0);
            passwordlabel2.Location = new Point(88, 356);
            passwordlabel2.Name = "passwordlabel2";
            passwordlabel2.Size = new Size(560, 24);
            passwordlabel2.TabIndex = 72;
            passwordlabel2.Text = "Make the password complex and not less than 8 char";
            // 
            // passwordtextBox2
            // 
            passwordtextBox2.BorderStyle = BorderStyle.None;
            passwordtextBox2.Location = new Point(88, 321);
            passwordtextBox2.Name = "passwordtextBox2";
            passwordtextBox2.Size = new Size(270, 24);
            passwordtextBox2.TabIndex = 71;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.SlateGray;
            label14.Location = new Point(88, 264);
            label14.Name = "label14";
            label14.Size = new Size(129, 32);
            label14.TabIndex = 70;
            label14.Text = "Password:";
            // 
            // labelErrorMessage7
            // 
            labelErrorMessage7.AutoSize = true;
            labelErrorMessage7.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelErrorMessage7.ForeColor = Color.FromArgb(192, 0, 0);
            labelErrorMessage7.Location = new Point(666, 263);
            labelErrorMessage7.Name = "labelErrorMessage7";
            labelErrorMessage7.Size = new Size(320, 24);
            labelErrorMessage7.TabIndex = 61;
            labelErrorMessage7.Text = "Please select one from the List";
            // 
            // labelErrorMessage4
            // 
            labelErrorMessage4.AutoSize = true;
            labelErrorMessage4.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelErrorMessage4.ForeColor = Color.FromArgb(192, 0, 0);
            labelErrorMessage4.Location = new Point(84, 223);
            labelErrorMessage4.Name = "labelErrorMessage4";
            labelErrorMessage4.Size = new Size(283, 24);
            labelErrorMessage4.TabIndex = 59;
            labelErrorMessage4.Text = "Please Enter  a valid name";
            // 
            // editTeacherButton
            // 
            editTeacherButton.BackColor = Color.SteelBlue;
            editTeacherButton.FlatStyle = FlatStyle.Flat;
            editTeacherButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editTeacherButton.ForeColor = SystemColors.ButtonHighlight;
            editTeacherButton.Location = new Point(950, 513);
            editTeacherButton.Name = "editTeacherButton";
            editTeacherButton.Size = new Size(151, 59);
            editTeacherButton.TabIndex = 57;
            editTeacherButton.Text = "Edit";
            editTeacherButton.UseVisualStyleBackColor = false;
            editTeacherButton.Click += editTeacherButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.SlateGray;
            label3.Location = new Point(666, 129);
            label3.Name = "label3";
            label3.Size = new Size(102, 32);
            label3.TabIndex = 56;
            label3.Text = "Classes:";
            // 
            // nameTeachertextBox
            // 
            nameTeachertextBox.BorderStyle = BorderStyle.None;
            nameTeachertextBox.Location = new Point(88, 183);
            nameTeachertextBox.Name = "nameTeachertextBox";
            nameTeachertextBox.Size = new Size(270, 24);
            nameTeachertextBox.TabIndex = 55;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.SlateGray;
            label12.Location = new Point(88, 136);
            label12.Name = "label12";
            label12.Size = new Size(88, 32);
            label12.TabIndex = 54;
            label12.Text = "Name:";
            // 
            // panel9
            // 
            panel9.BackColor = Color.Goldenrod;
            panel9.Location = new Point(97, 213);
            panel9.Name = "panel9";
            panel9.Size = new Size(270, 2);
            panel9.TabIndex = 53;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(6, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(76, 79);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 44;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Goldenrod;
            label2.Location = new Point(88, 23);
            label2.Name = "label2";
            label2.Size = new Size(152, 32);
            label2.TabIndex = 36;
            label2.Text = "Edit Teacher";
            // 
            // Edit
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            Controls.Add(EditTab);
            Name = "Edit";
            Size = new Size(1274, 695);
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
