using HBGaragem.Enums;
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

        [JsonIgnore]
        [ForeignKey("Veiculo_FK")]
        public Veiculo Veiculo  { get; set; }
        public  int Veiculo_FK { get; set; }

        [JsonIgnore]
        [ForeignKey("PeriodoLocacao_FK")]
        public PeriodoLocacao PeriodoLocacao { get; set; }
        public int PeriodoLocacao_FK { get; set; }

        [JsonIgnore]
        [ForeignKey("Usuario_FK")]
        public Usuario Usuario { get; set; }
        public int Usuario_FK { get; set; }

        [JsonIgnore]
        public TermosDeUso TermosDeUso { get; set; }
        public bool TermosDeUso_Id { get; set; }


        public Status Status { get; set; }


    }
}