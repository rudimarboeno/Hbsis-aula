using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostraCalculadora
{
    public class Class1
    {
        public decimal Adicao (decimal numero01,decimal numero02)
        {
            return numero01 + numero02;
        }
        public decimal Subtracao(decimal numero01, decimal numero02)
        {
            return numero01 - numero02;
        }
        public decimal Multiplicacao(decimal numero01, decimal numero02)
        {
            return numero01 * numero02;
        }
        public decimal Divisao(decimal numero01, decimal numero02)
        {
            return numero01 / numero02;
        }
        public decimal Retangulo(decimal numero01, decimal numero02)
        {
            return numero01 * numero02;
        }
        public double TrianguloEquilatero(double lado)
        {
            return (Math.Pow(lado, 2) * Math.Sqrt(3)) /4;
        }

        public double AreaDeUmCirculo(double area)
        {
        
            return (Math.Sqrt(Math.PI / area));
        }
    }
}
