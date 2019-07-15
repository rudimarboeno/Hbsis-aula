using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeLista
{
    class Program
    {
        static void Main(string[] args)
        {

            string[,] ListaDeNome = new string[5, 3];

            int IdParaLista = 0;

            InserirRegistro(ref ListaDeNome, ref IdParaLista);

            Console.ReadKey();
            InserirRegistro(ref ListaDeNome, ref IdParaLista);

            Console.ReadKey();
        }
        public static void InserirRegistro(ref String[,] ListaDeNome, ref int IdParaLista)
        {
            for (int i = 0; i < ListaDeNome.GetLength(0); i++)
            {
                if (ListaDeNome[i, 0] != null)
                    continue;

                Console.WriteLine("\r\nInforma um nome para adicionar um registro");
                var nome = Console.ReadLine();

                Console.WriteLine("\r\nInforma sua idade para adicionar um registro");
                var idade = Console.ReadLine();



                ListaDeNome[i, 0] = (IdParaLista++).ToString();
                ListaDeNome[i, 1] = nome;
                ListaDeNome[i, 2] = idade;

                Console.WriteLine("Deseja inserir um novo registro? sim(1) || não(0) || Excluir(2)");

                var continuar = Console.ReadKey().KeyChar.ToString();

                if (continuar == "0")
                    break;
                /*
                if(continuar == "2")

                    foreach(var ListaDeNome in IdParaLista)
                    {
                        list.Remove(ListaDeNome);
                        
                    }
                    Console.ReadLine();
                */

                AumentaTamanhoDaLista(ref ListaDeNome);

            }

            Console.WriteLine("Registro adicionado com sucesso, segue lista de informação adicionadas:");

            //agora vo retornar os valores que adicionei acima

            for (int i = 0; i < ListaDeNome.GetLength(0); i++)

                Console.WriteLine(string.Format("Registro ID {0} - Nome:{1} - Idade:{2}", ListaDeNome[i, 0], ListaDeNome[i, 1], ListaDeNome[i, 2]));

        }
        public static void AumentaTamanhoDaLista (ref string[,] ListaDeNome)
        {
            var LimiteDaLista = true;

            for (int i = 0; i < ListaDeNome.GetLength(0); i++)
            {
                if (ListaDeNome[i, 0] == null)
                    LimiteDaLista = false;
            }

            if (LimiteDaLista)
            {
                var ListaCopia = ListaDeNome;

                ListaDeNome = new string[ListaDeNome.GetLength(0) + 5, 3];

                for (int i = 0; i < ListaCopia.GetLength(0); i++)
                {
                    ListaDeNome[i, 0] = ListaCopia[i, 0];
                    ListaDeNome[i, 1] = ListaCopia[i, 1];
                    ListaDeNome[i, 2] = ListaCopia[i, 2];
                }

                Console.WriteLine("O tamanho da lista foi atualizado");
            }

        }

    }
}
