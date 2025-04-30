using Microsoft.EntityFrameworkCore;
using StudentGradeManagement.BusinessLayer;
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
    public partial class TeacherForm : Form
    {
        private readonly StudentGradeDb context;
        private readonly StudentManager manager;
        public TeacherForm()
        {
            InitializeComponent();

            context = new StudentGradeDb();
            manager = new StudentManager(new StudentGradeDb());

        }

        private void btnList_Click(object sender, EventArgs e)
        {
            var st = manager.GetAllStudent();
            dataGridView1.DataSource = st;
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            var student = new Student();
            student.StudentName = txtStudentName.Text;
            student.Password = txtPassword.Text;
            manager.AddStudent(student);
            MessageBox.Show("Öğrenci başarıyla eklendi.");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtStudentId.Text);
            var updatedValue = manager.GetStudentById(id);
            updatedValue.StudentId = Convert.ToInt32(txtStudentId.Text);
            updatedValue.StudentName = txtStudentName.Text;
            updatedValue.Password = txtPassword.Text;
            manager.UpdateStudent(updatedValue);
            MessageBox.Show("Güncelleme işlemi gerçekleşmiştir.");
        }

        private void TeacherForm_Load(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridView1.CurrentRow.Cells["StudentId"].Value;
            manager.DeleteStudent(id);
            MessageBox.Show("Öğrenci silindi...");
            manager.GetAllStudent();
            dataGridView1.DataSource = manager.GetAllStudent();
        }
    }
}
