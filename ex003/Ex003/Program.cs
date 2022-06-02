using System;
using System.Globalization;

namespace Ex003
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre a largura e altura do retangulo: ");

            Retangulo r = new Retangulo();

            r.LadoA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            r.LadoB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(r.ToString());
            


        }
    }
}
