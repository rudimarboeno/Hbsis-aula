using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinalConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] BaseDeDados = new string[2, 5];

            int IndiceBaseDeDados = 0;

            var EscolhaInicial = ApresentaMenuInicial();

            while (true)
            {
                switch(EscolhaInicial)
                {
                    case "1": { InserirValoresNaLista(ref BaseDeDados,ref IndiceBaseDeDados); } break;

                    case "2": { RemoverInformacoes(ref BaseDeDados); } break;

                    case "3": { MostraInformacoes(BaseDeDados); } break;

                    case "4": { MostraInformacoes(BaseDeDados, "true"); } break;

                    case "5": { return; }
                }

                EscolhaInicial = ApresentaMenuInicial();
            }
        }
        /// <summary>
        /// Metodo que chama o menu inicial o seja bem vindo
        /// </summary>
        /// <returns></returns>
        public static string ApresentaMenuInicial()
        {
            Console.Clear();
            Console.WriteLine("                                     \\\\////\\\\////\\\\////\\\\////\\\\////\\\\////");
            Console.WriteLine("                                     ////\\\\Bem Vindo ao texas book/////\\\\");
            Console.WriteLine("                                     \\\\////\\\\////\\\\////\\\\////\\\\////\\\\////");
            Console.WriteLine("");
            Console.WriteLine("Menu Inicial:");
            Console.WriteLine("");
            Console.WriteLine("1 - Inserir um novo registro:");
            Console.WriteLine("2-  Remover um novo registro:");
            Console.WriteLine("3-  Listar informações:");
            Console.WriteLine("4-  Listar informações desativadas:");
            Console.WriteLine("5-  Sair do sistema:");
            Console.WriteLine("");
            Console.WriteLine("Digite  o número da opção desejada:");
            Console.WriteLine("");


            return Console.ReadLine();
        }
        /// <summary>
        /// Metodo que insere informações dentro da nossa base de dados
        /// </summary>
        /// <param name="BaseDeDados">Base de dados como ref para alterar para todos os metoodos</param>
        /// <param name="IndiceBaseDeDados">Indice da nossa base como red para alterar para todos os metodos</param>
        public static void InserirValoresNaLista(ref string[,] BaseDeDados, ref int IndiceBaseDeDados)
        {
            Console.WriteLine("---------------Inserido valores na lista-----------");
            Console.WriteLine("");

            Console.WriteLine("Informe o nome do livro:");
            var NomeLivro = Console.ReadLine();

            Console.WriteLine("Informe o nome do autor:");
            var NomeAutor = Console.ReadLine();

            AumentaTamanhoDaLista(ref BaseDeDados);

            for (int i = 0; i < BaseDeDados.GetLength(0); i++)
            {
                if (BaseDeDados[i, 0] != null)
                    continue;

                BaseDeDados[i, 0] = (IndiceBaseDeDados++).ToString();
                BaseDeDados[i, 1] = NomeLivro;
                BaseDeDados[i, 2] = NomeAutor;
                BaseDeDados[i, 3] = "true";
                BaseDeDados[i, 4] = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                break;
            }
            Console.WriteLine("");
            Console.WriteLine("Registro Cadastrado com sucesso!");
            Console.WriteLine("");
            Console.WriteLine("Para voltar ao menu inicial, basta apertar qualquer tecla:");
            Console.WriteLine("");
            Console.ReadKey();
        }
        /// <summary>
        /// Metodo que mostra as informações da nossa lista de dados"base de dados"
        /// </summary>
        /// <param name="BaseDeDados">Base de dados para a leitura e mostrar pro usuario</param>
        /// <param name="MostraRegistroNAtivos">Quando identificado com valor true, o mesmo mostra os valores que não
        /// estão ativos dentro do sistema</param>
        public static void MostraInformacoes(string[,] BaseDeDados, string MostraRegistroNAtivos = "false")
        {
            Console.WriteLine("Apresentação das informações dentro da base de dados.");

            if (MostraRegistroNAtivos == "true")
                Console.WriteLine("Lista de registros desativados no nosso sistema:");
                Console.WriteLine("");

            for (int i = 0; i < BaseDeDados.GetLength(0); i++)
            {
                if (BaseDeDados[i, 3] != MostraRegistroNAtivos)
                    Console.WriteLine($"ID: {BaseDeDados[i, 0]}" +
                           $" - Nome livro:{BaseDeDados[i, 1]}" +
                           $" - Nome autor:{BaseDeDados[i, 2]}" +
                           $" - Data de Alteração:{BaseDeDados[i, 4]}");
            }
            Console.WriteLine("");
            Console.WriteLine("Resultado apresentado com sucesso!");
            Console.WriteLine("");
            Console.WriteLine("Para voltar ao menu inicial informar qualquer tecla.");
            Console.WriteLine("");
            Console.ReadKey();
        }
        /// <summary>
        /// Metodo utilizado para remover um registro pelo id dentro do sistema
        /// </summary>
        /// <param name="BaseDeDados">Base de dados em que ele irá remover o registro pelo id</param>
        public static void RemoverInformacoes(ref string[,] BaseDeDados)
        {
            Console.WriteLine("Area de remoção de registro do sistema");
            Console.WriteLine("");

            for (int i = 0; i < BaseDeDados.GetLength(0); i++)
            {
                if (BaseDeDados[i, 3] != "false")
                    Console.WriteLine($"ID:{BaseDeDados[i, 0]} " +
                            $" - Nome livro:{BaseDeDados[i, 1]}" +
                            $" - Nome autor:{BaseDeDados[i, 2]}");         
            }

            Console.WriteLine("Informe o id a ser removido:");
            Console.WriteLine("");
            var id = Console.ReadLine();

            for (int i = 0; i < BaseDeDados.GetLength(0); i++)
            {
                if(BaseDeDados[i, 0] != null && BaseDeDados[i,0] == id)
                {
                    BaseDeDados[i, 3] = "false";
                    BaseDeDados[i, 4] = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                }
            }
            Console.WriteLine("");
            Console.WriteLine("Operação finalizada");
            Console.WriteLine("");
            Console.WriteLine("Para retornar ao menu inicial apertar qualque tecla.");
            Console.ReadKey();
        }
        /// <summary>
        /// Metodo que aumenta as informações disponivel para cadastro dentro da nossa lista
        /// </summary>
        /// <param name="BaseDeDados">Retorna a nossa base de dados</param>
        public static void AumentaTamanhoDaLista(ref string[,] BaseDeDados)
        {
            var LimiteDaLista = true;

            for (int i = 0; i < BaseDeDados.GetLength(0); i++)
            {
                if (BaseDeDados[i, 0] == null)
                    LimiteDaLista = false;
            }

            if(LimiteDaLista)
            {
                var ListaCopia = BaseDeDados;

                BaseDeDados = new string[BaseDeDados.GetLength(0) + 5, 5];

                for (int i = 0; i < ListaCopia.GetLength(0); i++)
                {
                    BaseDeDados[i, 0] = ListaCopia[i, 0];
                    BaseDeDados[i, 1] = ListaCopia[i, 1];
                    BaseDeDados[i, 2] = ListaCopia[i, 2];
                    BaseDeDados[i, 3] = ListaCopia[i, 3];
                    BaseDeDados[i, 4] = ListaCopia[i, 4];
                }

                Console.WriteLine("O tamanho da lista foi atulizado.");
                Console.WriteLine("");
            }
 
        }
    }
}
