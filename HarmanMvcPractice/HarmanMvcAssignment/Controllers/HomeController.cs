using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using HarmanMvcAssignment.Models;
using BusinessLayer;
using Microsoft.Extensions.Caching.Memory;


namespace HarmanMvcAssignment.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private  IStudent _studentList = null;
        //private readonly IStudentComponent _studentComponent;
        private readonly IMemoryCache memoryCache;
        public HomeController(ILogger<HomeController> logger, IMemoryCache memoryCache,IStudent studentList
            //, IStudentComponent studentComponent
            )
        {
            _logger = logger;
            this.memoryCache = memoryCache;
            _studentList = studentList;
        //    _studentComponent = studentComponent;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ExtraView()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            //var tempData =_studentComponent.GetStudents();
            DateTime currentTime;
            bool isExist = memoryCache.TryGetValue("cacheTime", out currentTime);
            if (!isExist)
            {
                currentTime = DateTime.Now;
                var cacheEntryOptions = new MemoryCacheEntryOptions().SetSlidingExpiration(TimeSpan.FromMinutes(1));
                memoryCache.Set("CacheTime", currentTime, cacheEntryOptions);
            }
            ViewBag.time = currentTime;
            ViewBag.FirstTime = memoryCache.Get<DateTime?>("CacheTime");
            ViewBag.SecondTime = memoryCache.GetOrCreate("CacheTime", entry => {
                entry.SlidingExpiration = TimeSpan.FromSeconds(45);
                return DateTime.Now;
            });

            int noOfItem = 6;
            List<Student1> TempList = _studentList.GetStudents().Skip(0).Take(noOfItem).ToList();

            return View(TempList);
        }
        
        public IActionResult Pagination(int id)
        {
            int noOfItem = 6;
            List<Student1> TempList = _studentList.GetStudents().Skip((id - 1) * noOfItem).Take(noOfItem).ToList();
            DateTime currentTime;
            bool isExist = memoryCache.TryGetValue("cacheTime", out currentTime);
            if (!isExist)
            {
                currentTime = DateTime.Now;
                var cacheEntryOptions = new MemoryCacheEntryOptions().SetSlidingExpiration(TimeSpan.FromMinutes(1));
                memoryCache.Set("CacheTime", currentTime, cacheEntryOptions);
            }
            ViewBag.time = currentTime;
            ViewBag.FirstTime = memoryCache.Get<DateTime?>("CacheTime");
            ViewBag.SecondTime = memoryCache.GetOrCreate("CacheTime", entry => {
                entry.SlidingExpiration = TimeSpan.FromSeconds(45);
                return DateTime.Now;
            });
            return View("Privacy",TempList);
        }
        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
