using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdicionandoValoresEmUmaListaManualmente
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criação de nossa lista o.0
            string[,] listadeNome = new string[10, 2];
            //Aqui vamos criar uma forma externa de identificar nosso registros
            int IdParaLista = 0;
            //Chama no nosso metodo para inserir o registro passado por meio de referencia
            //nosso dois itens, lista de nomes 
            InsereRegistro(ref listadeNome, ref IdParaLista);

             Console.ReadKey();
            InsereRegistro(ref listadeNome, ref IdParaLista);

            Console.ReadKey();
        }
        /// <summary>
        /// Metodo que insere novo registro dentro da nossa lista
        /// </summary>
        /// <param name="listadeNome">Nossa lista de nomes vazia ou mão</param>
        /// <param name="IdParaLista">Nossa referencia extrema </param>
        public static void InsereRegistro(ref String[,] listadeNome, ref int IdParaLista)
        {
            //Aqui estaremos em um laço para informar nosso registros
            for (int i = 0; i < listadeNome.GetLength(0); i++)
            {
                //Aqui definimos que o mesmo deve continuar oara o próximo registro
                //pois esse registro já esta ocupado
                if (listadeNome[i, 0] != null)
                    continue;
                //indicamos que ele deve apenas informar o nome do nosso registro
                Console.WriteLine("\r\nInforma um nome para adicionar um registro");
                var nome = Console.ReadLine();
                //Criamos o nosso identificador unico com um objeto extremo que
                //mesmo após sairmos do nosso laço ainda poderar ser incrementado
                listadeNome[i, 0] = (IdParaLista++).ToString();
                //Aqui colocamos nosso nome na lista
                listadeNome[i, 1] = nome;

                //Indentificamos se o mesmo ainda deseja inserir registro dentro da nossa lista
                Console.WriteLine("Deseja inserir um novo registro? sim(1) ou não(0)");
                //O readkey so espera uma unica tecla e nos terna a tecla que foi acionada e não o valor dela
                //Por isso usamos o KeyChar para pegar esse valor e converter ele em um string para comparação
                var continuar = Console.ReadKey().KeyChar.ToString();
                //Aqui validamos a condição se o mesmo deve ou não continuar a adicionar registro até que a nossa 
                //lista esteja completa de informações
                if (continuar == "0")
                    break;//Break é uma palavra reservada do c# que para, por isso break, todo laço repetição
                //ou sequenciador logico o.0.

                //Terceira camada de deepweb aqui ja.
                AumentaTamanhoLista(ref listadeNome);

            }

            Console.WriteLine("Registro adicionados com sucesso, segue lista de informações adicionadas:");

            //Mas agora a coisa muda,
            for (int i = 0; i < listadeNome.GetLength(0); i++)
                //Utilizamos o string format, basicamente ele faz da mesma forma que o sifrão
                //a diferença entre eles é que este e um cara em grande quantidades
                //acaba sendo mais rápido
                Console.WriteLine(string.Format("Registro ID {0} - Nome:{1}", listadeNome[i, 0], listadeNome[i, 1]));
        }
        public static void AumentaTamanhoLista(ref string[,] listaDeNome)
        {
            //Vereficar se precisa criar uma lista maior
            var limiteDaLista = true;
            //Laço que verefica se exite registro disponive
            for (int i = 0; i < listaDeNome.GetLength(0); i++)
            {
                //Caso ainda existir registro disponivel ele seta nossa variavel "limitedalista" para false
                if (listaDeNome[i, 0] == null)
                    limiteDaLista = false;
            }

            //Caso não tenha mais registro nossa variavel ficou como true então indica que precisamos aumentar nossa lista
            if(limiteDaLista)
            {
                //criamos uma cópia da nossa lista antiga e assinamos novamente com uma lista com mais espaços
                var listaCopia = listaDeNome;
                //Aqui limpamos nossa lista antigas e assinamos novamente com uma lista com mais espaços
                listaDeNome = new string[listaDeNome.GetLength(0) + 5, 2];
                //Agora copiamos os registros da nossa lista antiga e passamos para a nossa nova lista
                for (int i = 0; i < listaCopia.GetLength(0); i++)
                {
                    //copiamos a informação do identificador unico
                    listaDeNome[i, 0] = listaCopia[i, 0];
                    //copiamos a informação do nosso nome
                    listaDeNome[i, 1] = listaCopia[i, 1];
                }
                //indicamos que neste ponto a lista foi atualizada em seu tamanho.
                Console.WriteLine("O tamanho da lista foi atualizado.");
            }
        }

    }
}
