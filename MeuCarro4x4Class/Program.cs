﻿using MeuCarro4x4Class.MyFirstClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuCarro4x4Class
{
    class Program
    {
        static void Main(string[] args)
        {
            var teste = new Carro();

            teste.Rodas = 5;

            teste.janela = 5;

            teste.MostrarCarro();

            Console.ReadKey();
        }
    }
}
