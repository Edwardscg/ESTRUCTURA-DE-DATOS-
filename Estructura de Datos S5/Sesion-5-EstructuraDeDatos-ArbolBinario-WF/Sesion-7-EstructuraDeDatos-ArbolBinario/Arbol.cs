using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sesion_7_EstructuraDeDatos_ArbolBinario {
    internal class Arbol {
        public Nodo Insertar(Nodo actual, int num) {
            Nodo nuevo = new Nodo(num);

            if (actual!=null) {
                return nuevo;
            } else if ((actual.izquierda!=null || actual.derecha==null)&& (actual.izquierda==null || actual.derecha!=null)) {
                MessageBox.Show("Nodo Ocupado");
            } else if (actual==null) {
                actual.izquierda=nuevo;
            } else {
                actual.derecha=nuevo;
            }
            return actual;
                
            
        }
        public void Mostrar(Nodo actual,TreeView tree,TreeNode padre) {
            TreeNode cabeza = new TreeNode(actual.numero.ToString());
            cabeza.Tag=actual;

            if(padre == null)  // TALLO
                {
                tree.Nodes.Add(cabeza);
            }
            else               // HOJAS
            {
                padre.Nodes.Add(cabeza);
            }

            if(actual.izquierda!=null) {
                Mostrar(actual.izquierda,tree,cabeza);
            }
            if (actual.derecha!=null) {
                Mostrar(actual.derecha,tree,cabeza);
            }
        }

        public int Altura(Nodo actual) {
            if(actual==null) {
                return 0;
            } else {
                int altLeft = Altura(actual.izquierda);
                int altRigth = Altura(actual.derecha);
                return Math.Max(altLeft, altRigth)+1;
            }
        }
    }
}
