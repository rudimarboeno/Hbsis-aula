using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HbLocacao.Models
{
    public class TipoDeVeiculo
    {
        [Key]

        public string Automovel { get; set; }
        public string Moto { get; set; }
        public string Bicicleta { get; set; }
        public string Patinete { get; set; }
    }
}