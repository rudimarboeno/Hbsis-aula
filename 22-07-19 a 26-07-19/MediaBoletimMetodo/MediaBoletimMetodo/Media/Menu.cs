using MediaBoletimMetodo.Media;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBoletimMetodo.Media
{
   public class Menu
    {
        string[,] BasedeDados = new string[5,5];

        int IndiceBaseDeDados = 0;
       

        public void Inserir()
        {
            MediaCalculos Boletim = new MediaCalculos();

            for (int i = 0; i < BasedeDados.GetLength(0); i++)
            {

                Console.WriteLine("Informe o nome do aluno");
                var nome = Console.ReadLine();
                BasedeDados[i, 1] = nome;

                Console.WriteLine("Informe a primeira nota");
                int.TryParse(Console.ReadLine(), out int nota01);

                Console.WriteLine("Informe a segunda nota");
                int.TryParse(Console.ReadLine(), out int nota02);

                Console.WriteLine("Informe a terceira nota");
                int.TryParse(Console.ReadLine(), out int nota03);

                var media = Boletim.medias(nota01, nota02, nota03);
                BasedeDados[i, 2] = media.ToString();

                Console.WriteLine("Informe o numero de aulas");
                int.TryParse(Console.ReadLine(), out int totalAulas);

                Console.WriteLine("Informe o numero de Faltas");
                int.TryParse(Console.ReadLine(), out int numeroFaltas);

                var Frenquenci = Boletim.frequencia(totalAulas, numeroFaltas);
                BasedeDados[i, 3] = Frenquenci.ToString();

                
                    BasedeDados[i, 0] = (IndiceBaseDeDados++).ToString();
                    BasedeDados[i, 1] = nome;
                    BasedeDados[i, 2] = media.ToString();
                    BasedeDados[i, 3] = Frenquenci.ToString();
                    BasedeDados[i, 4] = Boletim.Retornasituacao(media,Frenquenci);         
               
            }

                
        }
        
        public void MostraLista(string MostrarRegistroNativos = "false")
        {
            Console.WriteLine("Apresentação das informações dentro da base de dados");

            for (int i = 0; i < BasedeDados.GetLength(0); i++)
            {
                if(BasedeDados[i, 4] != MostrarRegistroNativos)
                Console.WriteLine($"ID: {BasedeDados[i,0]} || " +
                                  $"Nome do aluno: {BasedeDados[i, 1]} || " +
                                  $"Media: {BasedeDados[i, 2]} || " +
                                  $"Frequencia: {BasedeDados[i, 3]}%");
            }

            Console.WriteLine("");
            Console.WriteLine("Resultado apresentado  com sucesso");
            Console.WriteLine("");
            Console.WriteLine("Para voltar ao menu inicial aperte qual que botão");
            Console.WriteLine("");
            Console.ReadKey();
        }

        public void RemoverInformacoes()
        {
            Console.WriteLine("");
            Console.WriteLine("Area de romoção de registro do sistema");
            Console.WriteLine("");

            for (int i = 0; i < BasedeDados.GetLength(0); i++)
            {
                if (BasedeDados[i, 4] != "false")
                    Console.WriteLine($"ID: {BasedeDados[i, 0]} ||"  +
                            $" - Nome do aluno: {BasedeDados[i, 1]} ||" +
                            $" - Media: {BasedeDados[i, 2]} ||" +
                            $" - Frequencia: {BasedeDados[i,3]}");
            }

            Console.WriteLine("Informe o Id a ser removido:");
            Console.WriteLine("");

            var id = Console.ReadLine();

            for (int i = 0; i < BasedeDados.GetLength(0); i++)
            {
                if(BasedeDados[i, 0] != null && BasedeDados[i,0] == id)
                {
                    BasedeDados[i, 1] = "";
                    BasedeDados[i, 2] = "";
                    BasedeDados[i, 3] = "";
                    BasedeDados[i, 4] = "";
                }
            }

            Console.WriteLine("");
            Console.WriteLine("Operação finalizada");
            Console.WriteLine("");
            Console.WriteLine("Para retornar ao menu inicial aperte qualquer tecla.");
            Console.WriteLine("");
            Console.ReadKey();
        }
    }
}
