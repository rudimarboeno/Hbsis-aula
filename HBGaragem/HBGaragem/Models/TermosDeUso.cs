using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HBGaragem.Models
{
    public class TermosDeUso 
    {
        [Key]
        public int Id { get; set; }
        public string Descricao { get; set; }

        public bool Atual { get; set; }
    }
}