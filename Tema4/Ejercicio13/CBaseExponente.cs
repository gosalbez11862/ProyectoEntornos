using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavajaSuiza.Tema4.Ejercicio13
{
    class CBaseExponente
    {
        public double Potencia(double Numero, double Exponente)
        {
            double Resultado, i;
            Resultado = 1;

            for (i = 1; i <= Exponente; i++)
            {
                Resultado = Resultado * Numero;
            }
            return Resultado;
        }
    }
}
