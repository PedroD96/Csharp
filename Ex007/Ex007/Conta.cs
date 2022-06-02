using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Ex007
{
    class Conta
    {

        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }



        public ContaBancaria(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;             
        }

        public ContaBancaria(int numero, string titular, double saldo) : this(numero, titular)
        {
            Saldo = saldo;
        }

        public override string ToString()
        {
            return "Conta "
                 + Numero
                 + ", Titular: "
                 + Titular
                 + ", Saldo: $"
                 + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }


    }
}
