using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDeAluno.Classes
{
    public class Aluno
    {
        public string Nome   { get; set; }
        public int    Idadae { get; set; }
        public DateTime DatInc { get; set; } = DateTime.Now;
    }
}
