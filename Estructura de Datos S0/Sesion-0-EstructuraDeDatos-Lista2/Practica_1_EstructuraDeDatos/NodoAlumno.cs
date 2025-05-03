using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1_EstructuraDeDatos
{
    internal class NodoAlumno
    {
        public Alumno info { get; set; }
        public NodoAlumno sig { get; set; }
    }
}
