using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sesion_8_EstruturaDeDatos_ArbolBinario2 {
    internal class Nodo {
        public int numero {  get; set; }
        public Nodo izquierdo { get; set; }
        public Nodo derecho { get; set; }

        public Nodo (int num) {
            numero= num;
            izquierdo=null;
            derecho=null;
        }
    }
}
