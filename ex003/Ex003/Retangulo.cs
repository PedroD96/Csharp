using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Ex003
{
    class Retangulo
    {
        public double LadoA;
        public double LadoB;


        public double Area()
        {
            return LadoA * LadoB;
            
        }

        public double Perimetro()
        {
            return 2 * (LadoA + LadoB);
        }

        public double Diagonal()
        {
            return Math.Sqrt(Math.Pow(LadoA, 2) + Math.Pow(LadoB, 2));
        }

        public override string ToString()
        {
            return "AREA = "
                + Area().ToString("F2", CultureInfo.InvariantCulture)
                + "\nPERIMETRO = "
                + Perimetro().ToString("F2", CultureInfo.InvariantCulture)
                + "\nDIAGONAL = "
                + Diagonal().ToString("F2", CultureInfo.InvariantCulture);

        }
    }

}
