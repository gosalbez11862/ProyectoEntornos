// ***********************************************************************
// Assembly         : NavajaSuiza
// Author           : Carlos Gosalbez
// Created          : 04-20-2017
//
// Last Modified By : 
// Last Modified On : 05-14-2017
// ***********************************************************************
// <copyright file="LecturaNumerosVector.cs" company="">
//     . All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Windows.Forms;

namespace NavajaSuiza.Tema5.Ejercicio2
{
    public partial class LecturaNumerosVector : Form
    {
        /// <summary>
        /// Lee los numeros que introducimos en el vector,
        /// calcula la media despues de a ver llenado el vector 
        /// y por ultimo paso nos mostrara la media del mismo.
        /// </summary>
        public LecturaNumerosVector()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Inicializamos la clase LecturaVector
        /// </summary>
        LecturaVector CLV = new LecturaVector();

        /// <summary>
        /// Constante para limitar el vector
        /// </summary>
        const int KTam = 10;

        /// <summary>
        /// Inicializamos el vector con un tamaño determinado
        /// </summary>
        int[] vector = new int[KTam];

        /// <summary>
        /// Leemos el vector introduciendo los
        /// numeros
        /// </summary>
        /// <param name="vector">Numeros que van en el vector.</param>
        void FLeerVector(int[] vector)
        {
            int posicion = 0;
            bool bNumeroCorrecto;
            int numero;

            bNumeroCorrecto = int.TryParse(TNumeros.Text, out numero);

            if (bNumeroCorrecto)
            {
                if (true)
                {
                    if (posicion < vector.Length)
                    {
                        vector[posicion] = numero;
                        TNumeros.Text = "";
                        posicion++;
                    }
                    else
                    {
                        LResultado.Text = "Vector lleno";
                    }
                }
                else
                {
                    LMensaje.Text = "¡Error! El numero tiene que ser menor a " + int.MaxValue;
                }
                
            }
            else
            {
                LMensaje.Text = "¡Error! Debe Introducir un Numero";
            }
        }

        /// <summary>
        /// Cada vez que hacemos "click" introducimos un 
        /// numero en el vector
        /// </summary>
        /// <param name="sender">La fuente del evento.</param>
        /// <param name="e">El <see cref="EventArgs"/> instancia que contiene los datos del evento.</param>
        private void BInsertar_Click(object sender, EventArgs e)
        {
            FLeerVector(vector);
        }

        /// <summary>
        /// Boton para mostrar los numeros que estan en el vector.
        /// </summary>
        /// <param name="sender">La fuente del evento.</param>
        /// <param name="e">The <see cref="EventArgs"/>instancia que contiene los datos del evento.</param>
        private void BMostrar_Click(object sender, EventArgs e)
        {
            int valor;

            valor = CLV.FMediaVector(vector);
            LResultado.Text = valor.ToString();
        }

        /// <summary>
        /// Comprobamos que lo que introducimos en el textbox son numeros
        /// enteros y no dobles ni letras ni caracteres extraños.
        /// </summary>
        /// <param name="sender">El sender.</param>
        /// <param name="e">El <see cref="EventArgs"/>instancia que contiene los datos del evento.</param>
        private void ComprobarTextBox(object sender, EventArgs e)
        {
            int numero;

            if (int.TryParse(TNumeros.Text, out numero))
            {
                BInsertar.Enabled = true;
            }
            else
            {
                BInsertar.Enabled = false;

            }
        }

        private void ActivarBoton(object sender, EventArgs e)
        {

        }

        private void LecturaNumerosVector_Load(object sender, EventArgs e)
        {

        }
    }
}
