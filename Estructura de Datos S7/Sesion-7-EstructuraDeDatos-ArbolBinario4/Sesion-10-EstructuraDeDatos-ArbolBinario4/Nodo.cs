using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sesion_10_EstructuraDeDatos_ArbolBinario4 {
    internal class Nodo {
        public int numero {  get; set; }
        public Nodo izquierda { get; set; }
        public Nodo derecho { get; set; }

        public Nodo (int num) {
            numero = num;
            izquierda=null;
            derecho = null;
        }
    }
}
