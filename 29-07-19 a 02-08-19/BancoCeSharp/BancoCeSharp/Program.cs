﻿using BancoCeSharp.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoCeSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta accountUser = new Conta();

            Console.WriteLine("Informe o valor para saque:");
            //Aaqui usamos a conversão da valor informado
            double.TryParse(Console.ReadLine(), out double valorSacar);
            //Verificamos se o valor é maior que 0 e se realizou o saque
            if(valorSacar > 0 && accountUser.Sacar(valorSacar))
                    Console.WriteLine("Saque realizado com sucesso!");
            else
                    Console.WriteLine("Operação não realizada");
            //Mostramos o saldo disponivel
            Console.WriteLine($"Saldo atual disponivel:{accountUser.Saldo.ToString("N2")}");

            Console.ReadKey();
        }
    }
}
