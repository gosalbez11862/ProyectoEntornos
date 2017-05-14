using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavajaSuiza.Tema5.Ejercicio3
{
    class CNumeroMenor
    {
        public static int FMenorVector(int[] vector)
        {
            int Menor, Mayor, i;
            Menor = 1;
            for (i = 0; i < vector.Length; i++)
            {
                if (Menor > vector[i])
                {
                    Menor = vector[i];
                }
                else
                {
                    Mayor = vector[i];
                }
            }
            return Menor;
        }
    }
}
