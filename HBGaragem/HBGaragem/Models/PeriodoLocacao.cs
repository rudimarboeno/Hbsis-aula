using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HBGaragem.Models
{
    public class PeriodoLocacao
    {
       [Key]
        public int Id { get; set; }

        [Display(Name = "Data Inicio:")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DataInicio { get; set; } = DateTime.Now;

        [Display(Name = "Data Final:")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DataFinal { get; set; } = DateTime.Now;
    }
}