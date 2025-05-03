using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1_EstructuraDeDatos
{
    public class Alumno
    {
        public Alumno() 
        {

        }

        public Alumno(string codigo, string apellidos, string nombres, int edad, string correo, string telefono)
        {
            this.codigo = codigo;
            this.apellidos = apellidos;
            this.nombres = nombres;
            this.edad = edad;
            this.correo = correo;
            this.telefono = telefono;
        }

        public string codigo {  get; set; }
        public string apellidos { get; set; }
        public string nombres { get; set; }
        public int edad {  get; set; }
        public string correo { get; set; }
        public string telefono { get; set; }
    }
}
