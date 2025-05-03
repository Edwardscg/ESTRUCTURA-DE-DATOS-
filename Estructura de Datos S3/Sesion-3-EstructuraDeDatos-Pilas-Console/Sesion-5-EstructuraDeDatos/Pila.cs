using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sesion_5_EstructuraDeDatos {
    public class Pila {
        Nodo cima, nuevo, ptr;

        // METODO CONSTRUCTOR
        public Pila() {
            cima=null;
        }

        // METODO ES VACIO
        public bool EsVacio() {
            return cima==null;
        }

        // METODO APILAR (PUSH)
        public void Apilar(int dato) {
            nuevo=new Nodo(); // Crear nuevo Nodo
            nuevo.info=dato;  // Guardar el dato en el campo info
            nuevo.sig=cima;     // Apilar el nodo en la cima
            cima=nuevo;         // Actualizar la cima
        }

        // METODO DESAPILAR (POP)
        public int Desapilar () {
            if (EsVacio()) {
                Console.WriteLine("\n ***ERROR, LA PILA ESTA VACIA***");
                return -1;
            } else {
                int dato = cima.info; // Almacanenando el valor del primer elemento
                cima=cima.sig;        // Actualizar la cima
                return dato;          // Retornar el valor recuperado de la cima
            }
        }

        // METODO RECORRIDO 
        public void Recorrido() {
            if (EsVacio()) {
                Console.WriteLine("\n ***ERROR, LA PILA ESTA VACIA***");
            } 
            else {
                ptr=cima;
                while(ptr!=null) {
                    Console.WriteLine("{0},", ptr.info);
                    ptr=ptr.sig;
                }
            }
        }

        // METODO ELIMINAR
        public void Eliminar(int dato) {
            if (EsVacio()) {
                Console.WriteLine("\n ***ERROR, LA PILA ESTA VACIA***");
            }
            else {
                if (cima.info==dato) {
                    cima=cima.sig;
                } 
                else {

                }

                ptr = cima;
                if (ptr.info==dato) {

                }
            }
        }

        // METODO BUSCAR
        public void Buscar (int dato) {
            bool encontrado = false;
            if (EsVacio()) {
                Console.WriteLine("\n ***ERROR, LA PILA ESTA VACIA***");
            } else {
                ptr=cima;
                while (ptr!=null) {
                    if (ptr.info==dato) {
                        encontrado = true;
                        break;
                    }
                    ptr= ptr.sig;
                }
                Console.WriteLine("\n {0} {1} Existe ");
            }

        }

        // METODO MODIFICAR
        public void Modificar(int numAct,int numModi) {
            ptr = cima;
            while (ptr!=null) {
            if(ptr.info==numModi) {
                    ptr.info = numModi;
                    ptr=ptr.sig;    
                }
            }
        }
    }

}
