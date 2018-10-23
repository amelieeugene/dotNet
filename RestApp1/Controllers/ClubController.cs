using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RestApp1.Models;

namespace RestApp1.Controllers
{
  public class ClubController : Controller
  {
    sandboxEntities edb;
   

    public ClubController()
    {
      edb = new sandboxEntities();
     

    }

    // GET: Club
    public ActionResult Index()
    {
      return GetClubHomeView();
    }

    public ActionResult Events()
    {
      var evns = (from evt in edb.club_event                 
                  select evt).ToList();

      var upcomingevts = (from ev in evns
                          where ev.schedule_time >= DateTime.Now
                          select ev).ToList();

      var pastevts = (from ev in evns
                      where ev.schedule_time < DateTime.Now
                      select ev).ToList();

      ClubModel clubModel = new ClubModel();
      clubModel.Upcoming_events = upcomingevts;
      clubModel.Past_events = pastevts;
      ViewBag.IsAdmin = (bool)Session["adminLoggedIn"];

      return View("Events", clubModel);
    }

    public ActionResult JoinUs()
    {
      ViewBag.IsAdmin = (bool)Session["adminLoggedIn"];
      return View();
    }

    public ActionResult NewAnnouncement()
    {
      ViewBag.IsAdmin = (bool)Session["adminLoggedIn"];

      if (Request.Form.Count == 0)
        return View();
      else
      {
        announcement newAnno = new announcement
        { topic = Request["topic"], detail = Request["detail"] };
        newAnno.announceTime = DateTime.Now;
        edb.announcements.Add(newAnno);
        edb.SaveChanges();

        return GetClubHomeView();
      }
    }

    public ActionResult NewEvent()
    {
      ViewBag.IsAdmin = (bool)Session["adminLoggedIn"];

      if (Request.Form.Count == 0)
        return View();
      else
      {
        club_event newEvt = new club_event
        { name = Request["name"], description = Request["description"], location = Request["location"] };

        string dateTimeStr = Request["schedule_time"];
        newEvt.schedule_time = Convert.ToDateTime(dateTimeStr);
        edb.club_event.Add(newEvt);
        edb.SaveChanges();

        return Events();
      }
    }

    public ActionResult DeleteAnnouncement()
    {
      int ID_announcement = Convert.ToInt32(Request["ID_announcement"]);

      announcement delAnno = (from anno in edb.announcements
                              where anno.ID_announcement == ID_announcement
                              select anno).FirstOrDefault();

      
      edb.announcements.Remove(delAnno);
      edb.SaveChanges();
      return GetClubHomeView();
    }

    public ActionResult AdminLogin(FormCollection formCollection)
    {
      string userId = formCollection["adminUserId"];
      string psw = formCollection["adminPassword"];

      if (userId.Equals("amelie") && psw.Equals("amelie"))
        Session["adminLoggedIn"] = true;
      else
        Session["adminLoggedIn"] = false;

      return RedirectToAction("Index", "Club");



      //return Content("hi.");
    }

   
    private ActionResult GetClubHomeView()
    {
      var anns = (from ann in edb.announcements
                  select ann).ToList();

      ClubModel clubModel = new ClubModel();
      clubModel.Announcements = anns;
      clubModel.IsAdmin = (bool)Session["adminLoggedIn"];

      ViewBag.IsAdmin = clubModel.IsAdmin;

      return View("Index", clubModel);
    }
  }
}