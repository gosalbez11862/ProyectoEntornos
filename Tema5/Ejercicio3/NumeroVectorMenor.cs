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
        public NumeroVectorMenor()
        {
            InitializeComponent();
        }
        private static string InputBox(string texto)
        {
            InputBoxDialog ib = new InputBoxDialog();
            ib.FormPrompt = texto;
            ib.DefaultValue = "";
            ib.ShowDialog();
            string s = ib.InputResponse;
            ib.Close();
            return s;
        }

        const int KTam = 10;
        int[] vector = new int[KTam];

        void FLeerVector(int[] vector)
        {
            int i;
            for (i = 0; i < vector.Length; i++)
            {
                vector[i] = int.Parse(InputBox("Introduzca el numero: " + i));
            }
        }

        int FMenorVector(int[] vector)
        {
            int Menor, Mayor, i;
            Menor = 1;
            for (i = 0; i < vector.Length; i++)
            {
                if (Menor > vector[i])
                {
                    Menor = vector[i];
                }
                else
                {
                    Mayor = vector[i];
                }
            }
            return Menor;
        }

        private void BLeer_Click(object sender, EventArgs e)
        {
            FLeerVector(vector);
        }

        private void BComprobar_Click(object sender, EventArgs e)
        {
            int menor;

            menor = FMenorVector(vector);
            MessageBox.Show(menor.ToString());
        }
    }
}
