using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sesion_4_EstructuraDeDatos_ListaCircular_Consola {
    public class ListaSimpleCircular {
        NodoSimple raiz, nuevo, ptr, ant, ult;


        //METODO CONSTRUCTOR

        public ListaSimpleCircular() {
            raiz=null;
        }

        // METODO INSERTAR

        public void Insertar (int dato) {
            nuevo = new NodoSimple();
            nuevo.info = dato;
            if (raiz==null) {
                raiz=ult=nuevo;
            }
            else {
                ult.sig=nuevo;
                ult = nuevo;
            }
            nuevo.sig=raiz;
        }

        // METODO LISTAR
        public void Listar () {
            ptr=raiz;
            Console.WriteLine("\n LISTADO GENERAL");
            do{
                Console.Write("{0} ",ptr.info);
                ptr=ptr.sig;
            } while (ptr!=raiz);
        }

        // METODO 1 BUSCAR 
        public bool Buscar1(int dato) {
            bool encontrado = false;
            ptr = raiz;
            while (ptr!=null&&encontrado!=true) {
                if(ptr.info==dato) {
                    encontrado = true; break;
                }
                ptr = ptr.sig;
            }
            return encontrado;
        }

        // METODO 2 BUSCAR
        public void Buscar2 (int dato) {
            bool encontrado =false;
            ptr=raiz;
            do {
                if (ptr.info == dato) {
                    encontrado = true; break;
                }
                ptr = ptr.sig;
            }while (ptr!=raiz);
            Console.WriteLine("\n{0} {1} EXISTE",dato,encontrado ? "SI" : "NO");
        }

        // METODO ELIMINAR
        public void Eliminar(int dato) {
            bool encontrado = false;

            if (raiz.info==dato) {
                raiz=raiz.sig;
                ult.sig=raiz;
                encontrado=true;
            } else {
                ptr=ant=raiz;
                do {
                    if (ptr.info==dato) {
                        ant.sig=ptr.sig;
                        encontrado=true;
                        break;
                    }
                    ant=ptr;
                    ptr=ptr.sig;
                } while (ptr!=raiz);
            }
            Console.WriteLine("\n {0} {1} ELIMINADO", dato, encontrado ? "":"NO");
        }

        // METODO ORDENAR
        public void Ordenar() {
            NodoSimple ptr1, ptr2;
            ptr1 = raiz;
            do {
                ptr2=raiz;
                do {
                    if (ptr1.info > ptr2.info) {
                        int aux = ptr1.info;
                        ptr1.info=ptr2.info;
                        ptr2.info=aux;
                    }
                    ptr2 = ptr2.sig;
                } while (ptr2!=raiz);
                ptr1=ptr1.sig;
            }while (ptr1!=raiz);
        }
    }
}
