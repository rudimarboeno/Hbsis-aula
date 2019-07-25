using BibliotecaDeArquivosDoWindows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlibliotecaComDll
{
    class Program
    {
        static void Main(string[] args)
        {
            var teste = new GetFiles();

            var Arquivo = teste.RetornaArquivosDoMeuDocumentos();
            var Imagens = teste.RetornaArquivosImagesFiles();
            var Git = teste.RetornaArquivosGit();
    
            for (int i = 0; i < Arquivo.Length; i++)
            {
                Console.WriteLine(Arquivo[i]);
                Console.ReadKey();
            }
            

            for (int i = 0; i < Imagens.Length; i++)
            {
                Console.WriteLine(Imagens[i]);
                Console.ReadKey();
            }

            for (int i = 0; i < Git.Length; i++)
            {
                Console.WriteLine(Git[i]);
                Console.ReadKey();
            }
            
        }
    }
}
