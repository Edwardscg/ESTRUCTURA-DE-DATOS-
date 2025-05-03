using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1_EstructuraDeDatos
{
    public class ListaAlumnos
    {
        NodoAlumno raiz, nuevo, ptr, ant;

        public ListaAlumnos()
        {
            raiz = null;
        }

        // Método Agregar LIFO
        public void AgregarLIFO(Alumno dato)
        // LIFO = Last,Input,First,Output
        {
            // Crear un nuevo nodo
            nuevo = new NodoAlumno();
            // Asignar valor al campo info
            nuevo.info = dato;
            // Enlazar con el primer nodo de la lista
            nuevo.sig = raiz;
            // Hacer que raiz tome la direccion del primer nodo de la lista
            raiz = nuevo;
        }

        // Método Agregar FIFO
        public void AgregarFIFO(Alumno dato)
        // FIFO = First,Input,First,Output
        {
            nuevo = new NodoAlumno();
            nuevo.info = dato;
            nuevo.sig = null;
            if (raiz == null) raiz = ant = nuevo;
            else
            { ant.sig = nuevo; ant = nuevo; }
        }

        // Método Listar
        public void Listar()
        {
            ptr = raiz;
            Console.WriteLine("\nLISTADO DE ELEMENTOS---");
            while (ptr != null)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}", ptr.info.codigo,
                    ptr.info.apellidos,
                    ptr.info.nombres,
                    ptr.info.edad,
                    ptr.info.correo,
                    ptr.info.telefono);
                ptr = ptr.sig;
            }
        }

        // Método Buscar
        public bool Buscar(string dato)
        {
            bool encontrado = false;
            ptr = raiz;
            while (ptr != null && !encontrado)
            {
                if (ptr.info.codigo == dato)
                {
                    encontrado = true; break;
                }
                ptr = ptr.sig;
            }
            return encontrado;
        }

        // Método para suprimir un elemento
        public void Suprimir(string dato)
        {
            bool encontrado = false;
            if (raiz.info.codigo == dato) raiz = raiz.sig;
            else
            {
                ptr = ant = raiz;
                while (ptr != null && !encontrado)
                {
                    if (ptr.info.codigo == dato)
                    {
                        ant.sig = ptr.sig;
                        encontrado = true;
                        break;
                    }
                    ant = ptr;
                    ptr = ptr.sig;
                }
            }
        }

        // Metodo Ordenar
        public void Burbuja()
        {
            NodoAlumno ptr1, ptr2;
            ptr1 = raiz;
            while (ptr1 != null)
            {
                ptr2 = raiz;
                while (ptr2 != null)
                {
                    int num1 = ExtraerNumero(ptr2.info.codigo);
                    int num2 = ExtraerNumero(ptr2.sig.info.codigo);
                    if (num1>num2)
                    {
                        NodoAlumno aux = ptr1;
                        ptr1 = ptr2;
                        ptr2 = aux;
                    }
                    ptr2 = ptr2.sig;
                }
                ptr1 = ptr1.sig;
            }
        }

        public int ExtraerNumero(string codigo)
        {
           
            //NodoAlumno ptr = new NodoAlumno();
            //ptr.info.codigo = codigo;
        
            return int.Parse(codigo.Substring(1));
        }

    }
}
