using MediaBoletimMetodo.Media;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorEscola
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();

           var EscolhaInicial = MenuInicial();

            while (true)
            {
                switch (EscolhaInicial)
                {
                    case "1": { menu.Inserir(); } break;
                       
                    case "2": { menu.MostraLista(); } break;

                    case "3": { menu.RemoverInformacoes(); } break;

                    case "4": { return; }
                }
            
                EscolhaInicial = MenuInicial();
            }
        }

        public static string MenuInicial()
        {
            Console.Clear();
            Console.WriteLine("Menu Inicial");
            Console.WriteLine("");
            Console.WriteLine("1-Registrar aluno");
            Console.WriteLine("");
            Console.WriteLine("2-Listagem");
            Console.WriteLine("");
            Console.WriteLine("3-Excluir registro");
            Console.WriteLine("");
            Console.WriteLine("4-Sair do sistema");

            return Console.ReadLine();
        }
    }
}
