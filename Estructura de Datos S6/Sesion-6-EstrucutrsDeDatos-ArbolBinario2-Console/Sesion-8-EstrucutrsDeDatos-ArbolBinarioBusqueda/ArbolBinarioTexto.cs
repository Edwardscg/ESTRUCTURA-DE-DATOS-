using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sesion_8_EstrucutrsDeDatos_ArbolBinarioBusqueda {
    public class ArbolBinarioTexto {
        public Nodo Raiz;

        // METODO CONSTRUCTOR
        public ArbolBinarioTexto() {
            Raiz=null;
        }

        // METODO INSERTAR NODO EN EL ARBOL 
        public void Insertar(char dato) {
            Raiz=InsertarRecursivo(Raiz,dato);
        }

        // METODO INSERSIÓN EN FORMA RECURSIVA
        public Nodo InsertarRecursivo(Nodo raiz,char dato) {
            if (raiz==null) {
                raiz=new Nodo(dato);
            } else if (raiz.info>dato) {
                raiz.left=InsertarRecursivo(raiz.left,dato);
            } else if (raiz.info<dato) {
                raiz.right=InsertarRecursivo(raiz.right,dato);
            }
            return raiz;

        }

        // METODO RECORRIDO EN PRE ORDEN
        public void PreOrden(Nodo raiz) {
            if (raiz!=null) {
                Console.WriteLine((char)raiz.info+"-");
                PreOrden(raiz.left);
                PreOrden(raiz.right);
            }
        }
Sesion-8-EstrucutrsDeDatos
        // METODO RECORRIDO IN ORDEN
        public void InOrden(Nodo raiz) {
            if (raiz!=null) {
                InOrden(raiz.left);
                Console.WriteLine((char)raiz.info+"-");
                InOrden(raiz.right);
            }
        }

        // METODO RECORRIDO POST ORDEN
        public void PostOrden(Nodo raiz) {
            if (raiz!=null) {
                PostOrden(raiz.left);
                PostOrden(raiz.right);
                Console.WriteLine((char)raiz.info+"-");
            }
        }
    }
}
