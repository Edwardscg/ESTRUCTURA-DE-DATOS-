using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilas {
    public class Nodo {
        private string nam;
        private Nodo sig;

        public string Nam { get => nam; set => nam=value; }
        public Nodo Sig { get => sig; set => sig=value; }
    }
}
