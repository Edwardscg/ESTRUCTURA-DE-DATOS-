using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sesion_4_EstructuraDeDatos_ListaCircularDoble {
    internal class ListaCircularDoble {
        NodoDoble raiz1,raiz2, nuevo, ptr, ant, ult;

        //METODO CONSTRUCTOR

        public ListaCircularDoble() {
            raiz1=raiz2= null;
        }

        // METODO INSERTAR LIFO

        public void InsertarLifo(int dato) {
            nuevo=new NodoDoble();
            nuevo.info=dato;
            nuevo.ant=null;

            if (raiz1==null) {
                raiz1=ult=nuevo;
            } else {
                ult.sig=nuevo;
                ult=nuevo;
            }
            nuevo.sig=raiz1;
        }

        // METODO INSERTAR LIFO
        public void InsertarFifo(int dato) {
            nuevo=new NodoDoble();
            nuevo.info=dato;
            nuevo.sig=null;

            if (raiz1 == null) {
                raiz1=ult=nuevo;
            } else {
                ult.ant=nuevo;
                ult=nuevo;
            }
            nuevo.ant=raiz1;
        }

        // METODO LISTAR
        public void Listar() {
            ptr=raiz1;
            Console.WriteLine("\n LISTADO GENERAL");
            do {
                Console.Write("{0} ",ptr.info);
                ptr=ptr.sig;
            } while (ptr!=raiz1);
        }

        // METODO 2 BUSCAR
        public void Buscar(int dato) {
            bool encontrado = false;
            ptr=raiz1;
            do {
                if (ptr.info==dato) {
                    encontrado=true; break;
                }
                ptr=ptr.sig;
            } while (ptr!=raiz1);
            Console.WriteLine("\n{0} {1} EXISTE",dato,encontrado ? "SI" : "NO");
        }

        // METODO ELIMINAR
        public void Eliminar(int dato) {
            bool encontrado = false;

            if (raiz1.info==dato) {
                raiz1=raiz1.sig;
                raiz1.ant=null;
                encontrado=true;
            } else if(raiz1.info==dato) {
                raiz1=raiz1.sig;
                raiz1=null;
                encontrado =true;
            } else {
                ptr=raiz1;
                do {
                    if (ptr.info==dato) {
                        ptr.ant.sig=ptr.sig;
                        ptr.sig.ant=ptr.ant;
                        encontrado=true;
                    }
                    ptr=ptr.sig;
                } while (ptr!=raiz1);

            }
            Console.WriteLine("\n {0} {1} ELIMINADO",dato,encontrado ? "" : "NO");
        }

        //// METODO ORDENAR
        //public void Ordenar() {
        //    NodoSimple ptr1, ptr2;
        //    ptr1=raiz;
        //    do {
        //        ptr2=raiz;
        //        do {
        //            if (ptr1.info>ptr2.info) {
        //                int aux = ptr1.info;
        //                ptr1.info=ptr2.info;
        //                ptr2.info=aux;
        //            }
        //            ptr2=ptr2.sig;
        //        } while (ptr2!=raiz);
        //        ptr1=ptr1.sig;
        //    } while (ptr1!=raiz);
        //}

    }
}
