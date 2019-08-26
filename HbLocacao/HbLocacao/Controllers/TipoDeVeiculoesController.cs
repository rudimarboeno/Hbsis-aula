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
    public class TipoDeVeiculoesController : ApiController
    {
        private ContextDB db = new ContextDB();

        // GET: api/TipoDeVeiculoes
        public IQueryable<TipoDeVeiculo> GettipoDeVeiculos()
        {
            return db.tipoDeVeiculos;
        }

        // GET: api/TipoDeVeiculoes/5
        [ResponseType(typeof(TipoDeVeiculo))]
        public async Task<IHttpActionResult> GetTipoDeVeiculo(string id)
        {
            TipoDeVeiculo tipoDeVeiculo = await db.tipoDeVeiculos.FindAsync(id);
            if (tipoDeVeiculo == null)
            {
                return NotFound();
            }

            return Ok(tipoDeVeiculo);
        }

        // PUT: api/TipoDeVeiculoes/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutTipoDeVeiculo(string id, TipoDeVeiculo tipoDeVeiculo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tipoDeVeiculo.Automovel)
            {
                return BadRequest();
            }

            db.Entry(tipoDeVeiculo).State = EntityState.Modified;

            try
            {
              await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TipoDeVeiculoExists(id))
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

        // POST: api/TipoDeVeiculoes
        [ResponseType(typeof(TipoDeVeiculo))]
        public async Task<IHttpActionResult> PostTipoDeVeiculo(TipoDeVeiculo tipoDeVeiculo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.tipoDeVeiculos.Add(tipoDeVeiculo);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TipoDeVeiculoExists(tipoDeVeiculo.Automovel))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = tipoDeVeiculo.Automovel }, tipoDeVeiculo);
        }

        // DELETE: api/TipoDeVeiculoes/5
        [ResponseType(typeof(TipoDeVeiculo))]
        public async Task<IHttpActionResult> DeleteTipoDeVeiculo(string id)
        {
            TipoDeVeiculo tipoDeVeiculo = db.tipoDeVeiculos.Find(id);
            if (tipoDeVeiculo == null)
            {
                return NotFound();
            }

            db.tipoDeVeiculos.Remove(tipoDeVeiculo);
            await db.SaveChangesAsync();

            return Ok(tipoDeVeiculo);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool TipoDeVeiculoExists(string id)
        {
            return db.tipoDeVeiculos.Count(e => e.Automovel == id) > 0;
        }
    }
}