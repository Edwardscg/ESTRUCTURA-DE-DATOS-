﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Estructura_de_datos
{
    internal class Nodo
    {
        public int Numero { get; set; }
        public Nodo Siguiente { get; set; }
        public Nodo Izquierdo { get; set; }
        public Nodo Derecho { get; set; }

        public Nodo(int numero)
        {
            Numero = numero;
            Siguiente = null;
            Izquierdo = null;
            Derecho = null;
        }
    }
}
