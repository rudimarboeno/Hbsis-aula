using criação__de_lista.CarregarLista;
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
            var listaBi = new ListaBi();

            listaBi.MostraLista();

            listaBi.LimpaLista();

            listaBi.CarregandoListaBi(10);

            listaBi.CarregaLista();

            listaBi.MostraLista();

            Console.ReadKey();
         
        }
    }
}
