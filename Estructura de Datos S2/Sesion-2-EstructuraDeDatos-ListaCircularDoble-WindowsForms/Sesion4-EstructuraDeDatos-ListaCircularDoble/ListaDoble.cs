using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sesion4_EstructuraDeDatos_ListaCircularDoble {
    internal class ListaDoble {
        private Nodo prim;
        private Nodo ult;

        public ListaDoble() {
            prim=null;
            ult=null;
        }

        public void Insertar(int dato) {
            Nodo nuevo = new Nodo();
            nuevo.Num=dato;
            if (prim==null) {
                prim=nuevo;
                prim.Sig=prim;
                ult = nuevo;
            } else {
                ult.Sig=nuevo;
                nuevo.Sig=prim;
                ult = nuevo;
            }
        }

        public void Listar(ListBox list) {
            if(prim==null) {
                return;
            }
            Nodo actual = prim;
            do {
                list.Items.Add(actual);
                actual=actual.Sig;
            } while (actual!=prim);
        }

        public Nodo Buscar(int dato) {
            if(prim==null) { 
                return null;
            }

            Nodo actual = prim;

            do {
                if(actual.Num== dato) {
                    return actual;
                }
                actual=actual.Sig;
            } while (actual!=prim);
            return null;
        }

        public void Modificar(int num1, int num2) {
            Nodo modificar = Buscar(num1);
            if(modificar!=null) {
                modificar.Num=num2;
            } else {
                MessageBox.Show($"No se puede modificar un numero inexistente. {num1} No Existe");
            }

        }
        public void Eliminar (int dato) {
            if(prim == null) {
                return;
            }

            Nodo actual = prim;
            Nodo anterior = null;
            bool encontrado= false;

            do {
                if(actual.Num!=dato) {
                    if (actual==prim) {
                        prim=prim.Sig;
                        if (prim==actual) {
                            prim=null;
                        }
                        ult.Sig=prim;
                    } else if (actual==ult) {
                        anterior.Sig=prim;
                        ult=anterior;
                    } else {
                        anterior.Sig=actual.Sig;
                    }
                    encontrado=true;
                    break;
                }
                anterior=actual;
                actual=actual.Sig;
            } while (actual!=prim);

            if(encontrado==false) {
                MessageBox.Show($"No se puede eliminar. Porque {dato} no existe.");
            }
        }
    }
}
