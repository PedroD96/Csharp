using System;
using System.Globalization;


namespace Estoque
{
    internal class Program
    {
        static void Main(string[] args)
        {
                     
            
            Produto p = new Produto("TV", 500.00, 10);


            

            p.Nome = "T";

            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco);


            /*
             * Aula de Construtores
             * ***********************************************************************************************************************
             * 
             * Console.WriteLine("Entre os dados do produto: ");
            
            Console.Write("NOME: ");
            string nome = Console.ReadLine();

            Console.Write("PRECO: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

          
            Produto produto = new Produto(nome, preco);

            Produto p2 = new Produto();

            Produto p3 = new Produto {
                Nome = "TV",
                Preco = 500.00, 
                Quantidade = 20
            };

            Console.WriteLine("Dados do produto: " + produto);

            Console.WriteLine();

            Console.Write("DIGITE O NUMERO DE PRODUTOS A SER ADICIONADO DO ESTOQUE: ");
            int quantity = int.Parse(Console.ReadLine());
            produto.AdicionarProdutos(quantity);

            Console.WriteLine("Dados do produto: " + produto);

            Console.WriteLine();

            Console.Write("DIGITE O NUMERO DE PRODUTOS A SER REMOVIDO DO ESTOQUE: ");
            quantity = int.Parse(Console.ReadLine());
            produto.RemoverProdutos(quantity);


            Console.WriteLine("Dados do produto: " + produto);
            */

        }
    }
}
