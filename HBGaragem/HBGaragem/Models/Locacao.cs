using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HBGaragem.Models
{
    public class Locacao
    {
        [Key]
        public int Id { get; set; }
        public int TipoDeVeiculo { get; set; }
        public int Usuario { get; set; }
        public string TempoLocacao { get; set; }
        public string Placa { get; set; }
        public int Cor { get; set; }
        public bool PCD { get; set; }
        public bool Carona { get; set; }
        public virtual TipodeVeiculo TipoDeVeiculos { get; set; }
        public virtual Usuario Usuarios { get; set; }
        public virtual DetalhesVeiculos DetalhesVeiculos { get; set; }
    }
}