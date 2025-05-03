using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Estructura_de_datos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EstructuradorDeDatos lista = new EstructuradorDeDatos();

            // Insertar en orden ascendente
            lista.InsertarEnOrden(5);
            lista.InsertarEnOrden(3);
            lista.InsertarEnOrden(8);
            lista.InsertarEnOrden(1);
            lista.MostrarLista(); // 1 -> 3 -> 5 -> 8 -> null

            // Insertar en una posición específica
            lista.InsertarEnPosicion(4, 2);
            lista.MostrarLista(); // 1 -> 3 -> 4 -> 5 -> 8 -> null

            // Unión e intersección de listas
            List<int> L1 = new List<int> { 1, 2, 3, 4 };
            List<int> L2 = new List<int> { 3, 4, 5, 6 };

            var union = EstructuradorDeDatos.Union(L1, L2);
            Console.WriteLine("Unión: " + string.Join(", ", union));

            var interseccion = EstructuradorDeDatos.Interseccion(L1, L2);
            Console.WriteLine("Intersección: " + string.Join(", ", interseccion));

            // Copiar pila a cola
            Stack<int> pila = new Stack<int>(new[] { 1, 2, 3 });
            Queue<int> cola = EstructuradorDeDatos.CopiarPilaACola(pila);
            Console.WriteLine("Cola: " + string.Join(", ", cola));

            // Búsqueda en árbol xd
            Nodo raiz = new Nodo(10)
            {
                Izquierdo = new Nodo(5),
                Derecho = new Nodo(15)
            };
            int nivel = lista.BuscarNivel(raiz, 15);
            Console.WriteLine("Nivel del nodo con valor 15: " + nivel);

            Console.ReadKey();
        }
    }
}
