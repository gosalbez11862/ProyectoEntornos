using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NavajaSuiza.Tema4.Ejercicio4
{
    public partial class Convertir_PTS_Euros : Form
    {
        public Convertir_PTS_Euros()
        {
            InitializeComponent();
        }

        const double kconversor = 166.38;

        double FConversorpta(double num1)
        {
            double valor;

            valor = num1 * kconversor;
            return valor;
        }

        double FConversoreu(double num2)
        {
            double valor;

            valor = num2 / kconversor;
            return valor;
        }

        private void BPesetas_Click(object sender, EventArgs e)
        {
            double euro, resultado;
            bool moneda = false;

            moneda = double.TryParse(TEuros.Text, out euro);

            if (moneda == true)
            {
                resultado = FConversorpta(euro);
                TPesetas.Text = resultado.ToString("2");
            }
            else
            {
                MessageBox.Show("Introducir un número.");
            }
            TEuros.Text = "";     
        }

        private void BEuros_Click(object sender, EventArgs e)
        {
            double pta, resultado;
            bool moneda = false;

            moneda = double.TryParse(TPesetas.Text, out pta);

            if (moneda == true)
            {
                resultado = FConversoreu(pta);
                TEuros.Text = resultado.ToString("C2");
            }
            else
            {
                MessageBox.Show("Introducir un número.");
            }
            TPesetas.Text = "";
        }
    }
}
