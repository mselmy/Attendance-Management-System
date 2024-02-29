using Attendance_Management_System.Classes;
using Attendance_Management_System.Classes.DataClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendance_Management_System.Forms
{
    public partial class SearchForAdmin : UserControl
    {
        public SearchForAdmin()
        {
            InitializeComponent();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void search_Load(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();

            var ClassesList = DataXMLManagement.GetClassesData();
            foreach (var classes in ClassesList)
            {
                classcombBox.Items.Add(classes.ID);
            }


            var StudentList = DataXMLManagement.GetStudentData();
            foreach (var student in StudentList)
            {
                dataGridView2.Rows.Add(student.studentId, student.name);
            }

            var TeacherList = DataXMLManagement.GetTeacherData();
            foreach (var teacher in TeacherList)
            {
                dataGridVieww.Rows.Add(teacher.TeacherId, teacher.Name);
            }

            var ClassList = DataXMLManagement.GetClassesData();
            foreach (var clas in ClassList)
            {
                dataGridView3.Rows.Add(clas.ID, clas.Name);
            }
        }

        private void addStudentButton_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            //IdStudenttextBox nameStudenttextBox

            var StudentList = DataXMLManagement.GetStudentData();


            foreach (var student in StudentList)
            {
                if (
                    (student.studentId.Contains(IdStudenttextBox.Text) || IdStudenttextBox.Text == "") &&
                    (student.name.Contains(nameStudenttextBox.Text) || nameStudenttextBox.Text == "") &&
                    (student.Classes.Any(c => c == classcombBox.Text || classcombBox.Text == "")
                    ))
                    dataGridView2.Rows.Add(student.studentId, student.name);

            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridVieww.Rows.Clear();

            var TeacherList = DataXMLManagement.GetTeacherData();


            foreach (var teacher in TeacherList)
            {
                if (
                    (teacher.TeacherId.Contains(textBox1.Text) || textBox1.Text == "") &&
                    (teacher.Name.Contains(textBox2.Text) || textBox2.Text == "") &&
                    (teacher.Teacher_Courses.Any(c => c == comboBox1.Text || comboBox1.Text == "")
                    ))
                    dataGridVieww.Rows.Add(teacher.TeacherId, teacher.Name);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            dataGridView3.Rows.Clear();

            var ClassesList = DataXMLManagement.GetClassesData();


            foreach (var clas in ClassesList)
            {
                if (
                    (clas.ID.Contains(textBox3.Text) || textBox3.Text == "") &&
                    (clas.Name.Contains(textBox4.Text) || textBox4.Text == "")
                    )
                    dataGridView3.Rows.Add(clas.ID, clas.Name);
            }
        }

    }
}
