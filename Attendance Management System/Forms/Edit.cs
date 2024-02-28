using Attendance_Management_System.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static iText.StyledXmlParser.Jsoup.Select.Evaluator;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Attendance_Management_System.Forms
{
    public partial class Edit : UserControl
    {

        private static List<string> classidList = new List<string>();
        private static List<string> teacheridList = new List<string>();
        private static List<string> studentidList = new List<string>();

        public Edit()
        {
            InitializeComponent();
            IntializeUi();
        }
        private void IntializeUi()
        {
            labelErrorMessage.Visible = false;
            labelErrorMessage1.Visible = false;
            labelErrorMessage4.Visible = false;
            labelErrorMessage7.Visible = false;
            labelErrorMessage8.Visible = false;
            labelErrorMessage9.Visible = false;
            labelErrorMessage10.Visible = false;
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
                ClasscomboBox.Items.Add(id);
                classStudlistBox.Items.Add(id);
                TeacherClasslistBox.Items.Add(id);

            }
            foreach (string id in studentidList)
            {
                StudentcomboBox.Items.Add(id);
                StudentInClasslistBox.Items.Add(id);
            }
            foreach (string id in teacheridList)
            {
                TeachercomboBox.Items.Add(id);
                classteachercomboBox.Items.Add(id);
            }
        }
        private void Edit_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                Intilaize();
                populateTheList();
            }
        }
        private void StudentcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = StudentcomboBox.Text;
            string email = "", password = "", studentName = "";
            List<string> classes = new List<string>();
            GetStudentData(id, ref studentName, ref email, ref password, ref classes);

            nameStudenttextBox.Text = studentName;
            passswordstdtextBox.Text = password;
            emailtextBox.Text = email;

            for (int i = 0; i < classStudlistBox.Items.Count; i++)
            {
                string className = classStudlistBox.Items[i].ToString();

                if (classes.Contains(className))
                {
                    classStudlistBox.SetSelected(i, true);
                }
            }
        }
        public void GetStudentData(string id, ref string studentName, ref string email, ref string password, ref List<string> classes)
        {

            XmlDocument xmlDoc = XMLManagement.ReadAllDocument();

            XmlNode studentNode = xmlDoc.SelectSingleNode($"//students/student[@id='{id}']");
            studentName = studentNode.SelectSingleNode("name").InnerText;

            XmlNode userNode = xmlDoc.SelectSingleNode($"//users/user[id='{id}']");
            email = userNode.SelectSingleNode("email").InnerText;
            password = userNode.SelectSingleNode("password").InnerText;

            classes = new List<string>();
            XmlNodeList classNodes = studentNode.SelectNodes("classes/class");
            foreach (XmlNode classNode in classNodes)
            {
                string classId = classNode.Attributes["id"].Value;
                classes.Add(classId);
            }
        }
        private void ClasscomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            string id = ClasscomboBox.Text;
            string teacher = "", ClassName = "";
            List<string> students = new List<string>();
            GetClassData(id, ref teacher, ref ClassName, ref students);

            nameClasstextBox.Text = ClassName;
            classteachercomboBox.Text = teacher;

            for (int i = 0; i < StudentInClasslistBox.Items.Count; i++)
            {
                string className = StudentInClasslistBox.Items[i].ToString();

                if (students.Contains(className))
                {
                    StudentInClasslistBox.SetSelected(i, true);
                }
            }
        }
        public void GetClassData(string id, ref string teacherId, ref string ClassName, ref List<string> studentIds)
        {
            XmlDocument xmlDoc = XMLManagement.ReadAllDocument();
            XmlNode classNode = xmlDoc.SelectSingleNode($"//classes/class[id='{id}']");
            ClassName = classNode.SelectSingleNode("name").InnerText;
            teacherId = classNode.SelectSingleNode("teacher").Attributes["id"].Value;

            studentIds = new List<string>();
            XmlNodeList studentNodes = classNode.SelectNodes("student");
            foreach (XmlNode studentNode in studentNodes)
            {
                string studentId = studentNode.Attributes["id"].Value;
                studentIds.Add(studentId);
            }
        }
        private void TeachercomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = TeachercomboBox.Text;
            string email = "", password = "", TeacherName = "";
            List<string> classes = new List<string>();
            GetTeacherData(id, ref TeacherName, ref email, ref password, ref classes);

            nameTeachertextBox.Text = TeacherName;
            passwordtextBox2.Text = password;
            emailTtextBox.Text = email;

            for (int i = 0; i < TeacherClasslistBox.Items.Count; i++)
            {
                string className = TeacherClasslistBox.Items[i].ToString();

                if (classes.Contains(className))
                {
                    TeacherClasslistBox.SetSelected(i, true);
                }
            }
        }
        public void GetTeacherData(string id, ref string TeacherName, ref string email, ref string password, ref List<string> classes)
        {
            XmlDocument xmlDoc = XMLManagement.ReadAllDocument();

            XmlNode teacherNode = xmlDoc.SelectSingleNode($"//teachers/teacher[@id='{id}']");
            TeacherName = teacherNode.SelectSingleNode("name").InnerText;
            XmlNode userNode = xmlDoc.SelectSingleNode($"//users/user[id='{id}']");
            email = userNode.SelectSingleNode("email").InnerText;
            password = userNode.SelectSingleNode("password").InnerText;
            classes = new List<string>();
            XmlNodeList classNodes = teacherNode.SelectNodes("courses/course");
            foreach (XmlNode classNode in classNodes)
            {
                string classId = classNode.Attributes["id"].Value;
                classes.Add(classId);
            }
        }

        private void editStudentButton_Click(object sender, EventArgs e)
        {
            string name = nameStudenttextBox.Text;
            string password = passswordstdtextBox.Text;
            string email = emailtextBox.Text;
            string id = StudentcomboBox.Text;
            if(string.IsNullOrEmpty(id))
            {
                MessageBox.Show("please enter the id you want to modify:", "message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Validation.IsnameValid(name))
            {
                labelErrorMessage.Visible = true;
                labelErrorMessage1.Visible = false;
                passwordlabel1.Visible = false;
                emailexisterrormessage.Visible = false;
                emailnotvaliderrormessage.Visible = false;
            }
            else if (classStudlistBox.SelectedItems.Count == 0)
            {
                labelErrorMessage1.Visible = true;
                labelErrorMessage.Visible = false;
                passwordlabel1.Visible = false;
                emailexisterrormessage.Visible = false;
                emailnotvaliderrormessage.Visible = false;
            }
            else if (!Validation.IspasswordComplexValid(password))
            {
                labelErrorMessage.Visible = false;
                labelErrorMessage1.Visible = false;
                passwordlabel1.Visible = true;
                emailexisterrormessage.Visible = false;
                emailnotvaliderrormessage.Visible = false;
            }
            else if (!Validation.ISEmailVal(email))
            {
                labelErrorMessage.Visible = false;
                labelErrorMessage1.Visible = false;
                passwordlabel1.Visible = false;
                emailnotvaliderrormessage.Visible = true;
                emailexisterrormessage.Visible = false;
            }
            else if (UpdateData.CheckExist(id,email, XMLManagement.NodesToList(Configs.EmailPath, "email")))
            {
                labelErrorMessage.Visible = false;
                labelErrorMessage1.Visible = false;
                passwordlabel1.Visible = false;
                emailexisterrormessage.Visible = true;
                emailnotvaliderrormessage.Visible = false;
            }
            else
            {
                labelErrorMessage.Visible = false;
                labelErrorMessage1.Visible = false;
                passwordlabel1.Visible = false;
                emailexisterrormessage.Visible = false;
                emailnotvaliderrormessage.Visible = false;
              
                HashSet<string> selectedClasses = new HashSet<string>();
                foreach (var item in classStudlistBox.SelectedItems)
                {
                    selectedClasses.Add(item.ToString());
                }

                UpdateData.UpdateStudent(id, name, email, password, selectedClasses);
            }
        }

        private void editClassButton_Click(object sender, EventArgs e)
        {


            string id = ClasscomboBox.Text;
            string name = nameClasstextBox.Text;
            string IdTeacher = classteachercomboBox.Text;

            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("please enter the id you want to modify:", "message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Validation.IsnameValid(name))
            {
                labelErrorMessage8.Visible = true;
                labelErrorMessage9.Visible = false;
                labelErrorMessage10.Visible = false;
            }
            else if (!Validation.IsclassValid(IdTeacher, XMLManagement.GetIdofAllSt_Th(Configs.TeachersPath, "id")))
            {
                labelErrorMessage9.Visible = true;
                labelErrorMessage8.Visible = false;
                labelErrorMessage10.Visible = false;
            }
            else if (StudentInClasslistBox.SelectedItems.Count == 0)
            {
                labelErrorMessage10.Visible = true;
                labelErrorMessage9.Visible = false;
                labelErrorMessage8.Visible = false;
            }


            else
            {
                labelErrorMessage8.Visible = false;
                labelErrorMessage9.Visible = false;
                labelErrorMessage10.Visible = false;
      
                HashSet<string> selectedStudent = new HashSet<string>();
                foreach (var item in StudentInClasslistBox.SelectedItems)
                {
                    selectedStudent.Add(item.ToString());
                }
                UpdateData.UpdateClass(id, name, IdTeacher, selectedStudent);

            }


        }
        private void editTeacherButton_Click(object sender, EventArgs e)
        {

            string name = nameTeachertextBox.Text;
            string ID = TeachercomboBox.Text;
            string email = emailTtextBox.Text;
            string password = passwordtextBox2.Text;
            if (string.IsNullOrEmpty(ID))
            {
                MessageBox.Show("please enter the id you want to modify:", "message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Validation.IsnameValid(name))
            {
                labelErrorMessage4.Visible = true;
                labelErrorMessage7.Visible = false;
                passwordlabel2.Visible = false;
                emailexistmessage2.Visible = false;
                emailnotvalidmessage2.Visible = false;


            }
            else if (TeacherClasslistBox.SelectedItems.Count == 0)
            {
                labelErrorMessage7.Visible = true;
                labelErrorMessage4.Visible = false;
                passwordlabel2.Visible = false;
                emailexistmessage2.Visible = false;
                emailnotvalidmessage2.Visible = false;
            }
            else if (!Validation.IspasswordComplexValid(password))
            {
                labelErrorMessage7.Visible = false;
                labelErrorMessage4.Visible = false;
                passwordlabel2.Visible = true;
                emailexistmessage2.Visible = false;
                emailnotvalidmessage2.Visible = false;
            }
            else if (!Validation.ISEmailVal(email))
            {
                labelErrorMessage4.Visible = false;
                labelErrorMessage7.Visible = false;
                passwordlabel2.Visible = false;
                emailexistmessage2.Visible = false;
                emailnotvalidmessage2.Visible = true;

            }
            else if (UpdateData.CheckExist(ID, email, XMLManagement.NodesToList(Configs.EmailPath, "email")))
            {
                labelErrorMessage4.Visible = false;
                labelErrorMessage7.Visible = false;
                passwordlabel2.Visible = false;
                emailnotvalidmessage2.Visible = false;
                emailexistmessage2.Visible = true;
            }
            else
            {
                labelErrorMessage4.Visible = false;
                labelErrorMessage7.Visible = false;
                passwordlabel2.Visible = false;
                emailexistmessage2.Visible = false;
                emailnotvalidmessage2.Visible = false;
         

                HashSet<string> selectedStudent = new HashSet<string>();
                foreach (var item in TeacherClasslistBox.SelectedItems)
                {
                    selectedStudent.Add(item.ToString());
                }
                UpdateData.UpdateTeacher(ID, name, email, password, selectedStudent);

            }

        }


    }
}
