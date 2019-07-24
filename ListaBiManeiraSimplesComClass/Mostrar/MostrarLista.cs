using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaBiManeiraSimplesComClass.Mostrar
{
    class MostrarLista
    {
        /// <summary>
        /// Metodo que realiza a pesquisa pelo indentificador unico de nossa coleção
        /// </summary>
        /// <param name="arrayBi">Nossa coleção de informação</param>
        /// <param name="pID">Nosso indentificador unico</param>
        public void PesquisandoInformacoesNaNossaLista(string[,] arrayBi, string pID)
        {
            for (int i = 0; i < arrayBi.GetLength(0); i++)
            {
                //Realizamos nossa comparação dos mesmo tipos
                if (arrayBi[i, 0] == pID)
                {//Mostramos as informações formatadas da nossa pesquisa
                    Console.WriteLine($"Informação escolhida: ID:{arrayBi[i, 0]} - Nome:{arrayBi[i, 1]}");
                    //Aqui saimos da nossa lista mas retornamos vazio "return;" pois estamos em um metodo
                    //vazio "void" que não espera retornar algo.
                    return;
                }
            }
            //Caso ele passe por esta linha identificamos que ele não encontrou resultados compativeis.
            Console.WriteLine("Infelizmente a busca pelo id não resultou em nenhuma informação");
        }
    }
}
