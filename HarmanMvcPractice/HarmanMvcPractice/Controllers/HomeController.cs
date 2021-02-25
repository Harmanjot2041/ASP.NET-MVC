using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using HarmanMvcPractice.Models;

namespace HarmanMvcPractice.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        List<SignUp> employeeList;
       
       
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            employeeList = new List<SignUp>();
            employeeList.Add(new SignUp
            {
                Id = 1,
                Name = "Harmanjot",
                Age = 21,
                Desination = "UIET",
                Salary = 300000
            });
            employeeList.Add(new SignUp
            {
                Id = 2,
                Name = "Gunika",
                Age = 21,
                Desination = "UIET",
                Salary = 1000000
            });
            employeeList.Add(new SignUp
            {
                Id = 3,
                Name = "Venketesh",
                Age = 21,
                Desination = "PEC",
                Salary = 3000000
            });
            employeeList.Add(new SignUp
            {
                Id = 4,
                Name = "Abhishek",
                Age = 21,
                Desination = "CU",
                Salary = 600000
            });

        }

        public IActionResult Index()
        {
            return View(employeeList);
           // return Content("Heyyyyyyyyyyyyyyyyyyyyy");
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult EmployeeView()
        {
            return View(employeeList);
        }
        public IActionResult Content(int id)
        {
            return Content("Hello from Content " + id);
        }
        public JsonResult Json ()
        {
            return Json(employeeList);
        }
        [HttpGet]
        public IActionResult EditEmployee(long id )
        {
            var model = new SignUp();
            if (id > 0)
                model = employeeList.FirstOrDefault(x => x.Id == id);
          
            return View("_EditEmpployeePartial", model);
           // return PartialView("_EditEmpployeePartial", employeeList.FirstOrDefault(x=> x.Id == id));
        }
        [HttpPost]
        public IActionResult EditEmployee(SignUp model)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction(nameof(EmployeeView));
            }
            else
                return PartialView("_EditEmpployeePartial", model);
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
