// ***********************************************************************
// Assembly         : NavajaSuiza
// Author           : Carlos
// Created          : 09-04-2017
//
// Last Modified By : Carlos
// Last Modified On : 09-05-2017
// ***********************************************************************
// <copyright file="NavajaSuiza.cs">
// </copyright>
// <summary>Proyecto de Entornos</summary>
// ***********************************************************************
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
        /// 
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        private void Ejercicio4_Click(object sender, EventArgs e)
        {
            Tema4.Ejercicio4.ConvertirPtsEuros oFormulario1 = new Tema4.Ejercicio4.ConvertirPtsEuros();
            oFormulario1.ShowDialog();
        }

        private void Ejercicio13_Click(object sender, EventArgs e)
        {
            Tema4.Ejercicio13.CalcularBaseExponente oFormulario2 = new Tema4.Ejercicio13.CalcularBaseExponente();
            oFormulario2.ShowDialog();
        }

        private void Ejercicio2_Click(object sender, EventArgs e)
        {
            Tema5.Ejercicio2.LecturaNumerosVector oFormulario3 = new Tema5.Ejercicio2.LecturaNumerosVector();
            oFormulario3.ShowDialog();
        }

        private void Ejercicio3_Click(object sender, EventArgs e)
        {
            Tema5.Ejercicio3.NumeroVectorMenor oFormulario4 = new Tema5.Ejercicio3.NumeroVectorMenor();
            oFormulario4.ShowDialog();
        }
    }
}
