using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HBGaragem.Models
{
    public class DetalhesVeiculo
    {
        [Key]
        public int Id { get; set; }
        public string Cores { get; set; }
    }
}