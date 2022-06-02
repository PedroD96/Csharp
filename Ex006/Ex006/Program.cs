using System;
using System.Globalization;

namespace Ex006
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("QUAL E A COTACAO DO DOLAR? ");
            double dolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("QUANTOS DOLARES VOCÊ CAI COMPRAR? ");
            double qtdDolares = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double valorTotal = ConversorDeMoeda.ValorAPagar(dolar, qtdDolares);

            Console.WriteLine("Valor a ser pago em reais = " + valorTotal.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
