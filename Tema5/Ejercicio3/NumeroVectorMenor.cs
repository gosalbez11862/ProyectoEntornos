using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NavajaSuiza.Tema5.Ejercicio3
{
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

        const int KTam = 10;
        int posicion = 0;
        int[] vector = new int[KTam];

        void FLeerVector(int[] vector)
        {
            bool bNumeroCorrecto;
            int numero;

            bNumeroCorrecto = int.TryParse(TNumero.Text, out numero);

            if (bNumeroCorrecto)
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

                LResultado.Text = numero.ToString();
            }
            else
            {
                MessageBox.Show("¡Error! Debe Introducir un Numero");
            }
        }

        private void BLeer_Click(object sender, EventArgs e)
        {
            FLeerVector(vector);
        }

        private void BComprobar_Click(object sender, EventArgs e)
        {
            int menor;

            menor = CNumeroMenor.FMenorVector(vector);
            LResultado.Text = menor.ToString();
        }

        private void ComprobarTextBox(object sender, EventArgs e)
        {
            int Numero;

            if (int.TryParse(TNumero.Text, out Numero))
            {
                BLeer.Enabled = true;
            }
            else
            {
                BLeer.Enabled = false;

            }
        }
    }
}
