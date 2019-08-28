﻿using System;
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
    public class PeriodoLocacaosController : ApiController
    {
        private ContextDB db = new ContextDB();

        // GET: api/PeriodoLocacaos
        public IQueryable<PeriodoLocacao> GetPeriodoLocacaos()
        {
            return db.PeriodoLocacaos;
        }

        // GET: api/PeriodoLocacaos/5
        [ResponseType(typeof(PeriodoLocacao))]
        public async Task<IHttpActionResult> GetPeriodoLocacao(int id)
        {
            PeriodoLocacao periodoLocacao = await db.PeriodoLocacaos.FindAsync(id);
            if (periodoLocacao == null)
            {
                return NotFound();
            }

            return Ok(periodoLocacao);
        }

        // PUT: api/PeriodoLocacaos/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutPeriodoLocacao(int id, PeriodoLocacao periodoLocacao)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != periodoLocacao.Id)
            {
                return BadRequest();
            }

            db.Entry(periodoLocacao).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PeriodoLocacaoExists(id))
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

        // POST: api/PeriodoLocacaos
        [ResponseType(typeof(PeriodoLocacao))]
        public async Task<IHttpActionResult> PostPeriodoLocacao(PeriodoLocacao periodoLocacao)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.PeriodoLocacaos.Add(periodoLocacao);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = periodoLocacao.Id }, periodoLocacao);
        }

        // DELETE: api/PeriodoLocacaos/5
        [ResponseType(typeof(PeriodoLocacao))]
        public async Task<IHttpActionResult> DeletePeriodoLocacao(int id)
        {
            PeriodoLocacao periodoLocacao = await db.PeriodoLocacaos.FindAsync(id);
            if (periodoLocacao == null)
            {
                return NotFound();
            }

            db.PeriodoLocacaos.Remove(periodoLocacao);
            await db.SaveChangesAsync();

            return Ok(periodoLocacao);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PeriodoLocacaoExists(int id)
        {
            return db.PeriodoLocacaos.Count(e => e.Id == id) > 0;
        }
    }
}