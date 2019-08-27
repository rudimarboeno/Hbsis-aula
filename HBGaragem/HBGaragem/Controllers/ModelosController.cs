using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using HBGaragem.Models;

namespace HBGaragem.Controllers
{
    public class ModelosController : ApiController
    {
        private ContextDB db = new ContextDB();

        // GET: api/Modelos
        public IQueryable<Modelos> GetModelos()
        {
            return db.Modelos;
        }

        // GET: api/Modelos/5
        [ResponseType(typeof(Modelos))]
        public async Task<IHttpActionResult> GetModelos(int id)
        {
            Modelos modelos = await db.Modelos.FindAsync(id);
            if (modelos == null)
            {
                return NotFound();
            }

            return Ok(modelos);
        }

        // PUT: api/Modelos/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutModelos(int id, Modelos modelos)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != modelos.Id)
            {
                return BadRequest();
            }

            db.Entry(modelos).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ModelosExists(id))
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

        // POST: api/Modelos
        [ResponseType(typeof(Modelos))]
        public async Task<IHttpActionResult> PostModelos(Modelos modelos)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Modelos.Add(modelos);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = modelos.Id }, modelos);
        }

        // DELETE: api/Modelos/5
        [ResponseType(typeof(Modelos))]
        public async Task<IHttpActionResult> DeleteModelos(int id)
        {
            Modelos modelos = await db.Modelos.FindAsync(id);
            if (modelos == null)
            {
                return NotFound();
            }

            db.Modelos.Remove(modelos);
            await db.SaveChangesAsync();

            return Ok(modelos);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ModelosExists(int id)
        {
            return db.Modelos.Count(e => e.Id == id) > 0;
        }
    }
}