using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Calculos
{
    public class calculo
    {
        public int CalculoAd(int valor1, int valor2)
        {
            return valor1 + valor2;
        }

        public int CalculoSub(int valor1, int valor2)
        {
            return valor1 - valor2;
        }

        public int CalculoMul(int valor1, int valor2)
        {
            return valor1 * valor2;
        }

        public int CalculoDivi(int valor1, int valor2)
        {
            return valor1 / valor2;
        }
    }
}
