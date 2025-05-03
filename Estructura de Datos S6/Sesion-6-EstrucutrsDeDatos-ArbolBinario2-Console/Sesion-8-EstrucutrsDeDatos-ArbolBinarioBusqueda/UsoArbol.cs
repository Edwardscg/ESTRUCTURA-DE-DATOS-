using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sesion_8_EstrucutrsDeDatos_ArbolBinarioBusqueda {
    //Se pide ingresar un texto y luego los caracteres 
    // que fromen parte del texto de deberan insertar
    // en un arbol binario y por ultimo se debera recorrer
    // el arbol en PreOrden, InOrden y PostOrden
    public class UsoArbol {
        static void Main() {
            ArbolBinarioTexto arb = new ArbolBinarioTexto();
            string texto;

            Console.WriteLine("*** INSERTE UN TEXTO ***");
            texto=Console.ReadLine();

            // INSERTANDO LOS CARACTERES DEL TEXTO EN EL ARBOL
            for(int i=0; i<texto.Length;i++) {
                arb.Insertar(texto[i]);
            }

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
