using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sesion_8_EstrucutrsDeDatos_ArbolBinarioBusqueda {
    public class Nodo {
        public int info {  get; set; }
        public Nodo left { get; set; }
        public Nodo right { get; set; }

        // CONSTRUCTOR
        public Nodo(int dato) {
            this.info = dato;
            this.left=null;
            this.right=null;

            //info = dato;
        }
    }
}
