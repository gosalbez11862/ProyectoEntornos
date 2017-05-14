// ***********************************************************************
// Assembly         : NavajaSuiza
// Author           : Carlos
// Created          : 04-19-2017
//
// Last Modified By : Carlos
// Last Modified On : 05-14-2017
// ***********************************************************************
// <copyright file="Ejercicio13.cs">
//
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Windows.Forms;
using System.Globalization;

namespace NavajaSuiza.Tema4.Ejercicio13
{
    /// <summary>
    /// Ejercicio13 clacular de un numero con Base X
    /// y con exponente X
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class CalcularBaseExponente : Form
    {
        /// <summary>
        /// Inicializa una nueva instancia de la <see cref="CalcularBaseExponente"/> clase.	
        /// </summary>
        /// <remarks></remarks>
        public CalcularBaseExponente()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Boton para calcular el resultado de
        /// calcular la base con el exponente.
        /// </summary>
        /// <param name="sender">La fuente del evento.</param>
        /// <param name="e">El <see cref="EventArgs"/> Ejemplo que contiene los datos del evento.</param>
        private void BCalcular_Click(object sender, EventArgs e)
        {
            ClassBaseExponente baseExponente = new ClassBaseExponente();

            double numero, exponente, resultado;
            bool cNumero, cExponente;
            cNumero = false;
            cExponente = false;

            cNumero = double.TryParse(TBase.Text, out numero);
            cExponente = double.TryParse(TExponente.Text, out exponente);

            if (cNumero == true && cExponente == true)
            {
                resultado =baseExponente.Potencia(numero, exponente);
                LResultado.Text = resultado.ToString(CultureInfo.CurrentCulture);
            }
            else
                MessageBox.Show("Introducir un numero");
        }

        /// <summary>
        /// Evento que controla la entrada de datos
        /// y que solo sean numeros y no letras
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">El <see cref="EventArgs" /> Ejemplo que contiene los datos del evento.</param>
        private void TBase_TextChanged(object sender, EventArgs e)
        {
            double exponente, base1;

            if (double.TryParse(TExponente.Text, out exponente) && double.TryParse(TBase.Text, out base1))
            {
                BCalcular.Enabled = true;
            }
            else
            {
                BCalcular.Enabled = false;
            }
        }
    }
}
