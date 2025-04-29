using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraDeDatos_ListaDoble {
    internal class Nodo 
    {
        private int numero;
        private Nodo ant;
        private Nodo sig;

        public int Numero { get => numero; set => numero=value; }
        internal Nodo Ant { get => ant; set => ant=value; }
        internal Nodo Sig { get => sig; set => sig=value; }
    }
}
