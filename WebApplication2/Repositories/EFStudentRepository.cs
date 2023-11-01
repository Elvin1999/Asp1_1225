using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplication2.Data;
using WebApplication2.Entities;

namespace WebApplication2.Repositories
{
    public class EFStudentRepository : IStudentRepository
    {
        private readonly StudentDbContext _dbContext;

        public EFStudentRepository(StudentDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Add(Student student)
        {
            await _dbContext.Students.AddAsync(student);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<List<Student>> GetAllAsync()
        {
            return await _dbContext.Students.ToListAsync();
        }
    }
}
