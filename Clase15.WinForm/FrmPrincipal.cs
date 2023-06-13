using Clase15.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase15.WinForm
{
    public partial class FrmPrincipal : Form
    {
        private LogicaJuego _logica;

        public FrmPrincipal()
        {
            InitializeComponent();

            _logica = new LogicaJuego();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            label1.Text = $"El numero secreto es: {_logica.NumeroSecreto}";
        }

        private void btnCrearJugador_Click(object sender, EventArgs e)
        {
            var formNuevo = new Form1(_logica);

            formNuevo.Show();
        }

        private void btnTerminarPartida_Click(object sender, EventArgs e)
        {
            _logica.TerminarPartida();
        }
    }
}
