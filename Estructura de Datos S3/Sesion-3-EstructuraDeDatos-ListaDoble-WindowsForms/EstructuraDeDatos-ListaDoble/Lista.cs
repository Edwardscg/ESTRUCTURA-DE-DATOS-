using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstructuraDeDatos_ListaDoble {
    internal class Lista 
        
    {
        private Nodo primero;
        private Nodo ultimo;

        public Lista() 
        {
            primero=null;
            ultimo=null;
        }
        public void Insertar(int num) {
            Nodo nuevo = new Nodo();
            nuevo.Numero = num;

            if (primero == null) {
                primero = nuevo;
                primero.Ant=null;
                primero.Sig = null;
                ultimo=nuevo;
            }
            else
            {
                ultimo.Sig=nuevo;
                nuevo.Sig=null;
                nuevo.Ant=ultimo;
                ultimo=nuevo;

            }
        }
        public void Mostrar(ListBox list) {
            Nodo actual = primero;

            while (actual!=null) {
                list.Items.Add(actual.Numero);
                actual=actual.Sig;
            }

        }
        public Nodo Buscar (int num) {
            Nodo actual = primero;
            bool encontrado=false;

            while (actual!=null) {
                if (actual.Numero== num) {
                    encontrado=true;
                    return actual;
                }
                actual=actual.Sig;
            }
            
            return null;
        }

        public void Modificar(int valorActual, int valorModificar) {
            Nodo modificar = Buscar(valorActual);
            if (modificar!=null) {
                modificar.Numero=valorModificar;
            } else {
                MessageBox.Show($"Numero {valorModificar} no existe. No se puede modificar.");
            }

        }
        public void Eliminar(int num) {
            Nodo eliminar = Buscar(num);
            if(eliminar==primero) {
                primero=eliminar.Sig;
                if(primero != null) {
                    primero.Ant=null;
                }
            }else if (eliminar == ultimo) {
                ultimo=eliminar.Ant;
                if(ultimo!=null) {
                    ultimo.Sig=null;
                }
            } else {
                eliminar.Ant.Sig=eliminar.Sig;
                eliminar.Sig.Ant= eliminar.Ant;
            }
        }
    }
}
