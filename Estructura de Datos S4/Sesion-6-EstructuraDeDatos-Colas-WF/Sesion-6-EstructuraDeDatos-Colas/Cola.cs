using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sesion_6_EstructuraDeDatos_Colas {
    internal class Cola {
        private NodoCola prim = null;
        private NodoCola ult = null;
        private int cont = 0;

        public void Enqueue(string num) {
            NodoCola nuevo = new NodoCola();
            nuevo.Name=num;

            if (prim == null) {
                prim=nuevo;
                ult= nuevo;
            } else {
                ult.Sig=nuevo;
                ult=nuevo;
            }
            cont++;


        }

        public void Mostrar(ListBox list) {
            NodoCola actual = prim;

            while (actual!=null ) {
                list.Items.Add(actual.Name);
                actual=actual.Sig;
            }
        }

        public string Dequeue() {
            if (prim==null) {
                return null;
            }
            string nom = prim.Name;
            prim=prim.Sig;
            cont--;
            return nom;
        }

        public int Cont() {
            return cont;
        }

        public void Destruir() {
            prim=null;
            ult= null;
            cont=0;
        }

        public string Peek() {
            if (prim==null) {
                return null;
            }
            return prim.Name;
        }

        public bool ValidarTexto(string nom) {
            //foreach (char n in nom) {
            //    if (char.IsDigit(n))
                    
            //        break;
            //    else if (char.IsLetter(n)) {
                    
            //        return 1;
            //    }
            //}
            //return -1;

            if (Regex.IsMatch(nom, @"^[a-zA-Z\s]+$" )&& !string.IsNullOrWhiteSpace(nom)) {
                return true;
            }
            return false;
        }









        //NodoCola cabeza, nuevo, ptr, ult, ant;

        //// METODO CONSTRUCTOR
        //public Cola() {
        //    cabeza=null;
        //}

        //// METODO ES VACIO
        //public bool EsVacio() {
        //    return cabeza==null;
        //}

        //// METODO INSERTAR
        //public void Encolar(int dato) {
        //    nuevo=new NodoCola();
        //    nuevo.Name=dato;
        //    nuevo.Sig=null;

        //    if (cabeza==null) {
        //        cabeza=ult=nuevo;
        //    } else {
        //        ult.Sig=nuevo;
        //        ult=nuevo;
        //    }
        //}

        //// METODO DESENCOLAR
        //public int Desencolaar() {
        //    int dato;
        //    if (EsVacio()) {
        //        Console.WriteLine("\n *** ERROR, COLA VACIA. ***");
        //        return -1;
        //    } else {
        //        dato=cabeza.info;
        //        cabeza=cabeza.Sig;
        //        return dato;
        //    }
        //}

        //// METODO LISTAR COLA
        //public void Listar() {
        //    ptr=cabeza;
        //    Console.WriteLine(" *** ELEMENTOS DE LA COLA ***");
        //    while (ptr!=null) {
        //        Console.Write("{0} - ",ptr.info);
        //        ptr=ptr.Sig;
        //    }
        //}

        //// METODO BUSCAR
        //public bool Buscar(int dato) {
        //    bool encontrado = false;
        //    ptr=cabeza;
        //    while (ptr!=null) {
        //        if (ptr.info==dato) {
        //            encontrado=true;
        //            break;
        //        }
        //        ptr=ptr.Sig;
        //    }
        //    return false;
        //}

        //// METODO LIMPIAR
        //public void Limpiar() {
        //    if (!EsVacio()) {
        //        cabeza=null;
        //    } else {
        //        Console.WriteLine("\n ** COLA VACIA ***");
        //    }
        //}

        ////METODO CONTAR 
        //public int Contar() {
        //    int cont = 0;
        //    ptr=cabeza;
        //    for (ptr=cabeza;ptr!=null;ptr=ptr.Sig) {
        //        cont++;
        //    }
        //    return cont;
        //}
    }
}
