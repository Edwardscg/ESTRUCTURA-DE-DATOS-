using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sesion_8_EstrucutrsDeDatos_ArbolBinarioBusqueda {
    public class Program {
        static void Main(string[] args) {
            ArbolBinario arb = new ArbolBinario();

            arb.Insertar(30);
            arb.Insertar(50);
            arb.Insertar(10);
            arb.Insertar(40);
            arb.Insertar(20);

            // RECORRIDO PRE ORDEN
            Console.WriteLine("*** RECORRIDO PRE ORDEN ***");
            arb.PreOrden(arb.Raiz);

            // RECORRIDO IN ORDEN
            Console.WriteLine("*** RECORRIDO IN ORDEN ***");
            arb.InOrden(arb.Raiz);

            // RECORRIDO POST ORDEN
            Console.WriteLine("*** RECORRIDO POST ORDEN ***");
            arb.PostOrden(arb.Raiz);

            Console.ReadLine();

        }
    }
}
