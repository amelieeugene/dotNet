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
    public class club_eventController : ApiController
    {
        private sandboxEntities db = new sandboxEntities();

        // GET: api/club_event
        public IQueryable<club_event> Getclub_event()
        {
            return db.club_event;
        }

        // GET: api/club_event/5
        [ResponseType(typeof(club_event))]
        public IHttpActionResult Getclub_event(int id)
        {
            club_event club_event = db.club_event.Find(id);
            if (club_event == null)
            {
                return NotFound();
            }

            return Ok(club_event);
        }

        // PUT: api/club_event/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Putclub_event(int id, club_event club_event)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != club_event.ID_event)
            {
                return BadRequest();
            }

            db.Entry(club_event).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!club_eventExists(id))
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

        // POST: api/club_event
        [ResponseType(typeof(club_event))]
        public IHttpActionResult Postclub_event(club_event club_event)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.club_event.Add(club_event);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (club_eventExists(club_event.ID_event))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = club_event.ID_event }, club_event);
        }

        // DELETE: api/club_event/5
        [ResponseType(typeof(club_event))]
        public IHttpActionResult Deleteclub_event(int id)
        {
            club_event club_event = db.club_event.Find(id);
            if (club_event == null)
            {
                return NotFound();
            }

            db.club_event.Remove(club_event);
            db.SaveChanges();

            return Ok(club_event);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool club_eventExists(int id)
        {
            return db.club_event.Count(e => e.ID_event == id) > 0;
        }
    }
}