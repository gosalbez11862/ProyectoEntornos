using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NavajaSuiza.Tema4.Ejercicio13
{
    public partial class Ejercicio13 : Form
    {
        public Ejercicio13()
        {
            InitializeComponent();
        }

        private void BCalcular_Click(object sender, EventArgs e)
        {
            CBaseExponente BaseExponente = new CBaseExponente();

            double Numero, Exponente, Resultado;
            bool CNumero, CExponente;
            CNumero = false;
            CExponente = false;

            CNumero = double.TryParse(TBase.Text, out Numero);
            CExponente = double.TryParse(TExponente.Text, out Exponente);

            if (CNumero == true && CExponente == true)
            {
                Resultado =BaseExponente.Potencia(Numero, Exponente);
                LResultado.Text = Resultado.ToString();
            }
            else
                MessageBox.Show("Introducir un numero");
        }

        private void TBase_TextChanged(object sender, EventArgs e)
        {
            int Exponente, Base;

            if (int.TryParse(TExponente.Text, out Exponente) && int.TryParse(TBase.Text, out Base))
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
