using StudentGradeManagement.DataAccessLayer.Context;
using StudentGradeManagement.EntityLayer.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGradeManagement.BusinessLayer
{
    public class StudentManager
    {
        private readonly StudentGradeDb _context;

        public StudentManager(StudentGradeDb context)
        {
            _context = context;
        }
        public List<Student> GetAllStudent()
        {
            return _context.Students
              
               .ToList();
        }

        public void AddStudent(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
        }

        public Student GetStudentById(int id)
        {
            return _context.Students.FirstOrDefault(c => c.StudentId == id);
        }
        public void UpdateStudent(Student student)
        {
            _context.Students.Update(student);
            _context.SaveChanges();
        }

        public void DeleteStudent(int id)
        {
            var reservation = _context.Students.Find(id);
            if (reservation != null)
            {
                _context.Students.Remove(reservation);
                _context.SaveChanges();
            }
        }
    }
}
