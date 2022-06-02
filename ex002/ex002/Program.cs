using System;
using System.Globalization;


namespace ex002
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("\t\t\tEX02 - QUEM TEM MAIOR SALARIO\n\n");

            Funcionario funcionario1, funcionario2;

            funcionario1 = new Funcionario();
            funcionario2 = new Funcionario();


            Console.Write("DIGITE O NOME DO FUNCIONARIO1: ");
            funcionario1.nome = Console.ReadLine();
            Console.Write("DIGITE O SALARIO DO FUNCIONARIO1: ");
            funcionario1.salario = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("\n\n");

            Console.Write("DIGITE O NOME DO FUNCIONARIO2: ");
            funcionario2.nome = Console.ReadLine();
            Console.Write("DIGITE O SALARIO DO FUNCIONARIO2: ");
            funcionario2.salario = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("\n\n");

            float media = ((funcionario1.salario + funcionario2.salario) / 2);
            Console.Write($"SALARIO MEDIO = R${media.ToString("F2")}\n\n\n");

        }
    }
}
