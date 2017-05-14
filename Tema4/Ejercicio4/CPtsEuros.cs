using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavajaSuiza.Tema4.Ejercicio4
{
    class CPtsEuros
    {
        const double kconversor = 166.38;

        public static double FConversorpta(double num1)
        {
            double valor;

            valor = num1 * kconversor;
            return valor;
        }

        public static double FConversoreu(double num2)
        {
            double valor;

            valor = num2 / kconversor;
            return valor;
        }
    }
}
