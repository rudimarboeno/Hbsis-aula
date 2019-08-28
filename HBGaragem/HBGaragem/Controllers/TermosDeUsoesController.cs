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
    public class TermosDeUsoesController : ApiController
    {
        private ContextDB db = new ContextDB();

        // GET: api/TermosDeUsoes
        public IQueryable<TermosDeUso> GetTermosDeUsoes()
        {
            return db.TermosDeUsoes;
        }

        // GET: api/TermosDeUsoes/5
        [ResponseType(typeof(TermosDeUso))]
        public async Task<IHttpActionResult> GetTermosDeUso(int id)
        {
            TermosDeUso termosDeUso = await db.TermosDeUsoes.FindAsync(id);
            if (termosDeUso == null)
            {
                return NotFound();
            }

            return Ok(termosDeUso);
        }

        // PUT: api/TermosDeUsoes/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutTermosDeUso(int id, TermosDeUso termosDeUso)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != termosDeUso.Id)
            {
                return BadRequest();
            }

            db.Entry(termosDeUso).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TermosDeUsoExists(id))
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

        // POST: api/TermosDeUsoes
        [ResponseType(typeof(TermosDeUso))]
        public async Task<IHttpActionResult> PostTermosDeUso(TermosDeUso termosDeUso)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (termosDeUso != null)
            {
                db.TermosDeUsoes.FirstOrDefault(x => x.Atual == true).Atual = false;
            }

                db.TermosDeUsoes.Add(termosDeUso);
                await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = termosDeUso.Id }, termosDeUso);
        }

        // DELETE: api/TermosDeUsoes/5
        [ResponseType(typeof(TermosDeUso))]
        public async Task<IHttpActionResult> DeleteTermosDeUso(int id)
        {
            TermosDeUso termosDeUso = await db.TermosDeUsoes.FindAsync(id);
            if (termosDeUso == null)
            {
                return NotFound();
            }

            db.TermosDeUsoes.Remove(termosDeUso);
            await db.SaveChangesAsync();

            return Ok(termosDeUso);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool TermosDeUsoExists(int id)
        {
            return db.TermosDeUsoes.Count(e => e.Id == id) > 0;
        }
    }
}