using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavajaSuiza.Tema5.Ejercicio2
{
    class CLecturaVector
    {

        public int FMediaVector(int[] vector)
        {
            int Media, i;
            Media = 0;

            for (i = 0; i < vector.Length; i++)
            {
                Media = Media + vector[i];
            }
            Media = Media / KTam;

            return Media;
        }
    }
}
