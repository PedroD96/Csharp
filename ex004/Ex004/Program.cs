using System;
using System.Globalization;

namespace Ex004
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario f = new Funcionario();
            Console.Write("NOME: ");
            f.Nome = Console.ReadLine();

            Console.Write("SALARIO BRUTO: ");
            f.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("IMPOSTO: ");
            f.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(f.ToString());

            Console.Write("\n\nDIGITE A PORCENTAGEM PARA AUMENTAR O SALARIO: ");
            double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            f.AumentarSalario(porcentagem);

            Console.WriteLine(f.ToString());

        }
    }
}
