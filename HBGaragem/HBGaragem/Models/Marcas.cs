using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HBGaragem.Models
{
    public class Marcas
    {
        [Key]
        public int Id { get; set; }
        public string Descricao { get; set; }
        public virtual TipodeVeiculo TipodeVeiculo { get; set; }
    }
}