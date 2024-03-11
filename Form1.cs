using System.Diagnostics.Eventing.Reader;
using System.Net.Security;

namespace JMPracticaFinal
{
    public partial class Form1 : Form
    {
        string jugadorMaestro;
        string jugadorAdivinador;
        int numeroAdivinar;
        int numeroIngresado;

        public Form1(string jug, string jug2, int numero)
        {
            jugadorMaestro = jug;
            jugadorAdivinador = jug2;
            numeroAdivinar = numero;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Bienvenido jugador Adivinador " + jugadorAdivinador + ". Ahora es tu turno de adivinar el número del jugador Maestro.";
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            string numeroAdivinar2 = numeroAdivinar.ToString(); 
            string numeroIngresado = textboxNumero.Text;
            bool haybagels = true;

            for (int i = 0; i < numeroIngresado.Length; i++)
            {
                for (int j = 0; j < numeroAdivinar2.Length; j++)
                {
                    if (numeroAdivinar2[i] == numeroIngresado[j])
                    {
                        if(i == j)
                        {
                            listBox1.Items.Add("PICO en posición: " + i);
                        }
                        else
                        {
                            listBox1.Items.Add("FERMI en posición: " + i);
                        }
                    }
                }
            }
            for (int i = 0; i < numeroIngresado.Length; i++)
            {
                if (numeroAdivinar2.Contains(numeroIngresado[i]))
                {
                    haybagels = false;
                    break;
                }
            }
            if(haybagels)
            {
                listBox1.Items.Add("NINGUN DIGITO COINCIDE");
            }
            if (numeroAdivinar2 == numeroIngresado)
            {
                MessageBox.Show($"Felicitaciones, has encontra el numero secreto {numeroAdivinar}", "GANADOR");
                this.Close();
            }
        }


    }
}
