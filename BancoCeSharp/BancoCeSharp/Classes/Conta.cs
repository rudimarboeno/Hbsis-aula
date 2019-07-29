using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoCeSharp.Classes
{
    class Conta
    {
        double saldo = 0;
        //Propriedade que contem o valor do saldo
        public double Saldo { get { return saldo; } }

        public Conta()
        {
            //Bonus de mil reais para iniciar operar daytrade
            saldo = 1000;
        }
     /// <summary>
     /// Metodo para sacar de acordo com saldo disponivel
     /// </summary>
     /// <param name="valor">Valor para sacar</param>
     /// <returns>Retorna se o saque foi feito ou não</returns>
        public bool Sacar(double valor)
        {
            if(valor <= saldo)
            {//Desconta do valor em saldo na conta
                saldo -= valor;
                return true;
            }
            //retorna false em caso de não conter saldo disponivel
            return false;
        }
        /// <summary>
        /// Metodo para mostrar o saldo em conta disponivel
        /// </summary>
        public double MostrarSaldo()
        {
            return saldo;
        }
    }
}
