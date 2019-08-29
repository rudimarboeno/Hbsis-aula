using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HBGaragem.Models
{
    public class Locacao
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("TipodeVeiculo_Fk")]
        public TipodeVeiculo TipodeVeiculo { get; set; }
        public int TipodeVeiculo_Fk { get; set; }

        [ForeignKey("Marcas_FK")]
        public Marcas Marcas { get; set; }
        public int Marcas_FK { get; set; }

        [ForeignKey("Modelos_FK")]
        public Modelos Modelos { get; set; }
        public int Modelos_FK { get; set; }

        [ForeignKey("DetalhesVeiculos_FK")]
        public DetalhesVeiculos DetalhesVeiculos { get; set; }
        public  int DetalhesVeiculos_FK { get; set; }

        public string Placa { get; set; }

        [ForeignKey("PeriodoLocacao_FK")]
        public PeriodoLocacao PeriodoLocacao { get; set; }
        public int PeriodoLocacao_FK { get; set; }

        
        [ForeignKey("Usuario_FK")]
        public Usuario Usuario { get; set; }
        public int Usuario_FK { get; set; }

      
        public TermosDeUso TermosDeUso { get; set; }
        public bool TermosDeUso_Id { get; set; }


    }
}