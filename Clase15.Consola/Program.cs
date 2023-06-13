using Clase15.Entidades;

namespace Clase15.Consola
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            var logica = new LogicaJuego();
            var jugador = new JugadorDeConsola();
            jugador.PedirNumero();
            logica.AdivinarNumero(jugador);
        }
    }
}