using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebMvcApp.Models
{
    public class ContextDB : DbContext
    {
        public DbSet<Pessoa> pessoas { get; set; }

     
        public DbSet<Carro> Carroes { get; set; }
    }
}