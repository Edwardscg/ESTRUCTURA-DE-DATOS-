using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1_EstructuraDeDatos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListaAlumnos mylist = new ListaAlumnos();

            mylist.AgregarFIFO(new Alumno("n00371544","Corne","Edward",20 ,"edwardcorne@gmail.com","933031385"));
            mylist.AgregarFIFO(new Alumno("n00371540", "Corne", "Edward", 25, "edwardcorne@gmail.com", "933031385"));
            mylist.AgregarFIFO(new Alumno("n00371540", "Corne", "Edward", 20, "edwardcorne@gmail.com", "933031385"));
            mylist.AgregarFIFO(new Alumno("n00371549", "Corne", "Edward", 25, "edwardcorne@gmail.com", "933031385"));
            mylist.Listar();
            Console.ReadLine();


        }
    }
}
