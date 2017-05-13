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
        const int KTam = 10;
        int posicion = 0;
        int[] vector = new int[KTam];

        void FLeerVector (int[] vector)
        {
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
                    MessageBox.Show("Vector lleno");
                }
            }
            else
            {
                MessageBox.Show("¡Error! Debe Introducir un Numero");
            }
        }

        int FMediaVector(int[] vector)
        {
            int Media, i;
            Media = 0;

            for (i = 0; i < vector.Length; i++)
            {
                Media = Media + vector[i];
            }
            Media = Media / KTam;

            return Media;
        }

        private void BInsertar_Click(object sender, EventArgs e)
        {
            FLeerVector(vector);
        }

        private void BMostrar_Click(object sender, EventArgs e)
        {
            int valor;

            valor = FMediaVector(vector);
            LResultado.Text = valor.ToString();
        }

        private void ActivarBoton(object sender, EventArgs e)
        {

        }

        private void LecturaNumerosVector_Load(object sender, EventArgs e)
        {

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
    }
}
