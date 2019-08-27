using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HbLocacao.Models
{
    public class CoresVeiculos
    {
        [Key]
        public int CoresId { get; set; }
        public string Cores { get; set; }
        public virtual TipoDeVeiculo TipoDeVeiculo { get; set; }
    }
}