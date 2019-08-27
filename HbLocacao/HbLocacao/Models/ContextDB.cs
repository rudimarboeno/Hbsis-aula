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
   
       
    }
}