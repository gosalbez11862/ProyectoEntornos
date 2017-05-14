// ***********************************************************************
// Assembly         : NavajaSuiza
// Author           : Carlos Gosalbez
// Created          : 09-04-2017
//
// Last Modified By : Carlos
// Last Modified On : 09-05-2017
// ***********************************************************************
// <copyright file="NavajaSuiza.cs">
// </copyright>
// <summary>Proyecto de Entornos</summary>
// ***********************************************************************
using NavajaSuiza.Tema4.Ejercicio13;
using NavajaSuiza.Tema4.Ejercicio4;
using NavajaSuiza.Tema5.Ejercicio2;
using NavajaSuiza.Tema5.Ejercicio3;
using System;
using System.Windows.Forms;

namespace NavajaSuiza
{
    /// <summary>
    /// Union de 4 ejercicios para conformar un proyecto de entornos
    /// </summary>
    public partial class Form1 : Form
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="Form1"/> class.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Instanciamos el form <see cref="ConvertirPtsEuros"/> para poder abrirlo al pulsar el boton
        /// </summary>
        /// <param name="sender">La fuente del evento.</param>
        /// <param name="e">The <see cref="EventArgs"/>Instancia que contiene los datos del evento.</param>
        private void Ejercicio4_Click(object sender, EventArgs e)
        {
            Tema4.Ejercicio4.ConvertirPtsEuros oFormulario1 = new Tema4.Ejercicio4.ConvertirPtsEuros();
            oFormulario1.ShowDialog();
        }

        /// <summary>
        /// Instanciamos el form <see cref="CalcularBaseExponente"/> para poder abrirlo al pulsar el boton
        /// </summary>
        /// <param name="sender">La fuente del evento.</param>
        /// <param name="e">The <see cref="EventArgs"/>Instancia que contiene los datos del evento.</param>
        private void Ejercicio13_Click(object sender, EventArgs e)
        {
            Tema4.Ejercicio13.CalcularBaseExponente oFormulario2 = new Tema4.Ejercicio13.CalcularBaseExponente();
            oFormulario2.ShowDialog();
        }

        /// <summary>
        /// Instanciamos el form <see cref="LecturaNumerosVector"/> para poder abrirlo al pulsar el boton
        /// </summary>
        /// <param name="sender">La fuente del evento.</param>
        /// <param name="e">The <see cref="EventArgs"/>Instancia que contiene los datos del evento.</param>
        private void Ejercicio2_Click(object sender, EventArgs e)
        {
            Tema5.Ejercicio2.LecturaNumerosVector oFormulario3 = new Tema5.Ejercicio2.LecturaNumerosVector();
            oFormulario3.ShowDialog();
        }

        /// <summary>
        /// Instanciamos el form <see cref="NumeroVectorMenor"/> para poder abrirlo al pulsar el boton
        /// </summary>
        /// <param name="sender">La fuente del evento.</param>
        /// <param name="e">El <see cref="EventArgs"/>Instancia que contiene los datos del evento.</param>
        private void Ejercicio3_Click(object sender, EventArgs e)
        {
            Tema5.Ejercicio3.NumeroVectorMenor oFormulario4 = new Tema5.Ejercicio3.NumeroVectorMenor();
            oFormulario4.ShowDialog();
        }
    }
}
