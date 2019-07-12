using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade___01
{
    class Program
    {
        static void Main(string[] args)
        {
      
            MenuSejaBemVindo();
            MenuPrincipal();

            Console.ReadKey();
        }

        /// <summary>
        /// Chama meu menu de seja bem vindo
        /// </summary>
        public static void MenuSejaBemVindo()
        {
            Console.WriteLine("Bem Vindo ao sistema can drink or not");
            Console.WriteLine("  Desenvolvido pela texas.drink");
            Console.WriteLine("");

            Console.WriteLine("Menu can drink or not");
            Console.WriteLine("Com o nosso menu você pode saber se você pode ingirir alcoól");
            Console.WriteLine("");
        }
        /// <summary>
        /// Chama meu menu principal menu de opção
        /// </summary>
        /// <returns></returns>
        public static int MenuPrincipal()
        {
            Console.WriteLine("O que deseja realizar");
            Console.WriteLine("(1) - Para saber se você pode ingirir alcoól");
            Console.WriteLine("(2) - Sair do sistema");

            int.TryParse(Console.ReadKey().KeyChar.ToString(), out int opcao);

            if (opcao == 1)
            {
              
                Console.Clear();

                Console.WriteLine("Informe sua idade:");

                int.TryParse(Console.ReadLine(), out int idade);

                if (idade >= 18)
                {
                    Console.Clear();
                    Console.WriteLine("");
                    Console.WriteLine("Parabén você pode beber");
                    Console.WriteLine("Obrigado por uzar o nosso sistema");
                }
                else
                {
                    Console.WriteLine("Você ainda não possui idade suficiente para ingiri alcoól");
                }
            }
            return opcao;

            
        }
    }
}
