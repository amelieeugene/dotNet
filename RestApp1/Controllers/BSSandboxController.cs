using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GridMvc.Html;
using RestApp1.Models;

namespace RestApp1.Controllers
{
  public class BSSandboxController : Controller
  {
    // GET: BSSandbox
    public ActionResult BSS()
    {
      return View();
    }

    public ActionResult GridTest()
    {
      sandboxEntities sbxDB = new sandboxEntities();
      List<order> orders = (from o in sbxDB.orders
                            select o).ToList();

      return View(orders);
    }

    public ActionResult Detail(int ID)
    {
      sandboxEntities sbxDB = new sandboxEntities();
      order odr = (from o in sbxDB.orders
                   where o.id == ID
                   select o).FirstOrDefault();

      return PartialView(odr);
    }

    [HttpPost]
    public ActionResult DeleteOrder(int ID)
    {
      sandboxEntities sbxDB = new sandboxEntities();

      var odr = new order { id = ID };
      sbxDB.orders.Attach(odr);
      sbxDB.orders.Remove(odr);
      sbxDB.SaveChanges();

      //List<order> orders = (from o in sbxDB.orders
      //                      select o).ToList();

      //return PartialView("Orders", orders);
      return Content("");
    }

    public ActionResult Orders()
    {
      sandboxEntities sbxDB = new sandboxEntities();
      List<order> orders = (from o in sbxDB.orders
                            select o).ToList();

      return PartialView(orders);
    }
  }
    
}