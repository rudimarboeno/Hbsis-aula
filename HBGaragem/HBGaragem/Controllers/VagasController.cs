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
    public class VagasController : ApiController
    {
        private ContextDB db = new ContextDB();

        // GET: api/Vagas
        public IQueryable<Vagas> GetVagas()
        {
            return db.Vagas;
        }

        // GET: api/Vagas/5
        [ResponseType(typeof(Vagas))]
        public async Task<IHttpActionResult> GetVagas(int id)
        {
            Vagas vagas = await db.Vagas.FindAsync(id);
            if (vagas == null)
            {
                return NotFound();
            }

            return Ok(vagas);
        }

        // PUT: api/Vagas/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutVagas(int id, Vagas vagas)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != vagas.Id)
            {
                return BadRequest();
            }

            db.Entry(vagas).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VagasExists(id))
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

        // POST: api/Vagas
        [ResponseType(typeof(Vagas))]
        public async Task<IHttpActionResult> PostVagas(Vagas vagas)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Vagas.Add(vagas);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = vagas.Id }, vagas);
        }

        // DELETE: api/Vagas/5
        [ResponseType(typeof(Vagas))]
        public async Task<IHttpActionResult> DeleteVagas(int id)
        {
            Vagas vagas = await db.Vagas.FindAsync(id);
            if (vagas == null)
            {
                return NotFound();
            }

            db.Vagas.Remove(vagas);
            await db.SaveChangesAsync();

            return Ok(vagas);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool VagasExists(int id)
        {
            return db.Vagas.Count(e => e.Id == id) > 0;
        }
    }
}