using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sesion_9_EstructuraDeDatos_ArbolBinario3 {
    internal partial class Form1: Form {
        ArbolBinario a =new ArbolBinario();
        Nodo raiz;

        public Form1() {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender,EventArgs e) {
            if(int.TryParse(txtInput.Text, out int num)) {
                if (raiz==null) {
                    raiz=a.Insertar(null, num);
                } else {
                    a.Insertar(raiz, num);
                }
                treeViewArbol.Nodes.Clear();
                a.Mostrar(raiz,treeViewArbol,null);
                treeViewArbol.ExpandAll();
                txtInput.Clear();
            } else {
                MessageBox.Show("*** INGRESE UN NUMERO ENTERO VALIDO ***");
            }
        }

        private void btnEliminar_Click(object sender,EventArgs e) {
            if (int.TryParse(txtInput.Text,out int num)) {
                if(a.Eliminar(raiz, num)!=null) {
                    treeViewArbol.Nodes.Clear();
                    a.Mostrar(raiz, treeViewArbol, null);
                    treeViewArbol.ExpandAll();
                }
            } else {
                MessageBox.Show("*** INGRESE UN NUMERO ENTERO VALIDO ***");
            }
        }

        private void BTNmINIMO_Click(object sender,EventArgs e) {
            if (raiz!=null) {
                MessageBox.Show($"*** MINIMO: {a.Minimo(raiz)} ***");
            } else {
                MessageBox.Show($"*** ARBOL VACIO ***");
            }
        }

        private void BTNmAXIMO_Click(object sender,EventArgs e) {
            if (raiz!=null) {
                MessageBox.Show($"*** MAXIMO: {a.Maximo(raiz)} ***");
            } else {
                MessageBox.Show($"*** ARBOL VACIO ***");
            }
        }
    }
}
