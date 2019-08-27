using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HbLocacao.Models
{
    public class MarcaMoto
    {
        [Key]
        public int MotoId { get; set; }
        public string Marcamotos { get; set; }
        public string Descricao { get; set; }
    }
}