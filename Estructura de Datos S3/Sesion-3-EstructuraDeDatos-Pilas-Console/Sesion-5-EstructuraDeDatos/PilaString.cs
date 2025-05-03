using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sesion_5_EstructuraDeDatos {
    internal class PilaString {
        NodoString cima, nuevo, ptr;

        // METODO CONSTRUCTOR
        public PilaString() {
            cima=null;
        }

        // METODO ES VACIO
        public bool EsVacio() {
            return cima==null;
        }

        // METODO PUSH
        public void Push(char dato) {
            nuevo=new NodoString();
            nuevo.info=dato;
            nuevo.sig=cima;
            cima=nuevo;
        }

        // METODO
        public char Pop() {
            if (EsVacio()) {
                Console.WriteLine("\n ***ERROR, LA PILA ESTA VACIA***");
                return ' ';
            } else {
                char dato = cima.info;
                cima = cima.sig;
                return dato;
            }
        }
    }
}
