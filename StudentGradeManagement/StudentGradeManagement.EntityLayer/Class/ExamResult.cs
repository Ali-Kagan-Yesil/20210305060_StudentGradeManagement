using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGradeManagement.EntityLayer.Class
{
    public class ExamResult
    {
        public int ExamResultId { get; set; }
        public int Exam1 { get; set; }
        public int Exam2 { get; set; }
        public int Exam3 { get; set; }
        public double Average { get; set; }
        public int StudentId { get; set; }
        public int LessonId { get; set; }
    }
}
