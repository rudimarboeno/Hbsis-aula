using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade___02
{
    class Program
    {
        static string[,] BaseReceita;
        static void Main(string[] args)
        {
            BemVindo();
            Menu();

            Console.ReadLine();
        }
        public static void BemVindo()
        {
            Console.WriteLine("Bem Vindo ao 'Receitas com a vovó' ");
            Console.WriteLine("");
        }
        public static int Menu()
        {
            Console.WriteLine("O que deseja realizar?");
            Console.WriteLine("");
            Console.WriteLine("(1) - Bolo de chocolate");
            Console.WriteLine("(2) - banoffe");

            int.TryParse(Console.ReadLine(), out int opcao);

            if (opcao == 1)
            {
                for (int i = 0; i < opcao; i++)
                {
                    Console.Clear();
                    Console.WriteLine("Bolo de chocolate");
                    Console.ReadKey();
                    Console.WriteLine("");
                    Console.WriteLine("leite");
                    Console.ReadKey();
                    Console.WriteLine("açucar");
                    Console.ReadKey();
                    Console.WriteLine("ovo");
                    Console.ReadKey();
                    Console.WriteLine("farinha");
                    Console.ReadKey();
                    Console.WriteLine("chocolate em pó");
                    Console.ReadKey();
                    Console.WriteLine("Fermento");
                }
                
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Banoffe");
                Console.ReadKey();
                Console.WriteLine("");
                Console.WriteLine("banana");
                Console.ReadKey();
                Console.WriteLine("açucar");
                Console.ReadKey();
                Console.WriteLine("canela");
                Console.ReadKey();
                Console.WriteLine("1 lata de doce de leite");
                Console.ReadKey();
                Console.WriteLine("1 xicara de creme de leite");
                Console.ReadKey();
                Console.WriteLine("suco de limao");
            }
            return opcao;
        }
           
        /* teste com string não deu muito certo*/
        public static void CarregarDados()
        {
            BaseReceita = new string[2, 7]
            {
                {"Bolo Chocolate","Ovos","acução","massa para bolo","fermento","leite","trigo"},
                { "banoffee","Bananas","suco de limão","1 lata de leite condeçãdo","1 xicara de creme de leite","açucar","polvilho"},
            };
        }
           
    }
}
