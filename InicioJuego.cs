using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JMPracticaFinal
{
    public partial class InicioJuego : Form
    {
        public InicioJuego()
        {
            InitializeComponent();
        }

        private void AbrirFormularioPrincipal()
        {
            string jugador = textBox1.Text;
            string jugador2 = textBox2.Text;
            IngresoNumero formularioPrincipal = new IngresoNumero(jugador, jugador2);
            formularioPrincipal.Show();
            this.Hide();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormularioPrincipal();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
