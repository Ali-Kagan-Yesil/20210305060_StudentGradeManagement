using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGradeManagement.EntityLayer.Class
{
    public class Lesson
    {
        public int LessonId { get; set; }
        public string LessonName { get; set; }
        public int StudentId { get; set; }
        public ICollection<Teacher> Teachers { get; set; }
    }
}
