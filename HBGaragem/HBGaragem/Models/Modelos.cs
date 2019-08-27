using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HBGaragem.Models
{
    public class Modelos
    {
        [Key]
        public int Id { get; set; }
        public string Marca { get; set; }
        public string Descricao { get; set; }
        public virtual TipodeVeiculo TipodeVeiculo { get; set; }
        public virtual Marcas Marcas { get; set; }
    }
}