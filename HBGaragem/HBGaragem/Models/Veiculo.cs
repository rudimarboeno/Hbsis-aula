using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HBGaragem.Models
{
    public class Veiculo
    {
        [Key]
        public int Id { get; set; }

        [JsonIgnore]
        [ForeignKey("TipodeVeiculo_Fk")]
        public TipodeVeiculo TipodeVeiculo { get; set; }
        public int TipodeVeiculo_Fk { get; set; }

        [JsonIgnore]
        [ForeignKey("DetalhesVeiculo_FK")]
        public DetalhesVeiculo DetalhesVeiculo { get; set; }
        public int DetalhesVeiculo_FK { get; set;}

        [JsonIgnore]
        [ForeignKey("Marcas_Fk")]
        public Marcas Marcas { get; set; }
        public int Marcas_Fk { get; set; }

        [JsonIgnore]
        [ForeignKey("Modelos_FK")]
        public Modelos Modelos { get; set; }
        public int Modelos_FK { get; set; }

        [JsonIgnore]
        [CustomValidFields(Enums.ValidFields.ValidaPlaca)]
        public string Placa { get; set; }

        [JsonIgnore]
        public virtual Usuario Usuario { get; set; }
    }
}