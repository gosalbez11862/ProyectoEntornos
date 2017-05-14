// ***********************************************************************
// Assembly         : NavajaSuiza
// Author           : Carlos
// Created          : 05-14-2017
//
// Last Modified By : Carlos
// Last Modified On : 05-14-2017
// ***********************************************************************
// <copyright file="CBaseExponente.cs">
//
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavajaSuiza.Tema4.Ejercicio13
{
    class ClassBaseExponente
    {
        /// <summary>
        /// Funcion que calcula el exponente del numero,
        /// </summary>
        /// <param name="numero">Base del numero.</param>
        /// <param name="exponente">Exponente del numero.</param>
        /// <returns>el resultado de obtener el exponente del numero</returns>
        public double Potencia(double numero, double exponente)
        {
            double resultado, i;
            resultado = 1;

            for (i = 1; i <= exponente; i++)
            {
                resultado = resultado * numero;
            }
            return resultado;
        }
    }
}
