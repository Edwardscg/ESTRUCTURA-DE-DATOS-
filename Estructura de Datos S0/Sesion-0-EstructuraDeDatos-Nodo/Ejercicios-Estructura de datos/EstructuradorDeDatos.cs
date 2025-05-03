using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Estructura_de_datos
{
    // Clase con los métodos solicitados
    internal class EstructuradorDeDatos
    {
        private Nodo cabeza;

        public EstructuradorDeDatos()
        {
            cabeza = null;
        }

        // Insertar en orden ascendente
        public void InsertarEnOrden(int numero)
        {
            Nodo nuevo = new Nodo(numero);
            if (cabeza == null || cabeza.Numero >= numero)
            {
                nuevo.Siguiente = cabeza;
                cabeza = nuevo;
            }
            else
            {
                Nodo actual = cabeza;
                while (actual.Siguiente != null && actual.Siguiente.Numero < numero)
                {
                    actual = actual.Siguiente;
                }
                nuevo.Siguiente = actual.Siguiente;
                actual.Siguiente = nuevo;
            }
        }

        // Insertar en una posición específica
        public void InsertarEnPosicion(int numero, int posicion)
        {
            Nodo nuevo = new Nodo(numero);

            if (posicion == 0)
            {
                nuevo.Siguiente = cabeza;
                cabeza = nuevo;
                return;
            }

            Nodo actual = cabeza;
            int contador = 0;

            while (actual != null && contador < posicion - 1)
            {
                actual = actual.Siguiente;
                contador++;
            }

            if (actual == null)
            {
                throw new ArgumentOutOfRangeException("Posición fuera del rango de la lista.");
            }

            nuevo.Siguiente = actual.Siguiente;
            actual.Siguiente = nuevo;
        }

        // Unión de dos listas sin elementos repetidos
        public static List<int> Union(List<int> lista1, List<int> lista2)
        {
            HashSet<int> conjunto = new HashSet<int>(lista1);
            conjunto.UnionWith(lista2);
            return new List<int>(conjunto);
        }

        // Intersección de dos listas
        public static List<int> Interseccion(List<int> lista1, List<int> lista2)
        {
            HashSet<int> conjunto1 = new HashSet<int>(lista1);
            conjunto1.IntersectWith(lista2);
            return new List<int>(conjunto1);
        }

        // Copiar una pila a una cola
        public static Queue<int> CopiarPilaACola(Stack<int> pila)
        {
            Stack<int> auxiliar = new Stack<int>(pila);
            Queue<int> cola = new Queue<int>();

            while (auxiliar.Count > 0)
            {
                cola.Enqueue(auxiliar.Pop());
            }

            return cola;
        }

        // Buscar un elemento en un árbol binario
        public int BuscarNivel(Nodo raiz, int valor)
        {
            return BuscarNivelRecursivo(raiz, valor, 0);
        }

        private int BuscarNivelRecursivo(Nodo nodo, int valor, int nivel)
        {
            if (nodo == null) return -1;
            if (nodo.Numero == valor) return nivel;

            int nivelIzquierdo = BuscarNivelRecursivo(nodo.Izquierdo, valor, nivel + 1);
            if (nivelIzquierdo != -1) return nivelIzquierdo;

            return BuscarNivelRecursivo(nodo.Derecho, valor, nivel + 1);
        }

        // Mostrar lista para pruebas
        public void MostrarLista()
        {
            Nodo actual = cabeza;
            while (actual != null)
            {
                Console.Write(actual.Numero + " -> ");
                actual = actual.Siguiente;
            }
            Console.WriteLine("null");
        }

    }
}
