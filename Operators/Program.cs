using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            var elementoX = new Teste(5,5);

            elementoX.MostrarInformacoes();

            elementoX.AlteraMostrarInformacoes(5,5);

            elementoX.MostrarInformacoes();

            elementoX.AlteraInformacoes();

            elementoX.MostrarInformacoes();

            

            Console.ReadKey();
        }

        public void ManinaSuperPoderoza(ref Teste pTeste)
        {
                    }
        }

    public class Teste
    {
        public int A { get; set; } = 0;
        public int B { get; set; } = 0;
        public Teste(int pA,int pB)
        {
            A = pA;
            B = pB;
        }

        public void AlteraInformacoes()
        {
            A = B * 100;
        }

        public void AlteraMostrarInformacoes(int pA, int pB)
        {
            A = pA * 2;
            A = pB * 2;
        }

        public void MostrarInformacoes()
        {
            Console.WriteLine(A + B);

        }

    }
}
