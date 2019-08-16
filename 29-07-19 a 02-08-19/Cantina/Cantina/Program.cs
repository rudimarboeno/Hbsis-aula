using Cantina.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cantina
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta accountUser = new Conta();

        
            while (accountUser.Saldo > 0.00)
            {
               
                var valorLanche = Menu();
                Console.Clear();

                if (accountUser.comprar(valorLanche))
                    Console.WriteLine("Valor pago com sucesso");
                else
                    Console.WriteLine("Operação não realizada");

                Console.WriteLine($"Saldo atual disponivel:{accountUser.Saldo.ToString("N2")}");

                Console.WriteLine("");
            }

            Console.ReadKey();
        }

        public static double Menu()
        {
            Console.WriteLine("Bem vindo a cantina texasLanche");
            Console.WriteLine("");
            Console.WriteLine("Lanche               |     valor");
            Console.WriteLine("");
            Console.WriteLine("1-Mini pizza         |     2,50");
            Console.WriteLine("2-Pão com ovo        |     1,50");
            Console.WriteLine("3-Pão com banha      |     1,00");
            Console.WriteLine("4-Sair");


            switch (Console.ReadLine())
                {
                    case "1": { return 2.50; }
                    case "2": { return 1.50; }
                    case "3": { return 1.00; }
                    case "4": {} break;
               }
                return 0;
           
        }
   
    }
}
