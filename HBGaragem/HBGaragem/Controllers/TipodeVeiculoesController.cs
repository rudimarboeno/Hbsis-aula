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
    public class TipodeVeiculoesController : ApiController
    {
        private ContextDB db = new ContextDB();

        // GET: api/TipodeVeiculoes
        public IQueryable<TipodeVeiculo> GetTipodeVeiculos()
        {
            return db.TipodeVeiculos;
        }

        // GET: api/TipodeVeiculoes/5
        [ResponseType(typeof(TipodeVeiculo))]
        public async Task<IHttpActionResult> GetTipodeVeiculo(int id)
        {
            TipodeVeiculo tipodeVeiculo = await db.TipodeVeiculos.FindAsync(id);
            if (tipodeVeiculo == null)
            {
                return NotFound();
            }

            return Ok(tipodeVeiculo);
        }

        // PUT: api/TipodeVeiculoes/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutTipodeVeiculo(int id, TipodeVeiculo tipodeVeiculo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tipodeVeiculo.Id)
            {
                return BadRequest();
            }

            db.Entry(tipodeVeiculo).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TipodeVeiculoExists(id))
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

        // POST: api/TipodeVeiculoes
        [ResponseType(typeof(TipodeVeiculo))]
        public async Task<IHttpActionResult> PostTipodeVeiculo(TipodeVeiculo tipodeVeiculo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.TipodeVeiculos.Add(tipodeVeiculo);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = tipodeVeiculo.Id }, tipodeVeiculo);
        }

        // DELETE: api/TipodeVeiculoes/5
        [ResponseType(typeof(TipodeVeiculo))]
        public async Task<IHttpActionResult> DeleteTipodeVeiculo(int id)
        {
            TipodeVeiculo tipodeVeiculo = await db.TipodeVeiculos.FindAsync(id);
            if (tipodeVeiculo == null)
            {
                return NotFound();
            }

            db.TipodeVeiculos.Remove(tipodeVeiculo);
            await db.SaveChangesAsync();

            return Ok(tipodeVeiculo);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool TipodeVeiculoExists(int id)
        {
            return db.TipodeVeiculos.Count(e => e.Id == id) > 0;
        }
    }
}