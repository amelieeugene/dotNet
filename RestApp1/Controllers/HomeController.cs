﻿using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Newtonsoft.Json;
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
      //JsonSerializerSettings jss = new JsonSerializerSettings()
      //{
      //  ReferenceLoopHandling = ReferenceLoopHandling.Ignore
      //};

      //List<customer> cc = (from c in edb.customers
      //                     where c.orders.Any(o => o.order_item.Count > 1)
      //                     select c).ToList();


      //var jsonCC = JsonConvert.SerializeObject(cc, Formatting.Indented, jss);

      //List<customer> dd = (from c in edb.customers
      //                     where c.orders.Any(o => o.order_item.Any(oi => oi.item.name == "player"))
      //                     select c).ToList();



      //var jsonDD = JsonConvert.SerializeObject(dd, Formatting.Indented, jss);

      List<customer> custList = (from c in edb.customers
                                 select c).ToList<customer>();

      //var jsonee = JsonConvert.SerializeObject(custList, Formatting.Indented, jss);

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
