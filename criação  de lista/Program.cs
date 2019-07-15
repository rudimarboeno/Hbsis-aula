using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace criação__de_lista
{
    class Program
    {
        static void Main(string[] args)
        {
            //Iniciando uma lista de string com array linear
            string[] lista = new string[10];//arui é definimos as posições de lista iniciando ela com 10
            //espaços na memoria para alocar informações de texto

            for (int i = 0; i < lista.Length; i++)
            {
                //carregando os valores da nossa lista aqui
                //aonde "i" representa cada espaço que temos disponivel
                lista[i] = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss.fff");
                //DateTime é um tipo do .net c# que disponibiliza funções relacionadas a datas
                //e horas, ou seja se precisar trabalhar com essas informações é possivel usar esse cara.
            }
            //laço de petição que usamos para varrer nossa lista de maneira mais simples
            foreach (var item in lista)//"var intem" indica uma unidade da nossa lista "in lista"
                //indica a lista que desejamos varrer
                Console.WriteLine(item);//Aqui apresentamos essa informação na tela

            Console.ReadKey();

            for (int i = 0; i < lista.Length; i++)
                lista[i] = string.Empty;//aqui limpamos o nosso valor dentro da coleção

            foreach (var item in lista)//"var intem" indica uma unidade da nossa lista "in lista"
                //indica a lista que desejamos varrer
                Console.WriteLine(item);//Aqui apresentamos essa informação na tela

            Console.ReadKey();
        }
    }
}
