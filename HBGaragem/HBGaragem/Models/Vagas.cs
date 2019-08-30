using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HBGaragem.Models
{
    public class Vagas
    {
        [Key]
        public int Id { get; set; }
        public int Vaga { get; set; }
        public Decimal Valor
        {
            get
            { return Math.Round(Valor, 2); }
            set
            { Valor = value; }
        }
    }
}