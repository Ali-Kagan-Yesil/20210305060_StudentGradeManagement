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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace StudentGradeManagement.UI
{
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {

            using (var context = new StudentGradeDb())
            {
                var lessons = context.Lessons.ToList();
                cmbLesson.DisplayMember = "LessonName";
                cmbLesson.ValueMember = "LessonId";
                cmbLesson.DataSource = lessons;
            }
            int selectedLessonId = (int)cmbLesson.SelectedValue;
        }

        private void btnExamInfo_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void cmbLesson_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedLessonId = Convert.ToInt32(cmbLesson.SelectedValue);
            int currentStudentId = Session.CurrentStudentId;
            using (var context = new StudentGradeDb())
            {
                var student = context.ExamResults
                    .Where(g => g.StudentId == currentStudentId && g.LessonId == selectedLessonId)
                    .Select(g => new
                    {
                        Ders = g.LessonId,
                        Not = g.Exam1,
                        Not2 = g.Exam2,
                        Not3 = g.Exam3,
                        Average = g.Average
                    })
                    .ToList();

                dgvExamScore.DataSource = student;
                dgvExamScore.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
