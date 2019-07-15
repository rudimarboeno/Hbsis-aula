﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaBideManeirasSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criando nossa lista com mais de uma dimensão
            String[,] listaDeNome = new string[5, 2];

            //Aqui como estamos usando apenas uma referencia da nossa lista colocamos ref ao passar ela no metodo
            CarregaInformacoesElistaEmTela(ref listaDeNome);


        }
        /// <summary>
        /// Metodo que carrega as informações dentro da nossa lista criada no metodo "MAIN"
        /// E mostra as informações logo em seguida
        /// </summary>
        /// <param name="arrayBi">Nossa lista a ser carregada</param>
        public static void CarregaInformacoesElistaEmTela(ref string[,] arrayBi)
        {
            //Usando um laço simples para colocar valores mas no mesmo agora utilizando o 
            //GetLength com o parametro "0" para indicar que queremos o tamanho da primeira coluna
            for (int i = 0; i < arrayBi.GetLength(0); i++)
            {
                //Carregando o que podemos chamar de ID, identidicador do nosso registro unico
                arrayBi[i, 0] = i.ToString();
                //Aqui apenas idicionamos uma informação extra para deixar legal
                arrayBi[i, 1] = $"Felipe_{i}";
            }

            //Lembrando que GetLength é um metodo e usamos "(parametro)" com parametro ou as vezes sem
            //para realizar a chamada do mesmo
            for (int i = 0; i < arrayBi.GetLength(0); i++)
            {
                //Formatos uma string de maneira que os dados sejam apresentados
                Console.WriteLine($"ID:{arrayBi[i, 0]} - Nome:{arrayBi[i, 1]}");

            }
        }

        public static void PesquisandoInformacoesNaNossaLista(ref string[,] arrayBi,string pID)
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
