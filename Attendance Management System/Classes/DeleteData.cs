using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Attendance_Management_System.Forms;

namespace Attendance_Management_System.Classes
{
    internal class DeleteData
    {



        public static void DeleteTeacher(string teacherId, XmlDocument doc)
        {
            try
            {
                XmlNode teacherNode = doc.SelectSingleNode($"//teachers/teacher[@id='{teacherId}']");
                if (teacherNode != null)
                {
                    XmlNodeList classNodes = teacherNode.SelectNodes("courses/course");
                    if (classNodes.Count > 0)
                    {
                        DialogResult result = MessageBox.Show("This teacher is associated with classes. Do you want to enter another teacher to reassign these classes?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (result == DialogResult.Yes)
                        {
                            List<string> teacherIds = XMLManagement.GetIdofAllSt_Th(Configs.TeachersPath, "id");
                            string newTeacherId = PromptForNewTeacher(doc, teacherIds, teacherId);
                            if (!string.IsNullOrEmpty(newTeacherId))
                            {
                                foreach (XmlNode classNode in classNodes)
                                {
                                    XmlNode teacherIdNode = classNode.SelectSingleNode("teacher");
                                    if (teacherIdNode != null)
                                    {
                                        teacherIdNode.Attributes["id"].Value = newTeacherId;
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Please select another teacher to reassign the classes.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                        }
                        else
                        {
                            return;
                        }
                    }
                    teacherNode.ParentNode.RemoveChild(teacherNode);
                    XmlNode userNode = doc.SelectSingleNode($"//users/user[id='{teacherId}']");
                    if (userNode != null)
                    {
                        userNode.ParentNode.RemoveChild(userNode);
                    }
                    MessageBox.Show("Teacher deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Teacher not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to delete teacher: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static string PromptForNewTeacher(XmlDocument doc, List<string> existingTeachers, string teacherIdToDelete)
        {
            existingTeachers.Remove(teacherIdToDelete);
            Form form = new Form();
            Label label = new Label();
            ComboBox comboBox = new ComboBox();
            Button buttonOk = new Button();

            form.Text = "Select New Teacher";
            label.Text = "Select a new teacher to reassign the classes:";
            comboBox.DataSource = existingTeachers;

            buttonOk.Text = "OK";
            buttonOk.DialogResult = DialogResult.OK;

            label.SetBounds(9, 20, 372, 13);
            comboBox.SetBounds(12, 36, 372, 20);
            buttonOk.SetBounds(228, 72, 75, 23);

            label.AutoSize = true;
            comboBox.Anchor = comboBox.Anchor | AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(396, 107);
            form.Controls.AddRange(new Control[] { label, comboBox, buttonOk });
            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;

            DialogResult dialogResult = form.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                return comboBox.SelectedItem?.ToString();
            }
            else
            {
                return null;
            }
        }

        public static void DeleteClass(string classId, XmlDocument doc)
        {
            try
            {
                XmlNodeList records = doc.SelectNodes($"//attendance-records/attendance-record[class/id='{classId}']");
                foreach (XmlNode record in records)
                {
                    record.ParentNode.RemoveChild(record);
                }
                XmlNodeList students = doc.SelectNodes($"//students/student/class[@id='{classId}']");
                foreach (XmlNode studentNode in students)
                {
                    studentNode.ParentNode.RemoveChild(studentNode);
                }
                XmlNodeList teachers = doc.SelectNodes($"//teachers/teacher/class[@id='{classId}']");
                foreach (XmlNode teacherNode in teachers)
                {
                    teacherNode.ParentNode.RemoveChild(teacherNode);
                }

                XmlNode classNode = doc.SelectSingleNode($"//classes/class[id='{classId}']");
                if (classNode != null)
                {
                    classNode.ParentNode.RemoveChild(classNode);
                }
                MessageBox.Show("Class deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to delete class: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void DeleteStudent(string studentId, XmlDocument doc)
        {
            try
            {
                XmlNodeList classes = doc.SelectNodes($"//classes/class/student[@id='{studentId}']");
                foreach (XmlNode classNode in classes)
                {
                    classNode.ParentNode.RemoveChild(classNode);
                }

                XmlNodeList attendanceRecords = doc.SelectNodes($"//attendance-record/student[@id='{studentId}']");
                foreach (XmlNode recordNode in attendanceRecords)
                {
                    recordNode.ParentNode.RemoveChild(recordNode);
                }

                XmlNode studentNode = doc.SelectSingleNode($"//students/student[@id='{studentId}']");
                if (studentNode != null)
                {
                    studentNode.ParentNode.RemoveChild(studentNode);
                }

                XmlNode userNode = doc.SelectSingleNode($"//users/user[id='{studentId}']");
                if (userNode != null)
                {
                    userNode.ParentNode.RemoveChild(userNode);
                }

                MessageBox.Show("Student deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to delete student: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



    }
}
