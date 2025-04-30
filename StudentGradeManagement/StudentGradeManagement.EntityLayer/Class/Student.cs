using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGradeManagement.EntityLayer.Class
{
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string Password { get; set; }
      


        // public ICollection<Lesson> Lessons { get; set; }
    }
}
