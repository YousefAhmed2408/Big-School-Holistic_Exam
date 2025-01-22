using Holistic_Exam.Models;
using Microsoft.EntityFrameworkCore;

namespace Holistic_Exam.Data
{
    public class AppdbContext : DbContext
    {
        public AppdbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Classs> Classs { get; set; }   
        public DbSet<Grad> grads { get; set; }
        public DbSet<Student> students { get; set; }
        public DbSet<Subject> subjects { get; set; }
        public DbSet<Teacher> teachers { get; set; }

    }
}
