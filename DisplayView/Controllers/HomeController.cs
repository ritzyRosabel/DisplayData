using DisplayView.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DisplayView.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
           var result = GetData.GetTest();
            return View(result);
        }

        public ActionResult About()
        {
            List<Test> list = new List<Test>
            {
                new Test
                    {
                      Age=24,
                      Id=31,
                      Name = "kolawole Otumba"
                     },  
                new Test
                    {
                      Age=24,
                      Id=31,
                      Name = "kolawole Otumba"
                     },
                new Test
                    {
                      Age=24,
                      Id=31,
                      Name = "kolawole Otumba"
                     },
                new Test
                    {
                      Age=24,
                      Id=31,
                      Name = "kolawole Otumba"
                     },
                new Test
                    {
                      Age=24,
                      Id=31,
                      Name = "kolawole Otumba"
                     },
                new Test
                    {
                      Age=24,
                      Id=31,
                      Name = "kolawole Otumba"
                     },
                new Test
                    {
                      Age=24,
                      Id=31,
                      Name = "kolawole Otumba"
                     }
            };

            return View(list);
        }

        public ActionResult Contact()
        {
            Test test = new Test
            {
                Age = 24,
                Id = 31,
                Name = "kolawole Otumba"
            };
            return View(test);
        }
        public ActionResult GetDataFromDB()
        {
            var result = GetData.GetTest();
            ViewData["result"] = result;
            return View();
        } 
        public ActionResult GetDataFromDBUsingTempData()
        {
            var result = GetData.GetTest();
            TempData["result"] = result;
            return View();
        }  
        public ActionResult GetAllData()
        {
            var result = GetData.GetTest();
            ViewBag.test = result;
            return View();
        }
    }
}