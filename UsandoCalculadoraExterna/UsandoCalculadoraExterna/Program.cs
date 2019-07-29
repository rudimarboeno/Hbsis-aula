using BibliotecaCalculadora;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UsandoCalculadoraExterna
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 teste = new Class1();

            Console.WriteLine("Soma");
            Console.WriteLine(teste.Soma(5, 5));

            Console.WriteLine("Subtração");
            Console.WriteLine(teste.Subtracao(8, 3));

            Console.WriteLine("Multiplicação");
            Console.WriteLine(teste.Multiplicacao(50, 2));

            Console.WriteLine("Divisao");
            Console.WriteLine(teste.Divisao(25, 32));

            Console.WriteLine("Retangulo");
            Console.WriteLine(teste.AreaRetangulo(5, 5));

            Console.WriteLine("Triangulo");
            Console.WriteLine(teste.AreaTriangulo(5));

            
            Console.WriteLine("Multiplicação");
            Console.WriteLine(teste.RaioCirculo(85));


            Console.ReadKey();
        }
    }
}
