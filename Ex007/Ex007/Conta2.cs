using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Ex007
{
    class Conta2
    {
        //Aplicar validação de caracteres
        private string _nome;
        private string _nConta;


        public double Valor { get; private set; }

        public Conta2()
        {
        }

        public Conta2(string nome, string nConta, double valor)
        {
            _nome = nome;
            _nConta = nConta;
            Valor = 0.00;  
        }

        //Validando para ver se o nome de usuario não é vazio
        public string Nome
        {
            get { return _nome; }

            set 
            {
                if(value != null && value.Length > 0)
                {
                    _nome = value;
                }
            }
        }

        public string NConta
        {
            get { return _nConta; }

            set
            {
                if(value != null && value.Length > 0)
                {
                    _nConta = value;
                }
            }
        }


        public void Deposito(double valor)
        {
            Valor = Valor + valor;
        }

        public void Sacar(double valor)
        {
            Valor = Valor - (valor + 5.00);
        }


        public override string ToString()
        {
            return "Conta "
                +   _nConta
                +   ", Titular: "
                +   _nome
                +   ", Saldo: $"
                +   Valor.ToString("F2", CultureInfo.InvariantCulture);
        }


    }
}
