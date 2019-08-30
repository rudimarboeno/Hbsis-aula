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
    public class DetalhesVeiculoesController : ApiController
    {
        private ContextDB db = new ContextDB();

        // GET: api/DetalhesVeiculoes
        public IQueryable<DetalhesVeiculo> GetDetalhesVeiculos()
        {
            return db.DetalhesVeiculos;
        }

        // GET: api/DetalhesVeiculoes/5
        [ResponseType(typeof(DetalhesVeiculo))]
        public async Task<IHttpActionResult> GetDetalhesVeiculo(int id)
        {
            DetalhesVeiculo detalhesVeiculo = await db.DetalhesVeiculos.FindAsync(id);
            if (detalhesVeiculo == null)
            {
                return NotFound();
            }

            return Ok(detalhesVeiculo);
        }

        // PUT: api/DetalhesVeiculoes/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutDetalhesVeiculo(int id, DetalhesVeiculo detalhesVeiculo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != detalhesVeiculo.Id)
            {
                return BadRequest();
            }

            db.Entry(detalhesVeiculo).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DetalhesVeiculoExists(id))
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

        // POST: api/DetalhesVeiculoes
        [ResponseType(typeof(DetalhesVeiculo))]
        public async Task<IHttpActionResult> PostDetalhesVeiculo(DetalhesVeiculo detalhesVeiculo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.DetalhesVeiculos.Add(detalhesVeiculo);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = detalhesVeiculo.Id }, detalhesVeiculo);
        }

        // DELETE: api/DetalhesVeiculoes/5
        [ResponseType(typeof(DetalhesVeiculo))]
        public async Task<IHttpActionResult> DeleteDetalhesVeiculo(int id)
        {
            DetalhesVeiculo detalhesVeiculo = await db.DetalhesVeiculos.FindAsync(id);
            if (detalhesVeiculo == null)
            {
                return NotFound();
            }

            db.DetalhesVeiculos.Remove(detalhesVeiculo);
            await db.SaveChangesAsync();

            return Ok(detalhesVeiculo);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool DetalhesVeiculoExists(int id)
        {
            return db.DetalhesVeiculos.Count(e => e.Id == id) > 0;
        }
    }
}