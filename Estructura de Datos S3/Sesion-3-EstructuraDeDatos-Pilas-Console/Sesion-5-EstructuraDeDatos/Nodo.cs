using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sesion_5_EstructuraDeDatos {
    public class Nodo {
        public int info {  get; set; }
        public Nodo sig { get; set; }
        public Nodo ant {  get; set; }
    }
}
