using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HarmanMvcAssignment.Models;
using System.Xml.Serialization;
using System.IO;
using Microsoft.Extensions.Caching.Memory;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;

namespace HarmanMvcAssignment.Controllers
{
    public class AccountController : Controller
    {
        private readonly IMemoryCache memoryCache;
        public AccountController(IMemoryCache memoryCache)
        {
            this.memoryCache = memoryCache;
            //XmlSerializer searial = new XmlSerializer(typeof(List<Student>));
            //using (FileStream fs = new FileStream(Environment.CurrentDirectory + "\\StudentsData.xml", FileMode.Create, FileAccess.Write))
            //{
            //    searial.Serialize(fs, StudentData.GetStudents());
            //}
        }
        public ActionResult Login()
        {
            return View(new Login());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(Login Model)
        {
            if (Model.Email != "Happy16harman@gmail.com" && Model.Password != "12345678")
            {
                TempData["Error"] = "Invalid Username or Password";
                return View("Login", new Login());

            }
            List<Student> newList;
            XmlSerializer searial = new XmlSerializer(typeof(List<Student>));
            using (FileStream fs = new FileStream(Environment.CurrentDirectory + "\\StudentsData.xml", FileMode.Open, FileAccess.Read))
            {
                newList = searial.Deserialize(fs) as List<Student>;
            }

            if (ModelState.IsValid)
            {
                //FormAuthentication.SetAuthCookie();
                
                var claims = new List<Claim>
                {
                new Claim(ClaimTypes.Name, Model.Email),
                new Claim(ClaimTypes.Role, "Admin"),
                };
                var ClaimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var claimsPrincipal = new ClaimsPrincipal(ClaimsIdentity);
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, claimsPrincipal);
                return RedirectToAction(nameof(Details), newList);
            }


            return View("Login", new Login());
            // return RedirectToAction(nameof(Details), newList);
        }
        public async Task<IActionResult> LogOut()
        {

            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login",new Login());
        }
        public ActionResult ShowStudent(int id)
        {

            List<Student> newList;
            XmlSerializer searial = new XmlSerializer(typeof(List<Student>));
            using (FileStream fs = new FileStream(Environment.CurrentDirectory + "\\StudentsData.xml", FileMode.Open, FileAccess.Read))
            {
                newList = searial.Deserialize(fs) as List<Student>;
            }
            Student studentData = newList.First(x => x.StudentID == id);
            return View(studentData);
        }
        public ActionResult Index()
        {
            List<Student> newList;

            XmlSerializer searial = new XmlSerializer(typeof(List<Student>));
            using (FileStream fs = new FileStream(Environment.CurrentDirectory + "\\StudentsData.xml", FileMode.Open, FileAccess.Read))
            {
                newList = searial.Deserialize(fs) as List<Student>;
            }
            //if (!memoryCache.TryGetValue("StudentList", out newList))
            //{
            //    newList = memoryCache.GetOrCreate("StudentList", entry =>
            //    {
            //        entry.SlidingExpiration = TimeSpan.FromSeconds(45);
            //        return newList;
            //    });
            //}
            return View(newList);
        }
        [Authorize]
        public ActionResult Details(int id)
        {
            List<Student> newList;
            XmlSerializer searial = new XmlSerializer(typeof(List<Student>));
            using (FileStream fs = new FileStream(Environment.CurrentDirectory + "\\StudentsData.xml", FileMode.Open, FileAccess.Read))
            {
                newList = searial.Deserialize(fs) as List<Student>;
            }

            return View(newList);
        }

        [Authorize]
        public ActionResult Create()
        { 
            return View(new Student());
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Student Model)
        {
            try
            {
                
                List<Student> newList;
                XmlSerializer searial = new XmlSerializer(typeof(List<Student>));
                using (FileStream fs = new FileStream(Environment.CurrentDirectory + "\\StudentsData.xml", FileMode.Open, FileAccess.Read))
                {
                    newList = searial.Deserialize(fs) as List<Student>;
                }
                newList.Add(new Student() { StudentID = Model.StudentID, StudentName = Model.StudentName, Age = Model.Age });
                using (FileStream fs = new FileStream(Environment.CurrentDirectory + "\\StudentsData.xml", FileMode.Create, FileAccess.Write))
                {
                    searial.Serialize(fs, newList);
                }
                return RedirectToAction(nameof(Index),newList);
            }
            catch
            {
                return View();
            }
        }

        
        public ActionResult Edit(int id)
        {
            List<Student> newList;
            XmlSerializer searial = new XmlSerializer(typeof(List<Student>));
            using (FileStream fs = new FileStream(Environment.CurrentDirectory + "\\StudentsData.xml", FileMode.Open, FileAccess.Read))
            {
                newList = searial.Deserialize(fs) as List<Student>;
            }
            Student  editData = newList.First(x=> x.StudentID == id);
            return View(editData);
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Student model)
        {
            try
            {
               
                List<Student> newList;
                XmlSerializer searial = new XmlSerializer(typeof(List<Student>));
                using (FileStream fs = new FileStream(Environment.CurrentDirectory + "\\StudentsData.xml", FileMode.Open, FileAccess.Read))
                {
                    newList = searial.Deserialize(fs) as List<Student>;
                }
                foreach(Student obj in newList)
                {
                    if(obj.StudentID == id)
                    {
                        obj.StudentID = model.StudentID;
                        obj.StudentName = model.StudentName;
                        obj.Age =  model.Age;
                    }
                }

                //Student editData = newList.FirstOrDefault(x => x.StudentID == id);
                //editData.StudentID = model.StudentID;
                //editData.StudentName = model.StudentName;
                //editData.Age = model.Age;
                using (FileStream fs = new FileStream(Environment.CurrentDirectory + "\\StudentsData.xml", FileMode.Create, FileAccess.Write))
                {
                    searial.Serialize(fs, newList);
                }
                return RedirectToAction(nameof(Details), newList);
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Delete(int id)
        {
            try
            {
                
                List<Student> newList;
                XmlSerializer searial = new XmlSerializer(typeof(List<Student>));
                using (FileStream fs = new FileStream(Environment.CurrentDirectory + "\\StudentsData.xml", FileMode.Open, FileAccess.Read))
                {
                    newList = searial.Deserialize(fs) as List<Student>;
                }
                Student temp = newList.FirstOrDefault(x => x.StudentID == id);
                // newList.RemoveAt(id-1);
                newList.Remove(temp);
                using (FileStream fs = new FileStream(Environment.CurrentDirectory + "\\StudentsData.xml", FileMode.Create, FileAccess.Write))
                {
                    searial.Serialize(fs, newList);
                }
                return RedirectToAction(nameof(Details), newList);

            }
            catch
            {
                return View();
            }
        }
    }
}