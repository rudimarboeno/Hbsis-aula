using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HBGaragem.Models
{
    public class DetalhesVeiculos
    {
        [Key]
        public int Id { get; set; }
        public string Cores { get; set; }
        public string Placa { get; set; }
        public virtual TipodeVeiculo TipoDeVeiculo { get; set; }
    }
}