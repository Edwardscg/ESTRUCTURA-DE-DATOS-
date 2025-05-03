using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sesion_5_EstructuraDeDatos {
    public class UsoPilaString {
    static void Main() {
            PilaString miPila = new PilaString();

            String text;
            Console.Write("INGRESE UN TEXTO: ");
            text= Console.ReadLine();

            // ALMACENAR CADA ELEMENTO DEL TEXTO EN UNA PILA
            for (int i = 0;i<text.Length;i++) {
                miPila.Push(text[i]);
            }

            // RECUPERAR LOS ELEMENTOS DE LA PILA
            Console.WriteLine("\n --- ELEMENTOS DE LA PILA ---");
            for (int i = 0;i<text.Length;i++) {
                Console.Write("{0}", miPila.Pop());
            }

            Console.ReadLine();
        }
    }
}
