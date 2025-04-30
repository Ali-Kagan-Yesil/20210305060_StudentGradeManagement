using Microsoft.EntityFrameworkCore;
using StudentGradeManagement.EntityLayer.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGradeManagement.DataAccessLayer.Context
{
    public class StudentGradeDb:DbContext
    {
        public DbSet<Teacher>Teachers { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<ExamResult> ExamResults { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-EJVAHLJ; Database=StudentGradeManagement; Trusted_Connection=True; TrustServerCertificate=True; ");
        }
    }
}
