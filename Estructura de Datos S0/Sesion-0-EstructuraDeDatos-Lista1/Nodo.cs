using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructura_de_Datos_VERANO
{
    internal class Nodo
    {
        private int number;
        private Nodo siguiente;

        public int Number { get => number; set => number = value; }
        internal Nodo Siguiente { get => siguiente; set => siguiente = value; }
    }
}
