using System;
using System.Globalization;


namespace Estoque
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre os dados do produto: ");
            Produto produto = new Produto();


            Console.Write("NOME: ");
            produto.nome = Console.ReadLine();

            Console.Write("PRECO: ");
            produto.preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("QUANTIDADE NO ESTOQUE: ");
            produto.quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Console.Write($"\n\nDADOS DO PRODUTO: {produto.nome}, ${produto.preco.ToString("F2")} , {produto.quantidade}, Total: ${produto.ValorTotalEmEstoque().ToString("F2")} ");
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
        }
    }
}
