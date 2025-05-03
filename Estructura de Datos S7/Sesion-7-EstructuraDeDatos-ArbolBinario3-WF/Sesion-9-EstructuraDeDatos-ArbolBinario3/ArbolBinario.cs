using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sesion_9_EstructuraDeDatos_ArbolBinario3 {
    public class ArbolBinario {
        public Nodo Insertar(Nodo actual, int num) {
            Nodo nuevo = new Nodo(num);
            if (actual==null) {
                return nuevo;

            }
            if (num<actual.numero) {
                actual.izquierda= Insertar(actual, num);
            }
            else if (num>actual.numero) {
                actual.derecho= Insertar(actual, num);
            } else {
                MessageBox.Show("*** NO SE PERMITE DUPLICADOS ***");
            }
            return actual;
        }

        public void Mostrar(Nodo actual, TreeView tree, TreeNode padre) {

            if (actual==null) return;
            TreeNode cabe = new TreeNode(actual.numero.ToString());
            if (padre==null) {
                tree.Nodes.Add(cabe);
            }
            else {
            padre.Nodes.Add(cabe);
            }

            if (actual.izquierda!=null) {
                Mostrar(actual.izquierda, tree, cabe);
            } 
            if(actual.izquierda!=null){
                Mostrar(actual.derecho, tree, cabe);
            }
            
        }
        public Nodo Eliminar(Nodo actual, int num) {
            if(actual==null) {
                return null;
            }

            if (num<actual.numero) {
                actual.izquierda=Eliminar(actual.izquierda, num);
            }
            else if (num>actual.numero) {
                    actual.derecho=Eliminar(actual.derecho, num);
            }else
            {
                //Caso 1: Nodo sin hijos o con 1 solo hijo
                if (actual.izquierda==null) {
                    return actual.derecho;
                }
                else if (actual.derecho==null) {
                    return actual.izquierda;
                }

                // Caso 2: Nodo con 2 hijos
                actual.numero=Minimo(actual.derecho);
                actual.derecho=Eliminar(actual.derecho, actual.numero);
            }
            return actual;

        }
        public int Minimo(Nodo actual) {
            while (actual.izquierda!=null) {
                actual= actual.izquierda;
            }
            return actual.numero;
        }
        public int Maximo(Nodo actual) {
            while (actual.derecho!=null) {
                actual=actual.derecho;
            }
            return actual.numero;
        }
    }
}
