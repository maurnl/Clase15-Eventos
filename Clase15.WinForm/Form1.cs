using Clase15.Entidades;

namespace Clase15.WinForm
{
    public partial class Form1 : Form, IJugador
    {
        private LogicaJuego _logica;

        public int NumeroAdivinado => int.Parse(txtNumero.Text);

        public Form1(LogicaJuego partida)
        {
            InitializeComponent();

            _logica = partida;

            _logica.NumeroNoAcertado += MostrarEnLabel;
            _logica.NumeroAcertado += Felicitar;
            _logica.JuegoFinalizado += DesactivarBoton;
            _logica.JuegoFinalizado += Close;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblResultado.Text = string.Empty;
        }

        private void btnAdivinar_Click(object sender, EventArgs e)
        {
            lblResultado.Text = string.Empty;
            _logica.AdivinarNumero(this);
        }

        private void MostrarEnLabel()
        {
            lblResultado.Text = "No adinaste!!";
        }

        public void Felicitar(IJugador jugadorGanador)
        {
            if(jugadorGanador == this)
            {
                lblResultado.Text = "Bien ahii ganaste!!!";
                this.BackColor = Color.Green;
            }
        }

        private void DesactivarBoton()
        {
            btnAdivinar.Enabled = false;
        }
    }
}