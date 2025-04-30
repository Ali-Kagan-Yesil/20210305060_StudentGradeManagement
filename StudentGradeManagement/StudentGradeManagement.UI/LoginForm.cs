using StudentGradeManagement.DataAccessLayer.Context;
using StudentGradeManagement.EntityLayer.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentGradeManagement.UI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            cmbRole.Items.Add("Teacher");
            cmbRole.Items.Add("Student");
            cmbRole.SelectedIndex = 0;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string password = txtPassword.Text;
            string role = cmbRole.SelectedItem.ToString();
            using (var context = new StudentGradeDb())
            {
                if (role == "Teacher")
                {
                    var teacher = context.Teachers.FirstOrDefault(a => a.TeacherName == username && a.TeacherPassword == password);
                    if (teacher != null)
                    {
                        MessageBox.Show("Öğretmen girişi başarılı.");
                        this.Hide();
                        TeacherForm teacherForm = new TeacherForm();
                        teacherForm.Show();

                    }
                    else
                    {
                        MessageBox.Show("Öğretmen bilgileri hatalı.");
                    }
                }
                else if (role == "Student")
                {
                    var student = context.Students.FirstOrDefault(c => c.StudentName == username &&  c.Password == password);
                    if (student != null)
                    {
                        Session.CurrentStudentId = student.StudentId;

                        MessageBox.Show("Öğrenci girişi başarılı.");
                        this.Hide();
                        StudentForm studentForm = new StudentForm();
                        studentForm.Show();


                    }
                    else
                    {
                        MessageBox.Show("Öğrenci bilgileri hatalı.");
                    }
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
