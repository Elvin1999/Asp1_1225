using System.Collections.Generic;
using WebApplication2.Entities;

namespace WebApplication2.Models
{
    public class EmployeViewModel
    {
        public List<Employee> Employees { get; set; }
        public List<string> Cities { get; set; }
    }
}
