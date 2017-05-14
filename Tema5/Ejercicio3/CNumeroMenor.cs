// ***********************************************************************
// Assembly         : NavajaSuiza
// Author           : Carlos
// Created          : 05-14-2017
//
// Last Modified By : Carlos
// Last Modified On : 05-14-2017
// ***********************************************************************
// <copyright file="CNumeroMenor.cs">
//
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace NavajaSuiza.Tema5.Ejercicio3
{
    internal static class NumeroMenor
    {
        /// <summary>
        /// Recorre el vector entero y devuelve
        /// el menor del vector.
        /// </summary>
        /// <param name="vector">el vector.</param>
        /// <returns>Devuelve el numero menor del vector</returns>
        public static int FMenorVector(int[] vector)
        {
            int menor, mayor, i;
            menor = 1;
            for (i = 0; i < vector.Length; i++)
            {
                if (menor > vector[i])
                {
                    menor = vector[i];
                }
                else
                {
                    mayor = vector[i];
                }
            }
            return menor;
        }
    }
}
