using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HBGaragem.Models
{
    public class Usuario : UserControls
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }

    }
}