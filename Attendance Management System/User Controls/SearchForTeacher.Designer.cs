namespace Attendance_Management_System.Forms
{
    partial class SearchForTeacher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchForTeacher));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            Addtab = new TabControl();
            addStudenttabPage = new TabPage();
            admindashboard1 = new admindashboard();
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
            Addtab.SuspendLayout();
            addStudenttabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            AddclasstabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            SuspendLayout();
            // 
            // Addtab
            // 
            resources.ApplyResources(Addtab, "Addtab");
            Addtab.Controls.Add(addStudenttabPage);
            Addtab.Controls.Add(AddclasstabPage);
            Addtab.Name = "Addtab";
            Addtab.SelectedIndex = 0;
            // 
            // addStudenttabPage
            // 
            resources.ApplyResources(addStudenttabPage, "addStudenttabPage");
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
            addStudenttabPage.Name = "addStudenttabPage";
            // 
            // admindashboard1
            // 
            resources.ApplyResources(admindashboard1, "admindashboard1");
            admindashboard1.BackColor = SystemColors.ButtonHighlight;
            admindashboard1.Name = "admindashboard1";
            // 
            // dataGridView2
            // 
            resources.ApplyResources(dataGridView2, "dataGridView2");
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.BackgroundColor = Color.White;
            dataGridView2.BorderStyle = BorderStyle.None;
            dataGridView2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // Column1
            // 
            resources.ApplyResources(Column1, "Column1");
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            resources.ApplyResources(Column2, "Column2");
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // classcombBox
            // 
            resources.ApplyResources(classcombBox, "classcombBox");
            classcombBox.FormattingEnabled = true;
            classcombBox.Name = "classcombBox";
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
            // addStudentButton
            // 
            resources.ApplyResources(addStudentButton, "addStudentButton");
            addStudentButton.BackColor = Color.DarkGreen;
            addStudentButton.ForeColor = SystemColors.ButtonHighlight;
            addStudentButton.Name = "addStudentButton";
            addStudentButton.UseVisualStyleBackColor = false;
            addStudentButton.Click += addStudentButton_Click;
            // 
            // IdStudenttextBox
            // 
            resources.ApplyResources(IdStudenttextBox, "IdStudenttextBox");
            IdStudenttextBox.BorderStyle = BorderStyle.None;
            IdStudenttextBox.Name = "IdStudenttextBox";
            // 
            // label8
            // 
            resources.ApplyResources(label8, "label8");
            label8.ForeColor = Color.SlateGray;
            label8.Name = "label8";
            // 
            // panel5
            // 
            resources.ApplyResources(panel5, "panel5");
            panel5.BackColor = Color.Goldenrod;
            panel5.Name = "panel5";
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
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.ForeColor = Color.Goldenrod;
            label1.Name = "label1";
            // 
            // AddclasstabPage
            // 
            resources.ApplyResources(AddclasstabPage, "AddclasstabPage");
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
            AddclasstabPage.Name = "AddclasstabPage";
            // 
            // dataGridView3
            // 
            resources.ApplyResources(dataGridView3, "dataGridView3");
            dataGridView3.AllowUserToAddRows = false;
            dataGridView3.AllowUserToDeleteRows = false;
            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView3.BackgroundColor = Color.White;
            dataGridView3.BorderStyle = BorderStyle.None;
            dataGridView3.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4 });
            dataGridView3.Name = "dataGridView3";
            dataGridView3.ReadOnly = true;
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridView3.RowsDefaultCellStyle = dataGridViewCellStyle2;
            // 
            // dataGridViewTextBoxColumn3
            // 
            resources.ApplyResources(dataGridViewTextBoxColumn3, "dataGridViewTextBoxColumn3");
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            resources.ApplyResources(dataGridViewTextBoxColumn4, "dataGridViewTextBoxColumn4");
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // button2
            // 
            resources.ApplyResources(button2, "button2");
            button2.BackColor = Color.DarkGreen;
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Name = "button2";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // textBox3
            // 
            resources.ApplyResources(textBox3, "textBox3");
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Name = "textBox3";
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
            // textBox4
            // 
            resources.ApplyResources(textBox4, "textBox4");
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Name = "textBox4";
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
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.ForeColor = Color.Goldenrod;
            label3.Name = "label3";
            // 
            // SearchForTeacher
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Addtab);
            Name = "SearchForTeacher";
            Load += search_Load;
            Addtab.ResumeLayout(false);
            addStudenttabPage.ResumeLayout(false);
            addStudenttabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            AddclasstabPage.ResumeLayout(false);
            AddclasstabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl Addtab;
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
        private DataGridView dataGridView3;
        private Button button2;
        private TextBox textBox3;
        private Label label5;
        private Panel panel2;
        private TextBox textBox4;
        private Label label6;
        private Panel panel3;
        private admindashboard admindashboard1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}
