// ***********************************************************************
// Assembly         : NavajaSuiza
// Author           : Carlos Gosalbez
// Created          : 05-14-2017
//
// Last Modified By : 
// Last Modified On : 05-14-2017
// ***********************************************************************
// <copyright file="CPtsEuros.cs" company="">
//     . All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace NavajaSuiza.Tema4.Ejercicio4
{
    /// <summary>
    /// Clase de ConvertirPtsEuros
    /// </summary>
    class PtsEuros
    {
        const double Kconversor = 166.38;

        /// <summary>
        /// Obtiene el numero en pesetas que se 
        /// quieren convertir en euros.
        /// </summary>
        /// <param name="num1">Pesetas.</param>
        /// <returns>La conversion a Euros</returns>
        public static double FConversorpta(double num1)
        {
            double valor;

            valor = num1 * Kconversor;
            return valor;
        }

        /// <summary>
        /// Obtiene el numero en euros que se 
        /// quieren convertir en pesetas.
        /// </summary>
        /// <param name="num2">Euros.</param>
        /// <returns>La conversion a Pesetas</returns>
        public static double FConversoreu(double num2)
        {
            double valor;

            valor = num2 / Kconversor;
            return valor;
        }
    }
}
