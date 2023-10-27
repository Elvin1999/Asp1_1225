using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Entities;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Hello from Index Action";
        }

        public IActionResult Index2()
        {
            return View();
        }

        public ViewResult Employees()
        {
            List<Employee> employees = new List<Employee>
            {
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

            List<string> cities = new List<string> { "Baku", "Oslo", "Ankara" };

            var viewModel = new EmployeViewModel
            {
                Employees = employees,
                Cities = cities
            };
            return View(viewModel);
        }

        public IActionResult Index4()
        {
            return Ok();
        }

        public IActionResult Index5()
        {
            return NotFound();
        }

        public IActionResult Index6()
        {
            //throw new InvalidOperationException();
            return BadRequest();
        }

        public IActionResult Index7()
        {
            return Redirect("/home/employees");
        }

        public IActionResult Index8()
        {
            return RedirectToAction("employees");
        }

        public IActionResult Index9()
        {
            var routeValue = new RouteValueDictionary(new { action = "Employees", controller = "Home" });
            return RedirectToRoute(routeValue);
        }

        public JsonResult GetJson()
        {
            List<Employee> employees = new List<Employee>
            {
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

            return Json(employees);
        }
    }
}
