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
        public LecturaNumerosVector()
        {
            InitializeComponent();
        }
        const int KTam = 10;
        int[] vector = new int[KTam];

        void FLeerVector (int[] vector)
        {
            bool bNumeroCorrecto;
            int numero, posicion;
            posicion = 0;

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
    }
}
