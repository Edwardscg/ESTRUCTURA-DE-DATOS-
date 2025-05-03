using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pilas {
    internal class Pila {
        private Nodo cima = null;
        private int cont = 0;
        public void Push(string dato) {
            Nodo nuevo = new Nodo();
            nuevo.Nam=dato;

            nuevo.Sig=cima;
            cima=nuevo;
            cont++;
        }
        public void Mostrar(ListBox list) {
            Nodo actual = cima;
            while (actual!=null) {
                list.Items.Add(actual.Nam);
                actual=actual.Sig;
            }
        }

        // 
        public string Pop() {
            if (cima!=null) {
            string nam= cima.Nam;
                cima = cima.Sig;
                cont--;
                return nam;
            }
            return null;
        }

        // CONTAR ELEMENTOS
        public int Contar () {
            return cont;
        }

        // VISTAZO
        public string Peek() {
            if(cima!=null) {
                return cima.Nam;
            }
            return null;
        }

        // DESTRUIR PILA
        public void Clear() {
            cima=null;
            cont=0;
        }
    }
}
