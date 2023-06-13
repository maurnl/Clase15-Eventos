using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase15.Entidades
{
    public class ClaseConEventos
    {
        public event Action MetodoFueLlamado; // Delegado 

        public void MiMetodo()
        {
            MetodoFueLlamado?.Invoke();
        }
    }
}
