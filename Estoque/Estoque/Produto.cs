using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Estoque
{
    class Produto
    {
        public string nome;
        public double preco;
        public int quantidade;


        public double ValorTotalEmEstoque()
        {
            return quantidade * preco;
        }

        public void AdicionarProdutos(int quantity)
        {
            quantidade = quantidade + quantity;
        }

        public void RemoverProdutos(int quantity)
        {
            quantidade = quantidade - quantity;
        }

        public override string ToString()
        {
            return nome + " , $" + preco.ToString("F2", CultureInfo.InvariantCulture)
                        + " , "
                        + quantidade
                        + " unidades, Total: $"
                        + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
