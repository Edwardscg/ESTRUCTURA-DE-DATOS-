using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Sesion_5_EstructuraDeDatos {
    internal class Program {
        static void Main(string[] args) {
            Pila miPila = new Pila();
            miPila.Apilar(10);
            miPila.Apilar(20);
            miPila.Apilar(30);
            miPila.Apilar(40);
            miPila.Apilar(50);

            Console.WriteLine("\n --- RECORRIDO DE LA PILA ---");
            miPila.Recorrido();
            miPila.Desapilar();
            miPila.Desapilar();
            Console.WriteLine("\n --- RECORRIDO DE LA PILA ---");
            miPila.Recorrido();

            

            Console.ReadLine();

        }
    }
}
