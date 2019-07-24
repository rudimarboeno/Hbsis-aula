﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaBiManeiraSimplesComClass.Carrega
{
    class CarregarLista
    {
        

        String[,] listaDeNome;

        /// <summary>
        /// Retorna a lista de nome apenas como leitura ou olhar
        /// </summary>
        public string[,] ListaNome { get { return listaDeNome; } }


        /// <summary>
        /// Nosso metodo contrutor que sempre recebe o nome da classe
        /// </summary>
        /// <param name="arrayBi">Array que já deve estar assinada</param>
        public CarregarLista()
        {
            //Assinamos nossa lista no metodo contrutor
            //com isso já deixamos a lista pronta para uso nos demais metodos
            //sem precisar de um parametro para isso
            listaDeNome = new string[5, 2];

        }
        /// <summary>
        /// Metodo que carrega as informações dentro da nossa lista criada no metodo "MAIN"
        /// E mostra as informações logo em seguida
        /// </summary>
        /// <param name="arrayBi">Nossa lista a ser carregada</param>
        public void CarregaInformacoesElistaEmTela()
        {
            //Usando um laço simples para colocar valores mas no mesmo agora utilizando o 
            //GetLength com o parametro "0" para indicar que queremos o tamanho da primeira coluna
            for (int i = 0; i < listaDeNome.GetLength(0); i++)
            {
                //Carregando o que podemos chamar de ID, identidicador do nosso registro unico
                listaDeNome[i, 0] = i.ToString();
                //Aqui apenas idicionamos uma informação extra para deixar legal
                listaDeNome[i, 1] = $"Felipe_{i}";
            }

            //Lembrando que GetLength é um metodo e usamos "(parametro)" com parametro ou as vezes sem
            //para realizar a chamada do mesmo
            for (int i = 0; i < listaDeNome.GetLength(0); i++)
            {
                //Formatos uma string de maneira que os dados sejam apresentados
                Console.WriteLine($"ID:{listaDeNome[i, 0]} - Nome:{listaDeNome[i, 1]}");

            }
        }
    }
}
