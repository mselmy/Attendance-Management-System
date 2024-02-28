namespace Attendance_Management_System.Forms
{
    partial class search
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
            Addtab = new TabControl();
            addStudenttabPage = new TabPage();
            dataGridView2 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            classcombBox = new ComboBox();
            panel4 = new Panel();
            label7 = new Label();
            addStudentButton = new Button();
            IdStudenttextBox = new TextBox();
            label8 = new Label();
            panel5 = new Panel();
            nameStudenttextBox = new TextBox();
            label9 = new Label();
            panel6 = new Panel();
            label1 = new Label();
            AddteachertabPage = new TabPage();
            dataGridVieww = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            comboBox1 = new ComboBox();
            panel7 = new Panel();
            label10 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            label11 = new Label();
            panel8 = new Panel();
            textBox2 = new TextBox();
            label12 = new Label();
            panel9 = new Panel();
            label2 = new Label();
            AddclasstabPage = new TabPage();
            dataGridView3 = new DataGridView();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            button2 = new Button();
            textBox3 = new TextBox();
            label5 = new Label();
            panel2 = new Panel();
            textBox4 = new TextBox();
            label6 = new Label();
            panel3 = new Panel();
            label3 = new Label();
            admindashboard1 = new admindashboard();
            Addtab.SuspendLayout();
            addStudenttabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            AddteachertabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridVieww).BeginInit();
            AddclasstabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            SuspendLayout();
            // 
            // Addtab
            // 
            Addtab.Alignment = TabAlignment.Bottom;
            Addtab.Anchor = AnchorStyles.None;
            Addtab.Controls.Add(addStudenttabPage);
            Addtab.Controls.Add(AddteachertabPage);
            Addtab.Controls.Add(AddclasstabPage);
            Addtab.Location = new Point(93, 23);
            Addtab.Margin = new Padding(6);
            Addtab.Name = "Addtab";
            Addtab.SelectedIndex = 0;
            Addtab.Size = new Size(2586, 1724);
            Addtab.TabIndex = 1;
            // 
            // addStudenttabPage
            // 
            addStudenttabPage.BackColor = Color.White;
            addStudenttabPage.Controls.Add(admindashboard1);
            addStudenttabPage.Controls.Add(dataGridView2);
            addStudenttabPage.Controls.Add(classcombBox);
            addStudenttabPage.Controls.Add(panel4);
            addStudenttabPage.Controls.Add(label7);
            addStudenttabPage.Controls.Add(addStudentButton);
            addStudenttabPage.Controls.Add(IdStudenttextBox);
            addStudenttabPage.Controls.Add(label8);
            addStudenttabPage.Controls.Add(panel5);
            addStudenttabPage.Controls.Add(nameStudenttextBox);
            addStudenttabPage.Controls.Add(label9);
            addStudenttabPage.Controls.Add(panel6);
            addStudenttabPage.Controls.Add(label1);
            addStudenttabPage.Location = new Point(10, 10);
            addStudenttabPage.Margin = new Padding(6);
            addStudenttabPage.Name = "addStudenttabPage";
            addStudenttabPage.Padding = new Padding(6);
            addStudenttabPage.Size = new Size(2566, 1656);
            addStudenttabPage.TabIndex = 0;
            addStudenttabPage.Text = " Students";
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.BackgroundColor = Color.White;
            dataGridView2.BorderStyle = BorderStyle.None;
            dataGridView2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dataGridView2.Location = new Point(132, 470);
            dataGridView2.Margin = new Padding(6);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(2125, 1230);
            dataGridView2.TabIndex = 28;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Name";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // classcombBox
            // 
            classcombBox.FlatStyle = FlatStyle.Flat;
            classcombBox.FormattingEnabled = true;
            classcombBox.Location = new Point(1468, 318);
            classcombBox.Margin = new Padding(6);
            classcombBox.Name = "classcombBox";
            classcombBox.Size = new Size(580, 49);
            classcombBox.TabIndex = 23;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Goldenrod;
            panel4.Location = new Point(1475, 394);
            panel4.Margin = new Padding(6);
            panel4.Name = "panel4";
            panel4.Size = new Size(574, 4);
            panel4.TabIndex = 22;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.SlateGray;
            label7.Location = new Point(1479, 267);
            label7.Margin = new Padding(6, 0, 6, 0);
            label7.Name = "label7";
            label7.Size = new Size(128, 54);
            label7.TabIndex = 21;
            label7.Text = "Class:";
            // 
            // addStudentButton
            // 
            addStudentButton.BackColor = Color.DarkGreen;
            addStudentButton.FlatStyle = FlatStyle.Flat;
            addStudentButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addStudentButton.ForeColor = SystemColors.ButtonHighlight;
            addStudentButton.Location = new Point(2204, 307);
            addStudentButton.Margin = new Padding(6);
            addStudentButton.Name = "addStudentButton";
            addStudentButton.Size = new Size(251, 103);
            addStudentButton.TabIndex = 17;
            addStudentButton.Text = "Search";
            addStudentButton.UseVisualStyleBackColor = false;
            addStudentButton.Click += addStudentButton_Click;
            // 
            // IdStudenttextBox
            // 
            IdStudenttextBox.BorderStyle = BorderStyle.None;
            IdStudenttextBox.Location = new Point(125, 334);
            IdStudenttextBox.Margin = new Padding(6);
            IdStudenttextBox.Name = "IdStudenttextBox";
            IdStudenttextBox.Size = new Size(574, 40);
            IdStudenttextBox.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.SlateGray;
            label8.Location = new Point(132, 257);
            label8.Margin = new Padding(6, 0, 6, 0);
            label8.Name = "label8";
            label8.Size = new Size(155, 54);
            label8.TabIndex = 15;
            label8.Text = "Reg.Id:";
            // 
            // panel5
            // 
            panel5.BackColor = Color.Goldenrod;
            panel5.Location = new Point(121, 396);
            panel5.Margin = new Padding(6);
            panel5.Name = "panel5";
            panel5.Size = new Size(574, 4);
            panel5.TabIndex = 14;
            // 
            // nameStudenttextBox
            // 
            nameStudenttextBox.BorderStyle = BorderStyle.None;
            nameStudenttextBox.Location = new Point(824, 334);
            nameStudenttextBox.Margin = new Padding(6);
            nameStudenttextBox.Name = "nameStudenttextBox";
            nameStudenttextBox.Size = new Size(574, 40);
            nameStudenttextBox.TabIndex = 13;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.SlateGray;
            label9.Location = new Point(814, 257);
            label9.Margin = new Padding(6, 0, 6, 0);
            label9.Name = "label9";
            label9.Size = new Size(147, 54);
            label9.TabIndex = 12;
            label9.Text = "Name:";
            // 
            // panel6
            // 
            panel6.BackColor = Color.Goldenrod;
            panel6.Location = new Point(816, 396);
            panel6.Margin = new Padding(6);
            panel6.Name = "panel6";
            panel6.Size = new Size(574, 4);
            panel6.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Goldenrod;
            label1.Location = new Point(17, 16);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(307, 54);
            label1.TabIndex = 0;
            label1.Text = "Search Student";
            // 
            // AddteachertabPage
            // 
            AddteachertabPage.BackColor = Color.White;
            AddteachertabPage.Controls.Add(dataGridVieww);
            AddteachertabPage.Controls.Add(comboBox1);
            AddteachertabPage.Controls.Add(panel7);
            AddteachertabPage.Controls.Add(label10);
            AddteachertabPage.Controls.Add(button1);
            AddteachertabPage.Controls.Add(textBox1);
            AddteachertabPage.Controls.Add(label11);
            AddteachertabPage.Controls.Add(panel8);
            AddteachertabPage.Controls.Add(textBox2);
            AddteachertabPage.Controls.Add(label12);
            AddteachertabPage.Controls.Add(panel9);
            AddteachertabPage.Controls.Add(label2);
            AddteachertabPage.Location = new Point(10, 10);
            AddteachertabPage.Margin = new Padding(6);
            AddteachertabPage.Name = "AddteachertabPage";
            AddteachertabPage.Padding = new Padding(6);
            AddteachertabPage.Size = new Size(2566, 1656);
            AddteachertabPage.TabIndex = 1;
            AddteachertabPage.Text = "Teachers";
            // 
            // dataGridVieww
            // 
            dataGridVieww.AllowUserToAddRows = false;
            dataGridVieww.AllowUserToDeleteRows = false;
            dataGridVieww.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridVieww.BackgroundColor = Color.White;
            dataGridVieww.BorderStyle = BorderStyle.None;
            dataGridVieww.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridVieww.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridVieww.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2 });
            dataGridVieww.Location = new Point(132, 470);
            dataGridVieww.Margin = new Padding(6);
            dataGridVieww.Name = "dataGridVieww";
            dataGridVieww.ReadOnly = true;
            dataGridVieww.RowHeadersWidth = 51;
            dataGridVieww.Size = new Size(2125, 1074);
            dataGridVieww.TabIndex = 39;
            dataGridVieww.CellContentClick += dataGridView1_CellContentClick;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "ID";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Name";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // comboBox1
            // 
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(1468, 318);
            comboBox1.Margin = new Padding(6);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(580, 49);
            comboBox1.TabIndex = 38;
            // 
            // panel7
            // 
            panel7.BackColor = Color.Goldenrod;
            panel7.Location = new Point(1475, 394);
            panel7.Margin = new Padding(6);
            panel7.Name = "panel7";
            panel7.Size = new Size(574, 4);
            panel7.TabIndex = 37;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.SlateGray;
            label10.Location = new Point(1479, 267);
            label10.Margin = new Padding(6, 0, 6, 0);
            label10.Name = "label10";
            label10.Size = new Size(128, 54);
            label10.TabIndex = 36;
            label10.Text = "Class:";
            // 
            // button1
            // 
            button1.BackColor = Color.DarkGreen;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(2204, 307);
            button1.Margin = new Padding(6);
            button1.Name = "button1";
            button1.Size = new Size(251, 103);
            button1.TabIndex = 35;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(125, 334);
            textBox1.Margin = new Padding(6);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(574, 40);
            textBox1.TabIndex = 34;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.SlateGray;
            label11.Location = new Point(132, 257);
            label11.Margin = new Padding(6, 0, 6, 0);
            label11.Name = "label11";
            label11.Size = new Size(155, 54);
            label11.TabIndex = 33;
            label11.Text = "Reg.Id:";
            // 
            // panel8
            // 
            panel8.BackColor = Color.Goldenrod;
            panel8.Location = new Point(121, 396);
            panel8.Margin = new Padding(6);
            panel8.Name = "panel8";
            panel8.Size = new Size(574, 4);
            panel8.TabIndex = 32;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Location = new Point(824, 334);
            textBox2.Margin = new Padding(6);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(574, 40);
            textBox2.TabIndex = 31;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.SlateGray;
            label12.Location = new Point(814, 257);
            label12.Margin = new Padding(6, 0, 6, 0);
            label12.Name = "label12";
            label12.Size = new Size(147, 54);
            label12.TabIndex = 30;
            label12.Text = "Name:";
            // 
            // panel9
            // 
            panel9.BackColor = Color.Goldenrod;
            panel9.Location = new Point(816, 396);
            panel9.Margin = new Padding(6);
            panel9.Name = "panel9";
            panel9.Size = new Size(574, 4);
            panel9.TabIndex = 29;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Goldenrod;
            label2.Location = new Point(17, 16);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(303, 54);
            label2.TabIndex = 1;
            label2.Text = "Search Teacher";
            // 
            // AddclasstabPage
            // 
            AddclasstabPage.BackColor = Color.White;
            AddclasstabPage.Controls.Add(dataGridView3);
            AddclasstabPage.Controls.Add(button2);
            AddclasstabPage.Controls.Add(textBox3);
            AddclasstabPage.Controls.Add(label5);
            AddclasstabPage.Controls.Add(panel2);
            AddclasstabPage.Controls.Add(textBox4);
            AddclasstabPage.Controls.Add(label6);
            AddclasstabPage.Controls.Add(panel3);
            AddclasstabPage.Controls.Add(label3);
            AddclasstabPage.Location = new Point(10, 10);
            AddclasstabPage.Margin = new Padding(6);
            AddclasstabPage.Name = "AddclasstabPage";
            AddclasstabPage.Padding = new Padding(6);
            AddclasstabPage.Size = new Size(2566, 1656);
            AddclasstabPage.TabIndex = 2;
            AddclasstabPage.Text = "Classes";
            // 
            // dataGridView3
            // 
            dataGridView3.AllowUserToAddRows = false;
            dataGridView3.AllowUserToDeleteRows = false;
            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView3.BackgroundColor = Color.White;
            dataGridView3.BorderStyle = BorderStyle.None;
            dataGridView3.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4 });
            dataGridView3.Location = new Point(126, 483);
            dataGridView3.Margin = new Padding(6);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.ReadOnly = true;
            dataGridView3.RowHeadersWidth = 51;
            dataGridView3.Size = new Size(2125, 1074);
            dataGridView3.TabIndex = 50;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "ID";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Name";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkGreen;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(1548, 323);
            button2.Margin = new Padding(6);
            button2.Name = "button2";
            button2.Size = new Size(251, 103);
            button2.TabIndex = 46;
            button2.Text = "Search";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Location = new Point(119, 347);
            textBox3.Margin = new Padding(6);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(574, 40);
            textBox3.TabIndex = 45;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.SlateGray;
            label5.Location = new Point(126, 270);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(155, 54);
            label5.TabIndex = 44;
            label5.Text = "Reg.Id:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Goldenrod;
            panel2.Location = new Point(115, 409);
            panel2.Margin = new Padding(6);
            panel2.Name = "panel2";
            panel2.Size = new Size(574, 4);
            panel2.TabIndex = 43;
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Location = new Point(818, 347);
            textBox4.Margin = new Padding(6);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(574, 40);
            textBox4.TabIndex = 42;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.SlateGray;
            label6.Location = new Point(808, 270);
            label6.Margin = new Padding(6, 0, 6, 0);
            label6.Name = "label6";
            label6.Size = new Size(147, 54);
            label6.TabIndex = 41;
            label6.Text = "Name:";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Goldenrod;
            panel3.Location = new Point(810, 409);
            panel3.Margin = new Padding(6);
            panel3.Name = "panel3";
            panel3.Size = new Size(574, 4);
            panel3.TabIndex = 40;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Goldenrod;
            label3.Location = new Point(17, 16);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(293, 54);
            label3.TabIndex = 1;
            label3.Text = "Search Classes";
            // 
            // admindashboard1
            // 
            admindashboard1.BackColor = SystemColors.ButtonHighlight;
            admindashboard1.Location = new Point(16, 1629);
            admindashboard1.Margin = new Padding(4, 4, 4, 4);
            admindashboard1.Name = "admindashboard1";
            admindashboard1.Size = new Size(5950, 3885);
            admindashboard1.TabIndex = 29;
            // 
            // search
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Addtab);
            Margin = new Padding(6);
            Name = "search";
            Size = new Size(3079, 1844);
            Load += search_Load;
            Addtab.ResumeLayout(false);
            addStudenttabPage.ResumeLayout(false);
            addStudenttabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            AddteachertabPage.ResumeLayout(false);
            AddteachertabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridVieww).EndInit();
            AddclasstabPage.ResumeLayout(false);
            AddclasstabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl Addtab;
        private TabPage AddteachertabPage;
        private TabPage AddclasstabPage;
        private Label label3;
        private TabPage addStudenttabPage;
        private ComboBox classcombBox;
        private Panel panel4;
        private Label label7;
        private Button addStudentButton;
        private TextBox IdStudenttextBox;
        private Label label8;
        private Panel panel5;
        private TextBox nameStudenttextBox;
        private Label label9;
        private Panel panel6;
        private Label label1;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridView dataGridVieww;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private ComboBox comboBox1;
        private Panel panel7;
        private Label label10;
        private Button button1;
        private TextBox textBox1;
        private Label label11;
        private Panel panel8;
        private TextBox textBox2;
        private Label label12;
        private Panel panel9;
        private Label label2;
        private DataGridView dataGridView3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private Button button2;
        private TextBox textBox3;
        private Label label5;
        private Panel panel2;
        private TextBox textBox4;
        private Label label6;
        private Panel panel3;
        private admindashboard admindashboard1;
    }
}
