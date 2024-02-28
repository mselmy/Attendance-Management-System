using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using Attendance_Management_System.Classes;

namespace Attendance_Management_System.Forms
{
    public partial class AddUser : UserControl
    {
        private static List<string> students = new List<string>();
        private static List<string> studClasses = new List<string>();
        private static List<string> teachClasses = new List<string>();

        private static List<string> classidList;
        private static List<string> teacheridList;
        private static List<string> studentidList;

        public AddUser()
        {
            InitializeComponent();
            IntializeUi();

        }
        private void IntializeUi()
        {
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
            passwordlabel1.Visible = false;
            passwordlabel2.Visible = false;
            emailexisterrormessage.Visible = false;
            emailnotvaliderrormessage.Visible = false;
            emailexistmessage2.Visible = false;
            emailnotvalidmessage2.Visible = false;

        }
        private void Intilaize()
        {
            classidList = XMLManagement.NodesToList(Configs.ClassesPath, "id");
            studentidList = XMLManagement.GetIdofAllSt_Th(Configs.StudentsPath, "id");
            teacheridList = XMLManagement.GetIdofAllSt_Th(Configs.TeachersPath, "id");
        }
        private void populateTheList()
        {
            foreach (string id in classidList)
            {
                classStudlistBox.Items.Add(id);
                TeacherClasslistBox.Items.Add(id);

            }
            foreach (string id in studentidList)
            {
                StudentInClasslistBox.Items.Add(id);
            }
            foreach (string id in teacheridList)
            {
                classteachercomboBox.Items.Add(id);
            }
        }
        private void addStudentButton_Click(object sender, EventArgs e)
        {

            string name = nameStudenttextBox.Text;
            string ID = IdStudenttextBox.Text;
            string password = passswordstdtextBox.Text;
            string email = emailtextBox.Text;
            AddListOfClassesToStudent();
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
                emailexisterrormessage.Visible = false;
                emailnotvaliderrormessage.Visible = false;


            }
            else if (studClasses.Count == 0)
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
                emailexisterrormessage.Visible = false;
                emailnotvaliderrormessage.Visible = false;



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
                emailexisterrormessage.Visible = false;
                emailnotvaliderrormessage.Visible = false;


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
                emailexisterrormessage.Visible = false;
                emailnotvaliderrormessage.Visible = false;


            }
            else if (!Validation.IspasswordComplexValid(password))
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
                emailexisterrormessage.Visible = false;
                emailnotvaliderrormessage.Visible = false;
            }
            else if (!Validation.ISEmailVal(email))
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
                emailnotvaliderrormessage.Visible = true;
                emailexisterrormessage.Visible = false;
            }
            else if (Validation.IsEmailUnique(email, XMLManagement.NodesToList(Configs.EmailPath, "email")))
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
                emailexisterrormessage.Visible = true;
                emailnotvaliderrormessage.Visible = false;
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
                emailexisterrormessage.Visible = false;
                emailnotvaliderrormessage.Visible = false;
                nameStudenttextBox.Clear();
                IdStudenttextBox.Clear();
                passswordstdtextBox.Clear();
                emailtextBox.Clear();
                classStudlistBox.SelectedIndex = -1;

                if (XMLManagement.AddnewStudent(name, password, email, ID, studClasses))
                {
                    studClasses.Clear();
                    MessageBox.Show("The Student has been Added successfully");
                }
                else
                {
                    studClasses.Clear();
                    MessageBox.Show("Sorry! failed to addded, please try again");
                }

            }

        }
        private void addTeacherButton_Click(object sender, EventArgs e)
        {
            string name = nameTeachertextBox.Text;
            string ID = IdTeachertextBox.Text;
            string email = emailTtextBox.Text;
            string password = passwordtextBox2.Text;
            AddListOfClassesToTeacher();
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
                emailexistmessage2.Visible = false;
                emailnotvalidmessage2.Visible = false;


            }
            else if (teachClasses.Count == 0)
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
                emailexistmessage2.Visible = false;
                emailnotvalidmessage2.Visible = false;


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
                emailexistmessage2.Visible = false;
                emailnotvalidmessage2.Visible = false;

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
                emailexistmessage2.Visible = false;
                emailnotvalidmessage2.Visible = false;

            }
            else if (!Validation.IspasswordComplexValid(password))
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
                emailexistmessage2.Visible = false;
                emailnotvalidmessage2.Visible = false;
            }
            else if (!Validation.ISEmailVal(email))
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
                emailexistmessage2.Visible = false;
                emailnotvalidmessage2.Visible = true;

            }
            else if (Validation.IsEmailUnique(email, XMLManagement.NodesToList(Configs.EmailPath, "email")))
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
                emailnotvalidmessage2.Visible = false;
                emailexistmessage2.Visible = true;
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
                emailexistmessage2.Visible = false;
                emailnotvalidmessage2.Visible = false;
                nameTeachertextBox.Clear();
                IdTeachertextBox.Clear();
                passwordtextBox2.Clear();
                emailTtextBox.Clear();
                TeacherClasslistBox.SelectedIndex = -1;
                if (XMLManagement.AddnewTeacher(name, password, email, ID, teachClasses))
                {
                    teachClasses.Clear();
                    MessageBox.Show("The Teacher has been Added successfully");
                }
                else
                {
                    teachClasses.Clear();
                    MessageBox.Show("Sorry! failed to addded, please try again");
                }

            }

        }
        private void addClassButton_Click(object sender, EventArgs e)
        {
            string name = nameClasstextBox.Text;
            string IdTeacher = classteachercomboBox.Text;
            string Idclass = classIdtextBox.Text;
            AddListOfStudent();
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
            else if (students.Count == 0)
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
                StudentInClasslistBox.SelectedIndex = -1;

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
        private void AddListOfStudent()
        {
            List<string> selectedItems = StudentInClasslistBox.SelectedItems.Cast<string>().ToList();
            students.RemoveAll(item => selectedItems.Contains(item));
            foreach (string item in selectedItems)
            {
                if (!students.Contains(item))
                {
                    students.Add(item);
                }
            }
        }
        private void AddListOfClassesToStudent()
        {
            List<string> selectedItems = classStudlistBox.SelectedItems.Cast<string>().ToList();
            studClasses.RemoveAll(item => selectedItems.Contains(item));
            foreach (string item in selectedItems)
            {
                if (!studClasses.Contains(item))
                {
                    studClasses.Add(item);
                }
            }
        }
        private void AddListOfClassesToTeacher()
        {
            List<string> selectedItems = TeacherClasslistBox.SelectedItems.Cast<string>().ToList();
            teachClasses.RemoveAll(item => selectedItems.Contains(item));
            foreach (string item in selectedItems)
            {
                if (!teachClasses.Contains(item))
                {
                    teachClasses.Add(item);
                }
            }
        }
        private void AddUser_Load(object sender, EventArgs e)
        {
            Intilaize();
            populateTheList();
            IdStudenttextBox.Text = GenerateID("ST");
            classIdtextBox.Text = GenerateID("CL");
            IdTeachertextBox.Text = GenerateID("TE");
        }

        static string GenerateID(string entityType)
        {
            XmlDocument doc = XMLManagement.ReadAllDocument();

            int maxId = 0;

            switch (entityType)
            {
                case "TE":
                    maxId = GetMaxAttributeId(doc, "teacher");
                    break;
                case "ST":
                    maxId = GetMaxAttributeId(doc, "student");
                    break;
                case "CL":
                    maxId = GetMaxElementId(doc, "id");
                    break;
                default:
                    throw new ArgumentException("Invalid entity type");
            }

            string newId = entityType + "-" + (maxId + 1);
            return newId;
        }

        static int GetMaxAttributeId(XmlDocument doc, string attributeName)
        {
            int maxId = 0;
            XmlNodeList nodeList = doc.GetElementsByTagName(attributeName);

            foreach (XmlNode node in nodeList)
            {
                int id = int.Parse(node.Attributes["id"].Value.Substring(3));
                maxId = Math.Max(maxId, id);
            }

            return maxId;
        }

        static int GetMaxElementId(XmlDocument doc, string elementName)
        {
            int maxId = 0;
            XmlNodeList nodeList = doc.GetElementsByTagName(elementName);

            foreach (XmlNode node in nodeList)
            {
                int id = int.Parse(node.InnerText.Substring(3));
                maxId = Math.Max(maxId, id);
            }

            return maxId;
        }

        private void Addtab_Selected(object sender, TabControlEventArgs e)
        {
            Intilaize();
            populateTheList();
            IdStudenttextBox.Text = GenerateID("ST");
            classIdtextBox.Text = GenerateID("CL");
            IdTeachertextBox.Text = GenerateID("TE");
        }
    }
}
