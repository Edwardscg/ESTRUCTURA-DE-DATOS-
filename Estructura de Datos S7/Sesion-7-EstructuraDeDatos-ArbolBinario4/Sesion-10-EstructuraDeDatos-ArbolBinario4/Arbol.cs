using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sesion_10_EstructuraDeDatos_ArbolBinario4 {
    internal class Arbol {
        public Nodo Insertar(Nodo actual, int num) {
            Nodo nuevo = new Nodo(num);
            if (actual==null) {
                return nuevo;
            }
            if (actual==null) {
                return nuevo;
            }
            if (num<actual.numero) {
                actual.izquierda=Insertar(actual.izquierda,num);
            }
            else if (num>actual.numero) {
                actual.derecho=Insertar(actual.derecho,num);
            } else {
                MessageBox.Show("NO SE ACEPTAN DUCPLICADOS");
            }
            return actual;
        }

        public void Mostrar(Nodo actual, TreeView tree, TreeNode padre) {
            if (actual!=null) {
                TreeNode cabe = new TreeNode(actual.numero.ToString());

                if(padre ==null) {
                    tree.Nodes.Add(cabe);
                } else {
                    padre.Nodes.Add(cabe);
                }
                if (actual.izquierda!=null) {
                    Mostrar(actual,tree,cabe);
                }
                if (actual.derecho!=null) {
                    Mostrar(actual,tree,cabe);
                }
            }
            
        }

        public Nodo Buscar(Nodo actual, int num) {
            
            while (actual!=null) {
                if (num==actual.numero) {
                    return actual;
                }else if (num<actual.numero) {
                    actual=actual.izquierda;
                } else {
                    actual=actual.derecho;
                }
                
            }
            return null;
        }

        public int BuscarNivel(Nodo actual,int num) {
            int nivel = 0;
            while (actual!=null) {
                if (num==actual.numero) {
                    return nivel;
                } else if (num<actual.numero) {
                    actual=actual.izquierda;
                } else {
                    actual=actual.derecho;
                }
                nivel++;
            }
            return -1;
        }

        public void Pre(Nodo actual, TextBox txt) {
            if (actual!=null) {
                txt.Text+=actual.numero+" ";
                Pre(actual.izquierda, txt);
                Pre(actual.derecho, txt);
            }
        }
        public void Ino(Nodo actual,TextBox txt) {
            if (actual!=null) {
                Ino(actual.izquierda,txt);
                txt.Text+=actual.numero+" ";
                Ino(actual.derecho,txt);
            }
        }

        public void Post(Nodo actual,TextBox txt) {
            if (actual!=null) {
                Post(actual.izquierda,txt);
                Post(actual.derecho,txt);
                txt.Text+=actual.numero+" ";
            }
        }
    }
}
