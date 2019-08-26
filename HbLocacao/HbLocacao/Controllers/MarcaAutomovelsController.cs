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
using HbLocacao.Models;

namespace HbLocacao.Controllers
{
    public class MarcaAutomovelsController : ApiController
    {
        private ContextDB db = new ContextDB();

        // GET: api/MarcaAutomovels
        public IQueryable<MarcaAutomovel> GetmarcaAutomovels()
        {
            return db.marcaAutomovels;
        }

        // GET: api/MarcaAutomovels/5
        [ResponseType(typeof(MarcaAutomovel))]
        public async Task<IHttpActionResult> GetMarcaAutomovel(int id)
        {
            MarcaAutomovel marcaAutomovel = await db.marcaAutomovels.FindAsync(id);
            if (marcaAutomovel == null)
            {
                return NotFound();
            }

            return Ok(marcaAutomovel);
        }

        // PUT: api/MarcaAutomovels/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutMarcaAutomovel(int id, MarcaAutomovel marcaAutomovel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != marcaAutomovel.Id)
            {
                return BadRequest();
            }

            db.Entry(marcaAutomovel).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MarcaAutomovelExists(id))
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

        // POST: api/MarcaAutomovels
        [ResponseType(typeof(MarcaAutomovel))]
        public async Task<IHttpActionResult> PostMarcaAutomovel(MarcaAutomovel marcaAutomovel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.marcaAutomovels.Add(marcaAutomovel);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = marcaAutomovel.Id }, marcaAutomovel);
        }

        // DELETE: api/MarcaAutomovels/5
        [ResponseType(typeof(MarcaAutomovel))]
        public async Task<IHttpActionResult> DeleteMarcaAutomovel(int id)
        {
            MarcaAutomovel marcaAutomovel = await db.marcaAutomovels.FindAsync(id);
            if (marcaAutomovel == null)
            {
                return NotFound();
            }

            db.marcaAutomovels.Remove(marcaAutomovel);
            await db.SaveChangesAsync();

            return Ok(marcaAutomovel);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool MarcaAutomovelExists(int id)
        {
            return db.marcaAutomovels.Count(e => e.Id == id) > 0;
        }
    }
}