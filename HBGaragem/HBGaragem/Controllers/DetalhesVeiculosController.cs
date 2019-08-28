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
    public class DetalhesVeiculosController : ApiController
    {
        private ContextDB db = new ContextDB();

        // GET: api/DetalhesVeiculos
        public IQueryable<DetalhesVeiculos> GetCoresVeiculos()
        {
            return db.CoresVeiculos;
        }

        // GET: api/DetalhesVeiculos/5
        [ResponseType(typeof(DetalhesVeiculos))]
        public async Task<IHttpActionResult> GetDetalhesVeiculos(int id)
        {
            DetalhesVeiculos detalhesVeiculos = await db.CoresVeiculos.FindAsync(id);
            if (detalhesVeiculos == null)
            {
                return NotFound();
            }

            return Ok(detalhesVeiculos);
        }

        // PUT: api/DetalhesVeiculos/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutDetalhesVeiculos(int id, DetalhesVeiculos detalhesVeiculos)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != detalhesVeiculos.Id)
            {
                return BadRequest();
            }

            db.Entry(detalhesVeiculos).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DetalhesVeiculosExists(id))
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

        // POST: api/DetalhesVeiculos
        [ResponseType(typeof(DetalhesVeiculos))]
        public async Task<IHttpActionResult> PostDetalhesVeiculos(DetalhesVeiculos detalhesVeiculos)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.CoresVeiculos.Add(detalhesVeiculos);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = detalhesVeiculos.Id }, detalhesVeiculos);
        }

        // DELETE: api/DetalhesVeiculos/5
        [ResponseType(typeof(DetalhesVeiculos))]
        public async Task<IHttpActionResult> DeleteDetalhesVeiculos(int id)
        {
            DetalhesVeiculos detalhesVeiculos = await db.CoresVeiculos.FindAsync(id);
            if (detalhesVeiculos == null)
            {
                return NotFound();
            }

            db.CoresVeiculos.Remove(detalhesVeiculos);
            await db.SaveChangesAsync();

            return Ok(detalhesVeiculos);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool DetalhesVeiculosExists(int id)
        {
            return db.CoresVeiculos.Count(e => e.Id == id) > 0;
        }
    }
}