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
    public class ModeloAltomovelsController : ApiController
    {
        private ContextDB db = new ContextDB();

        // GET: api/ModeloAltomovels
        public IQueryable<ModeloAltomovel> GetmodeloAutomovels()
        {
            return db.modeloAutomovels;
        }

        // GET: api/ModeloAltomovels/5
        [ResponseType(typeof(ModeloAltomovel))]
        public async Task<IHttpActionResult> GetModeloAltomovel(int id)
        {
            ModeloAltomovel modeloAltomovel = await db.modeloAutomovels.FindAsync(id);
            if (modeloAltomovel == null)
            {
                return NotFound();
            }

            return Ok(modeloAltomovel);
        }

        // PUT: api/ModeloAltomovels/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutModeloAltomovel(int id, ModeloAltomovel modeloAltomovel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != modeloAltomovel.Id)
            {
                return BadRequest();
            }

            db.Entry(modeloAltomovel).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ModeloAltomovelExists(id))
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

        // POST: api/ModeloAltomovels
        [ResponseType(typeof(ModeloAltomovel))]
        public async Task<IHttpActionResult> PostModeloAltomovel(ModeloAltomovel modeloAltomovel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.modeloAutomovels.Add(modeloAltomovel);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = modeloAltomovel.Id }, modeloAltomovel);
        }

        // DELETE: api/ModeloAltomovels/5
        [ResponseType(typeof(ModeloAltomovel))]
        public async Task<IHttpActionResult> DeleteModeloAltomovel(int id)
        {
            ModeloAltomovel modeloAltomovel = await db.modeloAutomovels.FindAsync(id);
            if (modeloAltomovel == null)
            {
                return NotFound();
            }

            db.modeloAutomovels.Remove(modeloAltomovel);
            await db.SaveChangesAsync();

            return Ok(modeloAltomovel);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ModeloAltomovelExists(int id)
        {
            return db.modeloAutomovels.Count(e => e.Id == id) > 0;
        }
    }
}