﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBibliotecaOnline
{
    class Program
    {
        static string[,] baseDeLivros;
        static void Main(string[] args)
        {
            CarregaBaseDeDados();
           
            var opcaoMenu = MenuPrincipal();

            while(opcaoMenu !=3)
            {
                if (opcaoMenu == 1)
                    AlocarumLivro(); 

                if (opcaoMenu == 2)
                    DesalocarUmlivro();

                opcaoMenu = MenuPrincipal();
            }

            Console.ReadKey();
        }
        /// <summary>
        /// mostra o leiaute - seja bem vindo
        /// </summary>
        public static void MostrarSejaBemVindo()
        {
            Console.WriteLine("||||||||||||||||||||||||||||||||||||||||||||||||||||");
            Console.WriteLine("       Bem Vindo ao sistema de alocação de livros.  ");
            Console.WriteLine("||||||||||||||||||||||||||||||||||||||||||||||||||||");
            Console.WriteLine("____________________________________________________");
            Console.WriteLine("    Desenvolvido pela empresa texas.solution sistemas");
            Console.WriteLine("____________________________________________________");

        }
        /// <summary>
        /// Metodo que mostra o conteudo do menu e as opções de escolha.
        /// </summary>
        /// <returns>Retorna o valor do menu escolhido em um tipo inteiro</returns>
        public static int MenuPrincipal()
        {
            Console.Clear();
            MostrarSejaBemVindo();

            Console.WriteLine("Menu Inicial");
            Console.WriteLine("O que você deseja realizar?");
            Console.WriteLine("1- Alocar um livro");
            Console.WriteLine("2- Devolver um livro");
            Console.WriteLine("3- Sair do sistema");
            Console.WriteLine("Digite o número desejado:");

            int.TryParse(Console.ReadKey().KeyChar.ToString(), out int opcao);

            return opcao;
        }
        /// <summary>
        /// Metodo que carrega a base de dadaos dentro do sistema.
        /// </summary>
        public static void CarregaBaseDeDados()
        {
            baseDeLivros = new string[2, 2]
            {
                {"O pequeno","sim"},
                {"O grande","não"}
            };
        }
        /// <summary>
        /// Metodo que retorna se um livro pode ser alocado.
        /// </summary>
        /// <param name="nomeLivro">Nome do livro a ser pesquisado</param>
        /// <returns>Retorna verdadeiro em caso o livro estiver para alocação.</returns>
        public static bool? PesquisaLivroParaAlocacao(ref string nomeLivro)
        {
            for (int i = 0; i < baseDeLivros.GetLength(0); i++)
            {
                if (CompararNomes(nomeLivro, baseDeLivros[i, 0]))
                {
                    Console.WriteLine($"O livro:{nomeLivro}" +
                        $" pode ser alocado?:{baseDeLivros[i, 1]}");
                    /* i é a linha e o 1 é a coluna*/
                    return baseDeLivros[i, 1] == "sim";
                }

            }
            Console.WriteLine("Nenhum livro encontrado deseja realizar a busca novamente?");
            Console.WriteLine("Digite o número da opção desejada: sim(1) || não(0)");

            int.TryParse(Console.ReadKey().KeyChar.ToString(),out int opcao);
           
            if (opcao == 1)
            {
                Console.WriteLine("Digite o nome do livro a ser pesquisado:");
                nomeLivro = Console.ReadLine();

                return PesquisaLivroParaAlocacao(ref nomeLivro);//vai acessar a linha 135

            }

            return null;
        }
        /// <summary>
 /// Metodo para alterar a informação do alocação do livro.
 /// </summary>
 /// <param name="nomeLivro">Nome do livro</param>
 /// <param name="alocar">Valor booleano que define se o livro esta ou não disponivel</param>
        public static void AlocarLivro(string nomeLivro,bool alocar)
        {
            for (int i = 0; i < baseDeLivros.GetLength(0); i++)
            {
                if (CompararNomes(nomeLivro, baseDeLivros[i, 0]))
                {
                    baseDeLivros[i, 1] = alocar ? "não" : "sim";
                }
            }

            Console.Clear();
            MostrarSejaBemVindo();
            Console.WriteLine("Livro atualizado com sucesso!");
        }
        /// <summary>
        /// Metodo que carrega o conteudo inicial da aplicação do meu 1
        /// </summary>
        public static void AlocarumLivro()
        {
            MostrarMenuInicialLivros("Alocar um livro");

            var nomedolivro = Console.ReadLine();
            var resultadoPesquisa = PesquisaLivroParaAlocacao(ref nomedolivro);

            if (resultadoPesquisa !=null && resultadoPesquisa == true)
            {
                Console.Clear();
                MostrarSejaBemVindo();
                Console.WriteLine("Você deseja alocar o livro? sim (1) || não (0)");
                                 
                  /*se digitar 1 entra nessa base*/
                AlocarLivro(nomedolivro, Console.ReadKey().KeyChar.ToString() == "1");
                        
                MostrarListaDeLivros();


                Console.ReadKey();
            }
        }
        /// <summary>
        /// Metodo que mostra a lista de livros atualizado
        /// </summary>
        public static void MostrarListaDeLivros()
        {
            Console.WriteLine("Listagem de livros:");

            for (int i = 0; i < baseDeLivros.GetLength(0); i++)
            {
                Console.WriteLine($"Nome: {baseDeLivros[i, 0]} Disponivel:{baseDeLivros[i, 1]}");
            }

        }
        public static void DesalocarUmlivro()
        {
            MostrarMenuInicialLivros("Desalocar o livro");

            MostrarListaDeLivros();

            var nomedolivro = Console.ReadLine();
            var resultadoPesquisa = PesquisaLivroParaAlocacao(ref nomedolivro);

            if (resultadoPesquisa != null && resultadoPesquisa == false)
            {
                Console.Clear();
                MostrarSejaBemVindo();
                Console.WriteLine("Você deseja desalocar o livro? sim (1) || não (0)");

                /*se digitar 1 entra nessa base*/
                AlocarLivro(nomedolivro, Console.ReadKey().KeyChar.ToString() == "0");

                MostrarListaDeLivros();


                Console.ReadKey();
            }
        }
        public static void MostrarMenuInicialLivros(string operacao)
        {
            Console.Clear();

            MostrarSejaBemVindo();

            Console.WriteLine($"Menu - {operacao}");
            Console.WriteLine("Digite o nome do livro a ser alocado:");
        }
        /// <summary>
        /// Metodo que compara duas string deixando em caixa e remova aspaço vazios dentro da mesma.
        /// </summary>
        /// <param name="primeiro">Primeira string a ser comparada.</param>
        /// <param name="segundo">Segunda string a ser compaarada.</param>
        /// <returns>Retorna resultado Verdadeiro ou falso</returns>
        public static bool CompararNomes(string primeiro, string segundo)
        {
            if (primeiro.ToLower().Replace(" ", "")
                  == segundo.ToLower().Replace(" ", ""))
                return true;

            return false;
            
        }
    }
}
