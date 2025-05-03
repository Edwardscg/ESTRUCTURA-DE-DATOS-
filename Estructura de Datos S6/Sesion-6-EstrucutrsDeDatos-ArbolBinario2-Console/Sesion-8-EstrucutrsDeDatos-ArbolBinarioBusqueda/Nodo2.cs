using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sesion_8_EstrucutrsDeDatos_ArbolBinarioBusqueda {
    public class Nodo2 {
        public char info {  get; set; }
        public Nodo2 left { get; set; }
        public Nodo2 right { get; set; }

        public Nodo2(char dato) {
            this.info = dato;
            this.left=null;
            this.right=null;
        }
    }
}
