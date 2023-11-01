using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplication2.Entities;

namespace WebApplication2.Repositories
{
    public interface IStudentRepository
    {
        Task<List<Student>> GetAllAsync();
        Task Add(Student student);  
    }
}
