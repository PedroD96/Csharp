using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Estoque
{
    class Produto
    {

        //Se tiver uma logica particular não é recomendado usar a proprite
        private string _nome;
        //-----------------------------------------------------------------

        public double Preco { get; private set;}
        public int Quantidade { get; private set;}
        

        public Produto()
        {
        }

        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }


        public string Nome
        {
            get { return _nome; }

            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

      


        public double ValorTotalEmEstoque()
        {
            return Quantidade * Preco;
        }

        public void AdicionarProdutos(int quantity)
        {
            Quantidade = Quantidade + quantity;
        }

        public void RemoverProdutos(int quantity)
        {
            Quantidade = Quantidade - quantity;
        }

        public override string ToString()
        {
            return _nome + " , $"
                        + Preco.ToString("F2", CultureInfo.InvariantCulture)
                        + " , "
                        + Quantidade
                        + " unidades, Total: $"
                        + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
           
        }

        /*
            *Aula de Construtores
            * *********************************************************************************************************************** 
            * public string Nome;
           public double Preco;
           public int Quantidade;

           public Produto() {
           }

           public Produto(string nome, double preco, int quantidade)
           {
               Nome = nome;
               Preco = preco;
               Quantidade = quantidade;
           }

        /*
       public double Preco
       {
           get { return _preco; }
       }

       public int Quantidade 
       {
           get { return _quantidade; }
       }
      */

        /*
        public double GetPreco()
        {
            return _preco;
        }

        public int GetQuantidade()
        {
            return _quantidade;
        } 
        */

        /*

            public double ValorTotalEmEstoque()
            {
                return Quantidade * Preco;
            }

            public void AdicionarProdutos(int quantity)
            {
                Quantidade = Quantidade + quantity;
            }

            public void RemoverProdutos(int quantity)
            {
                Quantidade = Quantidade - quantity;
            }

            public override string ToString()
            {
                return Nome + " , $"
                            + Preco.ToString("F2", CultureInfo.InvariantCulture)
                            + " , "
                            + Quantidade
                            + " unidades, Total: $"
                            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
            }
         */

        /*
        public string GetNome()
        {
            return _nome;
        }

        public void SetNome(string nome)
        {
            if(nome != null && nome.Length > 1)
            {
                _nome = nome;
            }
            

        }
        */

    }
}
