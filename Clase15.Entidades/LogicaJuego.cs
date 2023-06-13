namespace Clase15.Entidades
{
    public class LogicaJuego
    {
        private static Random _random;
        private const int INTENTOS_MAXIMOS = 10;
        private int _numeroSecreto;
        private List<int> _numerosIngresados;

        public event Action<IJugador> NumeroAcertado;
        public event Action NumeroNoAcertado;
        public event Action JuegoFinalizado;

        public int NumeroSecreto { get => _numeroSecreto; }
        public List<int> NumerosIngresados { get => _numerosIngresados; }

        static LogicaJuego()
        {
            _random = new Random();
        }

        public LogicaJuego()
        {
            _numerosIngresados = new List<int>();
            _numeroSecreto = _random.Next(1, 100 + 1);
        }

        public void AdivinarNumero(IJugador jugador)
        {
            _numerosIngresados.Add(jugador.NumeroAdivinado);
            // si adivina o no
            // frio o caliente
            if(_numeroSecreto == jugador.NumeroAdivinado)
            {
                NumeroAcertado?.Invoke(jugador);
                TerminarPartida();
            }
            else
            {
                if (_numerosIngresados.Count >= INTENTOS_MAXIMOS)
                {
                    TerminarPartida();
                }
                NumeroNoAcertado?.Invoke();
            }
        }

        public void TerminarPartida()
        {
            JuegoFinalizado?.Invoke();
        }
    }
}
