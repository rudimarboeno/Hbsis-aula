using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HbLocacao.Models
{
    public class MarcaAutomovel 
    {
        [Key]
       public int AltomovelId { get; set; }
       public string AltomovelMarca { get; set; }
       public string Descricao { get; set; }
    }
}