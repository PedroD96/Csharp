using System;
using System.Globalization;

namespace Ex007
{
    class Program2
    {
        static void Main(string[] args)
        {
            Conta2 c = new Conta2();
            Console.Write("Entre o número da conta: ");

            //Numero da conta
            c.NConta = Console.ReadLine();

            Console.Write("Entre o titular da conta: ");

            //Nome do usuario da conta
            c.Nome = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");

            //Se haverá deposito inicial
            char op = char.Parse(Console.ReadLine());

            double valor;
            if( op == 's')
            {
                Console.Write("Entre o valor de depósito inicial: ");
                valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                c.Deposito(valor);
                Console.WriteLine("\nDados da conta: " + c.ToString());
            }
            else 
            {
                Console.WriteLine("\nDados da conta: " + c.ToString());

                //to.string --> dados da conta
            }


            Console.Write("\nEntre um valor para depósito: ");
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c.Deposito(valor);
            //to.string --> dados da conta
            Console.WriteLine("\nDados da conta atualizados: " + c.ToString());

            


            Console.Write("\nEntre um valor para saque: ");
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c.Sacar(valor);

            //to.string --> dados da conta + -R$5,00
            Console.WriteLine("\nDados da conta atualizados: " + c.ToString());

        }
    }
}
