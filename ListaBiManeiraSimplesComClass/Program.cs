using ListaBiManeiraSimplesComClass.Carrega;
using ListaBiManeiraSimplesComClass.Mostrar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaBiManeiraSimplesComClass
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Aqui iniciamos nosso objeto em memor
            var Nicholas = new CarregarLista();
            //Aqui chamamos o nosso metodo para carregar lista
            Nicholas.CarregaInformacoesElistaEmTela();

            var FelipeBlindao = new MostrarLista();

            FelipeBlindao.PesquisandoInformacoesNaNossaLista(Nicholas.ListaNome, "0");

            Console.ReadKey();
        }
    }
}
