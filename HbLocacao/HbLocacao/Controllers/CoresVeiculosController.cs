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
    public class CoresVeiculosController : ApiController
    {
        private ContextDB db = new ContextDB();

        // GET: api/CoresVeiculos
        public IQueryable<CoresVeiculos> Getcoresveiculos()
        {
            return db.coresveiculos;
        }

        // GET: api/CoresVeiculos/5
        [ResponseType(typeof(CoresVeiculos))]
        public async Task<IHttpActionResult> GetCoresVeiculos(int id)
        {
            CoresVeiculos coresVeiculos = await db.coresveiculos.FindAsync(id);
            if (coresVeiculos == null)
            {
                return NotFound();
            }

            return Ok(coresVeiculos);
        }

        // PUT: api/CoresVeiculos/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutCoresVeiculos(int id, CoresVeiculos coresVeiculos)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != coresVeiculos.Id)
            {
                return BadRequest();
            }

            db.Entry(coresVeiculos).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CoresVeiculosExists(id))
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

        // POST: api/CoresVeiculos
        [ResponseType(typeof(CoresVeiculos))]
        public async Task<IHttpActionResult> PostCoresVeiculos(CoresVeiculos coresVeiculos)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.coresveiculos.Add(coresVeiculos);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = coresVeiculos.Id }, coresVeiculos);
        }

        // DELETE: api/CoresVeiculos/5
        [ResponseType(typeof(CoresVeiculos))]
        public async Task<IHttpActionResult> DeleteCoresVeiculos(int id)
        {
            CoresVeiculos coresVeiculos = await db.coresveiculos.FindAsync(id);
            if (coresVeiculos == null)
            {
                return NotFound();
            }

            db.coresveiculos.Remove(coresVeiculos);
            await db.SaveChangesAsync();

            return Ok(coresVeiculos);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CoresVeiculosExists(int id)
        {
            return db.coresveiculos.Count(e => e.Id == id) > 0;
        }
    }
}