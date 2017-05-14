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

        private void BPesetas_Click(object sender, EventArgs e)
        {
            double euro, resultado;
            bool moneda = false;

            moneda = double.TryParse(TEuros.Text, out euro);

            if (moneda == true)
            {
                resultado = CPtsEuros.FConversorpta(euro);
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
                resultado = CPtsEuros.FConversoreu(pta);
                TEuros.Text = resultado.ToString("C2");
            }
            else
            {
                MessageBox.Show("Introducir un número.");
            }
            TPesetas.Text = "";
        }

        private void ComprobarTextBox(object sender, EventArgs e)
        {
            double Euros,Pesetas;

            if (double.TryParse(TEuros.Text, out Euros) || double.TryParse(TPesetas.Text, out Pesetas))
            {
                BPesetas.Enabled = true;
                BEuros.Enabled = true;
            }
            else
            {
                BPesetas.Enabled = false;
                BEuros.Enabled = false;
            }
        }
    }
}
