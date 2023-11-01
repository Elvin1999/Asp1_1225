using Microsoft.EntityFrameworkCore;
using WebApplication2.Entities;

namespace WebApplication2.Data
{
    public class StudentDbContext:DbContext
    {
        public StudentDbContext(DbContextOptions<StudentDbContext>
            contextOptions)
            : base(contextOptions)
        {
            
        }

        public DbSet<Student> Students { get; set; }
    }
}
