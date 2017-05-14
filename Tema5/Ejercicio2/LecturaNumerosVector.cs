using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        /// The CLV
        /// </summary>
        LecturaVector CLV = new LecturaVector();

        /// <summary>
        /// The k tam
        /// </summary>
        const int KTam = 10;

        /// <summary>
        /// The vector
        /// </summary>
        int[] vector = new int[KTam];

        /// <summary>
        /// fs the leer vector.
        /// </summary>
        /// <param name="vector">The vector.</param>
        void FLeerVector(int[] vector)
        {
            int posicion = 0;
            bool bNumeroCorrecto;
            int numero;

            bNumeroCorrecto = int.TryParse(TNumeros.Text, out numero);

            if (bNumeroCorrecto)
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
                LMensaje.Text = "¡Error! Debe Introducir un Numero";
            }
        }

        /// <summary>
        /// Handles the Click event of the BInsertar control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BInsertar_Click(object sender, EventArgs e)
        {
            FLeerVector(vector);
        }

        /// <summary>
        /// Handles the Click event of the BMostrar control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BMostrar_Click(object sender, EventArgs e)
        {
            int valor;

            valor = CLV.FMediaVector(vector);
            LResultado.Text = valor.ToString();
        }

        /// <summary>
        /// Comprobars the text box.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ComprobarTextBox(object sender, EventArgs e)
        {
            int Numero;

            if (int.TryParse(TNumeros.Text, out Numero))
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
