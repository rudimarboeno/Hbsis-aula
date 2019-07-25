using Calculadora.Calculos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            var Cal = new calculo();

            Console.WriteLine(Cal.CalculoAd(5, 5));

            Console.ReadKey();
        }
    }
}
