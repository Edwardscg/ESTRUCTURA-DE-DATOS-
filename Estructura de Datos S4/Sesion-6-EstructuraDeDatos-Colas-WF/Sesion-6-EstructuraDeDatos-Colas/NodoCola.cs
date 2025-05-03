using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sesion_6_EstructuraDeDatos_Colas {
    internal class NodoCola {
        private string name;
        private NodoCola sig;

        public string Name { get => name; set => name=value; }
        internal NodoCola Sig { get => sig; set => sig=value; }
    }
}
