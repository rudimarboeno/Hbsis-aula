using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HbLocacao.Models
{
    public class ModeloMoto
    {
        [Key]
        public int MotoId { get; set; }
        public string Modelomotos { get; set; }
        public string Descricao { get; set; }

        public virtual MarcaMoto MarcaMoto { get; set; }
    }
}