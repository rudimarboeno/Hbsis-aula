using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cantina.Classes
{
    class Conta
    {
        double saldo = 0;

        public double Saldo { get { return saldo; } }

        public Conta()
        {
          
            saldo = 20;
        }

        public bool comprar(double valor)
        {
            if(valor <= saldo)
            {
                saldo -= valor;
                return true;
            }
            return false;
        }
        public double MostrarSaldo()
        {
            return saldo;
        }
    }
}
