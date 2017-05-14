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

        CLecturaVector CLV = new CLecturaVector();
        const int KTam = 10;
        int[] vector = new int[KTam];

        void FLeerVector(int[] vector)
        {
            LecturaNumerosVector LNV = new LecturaNumerosVector();

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

        private void BInsertar_Click(object sender, EventArgs e)
        {
            FLeerVector(vector);
        }

        private void BMostrar_Click(object sender, EventArgs e)
        {
            int valor;

            valor = CLV.FMediaVector(vector);
            LResultado.Text = valor.ToString();
        }

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
