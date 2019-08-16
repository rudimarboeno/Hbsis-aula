using MinhaPrimeiraListaTipada.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaPrimeiraListaTipada
{
    class Program
    {
        static void Main(string[] args)
        {
           

            //O indicador <T> o tipo da minha lista com isso temos uma lista de lanches
            List<Lanche> minhaLista = new List<Lanche>();
            //Adiciono na minha lista um pão de queijo

            for (int i = 0; i < 2; i++)
            {
                minhaLista.Add(new Lanche()
                {
                    Nome = RetornaValores("Nome"),
                    Quatidade = int.Parse(RetornaValores("Quantidade")),
                    Valor = double.Parse(RetornaValores("Valor"))
                });
            }

            
            minhaLista.Add(new Lanche()
            {
                Nome = "x - Infarto",
                Quatidade = 1,
                Valor = 17.50

            });
            //Aqui ando pela minha lista para poder apresentar em tela os valores
            //item in significa que ele já e um indice da minha lista bonitinho
            foreach (var item in minhaLista)
                Console.WriteLine($"Lanche disponiveis: {item.Nome} || Quantidade:{item.Quatidade} || valor:{item.Valor}");

            Console.WriteLine("Removendo item");

            foreach (Lanche item in minhaLista)
            {
                if (item.Quatidade == 1)
                {
                    minhaLista.Remove(item);
                    break;
                }
                    
            }
   
            foreach (var item in minhaLista)
                Console.WriteLine($"Lanche disponiveis: {item.Nome}");


            Console.ReadKey();
        }
        /// <summary>
        /// Metodo que mostra uma interface legal para adicionar os valores
        /// </summary>
        /// <param name="nome">Nome do campo que ira retornar o valor</param>
        /// <returns>Retorna uma string com o valor</returns>
        public static string RetornaValores(string nome)
        {
            Console.WriteLine($"Informe o valor para o campo: {nome}");
            return Console.ReadLine();
        }
    }
}
