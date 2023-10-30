using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using WebApplication2.Entities;

namespace WebApplication2.Models
{
    public class EmployeeAddViewModel
    {
        public Employee Employee { get; set; }
        public List<SelectListItem> Cities { get; set; }
    }
}