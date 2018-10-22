using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using RestApp1.Models;

namespace RestApp1.Controllers
{
  public class HomeController : Controller
    {
    sandboxEntities edb;

    public HomeController()
    {
      edb = new sandboxEntities();

    }


    public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

      List<customer> custList = (from c in edb.customers
                                  select c).ToList<customer>();

      ViewBag.customerList = custList;

      return View();
        }

    //[System.Web.Http.Route("NewCustomer")]
    //[System.Web.Http.HttpPost]
    //public void NewCustomer([FromBody]string data)
    //{
    //  //string ss = (string)data;
    //  customer newCust = JsonConvert.DeserializeObject<customer>(data);
    //  //customer newCust = new customer { name = data.name };
    //  edb.customers.Add(newCust);
    //  edb.SaveChanges();

    //}
  }
}
