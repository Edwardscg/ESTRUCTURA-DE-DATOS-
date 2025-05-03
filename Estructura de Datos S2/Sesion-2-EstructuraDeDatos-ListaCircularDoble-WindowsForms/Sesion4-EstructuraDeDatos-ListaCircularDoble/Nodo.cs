using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sesion4_EstructuraDeDatos_ListaCircularDoble {
    internal class Nodo {
        private int num;
        private Nodo sig;

        public int Num { get => num; set => num=value; }
        internal Nodo Sig { get => sig; set => sig=value; }
    }
}
