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

        Week13bAdoDotNetViewBoxDBEntities _db = new Week13bAdoDotNetViewBoxDBEntities();    // Object from Model1.Context.cs
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}