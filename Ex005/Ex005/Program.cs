using System;
using System.Globalization;


namespace Ex005
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno a = new Aluno();
            Console.Write("NOME DO ALUNO: ");
            a.Nome = Console.ReadLine();

            Console.WriteLine("DIGITE AS TRES NOTAS DO ALUNO: ");
                        
            do
            {
                a.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (a.Nota1 > 30)
                    Console.WriteLine("Nota Invalida!\n Tente novamente");

            } while (a.Nota1 > 30);
            do
            {
                a.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (a.Nota2 > 35)
                    Console.WriteLine("Nota Invalida!\n Tente novamente");

            } while (a.Nota2 > 35);

            do
            {
                a.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (a.Nota3 > 35)
                    Console.WriteLine("Nota Invalida!\n Tente novamente");

            } while (a.Nota3 > 35);


            Console.WriteLine(a.ToString());
            if (a.NotaFinal() >= 60)
                Console.WriteLine("Aluno Aprovado!");
            else
            {
                Console.WriteLine("Aluno Reprovado");
                Console.WriteLine("FALTOU " + (60 - a.NotaFinal()).ToString("F2", CultureInfo.InvariantCulture));
            }

        }
    }
}
