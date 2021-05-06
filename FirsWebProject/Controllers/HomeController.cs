using FirsWebProject.Models;
using System.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace FirsWebProject.Controllers
{
    public class HomeController : Controller
    {
        FacultyEntities db = new FacultyEntities();

        public ActionResult Index()
        {
            List<Department> list = db.Departments.ToList();
            return View(list);
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