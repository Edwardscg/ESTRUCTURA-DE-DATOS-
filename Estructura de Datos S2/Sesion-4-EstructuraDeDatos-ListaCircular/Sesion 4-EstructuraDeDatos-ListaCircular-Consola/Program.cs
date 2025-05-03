using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sesion_4_EstructuraDeDatos_ListaCircular_Consola {
    internal class Program {
        static void Main(string[] args) {
            ListaSimpleCircular mylist = new ListaSimpleCircular();
            int dato;
            mylist.Insertar(40);
            mylist.Insertar(30);
            mylist.Insertar(50);
            mylist.Insertar(10);
            mylist.Insertar(20);

            mylist.Listar();
            do {
                Console.WriteLine("\n Ingresa numero a buscar: 0 Para Terminar");
                dato=int.Parse(Console.ReadLine());
                mylist.Buscar2(dato);
            } while (dato!=0);

            do {
                Console.WriteLine("\n Ingresa numero a eliminar: 0 Para Terminar");
                dato=int.Parse(Console.ReadLine());
                mylist.Eliminar(dato);
                mylist.Listar();
            } while (dato!=0);

            mylist.Listar();
            mylist.Ordenar();
            mylist.Listar();

            Console.ReadLine();
        }
       
    }
}
