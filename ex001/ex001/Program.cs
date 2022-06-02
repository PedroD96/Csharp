using System;

namespace ex001
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\tEX01 - QUEM TEM IDADE MAIOR\n\n");

            Pessoa pessoa1, pessoa2;

            pessoa1 = new Pessoa();
            pessoa2 = new Pessoa();


            
            Console.Write($"Digite o nome da pessoa1: ");
            pessoa1.nome = Console.ReadLine();
            Console.Write($"Digite a idade da pessoa1: ");
            pessoa1.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("\n\n");

            Console.Write($"Digite o nome da pessoa2: ");
            pessoa2.nome = Console.ReadLine();
            Console.Write("Digite a idade da pessoa2: ");
            pessoa2.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("\n\n");

            if (pessoa1.idade > pessoa2.idade)
            {
                Console.WriteLine($"A PESSOA MAIS VELHA: {pessoa1.nome}");
            }
            else
            {
                Console.WriteLine($"A PESSOA MAIS VELHA: {pessoa2.nome}");
            }



        }
    }
}
