using Clase15.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase15.Consola
{
    internal class JugadorDeConsola : IJugador
    {
        private int numeroIngresado;
        public int NumeroAdivinado => numeroIngresado;

        public int PedirNumero()
        {
           return numeroIngresado = int.Parse(Console.ReadLine()!);
        }
    }
}
