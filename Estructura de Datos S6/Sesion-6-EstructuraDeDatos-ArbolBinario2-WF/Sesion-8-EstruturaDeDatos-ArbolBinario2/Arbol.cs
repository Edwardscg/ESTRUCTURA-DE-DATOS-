using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sesion_8_EstruturaDeDatos_ArbolBinario2 {
    internal class Arbol {
        public Nodo Insertar(Nodo actual, int num) {
            Nodo nuevo = new Nodo(num);

            if (actual==null) {
                return nuevo;
            }
            if (num<actual.numero) {
                actual.izquierdo = Insertar(actual.izquierdo, num);
            }
            else if (num>actual.numero) {
                actual.derecho = Insertar(actual.derecho, num);
            }
            else
            {
                MessageBox.Show("*** NO SE PUDEN INSERTAR NODOS IGUALES ***");
            }
            return actual;
        }

        public void Mostrar(Nodo actual, TreeView tree, TreeNode padre) {
            TreeNode cabe = new TreeNode(actual.numero.ToString()); // raiz

            if(padre ==null) {
                tree.Nodes.Add(cabe);
            } else {
                padre.Nodes.Add(cabe);  
            }
            if (actual.izquierdo!=null) {
                Mostrar(actual.izquierdo, tree, cabe);
            }
            if (actual.derecho!=null) {
                Mostrar(actual.derecho, tree, cabe);
            }
        }

        public Nodo Buscar(Nodo actual, int num) {
            while (actual!=null) {
                if (actual.numero==num) {
                    return actual;
                }else if (num<actual.numero) {
                    actual= actual.izquierdo;
                } else {
                    actual= actual.derecho;
                }
            }
            
            return null;
        }
        public void PreOrden(Nodo actual,TextBox text) {
            if (actual==null) {
                return;
            }

            text.Text+=actual.numero + "-";
            PreOrden(actual.izquierdo,text);
            PreOrden(actual.derecho,text);
            
        }

        public void EnOrden(Nodo actual,TextBox text) {
            if (actual==null) {
                return;
            }

            EnOrden(actual.izquierdo,text);
            text.Text+=actual.numero+"-";
            EnOrden(actual.derecho,text);

        }

        public void PostOrden(Nodo actual,TextBox text) {
            if (actual==null) {
                return;
            }

            PostOrden(actual.izquierdo,text);
            PostOrden(actual.derecho,text);
            
            text.Text+=actual.numero+"-";
        }
    }
}
