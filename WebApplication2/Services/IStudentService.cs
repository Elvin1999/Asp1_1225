using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplication2.Entities;

namespace WebApplication2.Services
{
    public interface IStudentService
    {
        Task<List<Student>> GetAllByKey(string key = "");
    }
}
