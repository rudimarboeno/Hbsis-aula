using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HbLocacao.Models
{
    public class Locacao : UserControls
    {
        [Key]
        public int LocacaoId { get; set; }
        public int TipoDeVeiculo { get; set; }
        public int Usuario { get; set; }
        public virtual TipoDeVeiculo TipoDeVeiculos { get; set; }
        public virtual Usuario Usuarios { get; set; }
        
    }
}