using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoStudent.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        public ActionResult StudentDetail()
        {
            //ViewBag.Name = "Arya";
            //ViewBag.PresentTime = DateTime.Now.ToString();
            ViewData["Name"] = "Arya";
            ViewData["PresentTime"] = DateTime.Now.ToString();
            ViewData["College"] = "SNGCE";



            return View();
        }
    }
}