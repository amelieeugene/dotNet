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

    public ActionResult JoinUs(club_member cm)
    {
      ViewBag.IsAdmin = (bool)Session["adminLoggedIn"];

      if (cm.firstName == null)
        return View();
      else
      {
        if (ModelState.IsValid)
        {
          cm.joinDate = DateTime.Now.Date;
          cm.status = "Pending";
          edb.club_member.Add(cm);
          edb.SaveChanges();

          ViewBag.JoinSuccess = "true";
          return GetClubHomeView();
        }
        else
        {
          ViewBag.JoinSuccess = null;
          return View(cm);
        }
        
      }
    }

    public ActionResult AboutUs()
    {
      ViewBag.IsAdmin = (bool)Session["adminLoggedIn"];
      return View();
    }


    public ActionResult NewAnnouncement(announcement anno)
    {
      ViewBag.IsAdmin = (bool)Session["adminLoggedIn"];

      if (Request.Form.Count == 0)
      {
        return View(new announcement());
      }
      else
      {
        if (anno.ID_announcement == 0)
        {
          announcement newAnno = new announcement
          { topic = Request["topic"], detail = Request["detail"] };
          newAnno.announceTime = DateTime.Now;
          newAnno.status = "Active";
          edb.announcements.Add(newAnno);
          edb.SaveChanges();
        }
        else
        {
          int ID_announcement = anno.ID_announcement;

          var annoUpdate = edb.announcements
            .Where(aa => aa.ID_announcement == ID_announcement)
            .Single();

          annoUpdate.detail = anno.detail;
          annoUpdate.topic = anno.topic;

          edb.SaveChanges();

        }

        return GetClubHomeView();
      }
    }

    public ActionResult EditAnnouncement(int annoID)
    {
      ViewBag.IsAdmin = (bool)Session["adminLoggedIn"];

      announcement anno = (from ann in edb.announcements
                           where ann.ID_announcement == annoID
                           select ann).FirstOrDefault();

      return View("NewAnnouncement", anno);
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
                  where ann.status == "Active"
                  select ann).ToList();

      ClubModel clubModel = new ClubModel();
      clubModel.Announcements = anns;
      clubModel.IsAdmin = (bool)Session["adminLoggedIn"];

      ViewBag.IsAdmin = clubModel.IsAdmin;

      ViewBag.rootPath = string.Format("{0}://{1}{2}", Request.Url.Scheme, Request.Url.Authority, Url.Content("~"));

      return View("Index", clubModel);
    }
  }
}