using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HBGaragem.Models
{
    public class TipodeVeiculo
    {
        [Key]
        public int Id { get; set; }
        public string Descricao { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}