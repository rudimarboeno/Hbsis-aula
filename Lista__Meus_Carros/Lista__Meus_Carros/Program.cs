using Lista__Meus_Carros.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista__Meus_Carros
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Carro> minhaLista = new List<Carro>();
            var escolhaInicial = Menu();
            while (true)
            {


                switch (escolhaInicial)
                {
                    case "1": { Adicionar(); } break;
                    case "2": { Listagem(); } break;
                    case "3": { return; } 
                }
                escolhaInicial = Menu();
            }
        }
        public static string RetornaValores(string Modelo)
        {
            Console.WriteLine($"Informe o valor para o campo: {Modelo}");
            return Console.ReadLine();
        }
        public static string Menu()
        {
            Console.WriteLine("Texas car");
            Console.WriteLine("");
            Console.WriteLine("1 - Adicionar");
            Console.WriteLine("2 - Listar");
            Console.WriteLine("3 - Sair");

            return Console.ReadLine();
        }
        public static void Adicionar()
        {
            List<Carro> minhaLista = new List<Carro>();

            for (int i = 0; i < 1; i++)
            {
                minhaLista.Add(new Carro()
                {
                    Modelo = RetornaValores("Modelo"),
                    Ano = int.Parse(RetornaValores("Ano")),
                    Placa = int.Parse(RetornaValores("Placa")),
                    CV = double.Parse(RetornaValores("CV")),
                });
            }
        }
        public static void Listagem()
        {
            List<Carro> minhaLista = new List<Carro>();
            foreach (var item in minhaLista)
                Console.WriteLine($"Carro: {item.Modelo} || Ano:{item.Ano} || Placa:{item.Placa} || Potencia: {item.CV}");
        }
    }
}
