using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HbLocacao.Models
{
    public class Usuario : UserControls
    {
        [Key]
        public int UsuarioId { get; set; }
        public string Nome { get; set; }

    }
}