using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EmployeeMaintenance.Models;
using EmployeeMaintenance.Models.DL;

namespace EmployeeMaintenance.Controllers
{
    public class HomeController : Controller
    {

        DBModel db = new DBModel();

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