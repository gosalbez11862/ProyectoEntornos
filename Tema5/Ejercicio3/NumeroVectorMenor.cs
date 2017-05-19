// ***********************************************************************
// Assembly         : NavajaSuiza
// Author           : Carlos Gosalbez
// Created          : 04-20-2017
//
// Last Modified By : Carlos
// Last Modified On : 05-14-2017
// ***********************************************************************
// <copyright file="NumeroVectorMenor.cs">
//
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Windows.Forms;

namespace NavajaSuiza.Tema5.Ejercicio3
{
    /// <summary>
    /// Lee los numeros que introducimos en el vector,
    /// y busca entre todo el vector el numero menor de todos ellos.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class NumeroVectorMenor : Form
    {
        /// <summary>
        /// Lee los numeros que introducimos en el vector,
        /// y busca entre todo el vector el numero menor de todos ellos.
        /// </summary>
        public NumeroVectorMenor()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constante que sera el tamaño del vector
        /// </summary>
        const int KTam = 10;
        int posicion = 0;

        /// <summary>
        /// Inicializacion del vector con el tamaño dado 
        /// en la constante KTam
        /// </summary>
        int[] vector = new int[KTam];

        /// <summary>
        /// Leemos el vector introduciendo los
        /// numeros
        /// </summary>
        /// <param name="vector">Numeros que van en el vector.</param>
        public void FLeerVector(int[] vector)
        {
            bool bNumeroCorrecto;
            int numero;

            bNumeroCorrecto = int.TryParse(TNumero.Text, out numero);

            if (bNumeroCorrecto)
            {
                if (numero < int.MaxValue)
                {
                    if (posicion < vector.Length)
                    {
                        vector[posicion] = numero;
                        TNumero.Text = "";
                        posicion++;
                    }
                    else
                    {
                        MessageBox.Show("Vector lleno");
                    }

                    LResultado.Text = numero.ToString("D");
                }
                
            }
            else
            {
                MessageBox.Show("¡Error! Debe Introducir un Numero");
            }
        }
        /// <summary>
        /// Cada vez que hacemos "click" introducimos un 
        /// numero en el vector
        /// </summary>
        /// <param name="sender">La fuente del evento.</param>
        /// <param name="e">El <see cref="EventArgs"/> instancia que contiene los datos del evento.</param>
        private void BLeer_Click(object sender, EventArgs e)
        {
            FLeerVector(vector);
        }
        /// <summary>
        /// Boton para mostrar el numero menor del vector.
        /// </summary>
        /// <param name="sender">La fuente del evento.</param>
        /// <param name="e">The <see cref="EventArgs"/>instancia que contiene los datos del evento.</param>
        private void BComprobar_Click(object sender, EventArgs e)
        {
            int menor;

            menor = NumeroMenor.FMenorVector(vector);
            LResultado.Text = menor.ToString("D");
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

            if (int.TryParse(TNumero.Text, out numero))
            {
                BLeer.Enabled = true;
            }
            else
            {
                BLeer.Enabled = false;

            }
        }

        public bool FLeerVector(int vector)
        {
            throw new NotImplementedException();
        }
    }
}
