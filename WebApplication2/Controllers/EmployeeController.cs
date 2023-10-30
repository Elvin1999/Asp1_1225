using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using WebApplication2.Entities;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class EmployeeController : Controller
    {
        public static List<Employee> Employees { get; set; } = new List<Employee> {

              new Employee
                    {
                        Id=1,
                         CityId=1,
                          Firstname="Eynal",
                           Lastname="Baxshiyev",
                            Point=88
                    },
                    new Employee
                    {
                        Id=2,
                         CityId=2,
                          Firstname="Nigar",
                          Lastname="Mustafazade",
                          Point=56
                    },
                    new Employee
                    {
                        Id=3,
                         CityId=3,
                          Firstname="Shireli",
                           Lastname="Nuriyev",
                            Point=99
                    },
                    new Employee
                    {
                        Id=4,
                         CityId=4,
                          Firstname="Resul",
                           Lastname="Sebsiyev",
                            Point=66
                    }
};
        public IActionResult Index()
        {
            var vm = new EmployeeListViewModel
            {
                Employees = Employees
            };
            return View(vm);
        }

        [HttpGet]
        public IActionResult Add()
        {
            var vm = new EmployeeAddViewModel
            {
                Employee = new Employee(),
                Cities = new List<SelectListItem>
                {
                    new SelectListItem{Text="Baku",Value="10"},
                    new SelectListItem{Text="Xirdalan",Value="1"},
                    new SelectListItem{Text="Sumqayit",Value="50"}
                }
            };
            return View(vm);
        }

        [HttpPost]
        public IActionResult Add(EmployeeAddViewModel vm)
        {
            if (ModelState.IsValid)
            {
                Employees.Add(vm.Employee);
                return RedirectToAction("index");
            }
            return View(vm);
        }


        //public IActionResult Update(int myid)
        //{

        //}
    }
}
