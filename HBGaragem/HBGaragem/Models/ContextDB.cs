using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HBGaragem.Models
{
    public class ContextDB : DbContext
    {
        public DbSet<Marcas> Marcas { get; set; }
        public DbSet<Modelos> Modelos { get; set; }
        public DbSet<TipodeVeiculo> TipodeVeiculos { get; set; }
        public DbSet<Locacao> Locacaos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<DetalhesVeiculo> DetalhesVeiculos { get; set; }

        public DbSet<PeriodoLocacao> PeriodoLocacaos { get; set; }
        public DbSet<Veiculo> Veiculos { get; set; }

        public System.Data.Entity.DbSet<HBGaragem.Models.TermosDeUso> TermosDeUsoes { get; set; }

        public System.Data.Entity.DbSet<HBGaragem.Models.Vagas> Vagas { get; set; }
    }
}