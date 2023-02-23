using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;


namespace WebApI_student_subjects_reg.Models
{
    public class StudentContext : DbContext
    {
        public StudentContext(DbContextOptions<StudentContext> options)
            : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
    }

}
