using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Sesion_3_EstructuraDeDatos
{
    public class ListaDoble
    {
        Nodo raiz1, raiz2, nuevo, ptr;

        // METODO CONSTRUCTOR
        public ListaDoble()
        {
            raiz1 = raiz2 = null;
        }

        // METODO INSERTAR LIFO

        public void InsertarLifo(int dato)
        {
            nuevo = new Nodo();
            nuevo.info = dato;
            nuevo.ant = null;
            if (raiz1 == null) raiz2 = nuevo;
            else
            {
                nuevo.sig = raiz1;
                raiz1.ant = nuevo;
            }
            raiz1 = nuevo;
        }

        // METODO INSERTAR FIFO

        public void InsertarFifo (int dato)
        {
            nuevo = new Nodo();
            nuevo.info = dato;
            nuevo.sig = null;
            if (raiz2 == null) raiz1 = nuevo;
            else
            {
                nuevo.ant = raiz2;
                raiz2.sig = nuevo;
            }
            raiz2 = nuevo;

        }

        // METODO LISTADO

        public void Listado1()
        {
            ptr = raiz1;
            Console.WriteLine("Elementos:");
            while (ptr != null)
            {
                Console.WriteLine("{0}", ptr.info);
                ptr = ptr.sig;
            }
        }
        public void Listado2()
        {
            ptr = raiz2;
            Console.WriteLine("Elementoss:");
            while (ptr != null)
            {
                Console.WriteLine("{0}", ptr.info);
                ptr = ptr.ant;
            }
        }

        //METODO BUSCAR

        public void Buscar(int dato)
        {
            bool encontrado = false;
            ptr = raiz1;
            while (ptr!=null)
            {
                if(ptr.info == dato)
                {
                    encontrado = true;break;
                }
                ptr = ptr.sig;
            }
            Console.WriteLine(encontrado ? "Si Existe" : "No Existe");
        }

        //METODO ELIMINAR

        public void Eliminar (int dato)
        {
            bool encontrado = false;
            if(raiz1.info == dato)
            {
                raiz1 = raiz1.sig;
                raiz1.ant = null;
                encontrado = true;
            }
            else if (raiz2.info == dato)
            {
                raiz2 = raiz2.ant;
                raiz2.sig = null;
                encontrado=true;
            }
            else
            {
                ptr = raiz1;
                while(ptr !=null)
                {
                    if(ptr.info == dato)
                    {
                        ptr.ant.sig = ptr.sig;
                        ptr.sig.ant = ptr.ant;
                        encontrado = true;
                    }
                    ptr = ptr.sig;
                }
            }
            Console.WriteLine(encontrado ? "Eliminado" : "No Existe");

        }

        //METODO ORDENAR

        public void Ordenar ()
        {
            Nodo ptr1, ptr2;
            ptr1 = raiz1;
            while(ptr1 != null)
            {
                ptr2 = raiz1;
                while(ptr2 != null)
                {
                    if (ptr1.info > ptr2.info)
                    {
                        int aux = ptr1.info;
                        ptr1.info = ptr2.info;
                        ptr2.info = aux;
                    }
                    ptr2 = ptr2.sig;
                }
                ptr1 = ptr1.sig;
            }
        }

        // METODO BUSQUEDA OCURRENTE

        public int BusquedaOcurrente (int dato)
        {
            int cont = 0;
            ptr = raiz1;
            while (ptr != null)
            {
                if (ptr.info == dato) cont++;
                ptr = ptr.sig;
            }
            return cont;
            
        }

        // METODO ELIMINAR RECURRENTE

        public void EliminarRecurrente1(int dato)
        {
            int cont = 0;
            ptr = raiz1;
            while (ptr != null)
            {
                if (ptr.info == dato) cont++;
                ptr = ptr.sig;
            }
            while (cont>0)
            {
                bool encontrado = false;
                if (raiz1.info == dato)
                {
                    raiz1 = raiz1.sig;
                    raiz1.ant = null;
                    encontrado = true;
                    cont--;
                }
                else if (raiz2.info == dato)
                {
                    raiz2 = raiz2.ant;
                    raiz2.sig = null;
                    encontrado = true;
                    cont--;
                }
                else
                {
                    ptr = raiz1;
                    while (ptr != null)
                    {
                        if (ptr.info == dato)
                        {
                            ptr.ant.sig = ptr.sig;
                            ptr.sig.ant = ptr.ant;
                            encontrado = true;
                            cont--;
                        }
                        ptr = ptr.sig;
                    }
                }
                

            }
            
        }
        public void EliminarRecurrente2 (int dato)
        {
            Nodo ptr1;
            ptr1 = raiz1;
            while (ptr1 != null)
            {
                Eliminar(dato);
                ptr1 = ptr1.sig;
            }
        }
    }
}
