using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using RestApp1.Models;

namespace RestApp1.Controllers
{
  public class AnnouncementsController : ApiController
  {
    private sandboxEntities db = new sandboxEntities();

    // GET: api/announcements
    public IQueryable<announcement> Getannouncements()
    {
      return db.announcements;
    }

    // GET: api/announcements/5
    [ResponseType(typeof(announcement))]
    public IHttpActionResult Getannouncement(int id)
    {
      announcement announcement = db.announcements.Find(id);
      if (announcement == null)
      {
        return NotFound();
      }

      return Ok(announcement);
    }

    // PUT: api/announcements/5
    [ResponseType(typeof(void))]
    public IHttpActionResult Putannouncement(int id, announcement announcement)
    {
      if (!ModelState.IsValid)
      {
        return BadRequest(ModelState);
      }

      if (id != announcement.ID_announcement)
      {
        return BadRequest();
      }

      db.Entry(announcement).State = EntityState.Modified;

      try
      {
        db.SaveChanges();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!announcementExists(id))
        {
          return NotFound();
        }
        else
        {
          throw;
        }
      }

      return StatusCode(HttpStatusCode.NoContent);
    }

    //public void Post([FromBody]dynamic data)
    //{
    //  //string ss = (string)data;
    //  //customer newCust = JsonConvert.DeserializeObject<customer>(ss);
    //  announcement newAnno = new announcement { topic = data.topic, detail = data.detail };
    //  db.announcements.Add(newAnno);
    //  db.SaveChanges();

    //}

    // POST: api/announcements
    // could be called this way:  <form action="~/api/announcements" method="POST"> but...
    [ResponseType(typeof(announcement))]
    public IHttpActionResult Postannouncement(announcement announcement)
    {
      if (!ModelState.IsValid)
      {
        return BadRequest(ModelState);
      }

      announcement.announceTime = DateTime.Now;
      db.announcements.Add(announcement);
      announcement.status = "Active";

      try
      {
        db.SaveChanges();
      }
      catch (DbUpdateException)
      {
        if (announcementExists(announcement.ID_announcement))
        {
          return Conflict();
        }
        else
        {
          throw;
        }
      }

      return CreatedAtRoute("DefaultApi", new { id = announcement.ID_announcement }, announcement);
    }

    // DELETE: api/announcements/5
    [ResponseType(typeof(announcement))]
    public IHttpActionResult Deleteannouncement(int id)
    {
      announcement announcement = db.announcements.Find(id);
      if (announcement == null)
      {
        return NotFound();
      }

      announcement.status = "Inactive";
      db.Entry(announcement).State = EntityState.Modified;

      try
      {
        db.SaveChanges();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!announcementExists(id))
        {
          return NotFound();
        }
        else
        {
          throw;
        }
      }
      //db.announcements.Remove(announcement);

      //db.SaveChanges();

      return Ok(announcement);
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing)
      {
        db.Dispose();
      }
      base.Dispose(disposing);
    }

    private bool announcementExists(int id)
    {
      return db.announcements.Count(e => e.ID_announcement == id) > 0;
    }
  }
}