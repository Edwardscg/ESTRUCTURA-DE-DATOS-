using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sesion_3_EstructuraDeDatos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dato;

            // Crear e Instanciar un objeto de tipo ListaDoble 
            ListaDoble mylist = new ListaDoble();

            // Insertar 5 elementos
            mylist.InsertarFifo(5);
            mylist.InsertarFifo(3);
            mylist.InsertarFifo(5);
            mylist.InsertarFifo(2);
            mylist.InsertarFifo(5);

            // Ordenar Elementos
            mylist.Ordenar();

            // Recorrer los elementos de la lista
            mylist.Listado1();
            mylist.Listado2();

            // Buscar Ocurrente
            do
            {
                int num;
                Console.WriteLine("Dato Ocurrente A Buscar (0 Para Terminar)");
                dato = int.Parse(Console.ReadLine());
                num = mylist.BusquedaOcurrente(dato);
                Console.WriteLine($"Ocurrencias: {num} ");
            } while (dato != 0);

            // Eliminar Recurrente
            do
            {
                Console.WriteLine("Dato Recurrente A Eliminar (0 Para Terminar)");
                dato = int.Parse(Console.ReadLine());
                mylist.EliminarRecurrente1(dato);
                mylist.Listado2();
            } while (dato != 0);

            // Buscar Elemento
            do
            {
                Console.WriteLine("Dato A Buscar (0 Para Terminar)");
                dato = int.Parse(Console.ReadLine());
                mylist.Buscar(dato);
            } while (dato !=0);

            // Eliminar Elemento
            do
            {
                Console.WriteLine("Dato A Eliminar (0 Para Terminar)");
                dato = int.Parse(Console.ReadLine());
                mylist.Eliminar(dato);
                mylist.Listado2();
            } while (dato != 0);

            // 

            Console.ReadLine();
        

        }
    }
}
