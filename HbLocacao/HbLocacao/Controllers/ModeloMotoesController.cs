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
using HbLocacao.Models;

namespace HbLocacao.Controllers
{
    public class ModeloMotoesController : ApiController
    {
        private ContextDB db = new ContextDB();

        // GET: api/ModeloMotoes
        public IQueryable<ModeloMoto> Getmodelomoto()
        {
            return db.modelomoto;
        }

        // GET: api/ModeloMotoes/5
        [ResponseType(typeof(ModeloMoto))]
        public async Task<IHttpActionResult> GetModeloMoto(int id)
        {
            ModeloMoto modeloMoto = await db.modelomoto.FindAsync(id);
            if (modeloMoto == null)
            {
                return NotFound();
            }

            return Ok(modeloMoto);
        }

        // PUT: api/ModeloMotoes/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutModeloMoto(int id, ModeloMoto modeloMoto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != modeloMoto.Id)
            {
                return BadRequest();
            }

            db.Entry(modeloMoto).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ModeloMotoExists(id))
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

        // POST: api/ModeloMotoes
        [ResponseType(typeof(ModeloMoto))]
        public async Task<IHttpActionResult> PostModeloMoto(ModeloMoto modeloMoto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.modelomoto.Add(modeloMoto);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = modeloMoto.Id }, modeloMoto);
        }

        // DELETE: api/ModeloMotoes/5
        [ResponseType(typeof(ModeloMoto))]
        public async Task<IHttpActionResult> DeleteModeloMoto(int id)
        {
            ModeloMoto modeloMoto = await db.modelomoto.FindAsync(id);
            if (modeloMoto == null)
            {
                return NotFound();
            }

            db.modelomoto.Remove(modeloMoto);
            await db.SaveChangesAsync();

            return Ok(modeloMoto);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ModeloMotoExists(int id)
        {
            return db.modelomoto.Count(e => e.Id == id) > 0;
        }
    }
}