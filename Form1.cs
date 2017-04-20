using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NavajaSuiza
{
    public partial class NavajaSuiza : Form
    {
        public NavajaSuiza()
        {
            InitializeComponent();
        }

        private void Ejercicio4_Click(object sender, EventArgs e)
        {
            Tema4.Ejercicio4.Convertir_PTS_Euros oFormulario1 = new Tema4.Ejercicio4.Convertir_PTS_Euros();
            oFormulario1.ShowDialog();
        }

        private void Ejercicio13_Click(object sender, EventArgs e)
        {
            Tema4.Ejercicio13.Ejercicio13 oFormulario2 = new Tema4.Ejercicio13.Ejercicio13();
            oFormulario2.ShowDialog();
        }

        private void Ejercicio2_Click(object sender, EventArgs e)
        {
            Tema5.Ejercicio2.LecturaNumerosVector oFormulario3 = new Tema5.Ejercicio2.LecturaNumerosVector();
            oFormulario3.ShowDialog();
        }

        private void Ejercicio3_Click(object sender, EventArgs e)
        {
            Tema5.Ejercicio3.NumeroVectorMenor oFormulario4 = new Tema5.Ejercicio3.NumeroVectorMenor();
            oFormulario4.ShowDialog();
        }
    }
}
