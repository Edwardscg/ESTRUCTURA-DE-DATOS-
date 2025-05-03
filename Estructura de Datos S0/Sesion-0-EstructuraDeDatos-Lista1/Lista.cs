using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estructura_de_Datos_VERANO
{
    internal class Lista
    {
        private Nodo primero = null;
        private Nodo ultimo = null;

        public void Insertar (int num)
        {
            Nodo nuevo =  new Nodo();
            nuevo.Number = num;

            if (primero == null)
            {
                primero = nuevo;
                primero.Siguiente = null;
                ultimo = nuevo;
            }
            else 
            {
                ultimo.Siguiente = nuevo;
                nuevo.Siguiente = null;
                ultimo= nuevo;
            }
        }
        public void Mostrar (ListBox list)
        {
            Nodo actual = primero;

            while (actual != null)
            {
                list.Items.Add (actual.Number);
                actual = actual.Siguiente;
            }
        }
        public void Eliminar(int num)
        {
            Nodo actual = primero;
            Nodo anterior = null;
            while (actual != null)
            {
                if(actual.Number == num)
                {
                    if (actual== primero)
                    {
                        primero = primero.Siguiente;
                    }
                    else
                    {
                        anterior.Siguiente = null;
                        ultimo= anterior;
                    }
                }
                else
                {
                    anterior.Siguiente = actual.Siguiente;
                }
                anterior = actual;
                actual = actual.Siguiente;
            }
        }

        public bool Buscar(int num)
        {
            Nodo actual = primero;
            
            while(actual != null)
            {
                if (actual.Number == num)
                {
                    return true;
                }
                actual = actual.Siguiente;
            }
            return false;
        }

        //public Nodo Buscar(int num)
        //{
        //    Nodo actual = primero;

        //    while (actual != null)
        //    {
        //        if (actual.Number == num)
        //        {
        //            return actual;
        //        }
        //        actual = actual.Siguiente;
        //    }
        //    return null;
        //}

        public void Ascendente()
        {
            Nodo actual = primero;

            while (actual != null)
            {
                Nodo sig = actual.Siguiente;

                while (sig !=null)
                {
                    if(actual.Number > sig.Number)
                    {
                        int temp = actual.Number;
                        actual.Number = sig.Number;
                        sig.Number = temp;
                    }
                    sig = sig.Siguiente;
                }
                actual = actual.Siguiente;
            }
        }

        public void Descendente()
        {

            Nodo actual = primero;

            while (actual != null)
            {
                Nodo sig = actual.Siguiente;

                while (sig != null)
                {
                    if (actual.Number < sig.Number)
                    {
                        int temp = actual.Number;
                        actual.Number = sig.Number;
                        sig.Number = temp;
                    }
                    sig = sig.Siguiente;
                }
                actual = actual.Siguiente;
            }
        }
    }
}
