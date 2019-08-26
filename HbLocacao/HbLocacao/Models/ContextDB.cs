using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HbLocacao.Models
{
    public class ContextDB : DbContext
    {
        public DbSet<Usuario> usuarios { get; set; }
        public DbSet<TipoDeVeiculo> tipoDeVeiculos { get; set; }
        public DbSet<MarcaAutomovel> marcaAutomovels { get; set; }
        public DbSet<ModeloAltomovel> modeloAutomovels { get; set; }
        public DbSet<MarcaMoto> marcamoto { get; set; }
        public DbSet<ModeloMoto> modelomoto { get; set; }
        public DbSet<CoresVeiculos> coresveiculos { get; set; }
    }
}