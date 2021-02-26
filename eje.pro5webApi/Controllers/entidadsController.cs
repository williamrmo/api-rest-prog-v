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
using eje.pro5webApi;

namespace eje.pro5webApi.Controllers
{
    public class entidadsController : ApiController
    {
        private db_practica_03Entities db = new db_practica_03Entities();

        // GET: api/entidads
        public IQueryable<entidad> Getentidads()
        {
            return db.entidads;
        }

        // GET: api/entidads/5
        [ResponseType(typeof(entidad))]
        public IHttpActionResult Getentidad(string id)
        {
            entidad entidad = db.entidads.Find(id);
            if (entidad == null)
            {
                return NotFound();
            }

            return Ok(entidad);
        }

        // PUT: api/entidads/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Putentidad(string id, entidad entidad)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != entidad.Cedula)
            {
                return BadRequest();
            }

            db.Entry(entidad).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!entidadExists(id))
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

        // POST: api/entidads
        [ResponseType(typeof(entidad))]
        public IHttpActionResult Postentidad(entidad entidad)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.entidads.Add(entidad);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (entidadExists(entidad.Cedula))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = entidad.Cedula }, entidad);
        }

        // DELETE: api/entidads/5
        [ResponseType(typeof(entidad))]
        public IHttpActionResult Deleteentidad(string id)
        {
            entidad entidad = db.entidads.Find(id);
            if (entidad == null)
            {
                return NotFound();
            }

            db.entidads.Remove(entidad);
            db.SaveChanges();

            return Ok(entidad);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool entidadExists(string id)
        {
            return db.entidads.Count(e => e.Cedula == id) > 0;
        }
    }
}