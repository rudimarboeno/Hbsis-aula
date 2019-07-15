using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertAndRemoveInList
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criamos a nossa base de dados inicial
            string[,] baseDeDados = new string[2, 3];
            //Indicador dos registro que realizamos em nosso sistema
            int IndiceBaseDeDados = 0;
            //Apresentação inicial do nosso sistema
            Console.WriteLine("Iniciando sistema de lista de nome e idade.");
            //Criamos a variavel fora para não ser criada novamente
            var escolhaInicial = ApresentaçãoMenuInicial();
            //loop infinito ate que de uma treta
            while (true)
            {
                //Iniciando a escolha do nosso menu
                switch(escolhaInicial)
                {
                    //1-Insere as informações
                    case "1": { InseriValoresNaLista(ref baseDeDados,ref IndiceBaseDeDados); }break;
                    //1-Remove informações da nossa lista
                    case "2": {  } break;
                    //Lista as informações da lista
                    case "3": { MostraInformacoes(baseDeDados); } break;
                     //Sai do nosso sistema
                    case "4": {
                            //Return dentro do nosso caso de escolha ele sai do nosso meto principal ou
                            //metodo que estamos dentro de contexto
                            return;}
                    
                }
                //Alimento a escolha novamente
                escolhaInicial = ApresentaçãoMenuInicial();
            }
        }
        /// <summary>
        /// Apresenta as informações do meu inicial
        /// </summary>
        /// <returns>Retorno o menu escolhido</returns>
        public static string ApresentaçãoMenuInicial()
        {
            //Entrou no menu inicial inicializa 
            Console.Clear();
            Console.WriteLine("Menu");
            Console.WriteLine("1- Inserir um novo registro");
            Console.WriteLine("2- Remover um novo registro");
            Console.WriteLine("3- Listar informações");
            Console.WriteLine("4- Sair do nosso sistema");

            Console.WriteLine("Digite o número da opção desejada:");
            //retorno diretamente o menu escolhido.
            return Console.ReadLine();
        }
        /// <summary>
        /// Metodo que insere informações dentro da nossa base de dados
        /// </summary>
        /// <param name="baseDeDados">Base de dados como ref para alterar para todos os metodos</param>
        /// <param name="IndiceBase">Indice da nossa base como red para alterar para todos os metodos</param>
        public static void InseriValoresNaLista(ref string[,] baseDeDados, ref int IndiceBase)
        {
            Console.WriteLine("---------Inserido valores na lista----------");
            Console.WriteLine("");

            Console.WriteLine("Informe um nome:");
            //Aqui pegamos o nome da pessoa digitada pelo usuario do sistema
            var nome = Console.ReadLine();

            Console.WriteLine("Informe a idade");
            //Aqui pegamos a idade da pessoa digitada pelo usuario do sistema
            var idade = Console.ReadLine();

            //Iniciamos o laço de repetição oara varrer nossa base de dados
            for (int i = 0; i < baseDeDados.GetLength(0); i++)
            {
                if (baseDeDados[i, 0] != null)
                    continue;
                //Indentificamos a maneira unica nosso registro "("e")" garante que ele incremente primeiro
                //antes de fazer a conversão para string
                baseDeDados[i, 0] = (IndiceBase++).ToString();
                //Carregando na segunda coluna o valor nome
                baseDeDados[i, 1] = nome;
                //Carregando na terceira coluna o valor da idade
                baseDeDados[i, 2] = idade;
                //Finalizamos aqui para apenas inserir um registro por vez
                break;
            }
            Console.WriteLine("");
            Console.WriteLine("Registro cadastrado com secesso!");
            Console.WriteLine("");
            Console.WriteLine("Para voltar ao menu inicial, basta apertar qualquer tecla.");
            Console.ReadKey();
        }
        /// <summary>
        /// Mostra as informações dentro da nossa lista de dados"base de dados"
        /// </summary>
        /// <param name="baseDeDados">base de dados para a leitura e mostrar pro usuario</param>
        public static void MostraInformacoes(string[,] baseDeDados)
        {

            Console.WriteLine("Apresentação das informações dentro da base de dados.");

            for (int i = 0; i < baseDeDados.GetLength(0); i++)
            Console.WriteLine($"ID {baseDeDados[i,0]}" +
                $"- Nome:{baseDeDados[i, 1]} " +
                $"- idade:{baseDeDados[i, 2]} ");

            Console.WriteLine("");
            Console.WriteLine("Resultado apresentados com sucesso!");
            Console.WriteLine("");
            Console.WriteLine("Para voltar ao menu inicial informar qualquer tecla.");
            Console.WriteLine("");
            Console.ReadKey();

        }
        /// <summary>
        /// Metodo utilizado para remover um registro pelo id dentro do sistema
        /// </summary>
        /// <param name="baseDeDados">Base de dados em que ele irá remover o registro pelo id</param>
        public static void RemoverInformacoes(ref string[,] baseDeDados)
        {
            Console.WriteLine("Area de remoção de registrp do sistema.");

            for (int i = 0; i < baseDeDados.GetLength(0); i++)
                Console.WriteLine($"ID:{baseDeDados[i, 0]} " +
                    $"- Nome:{baseDeDados[i, 1]}" +
                    $"- Idade:{baseDeDados[i, 2]}");

                Console.WriteLine("Informe o id  do registro a ser removido:");
                var id = Console.ReadLine();

            for (int i = 0; i < baseDeDados.GetLength(0); i++)
            {

                if (baseDeDados[i, 0] != null && baseDeDados[i, 0] == id)
                {
                    baseDeDados[i, 0] = null;
                    baseDeDados[i, 1] = null;
                    baseDeDados[i, 2] = null;
                }
            }
                Console.WriteLine("");
                Console.WriteLine("Operações finalizadas.");
                Console.WriteLine("");
                Console.WriteLine("Para retornar ao menu inicial apertar qualque tecla.");
                Console.ReadKey();
        }
        public static void AumentaTamanhoLista(ref string[,] baseDeDados)
        {
            var limiteDaLista = true;

            for (int i = 0; i < baseDeDados.GetLength(0); i++)
            {
                if (baseDeDados[i, 0] == null)
                    limiteDaLista = false; 
            }
        }
    }
}

