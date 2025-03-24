using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Week13bAdoDotNetViewBox.Models;

namespace Week13bAdoDotNetViewBox.Controllers
{


    public class HomeController : Controller
    {

        //Week13bAdoDotNetViewBoxDBEntities _db = new Week13bAdoDotNetViewBoxDBEntities();    // Object from Model1.Context.cs
        public ActionResult Index()
        {
            var a = TempData["Message1"];
            var b = TempData["Message2"];
            var c = TempData["Message3"];
            var d = TempData["Message4"];

            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Create()
        {
            ViewBag.Message = "Your application description page with ViewBag.";
            return View();
        }

        [HttpPost]
        public ActionResult Create(Employee obj)
        {
            ViewBag.Shiv = $"Employee created with Name: {obj.FirstName} and Gender: {obj.Gender} and Gender: {obj.LastName}";

            //ViewBag.Message1 = obj.FirstName;
            //ViewBag.Message2 = obj.LastName;
            //ViewBag.Message3 = obj.Email;
            //ViewBag.Message4 = obj.Gender;

            //return View();

            TempData["Message1"] = obj.FirstName;       //TempData to send data to another action
            TempData["Message2"] = obj.LastName;
            TempData["Message3"] = obj.Email;
            TempData["Message4"] = obj.Gender;

            //return View();
            return RedirectToAction("Index");
        }



        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}