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
    public partial class IngresoNumero : Form
    {
        string jugador;
        string jugador2;
        int numero;
        public IngresoNumero(string jug, string jug2)
        {
            InitializeComponent();
            jugador = jug;
            jugador2 = jug2;
        }

        private void AbrirFormularioPrincipal()
        {
            Form1 form1 = new Form1(jugador, jugador2, numero);
            form1.Show();
            this.Hide();
        }

        private void IngresoNumero_Load(object sender, EventArgs e)
        {
            lblRegla.Text = "Bienvenido jugador Maestro " + jugador + ". A continuación debe elegir un número de 3 dígitos, que sean distintos para que el jugador Adivinador intente descubrirlo";
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            AbrirFormularioPrincipal();
        }

        private void btnEnviarNumero_Click(object sender, EventArgs e)
        {
            string numerostr = textboxAgregarnro.Text;
            bool numeroCorrecto = true;

            for (int i = 0; i < numerostr.Length - 1; i++)
            {
                for (int j = i + 1; j < numerostr.Length; j++)
                {
                    if (numerostr[i] == numerostr[j])
                    {
                        MessageBox.Show("Vuelva a ingresar un número con los 3 digitos distintos.");
                        numeroCorrecto = false;
                        textboxAgregarnro.Text = "";
                    }
                }
            }
            if (numeroCorrecto)
            {
                MessageBox.Show("El numero asignado es el correcto");
                int.TryParse(numerostr, out numero);
            }
        }


    }
}
