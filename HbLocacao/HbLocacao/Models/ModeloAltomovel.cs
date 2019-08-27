using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HbLocacao.Models
{
    public class ModeloAltomovel
    {
        [Key]
        public int AltomovelId { get; set; }
        public string AltomovelModelo { get; set; }
        public string Descricao { get; set; }
        public virtual MarcaAutomovel MarcaAutomovel { get; set; }
    }
}