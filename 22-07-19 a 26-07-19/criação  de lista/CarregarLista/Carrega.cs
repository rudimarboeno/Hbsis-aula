using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace criação__de_lista.CarregarLista
{
    class ListaBi
    {
        string[,] listaBi;

        public ListaBi()
        {
            listaBi = new string[5, 2];

            CarregaLista();

            CarregandoListaBi();    
        }
        /// <summary>
        /// Carrega Lista
        /// </summary>
        public void CarregaLista()
        {
            for (int i = 0; i < listaBi.GetLength(0); i++)
            {
                //carregando os valores da nossa lista aqui
                //aonde "i" representa cada espaço que temos disponivel
                listaBi[i ,0] = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss.fff");
                //DateTime é um tipo do .net c# que disponibiliza funções relacionadas a datas
                //e horas, ou seja se precisar trabalhar com essas informações é possivel usar esse cara.
            }
            
        }

        /// <summary>
        /// Laço de repetição
        /// </summary>
        public void CarregandoListaBi()
        {
            //laço de petição que usamos para varrer nossa lista de maneira mais simples
            foreach (var item in listaBi)//"var intem" indica uma unidade da nossa lista "in lista"
                //indica a lista que desejamos varrer
                Console.WriteLine(item);//Aqui apresentamos essa informação na tela

            
        }
        /// <summary>
        /// Limpa a lista
        /// </summary>
        public void LimpaLista()
        {
            for (int i = 0; i < listaBi.GetLength(0); i++)
                listaBi[i,0] = string.Empty;//aqui limpamos o nosso valor dentro da coleção

            Console.ReadKey();

        }

        public void MostraLista()
        {
            foreach (var item in listaBi)//"var intem" indica uma unidade da nossa lista "in lista"
                //indica a lista que desejamos varrer
                Console.WriteLine(item);//Aqui apresentamos essa informação na tela

        }
    }
}
