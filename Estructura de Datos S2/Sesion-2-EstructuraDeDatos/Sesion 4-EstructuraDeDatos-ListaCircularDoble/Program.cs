using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sesion_4_EstructuraDeDatos_ListaCircularDoble {
    internal class Program {
        static void Main(string[] args) {
            ListaCircularDoble mylist = new ListaCircularDoble();
            int dato;
            mylist.InsertarLifo(10);
            mylist.InsertarLifo(20);
            mylist.InsertarLifo(30);
            mylist.InsertarLifo(40);
            mylist.InsertarLifo(50);

            mylist.InsertarLifo(50);
            mylist.InsertarLifo(40);
            mylist.InsertarLifo(30);
            mylist.InsertarLifo(20);
            mylist.InsertarLifo(10);

            mylist.Listar();

            do {
                Console.WriteLine("\n Ingresa numero a buscar: 0 Para Terminar");
                dato=int.Parse(Console.ReadLine());
                mylist.Buscar(dato);
            } while (dato!=0);


            do {
                Console.WriteLine("\n Ingresa numero a eliminar: 0 Para Terminar");
                dato=int.Parse(Console.ReadLine());
                mylist.Eliminar(dato);
                mylist.Listar();
            } while (dato!=0);
            Console.ReadLine();
        }
    }
}
