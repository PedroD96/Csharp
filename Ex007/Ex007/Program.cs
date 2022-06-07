using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Ex007
{
     class Program
    {
        static void Main(string[] args)
        {
            Conta conta;

            Console.Write("Entre o número da conta: ");
            //Numero da conta
            int numero = int.Parse(Console.ReadLine());


            Console.Write("Entre o titular da conta: ");
            //Nome do usuario da conta
            string titular = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");
            //Se haverá deposito inicial
            char op = char.Parse(Console.ReadLine());
            if (op == 's')
            {
                Console.Write("Entre o valor de depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                conta = new Conta(numero, titular, depositoInicial);

                Console.WriteLine("\nDados da conta: " + conta);
            }
            else
            {
                conta = new Conta(numero, titular);
                Console.WriteLine("\nDados da conta: " + conta);

                //to.string --> dados da conta
            }


            Console.Write("\nEntre um valor para depósito: ");

            double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(deposito);
            //to.string --> dados da conta
            Console.WriteLine("\nDados da conta atualizados: " + conta);




            Console.Write("\nEntre um valor para saque: ");

            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(saque);
            //to.string --> dados da conta + -R$5,00
            Console.WriteLine("\nDados da conta atualizados: " + conta);
        }
    }
}
