using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaBiSuperCompacta.BibliotecaListaBi
{
    class ListaBi
    {

        string[,] listaBi;

        /// <summary>
        /// Iniciamos nossa lista bi, agora quandi iniciamos um istancia dela ela ja vem com a lista carregada
        /// </summary>
        public ListaBi()
        {
            listaBi = new string[5, 2];
            //Ao chamar este metodo no contrutor nossa lista ja vai estar carregada
            //ao iniciar a istancia "jogar para memoria"
            CarregaListaBi();
        }

        public void CarregaListaBi()
        {
            for (int i = 0; i < listaBi.GetLength(0); i++)
            {
                listaBi[i, 0] = i.ToString();
                listaBi[i, 1] = $"Bislau_{i}";
                //Ao adicionar o registro na lista ja mostramos na tela 
                Console.WriteLine($"Id:{i} Nome:Bislau_{i}");
            }
        }
        /// <summary>
        /// Aqui temos o metodo que realiza a pesquisa das informações em nossa
        /// lista
        /// </summary>
        /// <param name="idPesquisa">Aqui vai o id da nossa informação</param>
        public void PesquisaLista(string idPesquisa)
        {
            for (int i = 0; i < listaBi.GetLength(0); i++)
            {
                if(listaBi[i,0] == idPesquisa)
                {
                    Console.WriteLine("Resultado encontrado com sucesso!");
                    Console.WriteLine($"Você pesquisou pelo registro:{listaBi[i,1]}");

                    return;
                }
                Console.WriteLine("Nenhum registro encontrado com esse id");
            }
        }
    }
}
