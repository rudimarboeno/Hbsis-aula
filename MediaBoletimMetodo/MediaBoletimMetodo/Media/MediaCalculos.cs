using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBoletimMetodo.Media
{
    public class MediaCalculos
    {
        
        public int medias(int nota01,int nota02,int nota03)
        {

            return (nota01 + nota02 + nota03) / 3;
        }

        public int frequencia(int totalAulas, int numeroFaltas)
        {
            return ((totalAulas - numeroFaltas) * 100) / totalAulas;
        }
        
        public string Retornasituacao(int media,int frequencia)
        {
            if((media >= 7) && (frequencia >= 75))
            {
                return "Aprovado";
            }
            return "Reprovado";
            
        }

    }

}
