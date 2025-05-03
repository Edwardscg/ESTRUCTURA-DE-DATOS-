using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sesion_4_EstructuraDeDatos_ListaCircularDoble {
    internal class NodoDoble {
        public int info { get; set; }
        public NodoDoble sig { get; set; }
        public NodoDoble ant { get; set; }
    }
}
