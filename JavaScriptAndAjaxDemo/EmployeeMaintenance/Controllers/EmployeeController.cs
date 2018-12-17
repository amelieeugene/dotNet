using EmployeeMaintenance.Models;
using EmployeeMaintenance.Models.Enums;
using EmployeeMaintenance.Models.DL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployeeMaintenance.Controllers
{
    public class EmployeeController : Controller
    {
        DBModel db = new DBModel();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult EmployeeSummary()
        {
            IList<Employee> empSummary = db.Employees.ToList();
            return View(empSummary);
        }
        public ActionResult detail(int id)
        {
            return PartialView("_detail",db.Employees.Where(e => e.EmployeeId == id).FirstOrDefault());
        }


        [HttpPost]
        public ActionResult delete(int id)
        {
            Employee emp = db.Employees.Where(e => e.EmployeeId == id).FirstOrDefault();
            if(emp != null)
            {
                db.Employees.Remove(emp);
                db.SaveChanges();
                return Content("Deleted Successfully!");
            }
            return Content("Error!");
        }       
    }
}