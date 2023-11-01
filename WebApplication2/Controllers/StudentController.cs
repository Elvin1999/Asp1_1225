using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WebApplication2.Services;

namespace WebApplication2.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        public async Task<IActionResult> Index(string key="")
        {
            var result = await _studentService.GetAllByKey(key);
            return Ok(result);
        }
    }
}
