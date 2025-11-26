using Microsoft.EntityFrameworkCore;
using School.Domain.Entities;

namespace School.Persistence.Data
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
    }
}
