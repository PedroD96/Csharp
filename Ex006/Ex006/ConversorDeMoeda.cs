using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Ex006
{
    class ConversorDeMoeda
    {
        
        static public double IOF = 0.06;
         
        public static double ValorAPagar(double Dolar, double Comprar)
        {
            return ((Dolar * Comprar) +  ((Dolar * Comprar) * IOF));
        }
    }
}
