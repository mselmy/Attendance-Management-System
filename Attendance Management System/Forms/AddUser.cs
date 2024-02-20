using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Attendance_Management_System.Classes;

namespace Attendance_Management_System.Forms
{
    public partial class AddUser : UserControl
    {
        private List<string> students = new List<string>();
        public AddUser()
        {
            InitializeComponent();
            pictureBoxErrorMessage.Visible = false;
            labelErrorMessage.Visible = false;
            pictureBoxErrorMessage1.Visible = false;
            labelErrorMessage1.Visible = false;
            pictureBoxErrorMessage2.Visible = false;
            labelErrorMessage2.Visible = false;
            labelErrorMessage3.Visible = false;
            pictureBoxErrorMessage3.Visible = false;
            labelErrorMessage4.Visible = false;
            pictureBoxErrorMessage4.Visible = false;
            labelErrorMessage5.Visible = false;
            pictureBoxErrorMessage5.Visible = false;
            labelErrorMessage6.Visible = false;
            pictureBoxErrorMessage6.Visible = false;
            labelErrorMessage7.Visible = false;
            pictureBoxErrorMessage7.Visible = false;
            labelErrorMessage8.Visible = false;
            pictureBoxErrorMessage8.Visible = false;
            labelErrorMessage9.Visible = false;
            pictureBoxErrorMessage9.Visible = false;
            labelErrorMessage10.Visible = false;
            pictureBoxErrorMessage10.Visible = false;
            labelErrorMessage11.Visible = false;
            pictureBoxErrorMessage11.Visible = false;
            labelErrorMessage12.Visible = false;
            pictureBoxErrorMessage12.Visible = false;
            passwordpictureBox2.Visible = false;
            passwordpictureBox1.Visible = false;
            passwordlabel1.Visible= false;
            passwordlabel2.Visible= false;
            List<string> idList = XMLManagement.NodesToList(Configs.ClassesPath, "id");
            List<string> studentidList = XMLManagement.GetIdofAllSt_Th(Configs.StudentsPath, "id");
            List<string> teacheridList = XMLManagement.GetIdofAllSt_Th(Configs.TeachersPath, "id");

            foreach (string id in idList)
            {
                classcombBox.Items.Add(id);
                classTeachercombBox.Items.Add(id);

            }
            foreach (string id in studentidList)
            {
                StudentInClasslistBox.Items.Add(id);
            }
            foreach (string id in teacheridList)
            {
                classteachercomboBox.Items.Add(id);
            }
            classTeachercombBox.SelectedIndex = 0;
            classcombBox.SelectedIndex = 0;
            classteachercomboBox.SelectedIndex = 0;



        }

        private void addStudentButton_Click(object sender, EventArgs e)
        {
            string name = nameStudenttextBox.Text;
            string ID = IdStudenttextBox.Text;
            string classname = classcombBox.Text;
            string password=passswordstdtextBox.Text;
            if (!Validation.IsnameValid(name))
            {
                pictureBoxErrorMessage.Visible = true;
                labelErrorMessage.Visible = true;
                pictureBoxErrorMessage1.Visible = false;
                labelErrorMessage1.Visible = false;
                pictureBoxErrorMessage2.Visible = false;
                labelErrorMessage2.Visible = false;
                labelErrorMessage3.Visible = false;
                pictureBoxErrorMessage3.Visible = false;
                passwordpictureBox1.Visible = false;
                passwordlabel1.Visible = false;


            }
            else if (!Validation.IsclassValid(classname, XMLManagement.NodesToList(Configs.ClassesPath, "id")))
            {
                pictureBoxErrorMessage1.Visible = true;
                labelErrorMessage1.Visible = true;
                pictureBoxErrorMessage2.Visible = false;
                labelErrorMessage2.Visible = false;
                pictureBoxErrorMessage.Visible = false;
                labelErrorMessage.Visible = false;
                labelErrorMessage3.Visible = false;
                pictureBoxErrorMessage3.Visible = false;
                passwordpictureBox1.Visible = false;
                passwordlabel1.Visible = false;



            }
            else if (!Validation.IsIdValid("ST", ID))
            {
                pictureBoxErrorMessage.Visible = false;
                labelErrorMessage.Visible = false;
                pictureBoxErrorMessage1.Visible = false;
                labelErrorMessage1.Visible = false;
                pictureBoxErrorMessage2.Visible = true;
                labelErrorMessage2.Visible = true;
                labelErrorMessage3.Visible = false;
                pictureBoxErrorMessage3.Visible = false;
                passwordpictureBox1.Visible = false;
                passwordlabel1.Visible = false;


            }
            else if (Validation.IsIdUnique(ID, XMLManagement.GetIdofAllSt_Th(Configs.StudentsPath, "id")))
            {
                pictureBoxErrorMessage.Visible = false;
                labelErrorMessage.Visible = false;
                pictureBoxErrorMessage1.Visible = false;
                labelErrorMessage1.Visible = false;
                pictureBoxErrorMessage2.Visible = false;
                labelErrorMessage2.Visible = false;
                passwordpictureBox1.Visible = false;
                passwordlabel1.Visible = false;
                labelErrorMessage3.Visible = true;
                pictureBoxErrorMessage3.Visible = true;


            }
            else if(!Validation.IspasswordComplexValid(password))
            {
                pictureBoxErrorMessage.Visible = false;
                labelErrorMessage.Visible = false;
                pictureBoxErrorMessage1.Visible = false;
                labelErrorMessage1.Visible = false;
                pictureBoxErrorMessage2.Visible = false;
                labelErrorMessage2.Visible = false;
                labelErrorMessage3.Visible = false;
                pictureBoxErrorMessage3.Visible = false;
                passwordpictureBox1.Visible = true;
                passwordlabel1.Visible = true;
            }
            else
            {
                pictureBoxErrorMessage.Visible = false;
                labelErrorMessage.Visible = false;
                pictureBoxErrorMessage1.Visible = false;
                labelErrorMessage1.Visible = false;
                pictureBoxErrorMessage2.Visible = false;
                labelErrorMessage2.Visible = false;
                labelErrorMessage3.Visible = false;
                pictureBoxErrorMessage3.Visible = false;
                passwordpictureBox1.Visible = false;
                passwordlabel1.Visible = false;
                nameStudenttextBox.Clear();
                IdStudenttextBox.Clear();
                classcombBox.SelectedIndex = 0;
                passswordstdtextBox.Clear();
                if (XMLManagement.AddnewStudent(name,password, ID, classname))
                {
                    MessageBox.Show("The Student has been Added successfully");
                }
                else
                {
                    MessageBox.Show("Sorry! failed to addded, please try again");
                }

            }

        }

        private void addTeacherButton_Click(object sender, EventArgs e)
        {
            string name = nameTeachertextBox.Text;
            string ID = IdTeachertextBox.Text;
            string classname = classTeachercombBox.Text;
            string password = passwordtextBox2.Text;
            if (!Validation.IsnameValid(name))
            {
                pictureBoxErrorMessage4.Visible = true;
                labelErrorMessage4.Visible = true;
                pictureBoxErrorMessage5.Visible = false;
                labelErrorMessage5.Visible = false;
                pictureBoxErrorMessage6.Visible = false;
                labelErrorMessage6.Visible = false;
                labelErrorMessage7.Visible = false;
                pictureBoxErrorMessage7.Visible = false;
                passwordpictureBox2.Visible = false;
                passwordlabel2.Visible = false;


            }
            else if (!Validation.IsclassValid(classname, XMLManagement.NodesToList(Configs.ClassesPath, "id")))
            {
                pictureBoxErrorMessage7.Visible = true;
                labelErrorMessage7.Visible = true;
                pictureBoxErrorMessage6.Visible = false;
                labelErrorMessage6.Visible = false;
                pictureBoxErrorMessage5.Visible = false;
                labelErrorMessage5.Visible = false;
                labelErrorMessage4.Visible = false;
                pictureBoxErrorMessage4.Visible = false;
                passwordpictureBox2.Visible = false;
                passwordlabel2.Visible = false;


            }
            else if (!Validation.IsIdValid("TE", ID))
            {
                pictureBoxErrorMessage5.Visible = false;
                labelErrorMessage5.Visible = false;
                pictureBoxErrorMessage4.Visible = false;
                labelErrorMessage4.Visible = false;
                pictureBoxErrorMessage6.Visible = true;
                labelErrorMessage6.Visible = true;
                labelErrorMessage7.Visible = false;
                pictureBoxErrorMessage7.Visible = false;
                passwordpictureBox2.Visible = false;
                passwordlabel2.Visible = false;

            }
            else if (Validation.IsIdUnique(ID, XMLManagement.GetIdofAllSt_Th(Configs.TeachersPath, "id")))
            {
                pictureBoxErrorMessage7.Visible = false;
                labelErrorMessage7.Visible = false;
                pictureBoxErrorMessage6.Visible = false;
                labelErrorMessage6.Visible = false;
                pictureBoxErrorMessage4.Visible = false;
                labelErrorMessage4.Visible = false;
                labelErrorMessage5.Visible = true;
                pictureBoxErrorMessage5.Visible = true;
                passwordpictureBox2.Visible = false;
                passwordlabel2.Visible = false;


            }
            else if(!Validation.IspasswordComplexValid(password))
            {
                pictureBoxErrorMessage7.Visible = false;
                labelErrorMessage7.Visible = false;
                pictureBoxErrorMessage6.Visible = false;
                labelErrorMessage6.Visible = false;
                pictureBoxErrorMessage4.Visible = false;
                labelErrorMessage4.Visible = false;
                labelErrorMessage5.Visible = false;
                pictureBoxErrorMessage5.Visible = false;
                passwordpictureBox2.Visible = true;
                passwordlabel2.Visible = true;
            }
            else
            {
                pictureBoxErrorMessage4.Visible = false;
                labelErrorMessage4.Visible = false;
                pictureBoxErrorMessage5.Visible = false;
                labelErrorMessage5.Visible = false;
                pictureBoxErrorMessage6.Visible = false;
                labelErrorMessage6.Visible = false;
                labelErrorMessage7.Visible = false;
                pictureBoxErrorMessage7.Visible = false;
                passwordpictureBox2.Visible = false;
                passwordlabel2.Visible = false;
                nameTeachertextBox.Clear();
                IdTeachertextBox.Clear();
                classTeachercombBox.SelectedIndex = 0;
                passwordtextBox2.Clear();
                if (XMLManagement.AddnewTeacher(name,password, ID, classname))
                {
                    MessageBox.Show("The Teacher has been Added successfully");
                }
                else
                {
                    MessageBox.Show("Sorry! failed to addded, please try again");
                }

            }

        }

        private void addClassButton_Click(object sender, EventArgs e)
        {
            string name = nameClasstextBox.Text;
            string IdTeacher = classteachercomboBox.Text;
            string Idclass = classIdtextBox.Text;
            if (!Validation.IsnameValid(name))
            {
                pictureBoxErrorMessage8.Visible = true;
                labelErrorMessage8.Visible = true;
                pictureBoxErrorMessage9.Visible = false;
                labelErrorMessage9.Visible = false;
                pictureBoxErrorMessage10.Visible = false;
                labelErrorMessage10.Visible = false;
                pictureBoxErrorMessage11.Visible = false;
                labelErrorMessage11.Visible = false;
                pictureBoxErrorMessage12.Visible = false;
                labelErrorMessage12.Visible = false;

            }
            else if (!Validation.IsclassValid(IdTeacher, XMLManagement.GetIdofAllSt_Th(Configs.TeachersPath, "id")))
            {
                pictureBoxErrorMessage9.Visible = true;
                labelErrorMessage9.Visible = true;
                pictureBoxErrorMessage8.Visible = false;
                labelErrorMessage8.Visible = false;
                pictureBoxErrorMessage10.Visible = false;
                labelErrorMessage10.Visible = false;
                pictureBoxErrorMessage11.Visible = false;
                labelErrorMessage11.Visible = false;
                pictureBoxErrorMessage12.Visible = false;
                labelErrorMessage12.Visible = false;


            }
            else if (students.Capacity == 0)
            {
                pictureBoxErrorMessage10.Visible = true;
                labelErrorMessage10.Visible = true;
                pictureBoxErrorMessage9.Visible = false;
                labelErrorMessage9.Visible = false;
                pictureBoxErrorMessage8.Visible = false;
                labelErrorMessage8.Visible = false;
                pictureBoxErrorMessage11.Visible = false;
                labelErrorMessage11.Visible = false;
                pictureBoxErrorMessage12.Visible = false;
                labelErrorMessage12.Visible = false;


            }

            else if (!Validation.IsIdValid("CL", Idclass))
            {
                pictureBoxErrorMessage10.Visible = false;
                labelErrorMessage10.Visible = false;
                pictureBoxErrorMessage12.Visible = false;
                labelErrorMessage12.Visible = false;
                pictureBoxErrorMessage12.Visible = true;
                labelErrorMessage12.Visible = true;
                labelErrorMessage9.Visible = false;
                pictureBoxErrorMessage9.Visible = false;
                labelErrorMessage8.Visible = false;
                pictureBoxErrorMessage8.Visible = false;


            }
            else if (Validation.IsIdUnique(Idclass, XMLManagement.NodesToList(Configs.ClassesPath, "id")))
            {
                pictureBoxErrorMessage8.Visible = false;
                labelErrorMessage8.Visible = false;
                pictureBoxErrorMessage9.Visible = false;
                labelErrorMessage9.Visible = false;
                pictureBoxErrorMessage10.Visible = false;
                labelErrorMessage10.Visible = false;
                pictureBoxErrorMessage12.Visible = false;
                labelErrorMessage12.Visible = false;
                labelErrorMessage11.Visible = true;
                pictureBoxErrorMessage11.Visible = true;


            }

            else
            {
                pictureBoxErrorMessage8.Visible = false;
                labelErrorMessage8.Visible = false;
                pictureBoxErrorMessage9.Visible = false;
                labelErrorMessage9.Visible = false;
                pictureBoxErrorMessage10.Visible = false;
                labelErrorMessage10.Visible = false;
                pictureBoxErrorMessage11.Visible = false;
                labelErrorMessage11.Visible = false;
                pictureBoxErrorMessage12.Visible = false;
                labelErrorMessage12.Visible = false;
                nameClasstextBox.Clear();
                classIdtextBox.Clear();
                IdTeachertextBox.Clear();
                if (XMLManagement.AddnewClass(name, Idclass, IdTeacher, students))
                {
                    students.Clear();
                    MessageBox.Show("The Class has been Added successfully");
                }
                else
                {
                    students.Clear();
                    MessageBox.Show("Sorry! failed to addded, please try again");
                }


            }


        }
        private void StudentInClasslistBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            foreach (var item in StudentInClasslistBox.SelectedItems)
            {
                students.Add(item.ToString());
            }

        }

       
    }
}
