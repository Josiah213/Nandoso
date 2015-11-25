﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Nandoso.Models;

namespace Nandoso.Controllers
{
    public class FeedbacksController : ApiController
    {
        private NandosoContext db = new NandosoContext();

        // GET: api/Feedbacks
        public IQueryable<Feedbacks> GetFeedbacks()
        {
            return db.Feedbacks;
        }

        // GET: api/Feedbacks/5
        [ResponseType(typeof(Feedbacks))]
        public IHttpActionResult GetFeedback(int id)
        {
            Feedbacks feedback = db.Feedbacks.Find(id);
            if (feedback == null)
            {
                return NotFound();
            }

            return Ok(feedback);
        }

        // PUT: api/Feedbacks/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutFeedback(int id, Feedbacks feedback)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != feedback.ID)
            {
                return BadRequest();
            }

            db.Entry(feedback).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FeedbackExists(id))
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

        // POST: api/Feedbacks
        [ResponseType(typeof(Feedbacks))]
        public IHttpActionResult PostFeedback(Feedbacks feedback)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Feedbacks.Add(feedback);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = feedback.ID }, feedback);
        }

        // DELETE: api/Feedbacks/5
        [ResponseType(typeof(Feedbacks))]
        public IHttpActionResult DeleteFeedback(int id)
        {
            Feedbacks feedback = db.Feedbacks.Find(id);
            if (feedback == null)
            {
                return NotFound();
            }

            db.Feedbacks.Remove(feedback);
            db.SaveChanges();

            return Ok(feedback);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool FeedbackExists(int id)
        {
            return db.Feedbacks.Count(e => e.ID == id) > 0;
        }
    }
}